<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pruebas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pruebas))
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.imprimirDoc = New System.Drawing.Printing.PrintDocument()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPuerto = New System.Windows.Forms.TextBox()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.txtComando = New System.Windows.Forms.TextBox()
        Me.btnFin = New System.Windows.Forms.Button()
        Me.Lista = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPrueba = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'imprimirDoc
        '
        Me.imprimirDoc.DocumentName = "codigo_qr"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(110, 25)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(144, 26)
        Me.txtIP.TabIndex = 0
        Me.txtIP.Text = "192.168.5.1"
        Me.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(110, 57)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(144, 26)
        Me.txtUsuario.TabIndex = 2
        Me.txtUsuario.Text = "admin"
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(110, 89)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9580)
        Me.txtPassword.Size = New System.Drawing.Size(144, 26)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.Text = "deejay"
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Puerto"
        '
        'txtPuerto
        '
        Me.txtPuerto.Location = New System.Drawing.Point(110, 121)
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(144, 26)
        Me.txtPuerto.TabIndex = 6
        Me.txtPuerto.Text = "8728"
        Me.txtPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(35, 163)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(103, 31)
        Me.btnConectar.TabIndex = 8
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(589, 22)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(67, 30)
        Me.btnEnviar.TabIndex = 9
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'txtComando
        '
        Me.txtComando.Location = New System.Drawing.Point(279, 25)
        Me.txtComando.Name = "txtComando"
        Me.txtComando.Size = New System.Drawing.Size(304, 26)
        Me.txtComando.TabIndex = 11
        Me.txtComando.Text = "/ip/hotspot/user/profile/print"
        '
        'btnFin
        '
        Me.btnFin.Location = New System.Drawing.Point(662, 22)
        Me.btnFin.Name = "btnFin"
        Me.btnFin.Size = New System.Drawing.Size(67, 30)
        Me.btnFin.TabIndex = 12
        Me.btnFin.Text = "Fin"
        Me.btnFin.UseVisualStyleBackColor = True
        '
        'Lista
        '
        Me.Lista.Location = New System.Drawing.Point(279, 73)
        Me.Lista.Multiline = True
        Me.Lista.Name = "Lista"
        Me.Lista.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Lista.Size = New System.Drawing.Size(446, 277)
        Me.Lista.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 43)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Generar usuario"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'txtPrueba
        '
        Me.txtPrueba.Location = New System.Drawing.Point(12, 377)
        Me.txtPrueba.Multiline = True
        Me.txtPrueba.Name = "txtPrueba"
        Me.txtPrueba.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPrueba.Size = New System.Drawing.Size(710, 293)
        Me.txtPrueba.TabIndex = 15
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(166, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 30)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(195, 315)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 35)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Limpiar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Pruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 364)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtPrueba)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lista)
        Me.Controls.Add(Me.btnFin)
        Me.Controls.Add(Me.txtComando)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPuerto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIP)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Pruebas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pruebas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents imprimirDoc As Printing.PrintDocument
    Friend WithEvents txtIP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPuerto As TextBox
    Friend WithEvents btnConectar As Button
    Friend WithEvents btnEnviar As Button
    Friend WithEvents txtComando As TextBox
    Friend WithEvents btnFin As Button
    Friend WithEvents Lista As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPrueba As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
