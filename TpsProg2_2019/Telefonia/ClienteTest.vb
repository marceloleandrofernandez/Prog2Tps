Imports TelefoniaEntidades
Module ClienteTest

    Sub Main()
        Dim cli As New Cliente
        cli.Cuenta = 123456
        Console.WriteLine("El n° de Cuenta es: {0}", cli.Cuenta)

        Console.ReadKey()
    End Sub

End Module
