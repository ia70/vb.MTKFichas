﻿Imports ThoughtWorks.QRCode
Imports ThoughtWorks.QRCode.Codec
Public Class QRcode
    Private colorFondoQR As Integer = Color.FromArgb(255, 255, 255, 255).ToArgb
    Private colorQR As Integer = Color.FromArgb(255, 0, 0, 0).ToArgb

    Public Function GenerarQR(ByVal URL As String) As Bitmap

        Dim Imagen As New Bitmap(10, 10)
        Dim generarCodigoQR As QRCodeEncoder = New QRCodeEncoder

        Try
            generarCodigoQR.QRCodeEncodeMode =
            Codec.QRCodeEncoder.ENCODE_MODE.BYTE
            generarCodigoQR.QRCodeScale = 4

            generarCodigoQR.QRCodeErrorCorrect = Codec.QRCodeEncoder.ERROR_CORRECTION.M

            'La versión "0" calcula automáticamente el tamaño
            generarCodigoQR.QRCodeVersion = 0

            generarCodigoQR.QRCodeBackgroundColor = System.Drawing.Color.FromArgb(colorFondoQR)
            generarCodigoQR.QRCodeForegroundColor = System.Drawing.Color.FromArgb(colorQR)
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "QRcode -> GenerarQR-01")
            End If
        End Try
        Try
            Imagen = generarCodigoQR.Encode(URL, System.Text.Encoding.UTF8)
        Catch ex As Exception
            MSG_(ex.Message + "///// ///// ///// /////" + ex.StackTrace, 2, "QRcode -> GenerarQR-02")
        End Try
        Return Imagen
    End Function

End Class
