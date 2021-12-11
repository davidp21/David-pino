<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormE6
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
        Me.txtactual = New System.Windows.Forms.DateTimePicker()
        Me.labhecha = New System.Windows.Forms.Label()
        Me.txtaño = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtedad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtactual
        '
        Me.txtactual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtactual.Location = New System.Drawing.Point(84, 86)
        Me.txtactual.Name = "txtactual"
        Me.txtactual.Size = New System.Drawing.Size(119, 20)
        Me.txtactual.TabIndex = 15
        '
        'labhecha
        '
        Me.labhecha.AutoSize = True
        Me.labhecha.Location = New System.Drawing.Point(12, 64)
        Me.labhecha.Name = "labhecha"
        Me.labhecha.Size = New System.Drawing.Size(66, 13)
        Me.labhecha.TabIndex = 14
        Me.labhecha.Text = "fecha actual"
        '
        'txtaño
        '
        Me.txtaño.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtaño.Location = New System.Drawing.Point(84, 39)
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(119, 20)
        Me.txtaño.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(128, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "calcular "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtedad
        '
        Me.txtedad.AutoSize = True
        Me.txtedad.Location = New System.Drawing.Point(12, 119)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(60, 13)
        Me.txtedad.TabIndex = 10
        Me.txtedad.Text = "tu edad es:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "fecha de nacimiento "
        '
        'FormE6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtactual)
        Me.Controls.Add(Me.labhecha)
        Me.Controls.Add(Me.txtaño)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtedad)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormE6"
        Me.Text = "FormE6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtactual As System.Windows.Forms.DateTimePicker
    Friend WithEvents labhecha As System.Windows.Forms.Label
    Friend WithEvents txtaño As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtedad As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
