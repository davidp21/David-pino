<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormE4
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
        Me.lbmult2 = New System.Windows.Forms.Label()
        Me.lbmulta = New System.Windows.Forms.Label()
        Me.dtmulta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbdesc2 = New System.Windows.Forms.Label()
        Me.lbdescuento = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtentrada = New System.Windows.Forms.DateTimePicker()
        Me.dtsalida = New System.Windows.Forms.DateTimePicker()
        Me.btncalculo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbcosto = New System.Windows.Forms.Label()
        Me.lbcontrato = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbvehiculo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbmult2
        '
        Me.lbmult2.AutoSize = True
        Me.lbmult2.Location = New System.Drawing.Point(216, 196)
        Me.lbmult2.Name = "lbmult2"
        Me.lbmult2.Size = New System.Drawing.Size(91, 13)
        Me.lbmult2.TabIndex = 30
        Me.lbmult2.Text = "multa por retraso: "
        Me.lbmult2.Visible = False
        '
        'lbmulta
        '
        Me.lbmulta.AutoSize = True
        Me.lbmulta.Location = New System.Drawing.Point(216, 179)
        Me.lbmulta.Name = "lbmulta"
        Me.lbmulta.Size = New System.Drawing.Size(91, 13)
        Me.lbmulta.TabIndex = 29
        Me.lbmulta.Text = "multa por retraso: "
        Me.lbmulta.Visible = False
        '
        'dtmulta
        '
        Me.dtmulta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmulta.Location = New System.Drawing.Point(219, 145)
        Me.dtmulta.Name = "dtmulta"
        Me.dtmulta.Size = New System.Drawing.Size(119, 20)
        Me.dtmulta.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "informar retraso de entrega"
        '
        'lbdesc2
        '
        Me.lbdesc2.AutoSize = True
        Me.lbdesc2.Location = New System.Drawing.Point(28, 254)
        Me.lbdesc2.Name = "lbdesc2"
        Me.lbdesc2.Size = New System.Drawing.Size(117, 13)
        Me.lbdesc2.TabIndex = 26
        Me.lbdesc2.Text = "aplicando el descuento"
        Me.lbdesc2.Visible = False
        '
        'lbdescuento
        '
        Me.lbdescuento.AutoSize = True
        Me.lbdescuento.Location = New System.Drawing.Point(24, 225)
        Me.lbdescuento.Name = "lbdescuento"
        Me.lbdescuento.Size = New System.Drawing.Size(106, 13)
        Me.lbdescuento.TabIndex = 25
        Me.lbdescuento.Text = "su descuento es de: "
        Me.lbdescuento.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "fecha de entrada del vehiculo"
        '
        'dtentrada
        '
        Me.dtentrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtentrada.Location = New System.Drawing.Point(24, 145)
        Me.dtentrada.Name = "dtentrada"
        Me.dtentrada.Size = New System.Drawing.Size(119, 20)
        Me.dtentrada.TabIndex = 23
        '
        'dtsalida
        '
        Me.dtsalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtsalida.Location = New System.Drawing.Point(24, 89)
        Me.dtsalida.Name = "dtsalida"
        Me.dtsalida.Size = New System.Drawing.Size(119, 20)
        Me.dtsalida.TabIndex = 22
        '
        'btncalculo
        '
        Me.btncalculo.Location = New System.Drawing.Point(24, 299)
        Me.btncalculo.Name = "btncalculo"
        Me.btncalculo.Size = New System.Drawing.Size(75, 23)
        Me.btncalculo.TabIndex = 21
        Me.btncalculo.Text = "calcular"
        Me.btncalculo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "fecha de salida del vehiculo"
        '
        'lbcosto
        '
        Me.lbcosto.AutoSize = True
        Me.lbcosto.Location = New System.Drawing.Point(24, 196)
        Me.lbcosto.Name = "lbcosto"
        Me.lbcosto.Size = New System.Drawing.Size(102, 13)
        Me.lbcosto.TabIndex = 19
        Me.lbcosto.Text = "el costo total es de: "
        '
        'lbcontrato
        '
        Me.lbcontrato.AutoSize = True
        Me.lbcontrato.Location = New System.Drawing.Point(21, 168)
        Me.lbcontrato.Name = "lbcontrato"
        Me.lbcontrato.Size = New System.Drawing.Size(101, 13)
        Me.lbcontrato.TabIndex = 18
        Me.lbcontrato.Text = "el contrato sera por:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "selecione un vehiculo"
        '
        'cbvehiculo
        '
        Me.cbvehiculo.FormattingEnabled = True
        Me.cbvehiculo.Items.AddRange(New Object() {"auto", "camioneta"})
        Me.cbvehiculo.Location = New System.Drawing.Point(24, 38)
        Me.cbvehiculo.Name = "cbvehiculo"
        Me.cbvehiculo.Size = New System.Drawing.Size(135, 21)
        Me.cbvehiculo.TabIndex = 16
        '
        'FormE4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 344)
        Me.Controls.Add(Me.lbmult2)
        Me.Controls.Add(Me.lbmulta)
        Me.Controls.Add(Me.dtmulta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbdesc2)
        Me.Controls.Add(Me.lbdescuento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtentrada)
        Me.Controls.Add(Me.dtsalida)
        Me.Controls.Add(Me.btncalculo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbcosto)
        Me.Controls.Add(Me.lbcontrato)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbvehiculo)
        Me.Name = "FormE4"
        Me.Text = "FormE4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbmult2 As System.Windows.Forms.Label
    Friend WithEvents lbmulta As System.Windows.Forms.Label
    Friend WithEvents dtmulta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbdesc2 As System.Windows.Forms.Label
    Friend WithEvents lbdescuento As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtentrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtsalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents btncalculo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbcosto As System.Windows.Forms.Label
    Friend WithEvents lbcontrato As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbvehiculo As System.Windows.Forms.ComboBox
End Class
