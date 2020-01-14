Public Class GUI_Activacion
    Private Sub btnGenerarSolicitud_Click(sender As Object, e As EventArgs) Handles btnGenerarSolicitud.Click
        GUI_Activacion_Generar_Solicitud.Show()
        Close()
    End Sub

    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        GUI_Activacion_Activar.Show()
        Close()
    End Sub
End Class