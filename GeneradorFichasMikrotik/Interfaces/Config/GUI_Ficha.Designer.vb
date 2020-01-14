<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GUI_Ficha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI_Ficha))
        Me.Panel_Body = New System.Windows.Forms.Panel()
        Me.btnTitulo_Fuente = New System.Windows.Forms.Button()
        Me.lbEtiqueta = New System.Windows.Forms.Label()
        Me.btnEtiquetas = New System.Windows.Forms.Button()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.btnTitulo = New System.Windows.Forms.Button()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.txtTipoFicha = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDialogo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.picFicha = New System.Windows.Forms.PictureBox()
        Me.Dialogo_Abrir = New System.Windows.Forms.OpenFileDialog()
        Me.Dialogo_Color = New System.Windows.Forms.ColorDialog()
        Me.Panel_Header = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dialogo_Fuente = New System.Windows.Forms.FontDialog()
        Me.Panel_Body.SuspendLayout()
        CType(Me.picFicha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Header.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Body
        '
        Me.Panel_Body.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel_Body.Controls.Add(Me.btnTitulo_Fuente)
        Me.Panel_Body.Controls.Add(Me.lbEtiqueta)
        Me.Panel_Body.Controls.Add(Me.btnEtiquetas)
        Me.Panel_Body.Controls.Add(Me.lbTitulo)
        Me.Panel_Body.Controls.Add(Me.btnTitulo)
        Me.Panel_Body.Controls.Add(Me.btnDefault)
        Me.Panel_Body.Controls.Add(Me.txtTipoFicha)
        Me.Panel_Body.Controls.Add(Me.Label3)
        Me.Panel_Body.Controls.Add(Me.btnDialogo)
        Me.Panel_Body.Controls.Add(Me.Label2)
        Me.Panel_Body.Controls.Add(Me.btnGuardarCambios)
        Me.Panel_Body.Controls.Add(Me.picFicha)
        Me.Panel_Body.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Body.Location = New System.Drawing.Point(0, 61)
        Me.Panel_Body.Name = "Panel_Body"
        Me.Panel_Body.Size = New System.Drawing.Size(642, 401)
        Me.Panel_Body.TabIndex = 1
        '
        'btnTitulo_Fuente
        '
        Me.btnTitulo_Fuente.Location = New System.Drawing.Point(454, 242)
        Me.btnTitulo_Fuente.Name = "btnTitulo_Fuente"
        Me.btnTitulo_Fuente.Size = New System.Drawing.Size(34, 38)
        Me.btnTitulo_Fuente.TabIndex = 11
        Me.btnTitulo_Fuente.Text = "Button1"
        Me.btnTitulo_Fuente.UseVisualStyleBackColor = True
        Me.btnTitulo_Fuente.Visible = False
        '
        'lbEtiqueta
        '
        Me.lbEtiqueta.BackColor = System.Drawing.Color.White
        Me.lbEtiqueta.Location = New System.Drawing.Point(371, 168)
        Me.lbEtiqueta.Name = "lbEtiqueta"
        Me.lbEtiqueta.Size = New System.Drawing.Size(100, 40)
        Me.lbEtiqueta.TabIndex = 10
        Me.lbEtiqueta.Text = "Etiquetas:"
        Me.lbEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbEtiqueta.Visible = False
        '
        'btnEtiquetas
        '
        Me.btnEtiquetas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEtiquetas.BackgroundImage = Global.GeneradorFichasMikrotik.My.Resources.Resources.colores
        Me.btnEtiquetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEtiquetas.Location = New System.Drawing.Point(480, 168)
        Me.btnEtiquetas.Name = "btnEtiquetas"
        Me.btnEtiquetas.Size = New System.Drawing.Size(40, 40)
        Me.btnEtiquetas.TabIndex = 9
        Me.btnEtiquetas.UseVisualStyleBackColor = False
        Me.btnEtiquetas.Visible = False
        '
        'lbTitulo
        '
        Me.lbTitulo.BackColor = System.Drawing.Color.White
        Me.lbTitulo.Location = New System.Drawing.Point(371, 123)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(100, 40)
        Me.lbTitulo.TabIndex = 8
        Me.lbTitulo.Text = "Titulo:"
        Me.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbTitulo.Visible = False
        '
        'btnTitulo
        '
        Me.btnTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTitulo.BackgroundImage = Global.GeneradorFichasMikrotik.My.Resources.Resources.colores
        Me.btnTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTitulo.Location = New System.Drawing.Point(480, 123)
        Me.btnTitulo.Name = "btnTitulo"
        Me.btnTitulo.Size = New System.Drawing.Size(40, 40)
        Me.btnTitulo.TabIndex = 7
        Me.btnTitulo.UseVisualStyleBackColor = False
        Me.btnTitulo.Visible = False
        '
        'btnDefault
        '
        Me.btnDefault.BackColor = System.Drawing.Color.LightCoral
        Me.btnDefault.Location = New System.Drawing.Point(25, 140)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(189, 45)
        Me.btnDefault.TabIndex = 6
        Me.btnDefault.Text = "Default"
        Me.btnDefault.UseVisualStyleBackColor = False
        '
        'txtTipoFicha
        '
        Me.txtTipoFicha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTipoFicha.FormattingEnabled = True
        Me.txtTipoFicha.Items.AddRange(New Object() {"PIN", "Normal"})
        Me.txtTipoFicha.Location = New System.Drawing.Point(26, 104)
        Me.txtTipoFicha.Name = "txtTipoFicha"
        Me.txtTipoFicha.Size = New System.Drawing.Size(186, 30)
        Me.txtTipoFicha.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.GhostWhite
        Me.Label3.Location = New System.Drawing.Point(26, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 40)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Imagen: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDialogo
        '
        Me.btnDialogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDialogo.BackgroundImage = Global.GeneradorFichasMikrotik.My.Resources.Resources.lupa
        Me.btnDialogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDialogo.Location = New System.Drawing.Point(174, 43)
        Me.btnDialogo.Name = "btnDialogo"
        Me.btnDialogo.Size = New System.Drawing.Size(40, 40)
        Me.btnDialogo.TabIndex = 3
        Me.btnDialogo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(234, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(383, 39)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pre visualización (255x200px)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.BackColor = System.Drawing.Color.LightGreen
        Me.btnGuardarCambios.Location = New System.Drawing.Point(25, 337)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(189, 45)
        Me.btnGuardarCambios.TabIndex = 1
        Me.btnGuardarCambios.Text = "Guardar cambios"
        Me.btnGuardarCambios.UseVisualStyleBackColor = False
        '
        'picFicha
        '
        Me.picFicha.BackColor = System.Drawing.Color.White
        Me.picFicha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFicha.Location = New System.Drawing.Point(234, 82)
        Me.picFicha.Name = "picFicha"
        Me.picFicha.Size = New System.Drawing.Size(383, 300)
        Me.picFicha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFicha.TabIndex = 0
        Me.picFicha.TabStop = False
        '
        'Dialogo_Abrir
        '
        Me.Dialogo_Abrir.FileName = "Buscar"
        Me.Dialogo_Abrir.Filter = "Imágenes: |*.jpg;*.bmp;*.png"
        Me.Dialogo_Abrir.Title = "Buscar Imágen"
        '
        'Dialogo_Color
        '
        Me.Dialogo_Color.AnyColor = True
        Me.Dialogo_Color.FullOpen = True
        Me.Dialogo_Color.ShowHelp = True
        '
        'Panel_Header
        '
        Me.Panel_Header.BackgroundImage = Global.GeneradorFichasMikrotik.My.Resources.Resources.Textura
        Me.Panel_Header.Controls.Add(Me.Label1)
        Me.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Header.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Header.Name = "Panel_Header"
        Me.Panel_Header.Size = New System.Drawing.Size(642, 61)
        Me.Panel_Header.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(642, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Configuración de Ficha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GUI_Ficha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 462)
        Me.Controls.Add(Me.Panel_Body)
        Me.Controls.Add(Me.Panel_Header)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.Name = "GUI_Ficha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de Ficha"
        Me.Panel_Body.ResumeLayout(False)
        CType(Me.picFicha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Header.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Header As Panel
    Friend WithEvents Panel_Body As Panel
    Friend WithEvents picFicha As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardarCambios As Button
    Friend WithEvents btnDialogo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTipoFicha As ComboBox
    Friend WithEvents Dialogo_Abrir As OpenFileDialog
    Friend WithEvents btnDefault As Button
    Friend WithEvents Dialogo_Color As ColorDialog
    Friend WithEvents lbEtiqueta As Label
    Friend WithEvents btnEtiquetas As Button
    Friend WithEvents lbTitulo As Label
    Friend WithEvents btnTitulo As Button
    Friend WithEvents btnTitulo_Fuente As Button
    Friend WithEvents Dialogo_Fuente As FontDialog
End Class
