Public Class FormE2

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        Me.txtaltura.Text = ""
        Me.txtpeso.Text = ""
        Me.txtimc.Text = ""

    End Sub

    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click
        Dim altura, peso, imc As Decimal
        altura = Val(txtaltura.Text)
        altura = Math.Round(altura, 2)

        peso = Val(txtpeso.Text)
        peso = Math.Round(peso, 2)

        imc = peso / (altura / 100) ^ 2
        imc = Math.Round(imc, 2)

        If imc < 18.49 Then
            txtimc.Text = "su IMC es:" & imc & " infrapeso"
            txtimc.BackColor = Color.Aqua
        ElseIf imc > 18.5 And imc < 24.99 Then
            txtimc.Text = "su IMC es:" & imc & " peso normal"
            txtimc.BackColor = Color.Green
        ElseIf imc > 25 And imc < 29.99 Then
            txtimc.Text = "su IMC es:" & imc & " sobrepeso"
            txtimc.BackColor = Color.Orange
        Else
            txtimc.Text = "su IMC es:" & imc & " obeso"
            txtimc.BackColor = Color.Red
        End If
    End Sub
End Class