Public Class Usuario
    Public Property Ci As String
    Public Property PrimerNombre As String
    Public Property PrimerApellido As String
    Public Property SegundoApellido As String
    Public Property Sexo As String
    Public Property Telefono As String
    Public Property Calle As String
    Public Property Esquina As String
    Public Property NumeroPuerta As String
    Public Property FechaNacimiento As Date
    Public Property Mail As String
    Public Sub New(mCi As String, mPrimerNombre As String, mPrimerApellido As String, mSegundoApellido As String, mSexo As String, mTelefono As String, mCalle As String, mEsquina As String, mNumeroPuerta As String, mFechaNacimiento As Date, mMail As String)
        Me.Ci = mCi
        Me.PrimerNombre = mPrimerNombre
        Me.PrimerApellido = mPrimerApellido
        Me.SegundoApellido = mSegundoApellido
        Me.Sexo = mSexo
        Me.Telefono = mTelefono
        Me.Calle = mCalle
        Me.Esquina = mEsquina
        Me.NumeroPuerta = mNumeroPuerta
        Me.FechaNacimiento = mFechaNacimiento
        Me.Mail = mMail
    End Sub
    Public Sub New(mCi As String, mPrimerNombre As String)
        Ci = mCi
        PrimerNombre = mPrimerNombre
    End Sub
End Class
