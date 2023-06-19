Public Class Solicitud
    Public Property CodigoDiagnostico As Integer
    Public Property CiPaciente As String
    Public Property NombrePatologia As String
    Public Property Gravedad As Integer
    Public Sub New(mCodigoDiagnostico As Integer, mCiPaciente As String, mNombrePatologia As String, mGravedad As Integer)
        CodigoDiagnostico = mCodigoDiagnostico
        CiPaciente = mCiPaciente
        NombrePatologia = mNombrePatologia
        Gravedad = mGravedad
    End Sub
End Class
