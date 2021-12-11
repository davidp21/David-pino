<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormE15
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
        Me.Borrar = New System.Windows.Forms.Button()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Txtproducto = New System.Windows.Forms.TextBox()
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Borrar
        '
        Me.Borrar.Location = New System.Drawing.Point(209, 53)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(75, 23)
        Me.Borrar.TabIndex = 15
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(128, 53)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 14
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Txtproducto
        '
        Me.Txtproducto.Location = New System.Drawing.Point(5, 53)
        Me.Txtproducto.Name = "Txtproducto"
        Me.Txtproducto.Size = New System.Drawing.Size(100, 20)
        Me.Txtproducto.TabIndex = 13
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.Location = New System.Drawing.Point(2, 121)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(133, 13)
        Me.lblresultado.TabIndex = 12
        Me.lblresultado.Text = "El IVA del producto es de: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Ingrese el precio del producto"
        '
        'FormE15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 168)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Txtproducto)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormE15"
        Me.Text = "FormE15"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Borrar As System.Windows.Forms.Button
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Txtproducto As System.Windows.Forms.TextBox
    Friend WithEvents lblresultado As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
