Public Class Teisendaja
    Implements Iteisendaja

    Const KM2MI = 1.609344

    Private Function Iteisendaja_ConvertKilometersToMiles(kilometers As Double) As Double Implements Iteisendaja.ConvertKilometersToMiles
        Return kilometers / KM2MI
    End Function
End Class