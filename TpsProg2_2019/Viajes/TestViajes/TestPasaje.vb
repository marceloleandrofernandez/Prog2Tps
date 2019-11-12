Imports EntidadesViajes
Module TestPasaje
    Sub Main()
        Dim laceeeteee As New Ciudad("Cheeekaaagoooo")
        Dim otraciudad As New Ciudad("Alabama")
        Dim niuyor As New Ciudad("LA Estatua")
        Dim michi As New Ciudad("Michigan")
        Dim pasaje As New Pasaje("Pasaje a tu casa", "12/12/2019", 45.99, 2, laceeeteee, otraciudad)

        Console.WriteLine("Test de Getters")
        Console.WriteLine("Descripcion: {0}", pasaje.Descripcion)
        Console.WriteLine("Fecha Inicial: {0}", pasaje.FechaInicial)
        Console.WriteLine("Precio: {0}", pasaje.PrecioUnitario)
        Console.WriteLine("Cantidad de Asientos: {0}", pasaje.Asientos)
        Console.WriteLine("Origen: {0}", pasaje.Origen)
        Console.WriteLine("Destino: {0}", pasaje.Destino)
        Console.WriteLine("Precio: {0}", pasaje.PrecioPesos)

        Console.WriteLine("Test de Setters")
        pasaje.Descripcion = "Otra Descripcion"
        pasaje.FechaInicial = "22/12/2019"
        pasaje.Origen = niuyor
        pasaje.Origen = michi
        pasaje.Asientos = 3
        pasaje.PrecioUnitario = 50.59


        Console.WriteLine("Test de Getters")
        Console.WriteLine("Descripcion: {0}", pasaje.Descripcion)
        Console.WriteLine("Fecha Inicial: {0}", pasaje.FechaInicial)
        Console.WriteLine("Precio: {0}", pasaje.PrecioUnitario)
        Console.WriteLine("Cantidad de Asientos: {0}", pasaje.Asientos)
        Console.WriteLine("Origen: {0}", pasaje.Origen)
        Console.WriteLine("Destino: {0}", pasaje.Destino)
        Console.WriteLine("Precio: {0}", pasaje.PrecioPesos)

        Console.ReadKey()
    End Sub
End Module
