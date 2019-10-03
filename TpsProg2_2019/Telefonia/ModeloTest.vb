Imports TelefoniaEntidades
Module ModeloTest
    Sub Main()
        Dim mode As New Modelo("Moto")
        Console.WriteLine("Nombre: {0}", mode.Nombre)
        Console.ReadKey()

    End Sub
End Module
