Imports CapaBaseDeDatos
Imports Datos
Public Class LogicaInformacion
    Dim conexion As conexionBD = New conexionBD
    Public Function InfoAdmin(cedula As String)
        Dim Admins As List(Of Administrador)
        Admins = conexion.ObtenerAdministradores
        Dim Administrador As Administrador = Nothing
        For Each admin As Administrador In Admins
            If admin.Ci = cedula Then
                Administrador = admin
            End If
        Next
        Return Administrador
    End Function
    Public Function ModificarAdministrador(admin As Administrador)
        If DatosVacios(admin.Ci) Or DatosVacios(admin.Contraseña) Or DatosVacios(admin.PrimerApellido) Or DatosVacios(admin.PrimerNombre) Or DatosVacios(admin.SegundoApellido) Or DatosVacios(admin.Calle) Or DatosVacios(admin.Esquina) Or DatosVacios(admin.NumeroPuerta) Or DatosVacios(admin.FechaNacimiento) Or DatosVacios(admin.Telefono) Then
            Throw New Exception(Traduccion.Traducir("msgRellenarCampos", Traduccion.Idioma))
        ElseIf admin.Contraseña.Length < 8 Then
            Throw New Exception(Traduccion.Traducir("msgContraseñaCaracteres", Traduccion.Idioma))
        Else
            If conexion.ModificarAdministrador(admin) Then
                Return True
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorModificar", Traduccion.Idioma))
    End Function
    Public Function InfoMedico(cedula As String)
        Dim Medicos As List(Of Medico) = New List(Of Medico)
        Medicos = conexion.ObtenerMedicos
        Dim Medico As Medico = Nothing
        For Each Med As Medico In Medicos
            If Med.Ci = cedula Then
                Medico = Med
            End If
        Next
        Return Medico
    End Function
    Public Function ModificarMedico(medico As Medico)
        If DatosVacios(medico.Ci) Or DatosVacios(medico.Contraseña) Or DatosVacios(medico.PrimerApellido) Or DatosVacios(medico.PrimerNombre) Or DatosVacios(medico.SegundoApellido) Or DatosVacios(medico.Calle) Or DatosVacios(medico.Esquina) Or DatosVacios(medico.NumeroPuerta) Or DatosVacios(medico.FechaNacimiento) Or DatosVacios(medico.Telefono) Or DatosVacios(medico.Especialidad) Then
            Throw New Exception(Traduccion.Traducir("msgRellenarCampos", Traduccion.Idioma))
        ElseIf medico.Contraseña.Length < 8 Then
            Throw New Exception(Traduccion.Traducir("msgContraseñaCaracteres", Traduccion.Idioma))
        Else
            If conexion.ModificarMedico(medico) Then
                Return True
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorModificar", Traduccion.Idioma))
    End Function
    Public Function InfoPaciente(cedula As String)
        Dim pacientes As List(Of Paciente) = New List(Of Paciente)
        pacientes = conexion.ObtenerPacientes
        Dim paciente As Paciente = Nothing
        For Each pac As Paciente In pacientes
            If pac.Ci = cedula Then
                paciente = pac
            End If
        Next
        Return paciente
    End Function
    Public Function ModificarPaciente(paciente As Paciente)
        If DatosVacios(paciente.Ci) Or DatosVacios(paciente.Contraseña) Or DatosVacios(paciente.PrimerApellido) Or DatosVacios(paciente.PrimerNombre) Or DatosVacios(paciente.SegundoApellido) Or DatosVacios(paciente.Calle) Or DatosVacios(paciente.Esquina) Or DatosVacios(paciente.NumeroPuerta) Or DatosVacios(paciente.FechaNacimiento) Or DatosVacios(paciente.Telefono) Or DatosVacios(paciente.Mail) Then
            Throw New Exception(Traduccion.Traducir("msgRellenarCampos", Traduccion.Idioma))
        ElseIf paciente.Contraseña.Length < 8 Then
            Throw New Exception(Traduccion.Traducir("msgContraseñaCaracteres", Traduccion.Idioma))
        Else
            If conexion.ModificarPaciente(paciente) Then
                Return True
            End If
        End If
        Throw New Exception(Traduccion.Traducir("msgErrorModificar", Traduccion.Idioma))
    End Function
    Public Function DatosVacios(dato As String)
        If dato = "" Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function ObtenerHistorialDiagnosticos()
        Dim diagnosticos As List(Of Diagnostico) = conexion.ObtenerDiagnosticos()
        Return diagnosticos
    End Function
    Public Function ObtenerPatologias()
        Dim patologias As List(Of Patologia) = conexion.ObtenerPatologias
        Return patologias
    End Function
End Class