﻿Public Class FormE12

    Private Sub cbxpais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxpais.SelectedIndexChanged
        cbxestado.Items.Clear()

        If cbxpais.SelectedItem = "Estados Unidos" Then
            cbxestado.Items.Add("Alabama")
            cbxestado.Items.Add("Alaska")
            cbxestado.Items.Add("Arizona")
            cbxestado.Items.Add("Arkansas")
            cbxestado.Items.Add("California")
            cbxestado.Items.Add("Carolina del Norte")
            cbxestado.Items.Add("Carolina del Sur")
            cbxestado.Items.Add("Colorado")
            cbxestado.Items.Add("Connecticut")
            cbxestado.Items.Add("Dakota del Norte")
            cbxestado.Items.Add("Dakota del Sur")
            cbxestado.Items.Add("Delaware")
            cbxestado.Items.Add("Florida")
            cbxestado.Items.Add("Georgia")
            cbxestado.Items.Add("Hawai")
            cbxestado.Items.Add("Idaho")
            cbxestado.Items.Add("Illinois")
            cbxestado.Items.Add("Indiana")
            cbxestado.Items.Add("Iowa")
            cbxestado.Items.Add("Kansas")
            cbxestado.Items.Add("Kentucky")
            cbxestado.Items.Add("Luisiana")
            cbxestado.Items.Add("Maine")
            cbxestado.Items.Add("Maryland")
            cbxestado.Items.Add("Massachusetts")
            cbxestado.Items.Add("Michigan")
            cbxestado.Items.Add("Minnesota")
            cbxestado.Items.Add("Misisipi")
            cbxestado.Items.Add("Misuri")
            cbxestado.Items.Add("Montana")
            cbxestado.Items.Add("Nebraska")
            cbxestado.Items.Add("Nueva Jersey")
            cbxestado.Items.Add("Nueva York")
            cbxestado.Items.Add("Nuevo Hampshire")
            cbxestado.Items.Add("Nuevo Mexico")
            cbxestado.Items.Add("Ohio")
            cbxestado.Items.Add("Oklahoma")
            cbxestado.Items.Add("Oregon")
            cbxestado.Items.Add("Pensilvania")
            cbxestado.Items.Add("Rhode Island")
            cbxestado.Items.Add("Tennessee")
            cbxestado.Items.Add("Utah")
            cbxestado.Items.Add("Vermont")
            cbxestado.Items.Add("Virginia")
            cbxestado.Items.Add("Virginia Occidental")
            cbxestado.Items.Add("Washington")
            cbxestado.Items.Add("Wisconsin")
            cbxestado.Items.Add("Wyoming")

        ElseIf cbxpais.SelectedItem = "Venezuela" Then
            cbxestado.Items.Add("Amazonas - Puerto Ayacucho")
            cbxestado.Items.Add("Anzoategui - Barcelona")
            cbxestado.Items.Add("Apure - San Fernando de Apure")
            cbxestado.Items.Add("Aragua - Maracay")
            cbxestado.Items.Add("Barinas - Barinas")
            cbxestado.Items.Add("Bolivar Ciudad de Guayana")
            cbxestado.Items.Add("Carabobo - Valencia")
            cbxestado.Items.Add("Cojedes - San Carlos")
            cbxestado.Items.Add("Delta Amacuro - Tucupita")
            cbxestado.Items.Add("Distrito Capital - Caracas")
            cbxestado.Items.Add("Falcón - Punto Fijo")
            cbxestado.Items.Add("Guárico - San Juan De Los Morros")
            cbxestado.Items.Add("Lara - Barquisimeto")
            cbxestado.Items.Add("Mérida - Merida")
            cbxestado.Items.Add("Miranda - Caracas")
            cbxestado.Items.Add("Monagas - Maturin")
            cbxestado.Items.Add("Nueva Esparta - Por La Mar")
            cbxestado.Items.Add("Portuguesa - Acarigua")
            cbxestado.Items.Add("Sucre - Cumaná")
            cbxestado.Items.Add("Táchira - San Cristobal")
            cbxestado.Items.Add("Trujillo - Valencia")
            cbxestado.Items.Add("La Guaira - Catia La Mar")
            cbxestado.Items.Add("Yaracuy - San Felipe")
            cbxestado.Items.Add("Zulia - Maracaibo")

        End If

    End Sub
End Class