Imports MySql.Data.MySqlClient
Imports Datos
Public Class conexionBD
    'Private conexion As MySqlConnection = New MySqlConnection("server=192.168.5.50;port=3306;database=steven_acosta;user id=steven.acosta;password=57200277;persistsecurityinfo=True;Convert Zero Datetime=True")
    Private conexion As MySqlConnection = New MySqlConnection("server=localhost; database=medicapp; user id=root; password=; persistsecurityinfo=True; Convert Zero Datetime=True")
    Public da As New MySqlDataAdapter
    Public ds As DataSet = New DataSet()
    Public cmd As New MySqlCommand
    Public dt As DataTable
    Private Sub Conectar()
        conexion.Open()
    End Sub
    Private Sub Desconectar()
        conexion.Close()
    End Sub
    Private Sub VerificarConexion()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

    'Inicio de sesion
    Public Function Inicio(datos As Inicio, tipo As String)
        If tipo = "Administrador" Then
            Dim sql As String = "SELECT * FROM administrador WHERE ciAdmin='" & datos.Ci & "' AND contrasena='" & datos.Contraseña & "'"
            If ConsultaInicio(sql) Then
                Return True
            End If

        ElseIf tipo = "Paciente" Then
            Dim sql As String = "SELECT * FROM paciente WHERE ciPaciente='" & datos.Ci & "' AND contrasena='" & datos.Contraseña & "'"
            If ConsultaInicio(sql) Then
                Return True
            End If

        ElseIf tipo = "Medico" Then
            Dim sql As String = "SELECT * FROM medico WHERE ciMedico='" & datos.Ci & "' AND contrasena='" & datos.Contraseña & "'"
            If ConsultaInicio(sql) Then
                Return True
            End If
        End If
        Return Nothing
    End Function
    Public Function ConsultaInicio(sql As String)
        VerificarConexion()
        Conectar()
        Dim cmd As New MySqlCommand(sql, conexion)
        Dim leer As MySqlDataReader = cmd.ExecuteReader
        If leer.Read Then
            Desconectar()
            Return True
        Else
            Desconectar()
            Throw New Exception(Traduccion.Traducir("msgErrorIniciar", Traduccion.Idioma))
        End If
    End Function

    'Gestion Usuarios
    Public Function ObtenerUsuarios() As List(Of Usuario)
        VerificarConexion()
        Conectar()
        Dim usuarios As List(Of Usuario) = New List(Of Usuario)
        usuarios.Clear()
        Dim sql As String = "select * from usuario"
        Dim cmd = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Dim usuario As New Usuario(dr("ci"), dr("primerNombre"), dr("primerApellido"), dr("segundoApellido"), dr("sexo"), dr("telefono"), dr("calle"), dr("esquina"), dr("numeroPuerta"), dr("fechaNacimiento"), dr("mail"))
            usuarios.Add(usuario)
        End While
        Desconectar()
        Return usuarios
    End Function

    'Gestion Administradores
    Public Function IngresarAdministrador(administrador As Administrador)
        VerificarConexion()
        Dim formato As String = "yyyy-MM-dd"
        Dim datosU As String = "'" & administrador.Ci & "', '" & administrador.PrimerNombre & "', '" & administrador.PrimerApellido & "', '" & administrador.SegundoApellido & "', '" & administrador.Sexo & "', '" & administrador.Telefono & "', '" & administrador.Calle & "', '" & administrador.Esquina & "', '" & administrador.NumeroPuerta & "', '" & administrador.FechaNacimiento.ToString(formato) & "', '" & administrador.Mail & "'"
        Dim sqlU As String = "INSERT INTO `usuario` VALUES (" & datosU & ")"
        Dim datosA As String = "'" & administrador.Ci & "', '" & administrador.Contraseña & "'"
        Dim sqlA As String = "INSERT INTO `administrador` VALUES (" & datosA & ")"
        If Insertar(sqlU) Then
            If Insertar(sqlA) Then
                Return True
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorInsertar", Traduccion.Idioma))
    End Function
    Public Function ModificarAdministrador(Administrador As Administrador)
        VerificarConexion()
        Dim formato As String = "yyyy-MM-dd"
        Dim camposU As String = "primerNombre='" & Administrador.PrimerNombre & "', primerApellido='" & Administrador.PrimerApellido & "', segundoApellido='" & Administrador.SegundoApellido & "', sexo='" & Administrador.Sexo & "', telefono='" & Administrador.Telefono & "', calle='" & Administrador.Calle & "', esquina='" & Administrador.Esquina & "', numeroPuerta='" & Administrador.NumeroPuerta & "', fechaNacimiento='" & Administrador.FechaNacimiento.ToString(formato) & "', mail='" & Administrador.Mail & "'"
        Dim modiU As String = "update usuario set " + camposU + " where ci='" & Administrador.Ci & "'"
        Dim camposA As String = "contrasena='" & Administrador.Contraseña & "'"
        Dim modiA As String = "update administrador set " + camposA + " where ciAdmin='" & Administrador.Ci & "'"
        If Modificar(modiU) Then
            If Modificar(modiA) Then
                Return True
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorInsertar", Traduccion.Idioma))
    End Function
    Public Function EliminarAdministrador(Administrador As Administrador)
        VerificarConexion()
        Dim sqlA As String = "delete from administrador where ciAdmin = '" & Administrador.Ci & "'"
        Dim sqlU As String = "delete from usuario where ci = '" & Administrador.Ci & "'"
        If Eliminar(sqlA) Then
            If Eliminar(sqlU) Then
                Return True
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorInsertar", Traduccion.Idioma))
    End Function
    Public Function ObtenerAdministradores() As List(Of Administrador)
        VerificarConexion()
        Conectar()
        Dim admins As List(Of Administrador) = New List(Of Administrador)
        admins.Clear()
        Dim sql As String = "select * from usuario u inner join administrador a on u.ci=a.ciAdmin"
        Dim cmd = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Dim admin As New Administrador(dr("ci"), dr("contrasena"), dr("primerNombre"), dr("primerApellido"), dr("segundoApellido"), dr("sexo"), dr("telefono"), dr("calle"), dr("esquina"), dr("numeroPuerta"), dr("fechaNacimiento"), dr("mail"))
            admins.Add(admin)
        End While
        Desconectar()
        Return admins
    End Function

    'Gestion Medicos
    Public Function IngresarMedico(medico As Medico)
        VerificarConexion()
        Dim formato As String = "yyyy-MM-dd"
        Dim datosU As String = "'" & medico.Ci & "', '" & medico.PrimerNombre & "', '" & medico.PrimerApellido & "', '" & medico.SegundoApellido & "', '" & medico.Sexo & "', '" & medico.Telefono & "', '" & medico.Calle & "', '" & medico.Esquina & "', '" & medico.NumeroPuerta & "', '" & medico.FechaNacimiento.ToString(formato) & "', '" & medico.Mail & "'"
        Dim sqlU As String = "INSERT INTO `usuario` VALUES (" & datosU & ")"
        Dim datosM As String = "'" & medico.Ci & "', '" & medico.Contraseña & "', '" & medico.Especialidad & "'"
        Dim sqlM As String = "INSERT INTO `medico` VALUES (" & datosM & ")"
        If Insertar(sqlU) Then
            If Insertar(sqlM) Then
                Return True
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorInsertar", Traduccion.Idioma))
    End Function
    Public Function ModificarMedico(medico As Medico)
        VerificarConexion()
        Dim formato As String = "yyyy-MM-dd"
        Dim camposU As String = "primerNombre='" & medico.PrimerNombre & "', primerApellido='" & medico.PrimerApellido & "', segundoApellido='" & medico.SegundoApellido & "', sexo='" & medico.Sexo & "', telefono='" & medico.Telefono & "', calle='" & medico.Calle & "', esquina='" & medico.Esquina & "', numeroPuerta='" & medico.NumeroPuerta & "', fechaNacimiento='" & medico.FechaNacimiento.ToString(formato) & "', mail='" & medico.Mail & "'"
        Dim modiU As String = "update usuario set " + camposU + " where ci='" & medico.Ci & "'"
        Dim camposM As String = "contrasena='" & medico.Contraseña & "', especialidad='" & medico.Especialidad & "'"
        Dim modiM As String = "update medico set " + camposM + " where ciMedico='" & medico.Ci & "'"
        If Modificar(modiU) Then
            If Modificar(modiM) Then
                Return True
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorInsertar", Traduccion.Idioma))
    End Function
    Public Function EliminarMedico(medico As Medico)
        VerificarConexion()
        Dim sqlM As String = "delete from medico where ciMedico = '" & medico.Ci & "'"
        Dim sqlU As String = "delete from usuario where ci = '" & medico.Ci & "'"
        If Eliminar(sqlM) Then
            If Eliminar(sqlU) Then
                Return True
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorInsertar", Traduccion.Idioma))
    End Function
    Public Function ObtenerMedicos() As List(Of Medico)
        VerificarConexion()
        Conectar()
        Dim medicos As List(Of Medico) = New List(Of Medico)
        medicos.Clear()
        Dim sql As String = "select * from usuario u inner join medico m on u.ci=m.ciMedico"
        Dim cmd = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Dim medico As New Medico(dr("ci"), dr("contrasena"), dr("primerNombre"), dr("primerApellido"), dr("segundoApellido"), dr("sexo"), dr("telefono"), dr("calle"), dr("esquina"), dr("numeroPuerta"), dr("fechaNacimiento"), dr("mail"), dr("especialidad"))
            medicos.Add(medico)
        End While
        Desconectar()
        Return medicos
    End Function

    'Gestion Pacientes
    Public Function IngresarPaciente(paciente As Paciente)
        VerificarConexion()
        Dim formato As String = "yyyy-MM-dd"
        Dim datosU As String = "'" & paciente.Ci & "', '" & paciente.PrimerNombre & "', '" & paciente.PrimerApellido & "', '" & paciente.SegundoApellido & "', '" & paciente.Sexo & "', '" & paciente.Telefono & "', '" & paciente.Calle & "', '" & paciente.Esquina & "', '" & paciente.NumeroPuerta & "', '" & paciente.FechaNacimiento.ToString(formato) & "', '" & paciente.Mail & "'"
        Dim sqlU As String = "INSERT INTO `usuario` VALUES (" & datosU & ")"
        Dim datosP As String = "'" & paciente.Ci & "', '" & paciente.Contraseña & "'"
        Dim sqlP As String = "INSERT INTO `paciente` VALUES (" & datosP & ")"
        If Insertar(sqlU) Then
            If Insertar(sqlP) Then
                Return True
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorInsertar", Traduccion.Idioma))
    End Function
    Public Function ModificarPaciente(paciente As Paciente)
        VerificarConexion()
        Dim formato As String = "yyyy-MM-dd"
        Dim camposU As String = "primerNombre='" & paciente.PrimerNombre & "', primerApellido='" & paciente.PrimerApellido & "', segundoApellido='" & paciente.SegundoApellido & "', sexo='" & paciente.Sexo & "', telefono='" & paciente.Telefono & "', calle='" & paciente.Calle & "', esquina='" & paciente.Esquina & "', numeroPuerta='" & paciente.NumeroPuerta & "', fechaNacimiento='" & paciente.FechaNacimiento.ToString(formato) & "'"
        Dim modiU As String = "update usuario set " + camposU + " where ci='" & paciente.Ci & "'"
        Dim camposP As String = "contrasena='" & paciente.Contraseña & "'"
        Dim modiP As String = "update paciente set " + camposP + " where ciPaciente='" & paciente.Ci & "'"
        If Modificar(modiU) Then
            If Modificar(modiP) Then
                Return True
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorInsertar", Traduccion.Idioma))
    End Function
    Public Function EliminarPaciente(paciente As Paciente)
        VerificarConexion()
        Dim sqlP As String = "delete from paciente where ciPaciente= '" & paciente.Ci & "'"
        Dim sqlR As String = "delete from recibe where ciPaciente= '" & paciente.Ci & "'"
        Dim sqlM As String = "delete from mensajechat where ciEmisor= '" & paciente.Ci & "'"
        Dim sqlU As String = "delete from usuario where ci = '" & paciente.Ci & "'"
        If Eliminar(sqlR) Then
            If Eliminar(sqlM) Then
                If Eliminar(sqlP) Then
                    If Eliminar(sqlU) Then
                        Return True
                    End If
                End If
            End If
        ElseIf Eliminar(sqlM) Then
            If Eliminar(sqlP) Then
                If Eliminar(sqlU) Then
                    Return True
                End If
            End If
        ElseIf Eliminar(sqlP) Then
            If Eliminar(sqlU) Then
                Return True
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorEliminar", Traduccion.Idioma))
    End Function
    Public Function ObtenerPacientes() As List(Of Paciente)
        VerificarConexion()
        Conectar()
        Dim pacientes As List(Of Paciente) = New List(Of Paciente)
        pacientes.Clear()
        Dim sql As String = "select * from usuario u inner join paciente p on u.ci=p.ciPaciente"
        Dim cmd = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Dim pac As New Paciente(dr("ci"), dr("contrasena"), dr("primerNombre"), dr("primerApellido"), dr("segundoApellido"), dr("sexo"), dr("telefono"), dr("calle"), dr("esquina"), dr("numeroPuerta"), dr("fechaNacimiento"), dr("mail"))
            pacientes.Add(pac)
        End While
        Desconectar()
        Return pacientes
    End Function

    'Gestion Patologias
    Public Function IngresarPatologia(patologia As Patologia)
        VerificarConexion()
        Dim datosP As String = "null, '" & patologia.Especialista & "', '" & patologia.Gravedad & "', '" & patologia.Nombre & "'"
        Dim sqlP As String = "INSERT INTO `patologia` VALUES (" & datosP & ")"
        If Insertar(sqlP) Then
            Return True
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorInsertar", Traduccion.Idioma))
    End Function
    Public Function ModificarPatologia(patologia As Patologia)
        VerificarConexion()
        Dim camposP As String = "especialista='" & patologia.Especialista & "', gravedad='" & patologia.Gravedad & "', nombrePatologia='" & patologia.Nombre & "'"
        Dim modiP As String = "update patologia set " + camposP + " where codigoPatologia='" & patologia.Codigo & "'"
        If Modificar(modiP) Then
            Return True
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorModificar", Traduccion.Idioma))
    End Function
    Public Function EliminarPatologia(patologia As Patologia)
        VerificarConexion()
        Dim sqlA As String = "delete from asociado where codigoPatologia= '" & patologia.Codigo & "'"
        Dim sqlP As String = "delete from patologia where codigoPatologia= '" & patologia.Codigo & "'"
        If Eliminar(sqlA) Then
            If Eliminar(sqlP) Then
                Return True
            End If
        ElseIf Eliminar(sqlP) Then
            Return True
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorEliminar", Traduccion.Idioma))
    End Function
    Public Function ObtenerPatologias() As List(Of Patologia)
        VerificarConexion()
        Conectar()
        Dim patologias As List(Of Patologia) = New List(Of Patologia)
        patologias.Clear()
        Dim sql As String = "select * from patologia"
        Dim cmd = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Dim patologia As New Patologia(dr("codigoPatologia"), dr("nombrePatologia"), dr("especialista"), dr("gravedad"))
            patologias.Add(patologia)
        End While
        Desconectar()
        For Each patologia As Patologia In patologias
            Conectar()
            Dim sintomas As List(Of Sintoma) = New List(Of Sintoma)
            Dim codigoSintomas As List(Of Integer) = New List(Of Integer)
            Dim sql2 As String = "select * from asociado"
            Dim cmd2 = New MySqlCommand(sql2, conexion)
            Dim dr2 As MySqlDataReader
            dr2 = cmd2.ExecuteReader
            While dr2.Read
                If patologia.Codigo = dr2("codigoPatologia") Then
                    codigoSintomas.Add(dr2("codigoSintoma"))
                End If
            End While
            Desconectar()
            Dim SintomasBD As List(Of Sintoma) = ObtenerSintomas()
            Dim sintomasPatologia As List(Of Sintoma) = New List(Of Sintoma)
            For Each sint As Integer In codigoSintomas
                For Each sintBD As Sintoma In SintomasBD
                    If sint = sintBD.Codigo Then
                        sintomasPatologia.Add(sintBD)
                    End If
                Next
            Next
            patologia.Sintomas = sintomasPatologia
        Next
        Desconectar()
        Return patologias
    End Function

    'Gestion Sintomas
    Public Function IngresarSintoma(sintoma As Sintoma)
        VerificarConexion()
        Dim datosS As String = "null, '" & sintoma.Nombre & "'"
        Dim sqlS As String = "INSERT INTO `sintoma` VALUES (" & datosS & ")"
        If Insertar(sqlS) Then
            Return True
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorInsertar", Traduccion.Idioma))
    End Function
    Public Function ModificarSintoma(sintoma As Sintoma)
        VerificarConexion()
        Dim camposS As String = "nombreSintoma='" & sintoma.Nombre & "'"
        Dim modiS As String = "update sintoma set " & camposS & " where codigoSintoma='" & sintoma.Codigo & "'"
        If Modificar(modiS) Then
            Return True
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorModificar", Traduccion.Idioma))
    End Function
    Public Function EliminarSintoma(sintoma As Sintoma)
        VerificarConexion()
        Dim sqlA As String = "delete from asociado where codigoSintoma='" & sintoma.Codigo & "'"
        Dim sqlS As String = "delete from sintoma where codigoSintoma='" & sintoma.Codigo & "'"
        If Eliminar(sqlA) Then
            If Eliminar(sqlS) Then
                Return True
            End If
        ElseIf Eliminar(sqlS) Then
            Return True
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorEliminar", Traduccion.Idioma))
    End Function
    Public Function ObtenerSintomas() As List(Of Sintoma)
        VerificarConexion()
        Conectar()
        Dim sintomas As List(Of Sintoma) = New List(Of Sintoma)
        sintomas.Clear()
        Dim sql As String = "select * from sintoma"
        Dim cmd = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Dim sintoma As New Sintoma(dr("codigoSintoma"), dr("nombreSintoma"))
            sintomas.Add(sintoma)
        End While
        Desconectar()
        Return sintomas
    End Function

    'Asociar y desasociar síntomas a patologías
    Public Function Asociar(patologia As Patologia, sintoma As Sintoma)
        VerificarConexion()
        Conectar()
        Dim datos As String = "'" & patologia.Codigo & "', '" & sintoma.Codigo & "'"
        Dim sql As String = "INSERT INTO `asociado` (`CodigoPatologia`, `CodigoSintoma`) VALUES (" & datos & ")"
        cmd = New MySqlCommand(sql, conexion)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i > 0) Then
            Desconectar()
            Return True
        Else
            Desconectar()
            Throw New Exception(Traduccion.Traducir("msgErrorAsociar", Traduccion.Idioma))
        End If
    End Function
    Public Function Desasociar(patologia As Patologia, sintoma As Sintoma)
        VerificarConexion()
        Conectar()
        Dim datos As String = "codigopatologia='" & patologia.Codigo & "' and codigoSintoma='" & sintoma.Codigo & "'"
        Dim sql As String = "DELETE FROM `asociado` WHERE " & datos & ""
        cmd = New MySqlCommand(sql, conexion)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i > 0) Then
            Desconectar()
            Return True
        Else
            Desconectar()
            Throw New Exception(Traduccion.Traducir("msgErrorDesasociar", Traduccion.Idioma))
        End If
    End Function

    'Diagnóstico
    Public Function ObtenerSintomasAsociadosAAlgunaPatologia()
        VerificarConexion()
        Conectar()
        Dim sintomas As List(Of Sintoma) = New List(Of Sintoma)
        sintomas.Clear()
        Dim sql As String = "select * from sintoma where codigosintoma = any(select codigosintoma from asociado)"
        Dim cmd = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Dim sintoma As New Sintoma(dr("codigoSintoma"), dr("nombreSintoma"))
            sintomas.Add(sintoma)
        End While
        Desconectar()
        Return sintomas
    End Function
    Public Function RealizarConsulta(patologia As Patologia, paciente As Paciente)
        If RevisarCantidadDeDiagnosticosHoy(paciente.Ci) Then
            VerificarConexion()
            Conectar()
            Dim cantResultados = New List(Of Integer)
            Dim sql As String = "select * from diagnostico order by codigodiagnostico"
            Dim cmd = New MySqlCommand(sql, conexion) ' ejecuta un comando con la consulta que se pasa como parametro
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                cantResultados.Add(dr("codigodiagnostico").ToString())
            End While
            Dim numDiagnostico
            If cantResultados.Count = 0 Then
                cantResultados.Add(0)
            End If
            numDiagnostico = cantResultados.Last + 1
            Desconectar()
            Dim formato As String = "yyyy-MM-dd"
            Dim nuevoDiagnostico As New Diagnostico(numDiagnostico, patologia.Codigo, patologia.Codigo, "Inactivo", DateTime.Now.ToString(formato), paciente.Ci, "")
            Dim insertDiagnostico As String = "insert into diagnostico values(null, '" & patologia.Codigo & "', '" & patologia.Codigo & "', 'Inactivo', '" & DateTime.Now.ToString(formato) & "')"
            Dim insertRecibe As String = "insert into recibe values('" & paciente.Ci & "','" & numDiagnostico & "')"
            If Insertar(insertDiagnostico) Then
                If Insertar(insertRecibe) Then
                    Return nuevoDiagnostico
                End If
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorRealizarConsulta", Traduccion.Idioma))
    End Function
    Public Function RevisarCantidadDeDiagnosticosHoy(ciPaciente As String)
        VerificarConexion()
        Conectar()
        Dim cantConsultasHoy As Integer = 0
        Dim sql As String = "select r.CIPaciente, count(d.CodigoDiagnostico) from recibe r inner join diagnostico d on d.CodigoDiagnostico=r.CodigoDiagnostico where r.cipaciente='" & ciPaciente & "' and d.FechaDiagnostico=curdate() group by r.CIPaciente"
        Dim cmd = New MySqlCommand(sql, conexion) ' ejecuta un comando con la consulta que se pasa como parametro
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            cantConsultasHoy = dr("count(d.CodigoDiagnostico)")
        End While
        If cantConsultasHoy + 1 = 5 Then
            Throw New Exception(Traduccion.Traducir("msg4Consultas", Traduccion.Idioma))
        End If
        Return True
    End Function
    Public Function ActivarEstadoDiagnostico(diagnostico As Diagnostico)
        VerificarConexion()
        Dim activarEstado As String = "update diagnostico set estado='Activo' where codigoDiagnostico='" & diagnostico.Codigo & "'"
        If Insertar(activarEstado) Then
            Return True
        End If
        Return False
    End Function
    Public Function DesactivarEstadoDiagnostico(diagnostico As Diagnostico)
        VerificarConexion()
        Dim desactivarEstado As String = "update diagnostico set estado='Inactivo' where codigoDiagnostico='" & diagnostico.Codigo & "'"
        If Insertar(desactivarEstado) Then
            Return True
        End If
        Return False
    End Function
    Public Function ObtenerDiagnosticos()
        VerificarConexion()
        Conectar()
        Dim diagnosticos As List(Of Diagnostico) = New List(Of Diagnostico)
        Dim sql As String = "select * from diagnostico d inner join recibe r on d.codigodiagnostico=r.codigodiagnostico"
        Dim cmd = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Dim patologiaFinal As Integer
            If IsDBNull(dr("codigoPatologiaFinal")) Then
                patologiaFinal = -1
            Else
                patologiaFinal = dr("codigoPatologiaFinal")
            End If
            Dim diag As New Diagnostico(dr("CodigoDiagnostico"), dr("CodigoPatologiaPrimaria"), patologiaFinal, dr("FechaDiagnostico"), dr("CiPaciente"))
            diagnosticos.Add(diag)
        End While
        Desconectar()
        Return diagnosticos
    End Function

    'Chat
    Public Function IngresarMensaje(mensaje As Mensaje)
        VerificarConexion()
        Dim formato As String = "yyyy-MM-dd"
        Dim datos As String = "null, '" & mensaje.Emisor & "', '" & mensaje.Contenido & "', '" & mensaje.Fecha.ToString(formato) & "', '" & mensaje.CodDiagnostico & "'"
        Dim sql As String = "INSERT INTO `mensajechat` VALUES (" & datos & ")"
        If Insertar(sql) Then
            Return True
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorEnviarMensaje", Traduccion.Idioma))
    End Function
    Public Function ObtenerMensajes(diagnostico As Diagnostico)
        VerificarConexion()
        Conectar()
        Dim mensajes As List(Of Mensaje) = New List(Of Mensaje)
        mensajes.Clear()
        Dim sql As String = "select * from mensajechat where codigoDiagnostico='" & diagnostico.Codigo & "'"
        Dim cmd = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Dim mensaje As New Mensaje(dr("codigoMensaje"), dr("contenidoMensaje"), dr("ciEmisor"), dr("fechaMensaje"), dr("codigoDiagnostico"))
            mensajes.Add(mensaje)
        End While
        Desconectar()
        Return mensajes
    End Function
    Public Function ObtenerNombreUsuarios()
        VerificarConexion()
        Conectar()
        Dim usuarios As List(Of Usuario) = New List(Of Usuario)
        usuarios.Clear()
        Dim sql As String = "select * from usuario"
        Dim cmd = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Dim usuario As New Usuario(dr("ci"), dr("primerNombre"))
            usuarios.Add(usuario)
        End While
        Desconectar()
        Return usuarios
    End Function
    Public Function ObtenerSolicitudes(medico As Medico)
        VerificarConexion()
        Conectar()
        Dim solicitudes As List(Of Solicitud) = New List(Of Solicitud)
        solicitudes.Clear()
        Dim sql As String = "select * from diagnostico d inner join patologia p on p.codigopatologia=d.codigoPatologiaPrimaria inner join recibe r on r.codigoDiagnostico=d.CodigoDiagnostico where p.especialista='" & medico.Especialidad & "' and d.estado='Activo'"
        Dim cmd = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Dim soli As New Solicitud(dr("CodigoDiagnostico"), dr("CiPaciente"), dr("NombrePatologia"), dr("Gravedad"))
            solicitudes.Add(soli)
        End While
        Desconectar()
        Return solicitudes
    End Function
    Public Function ObtenerMedicoQueAtiende(codDiagnostico As Integer)
        VerificarConexion()
        Conectar()
        Dim CiMedico As String = ""
        Dim sql As String = "select * from atiende where codigoDiagnostico='" & codDiagnostico & "'"
        Dim cmd = New MySqlCommand(sql, conexion)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            CiMedico = dr("CiMedico")
        End While
        Desconectar()
        Return CiMedico
    End Function
    Public Function ModificarMedicoQueAtiende(codDiagnostico As Integer, ciMedico As String)
        VerificarConexion()
        Dim datos As String = "'" & codDiagnostico & "', '" & ciMedico & "'"
        Dim sql As String = "INSERT INTO `atiende` VALUES (" & datos & ")"
        If Insertar(sql) Then
            Return True
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorEnviarMensaje", Traduccion.Idioma))
    End Function
    Public Function ModificarPatologiaFinal(diagnostico As Diagnostico)
        VerificarConexion()
        Dim patFinal As String = "update diagnostico set codigoPatologiaFinal='" & diagnostico.CodigoPatologiaFinal & "' where codigoDiagnostico='" & diagnostico.Codigo & "'"
        Modificar(patFinal)
        Return True
    End Function

    'Funciones de consultas generales
    Public Function Insertar(sql As String)
        Conectar()
        cmd = New MySqlCommand(sql, conexion)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i > 0) Then
            Desconectar()
            Return True
        Else
            Desconectar()
            Return False
        End If

    End Function
    Public Function Modificar(ByVal modi)
        Conectar()
        cmd = New MySqlCommand(modi, conexion)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i > 0) Then
            Desconectar()
            Return True
        Else
            Desconectar()
            Return False
        End If
    End Function
    Public Function Eliminar(del As String)
        VerificarConexion()
        Conectar()
        cmd = New MySqlCommand(del, conexion)
        Dim i As Integer = cmd.ExecuteNonQuery()
        Desconectar()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class