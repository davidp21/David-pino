Public Class FormE10

    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim Bandera As Boolean

    Public Sub DeterminarConcatenar()
        If Bandera = True Then
            Resultado.Text = ""
            Bandera = False
        ElseIf Resultado.Text = "0" Then
            Resultado.Text = ""
        End If
    End Sub
    Public Sub OperacionProceso()
        Bandera = True
        Valor2 = Val(Resultado.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
            End Select
            Resultado.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DeterminarConcatenar()
        Resultado.Text &= "1"
    End Sub

    Private Sub BSuma_Click(sender As Object, e As EventArgs) Handles BSuma.Click
        OperacionProceso()
        Operacion = "+"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeterminarConcatenar()
        Resultado.Text &= "3"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DeterminarConcatenar()
        Resultado.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DeterminarConcatenar()
        Resultado.Text &= "8"
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        DeterminarConcatenar()
        Resultado.Text &= "9"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DeterminarConcatenar()
        Resultado.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DeterminarConcatenar()
        Resultado.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DeterminarConcatenar()
        Resultado.Text &= "6"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DeterminarConcatenar()
        Resultado.Text &= "2"
    End Sub

    Private Sub Button1w7_Click(sender As Object, e As EventArgs) Handles Button1w7.Click
        DeterminarConcatenar()
        Resultado.Text &= "0"
    End Sub

    Private Sub BResta_Click(sender As Object, e As EventArgs) Handles BResta.Click
        OperacionProceso()
        Operacion = "-"
    End Sub

    Private Sub BMultiplicacion_Click(sender As Object, e As EventArgs) Handles BMultiplicacion.Click
        OperacionProceso()
        Operacion = "*"
    End Sub

    Private Sub BDivision_Click(sender As Object, e As EventArgs) Handles BDivision.Click
        OperacionProceso()
        Operacion = "/"
    End Sub

    Private Sub BPunto_Click(sender As Object, e As EventArgs) Handles BPunto.Click
        DeterminarConcatenar()
        If InStr(Resultado.Text, ".", CompareMethod.Text) = 0 Then Resultado.Text &= "."
    End Sub

    Private Sub BBorrar_Click(sender As Object, e As EventArgs) Handles BBorrar.Click
        Resultado.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub BIgual_Click(sender As Object, e As EventArgs) Handles BIgual.Click
        OperacionProceso()
        Operacion = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class