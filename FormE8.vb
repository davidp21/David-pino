Public Class FormE8

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Boton.Click
        If Cedula.Text <= 0 Then
            MsgBox("El valor ingresado no corresponde a una cedula")
        ElseIf Cedula.Text >= 0 Then
            MsgBox("El valor ingresado es valido como cedula")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class