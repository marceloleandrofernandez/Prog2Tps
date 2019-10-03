Imports TelefoniaEntidades
Module Equipotest
    Sub Main()
        Dim marca As New Marca("Moto")
        Dim mode As New Modelo("C Plus ")

        Dim equi As New Equipo(marca, mode, "AEOEAEA")

        Console.WriteLine("Marca :{0}", equi.Marca.Nombre)
        Console.WriteLine("Marca :{0}", equi.Modelo.Nombre)
        Console.WriteLine("Marca :{0}", equi.Serie)
        Console.WriteLine("Marca :{0}", equi.FechaVenta)
        equi.Vender(Today)
        Console.WriteLine("Marca :{0}", equi.FechaVenta)


        Console.ReadKey()
    End Sub
End Module
