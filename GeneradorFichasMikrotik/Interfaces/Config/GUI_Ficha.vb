Imports System.IO

Public Class GUI_Ficha
    Private FichaFondoTemp As String = ""

    Private Sub GUI_Ficha_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim db As New DataBase_Ficha()
            FichaFondoTemp = db.Fondo
            txtTipoFicha.SelectedIndex = 0
            RefrescarFicha()
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GUIFicha")
            End If
        End Try
    End Sub

    Private Sub RefrescarFicha()
        Try
            Dim Ficha_ As Ficha

            'Dim db As New DataBase_Ficha()
            'FichaFondoTemp = db.Fondo
            'If Not Ficha_URL_Fondo = "img\fondo.jpg" Then
            'btnDefault.Enabled = True
            'End If

            If FichaFondoTemp.Length > 1 Then
                Ficha_ = New Ficha(Empresa_Nombre, Mikrotik_Dominio, FichaFondoTemp)
            Else
                Ficha_ = New Ficha(Empresa_Nombre, Mikrotik_Dominio, Ficha_URL_Fondo)
            End If

            If txtTipoFicha.SelectedIndex = 0 Then
                picFicha.Image = Ficha_.Generar("12345")
            Else
                picFicha.Image = Ficha_.Generar("12345", "11111")
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GUI_Ficha")
            End If
        End Try
    End Sub

    Private Sub txtTipoFicha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtTipoFicha.SelectedIndexChanged
        RefrescarFicha()
    End Sub

    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        Dim DB As New DataBase_Ficha()
        Dim NewFondo As String

        'If FichaFondoTemp = "img\fondo.jpg" Then
        'NewFondo = "img\fondo.jpg"
        'Else
        'On Error Resume Next
        'NewFondo = "img\FondoFicha" & Path.GetExtension(FichaFondoTemp)
        'End If

        'GUI_Cargar_Ficha(True)

        'On Error Resume Next
        'File.Delete("img\FondoFicha.jpg")
        'On Error Resume Next
        'File.Delete("img\FondoFicha.png")
        'On Error Resume Next
        'File.Delete("img\FondoFicha.gif")
        'On Error Resume Next
        'File.Delete("img\FondoFicha.bmp")

        'On Error Resume Next
        'File.Copy(FichaFondoTemp, NewFondo, True)

        If FichaFondoTemp = "" Then
            FichaFondoTemp = "img\fondo.jpg"
        End If
        DB.Fondo = FichaFondoTemp
        FichaFondoTemp = ""

        MSG_("Cambios guardados correctamente!")

        On Error Resume Next
        GUI_Cargar_Ficha()
    End Sub

    Private Sub btnDialogo_Click(sender As Object, e As EventArgs) Handles btnDialogo.Click
        Try
            If Dialogo_Abrir.ShowDialog() <> DialogResult.Cancel Then
                FichaFondoTemp = Dialogo_Abrir.FileName
                RefrescarFicha()

                'btnDefault.Enabled = True
                'btnGuardarCambios.Enabled = True
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GUI_Ficha")
            End If
        End Try
    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        Try
            'Dim DB As New DataBase_Ficha

            FichaFondoTemp = "img\fondo.jpg"
            'DB.Fondo = FichaFondoTemp
            RefrescarFicha()

            'btnDefault.Enabled = False

            'If DB.Fondo = "img\fondo.jpg" Then
            'btnGuardarCambios.Enabled = False
            'Else
            'btnGuardarCambios.Enabled = True
            'End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GUI_Ficha")
            End If
        End Try
    End Sub

    Private Sub btnTitulo_Click(sender As Object, e As EventArgs) Handles btnTitulo.Click
        Try
            Dim Color As Color
            If Dialogo_Color.ShowDialog <> DialogResult.Cancel Then
                Color = Dialogo_Color.Color
                lbTitulo.ForeColor = Color
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GUI_Ficha")
            End If
        End Try
    End Sub

    Private Sub btnEtiquetas_Click(sender As Object, e As EventArgs) Handles btnEtiquetas.Click
        On Error Resume Next
        Dialogo_Color.ShowDialog()
    End Sub

    'Private Sub btnTitulo_Fuente_Click(sender As Object, e As EventArgs) Handles btnTitulo_Fuente.Click
    'Dim Fuente As Font
    'If Dialogo_Fuente.ShowDialog <> DialogResult.Cancel Then
    ' Fuente = Dialogo_Fuente.Font
    ' lbTitulo.Font = Fuente
    'End If
    'End Sub
End Class