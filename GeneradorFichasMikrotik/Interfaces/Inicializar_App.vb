Public Class Inicializar_App
    Private Sub Inicializar_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim value As String
        'value = InputBox("Security Check", " Enter password", "*")

        'If value = "55555" Then
        'MSG_("Generador de Fichas v2.1.2")
        Inicializar()
        'Else
        'MSG_("Acceso Denegado!", 2)
        'End If

        Close()
    End Sub
End Class