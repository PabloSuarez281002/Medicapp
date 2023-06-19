Public Class Patologia
    Public Property Codigo As Integer
    Public Property Nombre As String
    Public Property Especialista As String
    Public Property Gravedad As Integer
    Public Property Sintomas As List(Of Sintoma)
    Public Sub New(mCodigo As Integer, mNombre As String, mEspecialista As String, mGravedad As Integer)
        Codigo = mCodigo
        Nombre = mNombre
        Especialista = mEspecialista
        Gravedad = mGravedad
    End Sub
End Class
