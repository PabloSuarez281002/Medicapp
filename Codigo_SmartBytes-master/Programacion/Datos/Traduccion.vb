Public Class Traduccion
    Public Shared Idioma As String
    Public Shared Function Traducir(clave As String, mIdioma As String)
        Idioma = mIdioma
        Dim traduccion = Nothing
        If mIdioma = "ES" Then
            traduccion = My.Resources.Espanol.ResourceManager.GetString(clave)
        ElseIf mIdioma = "EN" Then
            traduccion = My.Resources.Ingles.ResourceManager.GetString(clave)
        End If
        If traduccion = Nothing Then
            traduccion = clave
        End If
        Return traduccion
    End Function
End Class
