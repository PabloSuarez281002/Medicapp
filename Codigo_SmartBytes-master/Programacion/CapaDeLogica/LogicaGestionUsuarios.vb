Imports CapaBaseDeDatos
Imports Datos
Public Class LogicaGestionUsuarios
    Dim conexion As conexionBD = New conexionBD


    'Gestion Administradores
    Public Function IngresarAdministrador(admin As Administrador)
        If DatosVacios(admin.Ci) Or DatosVacios(admin.Contraseña) Or DatosVacios(admin.PrimerApellido) Or DatosVacios(admin.PrimerNombre) Or DatosVacios(admin.SegundoApellido) Or DatosVacios(admin.Calle) Or DatosVacios(admin.Esquina) Or DatosVacios(admin.NumeroPuerta) Or DatosVacios(admin.FechaNacimiento) Or DatosVacios(admin.Telefono) Then
            Throw New Exception(Traduccion.Traducir("msgRellenarCampos", Traduccion.Idioma))
        ElseIf ContieneNumeros(admin.PrimerNombre) Then
            Throw New Exception(Traduccion.Traducir("msgNombreNumeros", Traduccion.Idioma))
        ElseIf ContieneNumeros(admin.PrimerApellido) Then
            Throw New Exception(Traduccion.Traducir("msgApellidoNumeros", Traduccion.Idioma))
        ElseIf ContieneNumeros(admin.SegundoApellido) Then
            Throw New Exception(Traduccion.Traducir("msgApellidoNumeros", Traduccion.Idioma))
        ElseIf admin.Sexo <> "Masculino" And admin.Sexo <> "Femenino" Then
            Throw New Exception(Traduccion.Traducir("msgSexo", Traduccion.Idioma))
        ElseIf admin.Contraseña.Length < 8 Then
            Throw New Exception(Traduccion.Traducir("msgContraseñaCaracteres", Traduccion.Idioma))
        Else
            If VerificarUsuarioExiste(admin.Ci) Then
                Throw New Exception(Traduccion.Traducir("msgNoRepetirCedula", Traduccion.Idioma))
            End If
            If VerificarMailEnUso(admin.Ci,admin.Mail) Then
                Throw New Exception(Traduccion.Traducir("msgNoRepetirMail", Traduccion.Idioma))
            End If
            If conexion.IngresarAdministrador(admin) Then
                Return True
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorIngresarUsuario", Traduccion.Idioma))
    End Function
    Public Function ModificarAdministrador(admin As Administrador)
        If DatosVacios(admin.Ci) Or DatosVacios(admin.Contraseña) Or DatosVacios(admin.PrimerApellido) Or DatosVacios(admin.PrimerNombre) Or DatosVacios(admin.SegundoApellido) Or DatosVacios(admin.Calle) Or DatosVacios(admin.Esquina) Or DatosVacios(admin.NumeroPuerta) Or DatosVacios(admin.FechaNacimiento) Or DatosVacios(admin.Telefono) Then
            Throw New Exception(Traduccion.Traducir("msgRellenarCampos", Traduccion.Idioma))
        ElseIf ContieneNumeros(admin.PrimerNombre) Then
            Throw New Exception(Traduccion.Traducir("msgNombreNumeros", Traduccion.Idioma))
        ElseIf ContieneNumeros(admin.PrimerApellido) Then
            Throw New Exception(Traduccion.Traducir("msgApellidoNumeros", Traduccion.Idioma))
        ElseIf ContieneNumeros(admin.SegundoApellido) Then
            Throw New Exception(Traduccion.Traducir("msgApellidoNumeros", Traduccion.Idioma))
        ElseIf admin.Sexo <> "Masculino" And admin.Sexo <> "Femenino" Then
            Throw New Exception(Traduccion.Traducir("msgSexo", Traduccion.Idioma))
        ElseIf admin.Contraseña.Length < 8 Then
            Throw New Exception(Traduccion.Traducir("msgContraseñaCaracteres", Traduccion.Idioma))
        Else
            If Not VerificarUsuarioExiste(admin.Ci) Then
                Throw New Exception(Traduccion.Traducir("msgCedulaNoCoincide", Traduccion.Idioma))
            End If
            If VerificarMailEnUso(admin.Ci, admin.Mail) Then
                Throw New Exception(Traduccion.Traducir("msgNoRepetirMail", Traduccion.Idioma))
            End If
            If conexion.ModificarAdministrador(admin) Then
                Return True
            Else
                Throw New Exception(Traduccion.Traducir("msgErrorModificarUsuario", Traduccion.Idioma))
            End If
        End If
    End Function
    Public Function EliminarAdministrador(admin As Administrador)
        If DatosVacios(admin.Ci) Then
            Throw New Exception(Traduccion.Traducir("msgIngresarCedula", Traduccion.Idioma))
        Else
            If Not VerificarUsuarioExiste(admin.Ci) Then
                Throw New Exception(Traduccion.Traducir("msgCedulaNoCoincide", Traduccion.Idioma))
            End If
            If conexion.EliminarAdministrador(admin) Then
                Return True
            Else
                Throw New Exception(Traduccion.Traducir("msgErrorEliminarUsuario", Traduccion.Idioma))
            End If
        End If
    End Function
    Public Function ObtenerAdministradores()
        Dim administradores As List(Of Administrador) = New List(Of Administrador)
        administradores = conexion.ObtenerAdministradores()
        Return administradores
    End Function


    'Gestion Medicos
    Public Function IngresarMedico(medico As Medico)
        If DatosVacios(medico.Ci) Or DatosVacios(medico.Contraseña) Or DatosVacios(medico.PrimerApellido) Or DatosVacios(medico.PrimerNombre) Or DatosVacios(medico.SegundoApellido) Or DatosVacios(medico.Calle) Or DatosVacios(medico.Esquina) Or DatosVacios(medico.NumeroPuerta) Or DatosVacios(medico.FechaNacimiento) Or DatosVacios(medico.Telefono) Or DatosVacios(medico.Especialidad) Then
            Throw New Exception(Traduccion.Traducir("msgRellenarCampos", Traduccion.Idioma))
        ElseIf ContieneNumeros(medico.PrimerNombre) Then
            Throw New Exception(Traduccion.Traducir("msgNombreNumeros", Traduccion.Idioma))
        ElseIf ContieneNumeros(medico.PrimerApellido) Then
            Throw New Exception(Traduccion.Traducir("msgApellidoNumeros", Traduccion.Idioma))
        ElseIf ContieneNumeros(medico.SegundoApellido) Then
            Throw New Exception(Traduccion.Traducir("msgApellidoNumeros", Traduccion.Idioma))
        ElseIf medico.Sexo <> "Masculino" And medico.Sexo <> "Femenino" Then
            Throw New Exception(Traduccion.Traducir("msgSexo", Traduccion.Idioma))
        ElseIf medico.Contraseña.Length < 8 Then
            Throw New Exception(Traduccion.Traducir("msgContraseñaCaracteres", Traduccion.Idioma))
        Else
            If VerificarUsuarioExiste(medico.Ci) Then
                Throw New Exception(Traduccion.Traducir("msgNoRepetirCedula", Traduccion.Idioma))
            End If
            If VerificarMailEnUso(medico.Ci, medico.Mail) Then
                Throw New Exception(Traduccion.Traducir("msgNoRepetirMail", Traduccion.Idioma))
            End If
            If conexion.IngresarMedico(medico) Then
                Return True
            Else
                Throw New Exception(Traduccion.Traducir("msgErrorIngresarUsuario", Traduccion.Idioma))
            End If
        End If
    End Function
    Public Function ModificarMedico(medico As Medico)
        If DatosVacios(medico.Ci) Or DatosVacios(medico.Contraseña) Or DatosVacios(medico.PrimerApellido) Or DatosVacios(medico.PrimerNombre) Or DatosVacios(medico.SegundoApellido) Or DatosVacios(medico.Calle) Or DatosVacios(medico.Esquina) Or DatosVacios(medico.NumeroPuerta) Or DatosVacios(medico.FechaNacimiento) Or DatosVacios(medico.Telefono) Or DatosVacios(medico.Especialidad) Then
            Throw New Exception(Traduccion.Traducir("msgRellenarCampos", Traduccion.Idioma))
        ElseIf ContieneNumeros(medico.PrimerNombre) Then
            Throw New Exception(Traduccion.Traducir("msgNombreNumeros", Traduccion.Idioma))
        ElseIf ContieneNumeros(medico.PrimerApellido) Then
            Throw New Exception(Traduccion.Traducir("msgApellidoNumeros", Traduccion.Idioma))
        ElseIf ContieneNumeros(medico.SegundoApellido) Then
            Throw New Exception(Traduccion.Traducir("msgApellidoNumeros", Traduccion.Idioma))
        ElseIf medico.Sexo <> "Masculino" And medico.Sexo <> "Femenino" Then
            Throw New Exception(Traduccion.Traducir("msgSexo", Traduccion.Idioma))
        ElseIf medico.Contraseña.Length < 8 Then
            Throw New Exception(Traduccion.Traducir("msgContraseñaCaracteres", Traduccion.Idioma))
        Else
            If Not VerificarUsuarioExiste(medico.Ci) Then
                Throw New Exception(Traduccion.Traducir("msgCedulaNoCoincide", Traduccion.Idioma))
            End If
            If VerificarMailEnUso(medico.Ci, medico.Mail) Then
                Throw New Exception(Traduccion.Traducir("msgNoRepetirMail", Traduccion.Idioma))
            End If
            If conexion.ModificarMedico(medico) Then
                Return True
            Else
                Throw New Exception(Traduccion.Traducir("msgErrorModificarUsuario", Traduccion.Idioma))
            End If
        End If
    End Function
    Public Function EliminarMedico(medico As Medico)
        If DatosVacios(medico.Ci) Then
            Throw New Exception(Traduccion.Traducir("msgIngresarCedula", Traduccion.Idioma))
        Else
            If Not VerificarUsuarioExiste(medico.Ci) Then
                Throw New Exception(Traduccion.Traducir("msgCedulaNoCoincide", Traduccion.Idioma))
            End If
            If conexion.EliminarMedico(medico) Then
                Return True
            Else
                Throw New Exception(Traduccion.Traducir("msgErrorEliminarUsuario", Traduccion.Idioma))
            End If
        End If
    End Function
    Public Function ObtenerMedicos()
        Dim medicos As List(Of Medico) = New List(Of Medico)
        medicos = conexion.ObtenerMedicos()
        Return medicos
    End Function


    'Gestion Pacientes
    Public Function IngresarPaciente(paciente As Paciente)
        If DatosVacios(paciente.Ci) Or DatosVacios(paciente.Contraseña) Or DatosVacios(paciente.PrimerApellido) Or DatosVacios(paciente.PrimerNombre) Or DatosVacios(paciente.SegundoApellido) Or DatosVacios(paciente.Calle) Or DatosVacios(paciente.Esquina) Or DatosVacios(paciente.NumeroPuerta) Or DatosVacios(paciente.FechaNacimiento) Or DatosVacios(paciente.Telefono) Then
            Throw New Exception(Traduccion.Traducir("msgRellenarCampos", Traduccion.Idioma))
        ElseIf ContieneNumeros(paciente.PrimerNombre) Then
            Throw New Exception(Traduccion.Traducir("msgNombreNumeros", Traduccion.Idioma))
        ElseIf ContieneNumeros(paciente.PrimerApellido) Then
            Throw New Exception(Traduccion.Traducir("msgApellidoNumeros", Traduccion.Idioma))
        ElseIf ContieneNumeros(paciente.SegundoApellido) Then
            Throw New Exception(Traduccion.Traducir("msgApellidoNumeros", Traduccion.Idioma))
        ElseIf paciente.Sexo <> "Masculino" And paciente.Sexo <> "Femenino" Then
            Throw New Exception(Traduccion.Traducir("msgSexo", Traduccion.Idioma))
        ElseIf paciente.Contraseña.Length < 8 Then
            Throw New Exception(Traduccion.Traducir("msgContraseñaCaracteres", Traduccion.Idioma))
        Else
            If VerificarUsuarioExiste(paciente.Ci) Then
                Throw New Exception(Traduccion.Traducir("msgCedulaNoCoincide", Traduccion.Idioma))
            End If
            If VerificarMailEnUso(paciente.Ci, paciente.Mail) Then
                Throw New Exception(Traduccion.Traducir("msgNoRepetirMail", Traduccion.Idioma))
            End If
            If conexion.IngresarPaciente(paciente) Then
                Return True
            Else
                Throw New Exception(Traduccion.Traducir("msgErrorIngresarUsuario", Traduccion.Idioma))
            End If
        End If
    End Function
    Public Function ModificarPaciente(paciente As Paciente)
        If DatosVacios(paciente.Ci) Or DatosVacios(paciente.Contraseña) Or DatosVacios(paciente.PrimerApellido) Or DatosVacios(paciente.PrimerNombre) Or DatosVacios(paciente.SegundoApellido) Or DatosVacios(paciente.Calle) Or DatosVacios(paciente.Esquina) Or DatosVacios(paciente.NumeroPuerta) Or DatosVacios(paciente.FechaNacimiento) Or DatosVacios(paciente.Telefono) Then
            Throw New Exception(Traduccion.Traducir("msgRellenarCampos", Traduccion.Idioma))
        ElseIf ContieneNumeros(paciente.PrimerNombre) Then
            Throw New Exception(Traduccion.Traducir("msgNombreNumeros", Traduccion.Idioma))
        ElseIf ContieneNumeros(paciente.PrimerApellido) Then
            Throw New Exception(Traduccion.Traducir("msgApellidoNumeros", Traduccion.Idioma))
        ElseIf ContieneNumeros(paciente.SegundoApellido) Then
            Throw New Exception(Traduccion.Traducir("msgApellidoNumeros", Traduccion.Idioma))
        ElseIf paciente.Sexo <> "Masculino" And paciente.Sexo <> "Femenino" Then
            Throw New Exception(Traduccion.Traducir("msgSexo", Traduccion.Idioma))
        ElseIf paciente.Contraseña.Length < 8 Then
            Throw New Exception(Traduccion.Traducir("msgContraseñaCaracteres", Traduccion.Idioma))
        Else
            If Not VerificarUsuarioExiste(paciente.Ci) Then
                Throw New Exception(Traduccion.Traducir("msgCedulaNoCoincide", Traduccion.Idioma))
            End If
            If VerificarMailEnUso(paciente.Ci, paciente.Mail) Then
                Throw New Exception(Traduccion.Traducir("msgNoRepetirMail", Traduccion.Idioma))
            End If
            If conexion.ModificarPaciente(paciente) Then
                Return True
            Else
                Throw New Exception(Traduccion.Traducir("msgErrorModificarUsuario", Traduccion.Idioma))
            End If
        End If
    End Function
    Public Function EliminarPaciente(paciente As Paciente)
        If DatosVacios(paciente.Ci) Then
            Throw New Exception(Traduccion.Traducir("msgIngresarCedula", Traduccion.Idioma))
        Else
            If Not VerificarUsuarioExiste(paciente.Ci) Then
                Throw New Exception(Traduccion.Traducir("msgCedulaNoCoincide", Traduccion.Idioma))
            End If
            If conexion.EliminarPaciente(paciente) Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
    Public Function ObtenerPacientes()
        Dim pacientes As List(Of Paciente) = New List(Of Paciente)
        pacientes = conexion.ObtenerPacientes()
        Return pacientes
    End Function


    'Funciones para validar de datos
    Public Function ContieneNumeros(dato As String)
        If DatosVacios(dato) Then
            Return True
        End If
        Dim numeros() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}
        For Each num As Integer In numeros
            If dato.Contains(num) Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Function DatosVacios(dato As String)
        If dato = Nothing Then
            dato = ""
        End If
        If dato.Length = 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function VerificarUsuarioExiste(ci As String)
        Dim usuarios As List(Of Usuario) = conexion.ObtenerUsuarios
        For Each usuario As Usuario In usuarios
            If usuario.Ci = ci Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Function VerificarMailEnUso(ci As String, mail As String)
        Dim usuarios As List(Of Usuario) = conexion.ObtenerUsuarios
        For Each usuario As Usuario In usuarios
            If usuario.Mail = mail And usuario.Ci <> ci Then
                Return True
            End If
        Next
        Return False
    End Function
End Class