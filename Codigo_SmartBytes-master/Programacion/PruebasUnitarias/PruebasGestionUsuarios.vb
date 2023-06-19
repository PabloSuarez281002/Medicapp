Imports CapaDeLogica
Imports Datos
<TestClass()> Public Class PruebasGestionUsuarios
    Dim logicaUsuarios As New LogicaGestionUsuarios

    'Ingresar usuario 
    'Casos de error
    <TestMethod()> Public Sub GestionPacientesIngresarCedulaErronea()

        Dim paciente As New Paciente("666646666", "123456789", "Mauro", "Sosa", "Cerrudo", "Masculino", "092468741", "Maria Orticochea", "Hector Vigil", "8465", "2003-01-06", "testmail@gmail.com")
        Dim arrojoException As Boolean = False
        Try
            logicaUsuarios.IngresarPaciente(paciente)
        Catch ex As Exception
            arrojoException = True
        End Try
        Assert.AreEqual(True, arrojoException)
    End Sub
    <TestMethod()> Public Sub GestionPacientesIngresarContraseñaCorta()

        Dim paciente As New Paciente("66666666", "1234", "Mauro", "Sosa", "Cerrudo", "Masculino", "092468741", "Maria Orticochea", "Hector Vigil", "8465", "2003-01-06", "testmail@gmail.com")
        Dim arrojoException As Boolean = False
        Try
            logicaUsuarios.IngresarPaciente(paciente)
        Catch ex As Exception
            arrojoException = True
        End Try
        Assert.AreEqual(True, arrojoException)
    End Sub
    <TestMethod()> Public Sub GestionPacientesIngresarCampoVacio()

        Dim paciente As New Paciente("66666666", "123456789", "Mauro", "", "Cerrudo", "Masculino", "092468741", "Maria Orticochea", "Hector Vigil", "8465", "2003-01-06", "testmail@gmail.com")
        Dim arrojoException As Boolean = False
        Try
            logicaUsuarios.IngresarPaciente(paciente)
        Catch ex As Exception
            arrojoException = True
        End Try
        Assert.AreEqual(True, arrojoException)
    End Sub
    <TestMethod()> Public Sub GestionPacientesIngresarSexoIncorrecto()

        Dim paciente As New Paciente("66666666", "123456789", "Mauro", "Sosa", "Cerrudo", "Ma", "092468741", "Maria Orticochea", "Hector Vigil", "8465", "2003-01-06", "testmail@gmail.com")
        Dim arrojoException As Boolean = False
        Try
            logicaUsuarios.IngresarPaciente(paciente)
        Catch ex As Exception
            arrojoException = True
        End Try
        Assert.AreEqual(True, arrojoException)
    End Sub
    <TestMethod()> Public Sub GestionPacientesIngresarMailRepetido()

        Dim paciente As New Paciente("66666666", "123456789", "Mauro", "Sosa", "Cerrudo", "Masculino", "092468741", "Maria Orticochea", "Hector Vigil", "8465", "2003-01-06", "pablo281002@gmail.com")
        Dim arrojoException As Boolean = False
        Try
            logicaUsuarios.IngresarPaciente(paciente)
        Catch ex As Exception
            arrojoException = True
        End Try
        Assert.AreEqual(True, arrojoException)
    End Sub
    <TestMethod()> Public Sub GestionPacientesIngresarCedulaRepetida()
        Dim paciente As New Paciente("57200277", "123456789", "Mauro", "Sosa", "Cerrudo", "Masculino", "092468741", "Maria Orticochea", "Hector Vigil", "8465", "2003-01-06", "testmail@gmail.com")
        Dim arrojoException As Boolean = False
        Try
            logicaUsuarios.IngresarPaciente(paciente)
        Catch ex As Exception
            arrojoException = True
        End Try
        Assert.AreEqual(True, arrojoException)
    End Sub
    <TestMethod()> Public Sub GestionPacientesIngresarNombreConNumeros()

        Dim paciente As New Paciente("66666666", "123456789", "Maur0", "Sosa", "Cerrudo", "Masculino", "092468741", "Maria Orticochea", "Hector Vigil", "8465", "2003-01-06", "testmail@gmail.com")
        Dim arrojoException As Boolean = False
        Try
            logicaUsuarios.IngresarPaciente(paciente)
        Catch ex As Exception
            arrojoException = True
        End Try
        Assert.AreEqual(True, arrojoException)
    End Sub
    <TestMethod()> Public Sub GestionPacientesIngresarPrimerApellidoConNumeros()

        Dim paciente As New Paciente("666646666", "123456789", "Mauro", "S0sa", "Cerrudo", "Masculino", "092468741", "Maria Orticochea", "Hector Vigil", "8465", "2003-01-06", "testmail@gmail.com")
        Dim arrojoException As Boolean = False
        Try
            logicaUsuarios.IngresarPaciente(paciente)
        Catch ex As Exception
            arrojoException = True
        End Try
        Assert.AreEqual(True, arrojoException)
    End Sub
    <TestMethod()> Public Sub GestionPacientesIngresarSegundoApellidoConNumeros()

        Dim paciente As New Paciente("666646666", "123456789", "Mauro", "Sosa", "Cerrud0", "Masculino", "092468741", "Maria Orticochea", "Hector Vigil", "8465", "2003-01-06", "testmail@gmail.com")
        Dim arrojoException As Boolean = False
        Try
            logicaUsuarios.IngresarPaciente(paciente)
        Catch ex As Exception
            arrojoException = True
        End Try
        Assert.AreEqual(True, arrojoException)
    End Sub

    'Caso de exito
    <TestMethod()> Public Sub IngresarPaciente()
        If Not logicaUsuarios.VerificarUsuarioExiste("33333333") Then
            Dim paciente As New Paciente("33333333", "123456789", "Maria", "Gonzales", "Cardozo", "Femenino", "098452195", "Av. Rivera", "Tomas Tezanos", "2645", "1972-11-26", "mariagonzales72@gmail.com")
            Dim resultado As Boolean = False
            logicaUsuarios.IngresarPaciente(paciente)
            Dim pacientes As List(Of Paciente) = logicaUsuarios.ObtenerPacientes
            For Each pac As Paciente In pacientes
                If pac.Ci = paciente.Ci And pac.PrimerNombre = paciente.PrimerNombre And pac.Contraseña = paciente.Contraseña And pac.Mail = paciente.Mail Then
                    resultado = True
                End If
            Next
            Assert.AreEqual(True, resultado)
            If resultado = True Then
                logicaUsuarios.EliminarPaciente(paciente)
            End If
        End If
    End Sub

    'Modificar usuario
    'Casos de error
    <TestMethod()> Public Sub GestionPacientesModificarCedulaNoExistente()

        Dim paciente As New Paciente("66666666", "123456789", "Mauro", "Sosa", "Cerrudo", "Masculino", "092468741", "Maria Orticochea", "Hector Vigil", "8465", "2003-01-06", "testmail@gmail.com")
        Dim arrojoException As Boolean = False
        Try
            logicaUsuarios.ModificarPaciente(paciente)
        Catch ex As Exception
            arrojoException = True
        End Try
        Assert.AreEqual(True, arrojoException)
    End Sub
    <TestMethod()> Public Sub GestionPacientesModificarMailRepetido()

        Dim paciente As New Paciente("66758884", "123456789", "Mauro", "Sosa", "Cerrudo", "Masculino", "092468741", "Maria Orticochea", "Hector Vigil", "8465", "2003-01-06", "pablo281002@gmail.com")
        Dim arrojoException As Boolean = False
        Try
            logicaUsuarios.ModificarPaciente(paciente)
        Catch ex As Exception
            arrojoException = True
        End Try
        Assert.AreEqual(True, arrojoException)
    End Sub
    'Caso de éxito
    <TestMethod()> Public Sub ModificarPaciente()
        Dim resultado As Boolean = False
        If logicaUsuarios.VerificarUsuarioExiste("58789875") Then
            Dim paciente As New Paciente("58789875", "nuevaContraseña", "Paula", "Lopez", "Pereira", "Femenino", "099675412", "Cno. Ariel", "Av. Sayago", "548", "1977-03-24", "PauLopezPereira@gmail.com")
            logicaUsuarios.ModificarPaciente(paciente)
            Dim pacientes As List(Of Paciente) = logicaUsuarios.ObtenerPacientes
            For Each pac As Paciente In pacientes
                If pac.Ci = paciente.Ci And pac.Contraseña = paciente.Contraseña Then
                    resultado = True
                End If
            Next
        End If
        Assert.AreEqual(True, resultado)
        If resultado = True Then
            Dim restaurarPaciente As New Paciente("58789875", "58789875", "Paula", "Lopez", "Pereira", "Femenino", "099675412", "Cno. Ariel", "Av. Sayago", "548", "1977-03-24", "PauLopezPereira@gmail.com")
            logicaUsuarios.ModificarPaciente(restaurarPaciente)
        End If
    End Sub

    'Eliminar usuario
    'Casos de error
    <TestMethod()> Public Sub GestionPacientesEliminarCedulaNoExistente()

        Dim paciente As New Paciente("66666666", "123456789", "Mauro", "Sosa", "Cerrudo", "Masculino", "092468741", "Maria Orticochea", "Hector Vigil", "8465", "2003-01-06", "testmail@gmail.com")
        Dim arrojoException As Boolean = False
        Try
            logicaUsuarios.EliminarPaciente(paciente)
        Catch ex As Exception
            arrojoException = True
        End Try
        Assert.AreEqual(True, arrojoException)
    End Sub
    <TestMethod()> Public Sub GestionPacientesEliminarCedulaVacia()

        Dim paciente As New Paciente("", "123456789", "Mauro", "Sosa", "Cerrudo", "Masculino", "092468741", "Maria Orticochea", "Hector Vigil", "8465", "2003-01-06", "testmail@gmail.com")
        Dim arrojoException As Boolean = False
        Try
            logicaUsuarios.EliminarPaciente(paciente)
        Catch ex As Exception
            arrojoException = True
        End Try
        Assert.AreEqual(True, arrojoException)
    End Sub
    <TestMethod()> Public Sub GestionPacientesEliminarCedulaNothing()

        Dim paciente As New Paciente(Nothing, "123456789", "Mauro", "Sosa", "Cerrudo", "Masculino", "092468741", "Maria Orticochea", "Hector Vigil", "8465", "2003-01-06", "testmail@gmail.com")
        Dim arrojoException As Boolean = False
        Try
            logicaUsuarios.EliminarPaciente(paciente)
        Catch ex As Exception
            arrojoException = True
        End Try
        Assert.AreEqual(True, arrojoException)
    End Sub
    'Caso de éxito
    <TestMethod()> Public Sub EliminarPaciente()
        Dim resultado As Boolean = False
        If logicaUsuarios.VerificarUsuarioExiste("58789875") Then
            Dim paciente As New Paciente("58789875", "58789875", "Paula", "Lopez", "Pereira", "Femenino", "099675412", "Cno. Ariel", "Av. Sayago", "548", "1977-03-24", "PauLopezPereira@gmail.com")
            logicaUsuarios.EliminarPaciente(Paciente)
            Dim pacientes As List(Of Paciente) = logicaUsuarios.ObtenerPacientes
            If Not logicaUsuarios.VerificarUsuarioExiste(paciente.Ci) Then
                resultado = True
            End If
        End If
            Assert.AreEqual(True, resultado)
        If resultado = True Then
            Dim restaurarPaciente As New Paciente("58789875", "58789875", "Paula", "Lopez", "Pereira", "Femenino", "099675412", "Cno. Ariel", "Av. Sayago", "548", "1977-03-24", "PauLopezPereira@gmail.com")
            logicaUsuarios.IngresarPaciente(restaurarPaciente)
        End If
    End Sub
End Class