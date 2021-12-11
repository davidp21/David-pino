Public Class FormE15

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Dim IVA As Double

        IVA = 0.12
        lblresultado.Text = "El IVA del producto es de:" & (Val(Txtproducto.Text) * IVA)
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        Txtproducto.Text = String.Empty
        lblresultado.Text = String.Empty
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class