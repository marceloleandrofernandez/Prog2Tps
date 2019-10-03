Imports TelefoniaEntidades
Module PersonaTest
    Sub Main()
        Dim cli As New Cliente
        Dim pers As New Persona("Juan ", "Coso", 33444555)
        pers.Cuenta = 1234523
        Console.WriteLine("Nombre: {0}", pers.Nombre)
        Console.WriteLine("Apellido: {0}", pers.Apellido)
        Console.WriteLine("Documento: {0}", pers.Documento)
        Console.WriteLine("Cuenta: {0}", pers.Cuenta)

        Console.ReadKey()
    End Sub
End Module
