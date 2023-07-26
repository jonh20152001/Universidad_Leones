<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clasesofertadas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(clasesofertadas))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbid = New System.Windows.Forms.TextBox()
        Me.tbguardar = New System.Windows.Forms.Button()
        Me.btcancelar = New System.Windows.Forms.Button()
        Me.btsalir = New System.Windows.Forms.Button()
        Me.tbca = New System.Windows.Forms.Label()
        Me.tbcarrera = New System.Windows.Forms.TextBox()
        Me.tbclase = New System.Windows.Forms.Label()
        Me.tbclases = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbtelefono = New System.Windows.Forms.TextBox()
        Me.btmenu = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbtiempo = New System.Windows.Forms.TextBox()
        Me.dataclases = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataclases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Universidad_Leones.My.Resources.Resources.lion_leao_logo_47267D166B_seeklogo_com
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(234, 241)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Codigo Carrera"
        '
        'tbid
        '
        Me.tbid.Location = New System.Drawing.Point(111, 38)
        Me.tbid.Name = "tbid"
        Me.tbid.Size = New System.Drawing.Size(100, 20)
        Me.tbid.TabIndex = 13
        Me.tbid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbguardar
        '
        Me.tbguardar.Location = New System.Drawing.Point(54, 343)
        Me.tbguardar.Name = "tbguardar"
        Me.tbguardar.Size = New System.Drawing.Size(75, 23)
        Me.tbguardar.TabIndex = 14
        Me.tbguardar.Text = "Guardar"
        Me.tbguardar.UseVisualStyleBackColor = True
        '
        'btcancelar
        '
        Me.btcancelar.Location = New System.Drawing.Point(190, 343)
        Me.btcancelar.Name = "btcancelar"
        Me.btcancelar.Size = New System.Drawing.Size(75, 23)
        Me.btcancelar.TabIndex = 14
        Me.btcancelar.Text = "Cancelar"
        Me.btcancelar.UseVisualStyleBackColor = True
        '
        'btsalir
        '
        Me.btsalir.Location = New System.Drawing.Point(507, 343)
        Me.btsalir.Name = "btsalir"
        Me.btsalir.Size = New System.Drawing.Size(75, 23)
        Me.btsalir.TabIndex = 14
        Me.btsalir.Text = "Salir"
        Me.btsalir.UseVisualStyleBackColor = True
        '
        'tbca
        '
        Me.tbca.AutoSize = True
        Me.tbca.BackColor = System.Drawing.Color.Transparent
        Me.tbca.Location = New System.Drawing.Point(12, 83)
        Me.tbca.Name = "tbca"
        Me.tbca.Size = New System.Drawing.Size(49, 13)
        Me.tbca.TabIndex = 12
        Me.tbca.Text = "Carrera"
        '
        'tbcarrera
        '
        Me.tbcarrera.Location = New System.Drawing.Point(111, 76)
        Me.tbcarrera.Name = "tbcarrera"
        Me.tbcarrera.Size = New System.Drawing.Size(100, 20)
        Me.tbcarrera.TabIndex = 13
        Me.tbcarrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbclase
        '
        Me.tbclase.AutoSize = True
        Me.tbclase.BackColor = System.Drawing.Color.Transparent
        Me.tbclase.Location = New System.Drawing.Point(12, 116)
        Me.tbclase.Name = "tbclase"
        Me.tbclase.Size = New System.Drawing.Size(79, 13)
        Me.tbclase.TabIndex = 12
        Me.tbclase.Text = "Total Clases"
        '
        'tbclases
        '
        Me.tbclases.Location = New System.Drawing.Point(111, 113)
        Me.tbclases.Name = "tbclases"
        Me.tbclases.Size = New System.Drawing.Size(100, 20)
        Me.tbclases.TabIndex = 13
        Me.tbclases.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Telefono E.C"
        '
        'tbtelefono
        '
        Me.tbtelefono.Location = New System.Drawing.Point(111, 141)
        Me.tbtelefono.Name = "tbtelefono"
        Me.tbtelefono.Size = New System.Drawing.Size(100, 20)
        Me.tbtelefono.TabIndex = 13
        Me.tbtelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btmenu
        '
        Me.btmenu.Location = New System.Drawing.Point(343, 343)
        Me.btmenu.Name = "btmenu"
        Me.btmenu.Size = New System.Drawing.Size(75, 23)
        Me.btmenu.TabIndex = 14
        Me.btmenu.Text = "Menu"
        Me.btmenu.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tiempo Estudio"
        '
        'tbtiempo
        '
        Me.tbtiempo.Location = New System.Drawing.Point(111, 171)
        Me.tbtiempo.Name = "tbtiempo"
        Me.tbtiempo.Size = New System.Drawing.Size(100, 20)
        Me.tbtiempo.TabIndex = 13
        Me.tbtiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dataclases
        '
        Me.dataclases.AllowUserToAddRows = False
        Me.dataclases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataclases.Location = New System.Drawing.Point(255, 31)
        Me.dataclases.Name = "dataclases"
        Me.dataclases.ReadOnly = True
        Me.dataclases.Size = New System.Drawing.Size(355, 160)
        Me.dataclases.TabIndex = 15
        '
        'clasesofertadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Universidad_Leones.My.Resources.Resources.dd7650a2631b706e7fe577d451e8e212
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(635, 393)
        Me.Controls.Add(Me.dataclases)
        Me.Controls.Add(Me.btsalir)
        Me.Controls.Add(Me.btmenu)
        Me.Controls.Add(Me.btcancelar)
        Me.Controls.Add(Me.tbguardar)
        Me.Controls.Add(Me.tbtiempo)
        Me.Controls.Add(Me.tbtelefono)
        Me.Controls.Add(Me.tbclases)
        Me.Controls.Add(Me.tbcarrera)
        Me.Controls.Add(Me.tbid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbclase)
        Me.Controls.Add(Me.tbca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "clasesofertadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clases Ofertadas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataclases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbid As TextBox
    Friend WithEvents tbguardar As Button
    Friend WithEvents btcancelar As Button
    Friend WithEvents btsalir As Button
    Friend WithEvents tbca As Label
    Friend WithEvents tbcarrera As TextBox
    Friend WithEvents tbclase As Label
    Friend WithEvents tbclases As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbtelefono As TextBox
    Friend WithEvents btmenu As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbtiempo As TextBox
    Friend WithEvents dataclases As DataGridView
End Class
