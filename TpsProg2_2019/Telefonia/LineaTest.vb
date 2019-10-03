Imports TelefoniaEntidades
Module LineaTest
    Sub Main()
        Dim linea As New Linea(376, 4455667)
        Console.WriteLine("Codigo Area: {0}", linea.CodigoArea)
        Console.WriteLine("Numero: {0}", linea.Numero)
        Console.WriteLine("Estado: {0}", linea.Estado)
        Console.WriteLine("ToString: {0}", linea.ToString)


        Console.WriteLine("Suspender linea....")
        linea.Suspender()
        Console.WriteLine("Estado: {0}", linea.Estado)
        Console.WriteLine("ToString: {0}", linea.ToString)

        Console.WriteLine("Activar linea....")
        linea.Reactivar()
        Console.WriteLine("Estado: {0}", linea.Estado)
        Console.WriteLine("ToString: {0}", linea.ToString)

        Console.ReadKey()
    End Sub
End Module
