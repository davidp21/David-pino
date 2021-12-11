Public Class FormE13

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If TxtPalabra.TextLength = 0 Then
            MessageBox.Show("Ingrese una palabra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtPalabra.Focus()

        Else
            cbxpalguardadas.Items.Add(TxtPalabra.Text)
            TxtPalabra.Clear()
            TxtPalabra.Focus()

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class