Imports Entidades
Module JaulaTest
    Sub Main()
        Dim Coto As New Cotorra
        Dim Coto1 As New Cotorra
        Dim Coto2 As New Cotorra
        Dim Coto3 As New Cotorra
        Dim loro As New Loro
        '******* Test de Setters ************

        loro.Nombre = "Panchito"
        loro.FechaNacimiento = "21/09/1985"
        Coto.Nombre = "Panchita"
        Coto.FechaNacimiento = "21/09/1985"
        Coto1.Nombre = "Panchita1"
        Coto1.FechaNacimiento = "21/09/1985"
        Coto2.Nombre = "Panchita2"
        Coto2.FechaNacimiento = "21/09/1985"
        Coto3.Nombre = "Panchita3"
        Coto3.FechaNacimiento = "21/09/1985"
        Dim Jaula As New Jaula
        Jaula.Nombre = "Jaula Coso"
        Jaula.Loro = loro
        Console.WriteLine(Jaula.Nombre)
        Console.WriteLine("El Loro de La Jaula es: {0}", Jaula.Loro)
        Jaula.AddCotorra(Coto)
        Jaula.AddCotorra(Coto1)
        Jaula.AddCotorra(Coto2)
        Jaula.AddCotorra(Coto3)
        Console.WriteLine("test de getAll")
        For Each item In Jaula.getAllCotorras()
            Console.WriteLine(item.Nombre)
        Next
        Console.ReadKey()
    End Sub
End Module
