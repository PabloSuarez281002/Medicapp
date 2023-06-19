Public Class Diagnostico
    Public Property Codigo As Integer
    Public Property CodigoPatologiaPrimaria As Integer
    Public Property CodigoPatologiaFinal As Integer
    Public Property Estado As String
    Public Property FechaDiagnostico As Date
    Public Property CedulaPaciente As String
    Public Property CedulaMedicoQueAtiende As String
    Public Sub New(mCodigo As Integer, mCodigoPatologiaPrimaria As Integer, mCodigoPatologiaFinal As Integer, mEstado As String, mFechaDiagnostico As Date, mCedulaPaciente As String, mCedulaMedicoQueAtiende As String)
        Codigo = mCodigo
        CodigoPatologiaPrimaria = mCodigoPatologiaPrimaria
        CodigoPatologiaFinal = mCodigoPatologiaFinal
        Estado = mEstado
        FechaDiagnostico = mFechaDiagnostico
        CedulaPaciente = mCedulaPaciente
        CedulaMedicoQueAtiende = mCedulaMedicoQueAtiende
    End Sub
    Public Sub New(mCodigo As Integer)
        Codigo = mCodigo
    End Sub
    Public Sub New(mCodigo As Integer, mCodigoPatologiaPrimaria As Integer, mCodigoPatologiaFinal As Integer, mFechaDiagnostico As Date, mCedulaPaciente As String)
        Codigo = mCodigo
        CodigoPatologiaPrimaria = mCodigoPatologiaPrimaria
        CodigoPatologiaFinal = mCodigoPatologiaFinal
        FechaDiagnostico = mFechaDiagnostico
        CedulaPaciente = mCedulaPaciente
    End Sub
End Class
