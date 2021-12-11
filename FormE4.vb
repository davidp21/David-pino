Public Class FormE4

    Private Sub btncalculo_Click(sender As Object, e As EventArgs)
        Dim dias1 As Date = CDate(Me.dtsalida.Value)
        Dim dias2 As Date = CDate(Me.dtentrada.Value)
        Dim mult As Date = CDate(Me.dtmulta.Value)
        Dim vehiculo As Integer
        Dim costo, multa As Integer

        Dim result, result2 As Integer

        costo = Val(dias2.Day - dias1.Day)
        result = Val(dias2.Day - dias1.Day)

        multa = Val(dias1.Day - mult.Day)

        Me.lbcontrato.Text = "el contrato sera por: " & CStr(dias2.Day - dias1.Day) & " dias"

        If cbvehiculo.Text = "auto" Then
            vehiculo = 100
            lbcosto.Text = "el costo total es igual a: " & CStr(costo * vehiculo) & "$"

        ElseIf cbvehiculo.Text = "camioneta" Then
            vehiculo = 150
            lbcosto.Text = "el costo total es igual a: " & CStr(costo * vehiculo) & "$"

        End If

        If result & CStr(dias2.Day - dias1.Day) > 6 Then
            result = costo * vehiculo
            result2 = result / 100 * 25
            lbdescuento.Visible = True
            lbdesc2.Visible = True
            lbdescuento.Text = "su descuento es de: " & CStr(result / 100 * 25) & "$"
            lbdesc2.Text = "aplicando el descuento el monto total es de: " & CStr(result - result2) & "$"
        End If


        If multa > 0 Then
            lbmulta.Visible = True
            blmulta.Visible = True
            Me.lbmulta.Text = "se ha retrasado:" & multa & "dias"
            Me.blmulta.Text = "multa por retraso: " & CStr(result - result2) + 15
        End If

    End Sub

    Private Sub FormE4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class