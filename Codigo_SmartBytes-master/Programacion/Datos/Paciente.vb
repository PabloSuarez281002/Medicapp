Public Class Paciente
    Inherits Usuario
    Public Property Contraseña As String
    Public Sub New(mCi As String, mContraseña As String, mPrimerNombre As String, mPrimerApellido As String, mSegundoApellido As String, mSexo As String, mTelefono As String, mCalle As String, mEsquina As String, mNumeroPuerta As String, mFechaNacimiento As Date, mMail As String)
        MyBase.New(mCi, mPrimerNombre, mPrimerApellido, mSegundoApellido, mSexo, mTelefono, mCalle, mEsquina, mNumeroPuerta, mFechaNacimiento, mMail)
        Me.Contraseña = mContraseña
    End Sub
End Class