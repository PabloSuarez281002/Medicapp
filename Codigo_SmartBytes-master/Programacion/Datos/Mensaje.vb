Public Class Mensaje
    Public Property Codigo As Integer
    Public Property Contenido As String
    Public Property Emisor As String
    Public Property Fecha As Date
    Public Property CodDiagnostico As Integer
    Public Sub New(mCodigo As Integer, mContenido As String, mEmisor As String, mFecha As Date, mCodDiagnostico As Integer)
        Codigo = mCodigo
        Contenido = mContenido
        Emisor = mEmisor
        Fecha = mFecha
        CodDiagnostico = mCodDiagnostico
    End Sub
End Class
