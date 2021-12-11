<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormE8
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cedula = New System.Windows.Forms.TextBox()
        Me.Boton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ingrese Cedula:"
        '
        'Cedula
        '
        Me.Cedula.Location = New System.Drawing.Point(33, 56)
        Me.Cedula.MaxLength = 1000000000
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(100, 20)
        Me.Cedula.TabIndex = 4
        '
        'Boton
        '
        Me.Boton.Location = New System.Drawing.Point(46, 104)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(75, 23)
        Me.Boton.TabIndex = 3
        Me.Boton.Text = "aceptar"
        Me.Boton.UseVisualStyleBackColor = True
        '
        'FormE8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(165, 150)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cedula)
        Me.Controls.Add(Me.Boton)
        Me.Name = "FormE8"
        Me.Text = "FormE8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cedula As System.Windows.Forms.TextBox
    Friend WithEvents Boton As System.Windows.Forms.Button
End Class
