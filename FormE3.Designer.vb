<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormE3
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
        Me.labdetalle = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkcheked = New System.Windows.Forms.CheckBox()
        Me.txtpass4 = New System.Windows.Forms.TextBox()
        Me.txtuser1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmensaje = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labdetalle
        '
        Me.labdetalle.AutoSize = True
        Me.labdetalle.Location = New System.Drawing.Point(13, 172)
        Me.labdetalle.Name = "labdetalle"
        Me.labdetalle.Size = New System.Drawing.Size(204, 13)
        Me.labdetalle.TabIndex = 30
        Me.labdetalle.Text = "alguno de los campos se encuentra vacio"
        Me.labdetalle.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(188, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkcheked
        '
        Me.chkcheked.AutoSize = True
        Me.chkcheked.Location = New System.Drawing.Point(202, 95)
        Me.chkcheked.Name = "chkcheked"
        Me.chkcheked.Size = New System.Drawing.Size(15, 14)
        Me.chkcheked.TabIndex = 27
        Me.chkcheked.UseVisualStyleBackColor = True
        '
        'txtpass4
        '
        Me.txtpass4.Location = New System.Drawing.Point(10, 95)
        Me.txtpass4.Name = "txtpass4"
        Me.txtpass4.Size = New System.Drawing.Size(166, 20)
        Me.txtpass4.TabIndex = 25
        '
        'txtuser1
        '
        Me.txtuser1.Location = New System.Drawing.Point(16, 30)
        Me.txtuser1.Name = "txtuser1"
        Me.txtuser1.Size = New System.Drawing.Size(166, 20)
        Me.txtuser1.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "CONTRASEÑA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "USUARIO"
        '
        'txtmensaje
        '
        Me.txtmensaje.Location = New System.Drawing.Point(107, 136)
        Me.txtmensaje.Name = "txtmensaje"
        Me.txtmensaje.Size = New System.Drawing.Size(75, 23)
        Me.txtmensaje.TabIndex = 21
        Me.txtmensaje.Text = "login"
        Me.txtmensaje.UseVisualStyleBackColor = True
        '
        'FormE3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.labdetalle)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkcheked)
        Me.Controls.Add(Me.txtpass4)
        Me.Controls.Add(Me.txtuser1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmensaje)
        Me.Name = "FormE3"
        Me.Text = "FormE3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labdetalle As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkcheked As System.Windows.Forms.CheckBox
    Friend WithEvents txtpass4 As System.Windows.Forms.TextBox
    Friend WithEvents txtuser1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmensaje As System.Windows.Forms.Button
End Class
