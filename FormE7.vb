Public Class FormE7

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim far As Double
        Dim celsius As Double

        far = txtfaren.Text

        celsius = 5 / 9 * (far - 32)
        celsius = Math.Round(celsius, 1)
        Label3.Text = "el resultado es: " & celsius & "C°"
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class