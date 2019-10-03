Imports TelefoniaEntidades
Module MarcaTest
    Sub Main()
        Dim marca As New Marca("Moto")
        Console.WriteLine("Nombre: {0}", marca.Nombre)
        Console.ReadKey()

    End Sub
End Module
