<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.btcancelar = New System.Windows.Forms.Button()
        Me.btingresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbcontrasena = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbusu = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btcancelar
        '
        Me.btcancelar.BackColor = System.Drawing.Color.Transparent
        Me.btcancelar.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.btcancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btcancelar.Location = New System.Drawing.Point(191, 279)
        Me.btcancelar.Name = "btcancelar"
        Me.btcancelar.Size = New System.Drawing.Size(75, 23)
        Me.btcancelar.TabIndex = 11
        Me.btcancelar.Text = "Cancelar"
        Me.btcancelar.UseVisualStyleBackColor = False
        '
        'btingresar
        '
        Me.btingresar.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.btingresar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btingresar.Location = New System.Drawing.Point(39, 279)
        Me.btingresar.Name = "btingresar"
        Me.btingresar.Size = New System.Drawing.Size(75, 23)
        Me.btingresar.TabIndex = 12
        Me.btingresar.Text = "Ingresar"
        Me.btingresar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Universidad_Leones.My.Resources.Resources.lion_leao_logo_47267D166B_seeklogo_com
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(88, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(105, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña"
        '
        'tbcontrasena
        '
        Me.tbcontrasena.Location = New System.Drawing.Point(101, 228)
        Me.tbcontrasena.Name = "tbcontrasena"
        Me.tbcontrasena.Size = New System.Drawing.Size(85, 20)
        Me.tbcontrasena.TabIndex = 8
        Me.tbcontrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbcontrasena.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(116, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuario"
        '
        'tbusu
        '
        Me.tbusu.Location = New System.Drawing.Point(101, 172)
        Me.tbusu.Name = "tbusu"
        Me.tbusu.Size = New System.Drawing.Size(85, 20)
        Me.tbusu.TabIndex = 6
        Me.tbusu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Universidad_Leones.My.Resources.Resources.dd7650a2631b706e7fe577d451e8e212
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(304, 332)
        Me.Controls.Add(Me.btcancelar)
        Me.Controls.Add(Me.btingresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbcontrasena)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbusu)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btcancelar As Button
    Friend WithEvents btingresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbcontrasena As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbusu As TextBox
End Class
