Imports System.Management
Module Mod_Activacion
    Public Activacion As New Activacion_XCORU

    Public Sub Inicializar()
        Try
            Activacion_Cargar()

            If Activacion.Inicializar Then
                GUI_Cargar_Todo()
                Inicio.Show()
            Else
                GUI_Activacion.Show()
            End If
        Catch ex As Exception
            If Config_MostrarError Then
                MSG_(ex.ToString + "///// ///// ///// /////" + ex.StackTrace, 2, "Mod_Activacion -> Inicializar")
            End If
            GUI_Activacion.Show()
        End Try
    End Sub

End Module
