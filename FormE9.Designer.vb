<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormE9
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Inverso = New System.Windows.Forms.TextBox()
        Me.Valor = New System.Windows.Forms.TextBox()
        Me.Boton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Numero inverso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ingrese un numero"
        '
        'Inverso
        '
        Me.Inverso.Location = New System.Drawing.Point(15, 117)
        Me.Inverso.Name = "Inverso"
        Me.Inverso.ReadOnly = True
        Me.Inverso.Size = New System.Drawing.Size(100, 20)
        Me.Inverso.TabIndex = 7
        '
        'Valor
        '
        Me.Valor.Location = New System.Drawing.Point(15, 48)
        Me.Valor.Name = "Valor"
        Me.Valor.Size = New System.Drawing.Size(100, 20)
        Me.Valor.TabIndex = 6
        '
        'Boton
        '
        Me.Boton.Location = New System.Drawing.Point(18, 164)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(75, 23)
        Me.Boton.TabIndex = 5
        Me.Boton.Text = "Invertir"
        Me.Boton.UseVisualStyleBackColor = True
        '
        'FormE9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(141, 226)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Inverso)
        Me.Controls.Add(Me.Valor)
        Me.Controls.Add(Me.Boton)
        Me.Name = "FormE9"
        Me.Text = "FormE9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Inverso As System.Windows.Forms.TextBox
    Friend WithEvents Valor As System.Windows.Forms.TextBox
    Friend WithEvents Boton As System.Windows.Forms.Button
End Class
