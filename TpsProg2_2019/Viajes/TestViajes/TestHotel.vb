Imports EntidadesViajes
Module TestHotel
    Sub Main()
        Dim laceeeteee As New Ciudad("Cheeekaaagoooo")
        Dim otraciudad As New Ciudad("Alabama")
        Dim trigavo As New Hotel("Descripcion Hotel", "19/12/2019", laceeeteee, 5, 15.5)

        Console.WriteLine("Test de Getters")
        Console.WriteLine("Descripcion: {0}", trigavo.Descripcion)
        Console.WriteLine("Fecha Inicial: {0}", trigavo.FechaInicial)
        Console.WriteLine("Ciudad: {0}", trigavo.Ciudad)
        Console.WriteLine("Cantidad de Noches: {0}", trigavo.Noches)
        Console.WriteLine("Precio Diaria: {0}", trigavo.PrecioDiaria)
        Console.WriteLine("Cotizacion Pesos: {0}", trigavo.PrecioPesos)

        Console.WriteLine("Test de Setters")
        trigavo.Descripcion = "Otra Descripcion"
        trigavo.FechaInicial = "22/12/2019"
        trigavo.Ciudad = otraciudad
        trigavo.Noches = 3
        trigavo.PrecioDiaria = 50.59


        Console.WriteLine("Descripcion: {0}", trigavo.Descripcion)
        Console.WriteLine("Fecha Inicial: {0}", trigavo.FechaInicial)
        Console.WriteLine("Ciudad: {0}", trigavo.Ciudad)
        Console.WriteLine("Cantidad de Noches: {0}", trigavo.Noches)
        Console.WriteLine("Precio Diaria: {0}", trigavo.PrecioDiaria)
        Console.WriteLine("Cotizacion Pesos: {0}", trigavo.PrecioPesos)

        Console.ReadKey()
    End Sub
End Module
