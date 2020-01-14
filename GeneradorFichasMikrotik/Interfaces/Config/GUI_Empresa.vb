Imports System.IO

Public Class GUI_Empresa
    Private EmpresaLogoTemp As String = ""

    Private Sub btnDialogo_Click(sender As Object, e As EventArgs) Handles btnDialogo.Click
        Try
            If Dialogo_Abrir.ShowDialog() <> DialogResult.Cancel Then
                EmpresaLogoTemp = Dialogo_Abrir.FileName
                RefrescarFondo()
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GUI_Empresa")
            End If
        End Try
    End Sub

    Private Sub RefrescarFondo()
        Try
            If EmpresaLogoTemp.Length > 1 Then
                picLogo.Image = Image.FromFile(EmpresaLogoTemp)
            Else
                picLogo.Image = Empresa_Logo
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GUI_Empresa")
            End If
        End Try
    End Sub

    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        Dim DB As New DataBase_Empresa
        Dim Fondo() As String
        Dim NewFondo As String

        If Not EmpresaLogoTemp = "" Then
            On Error Resume Next
            NewFondo = "img\logo_." & Path.GetExtension(EmpresaLogoTemp)
        Else
            NewFondo = "img\logo.png"
        End If

        On Error Resume Next
        Fondo = DB.Cargar
        If Not Fondo(2) = "img\logo.png" Then
            On Error Resume Next
            File.Delete(Fondo(2))
        End If

        If Not EmpresaLogoTemp = "" Then
            On Error Resume Next
            File.Copy(EmpresaLogoTemp, NewFondo, True)
        End If

        On Error Resume Next
        DB.Editar(txtEmpresa_Nombre.Text, NewFondo)

        MSG_("Cambios guardados correctamente!")

        On Error Resume Next
        GUI_Cargar_Empresa()
        On Error Resume Next
        GUI_Cargar_Ficha()
    End Sub

    Private Sub GUI_Empresa_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Informacion_Cargar()
        Try
            txtEmpresa_Nombre.Text = Empresa_Nombre
            RefrescarFondo()
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "GUI_Empresa")
            End If
        End Try
    End Sub
End Class