Public Class FormConverter
    Private Const KM2MI = 1.609344

    Private Sub BottonConvert_Click(sender As Object, e As EventArgs) Handles BottonConvert.Click
        Dim teisendaja As component.Iteisendaja
        teisendaja = New component.Teisendaja
        Try
            TXTMIL.Text = teisendaja.ConvertKilometersToMiles(TXTKM.Text)
        Catch ex As Exception
            TXTMIL.Text = "Viga "
        End Try

    End Sub

    Private Sub FormConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTMIL.Enabled = False
    End Sub
End Class
