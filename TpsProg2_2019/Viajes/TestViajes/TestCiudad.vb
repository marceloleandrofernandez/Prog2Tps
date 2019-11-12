Imports EntidadesViajes
Module TestCiudad
    Sub Main()
        Dim laceeeteee As New Ciudad("Cheeekaaagoooo")



        Console.WriteLine("Nombre: {0}", laceeeteee.Nombre)

        'Excepciones
        Try
            laceeeteee.Nombre = "Un Nombre Con mas de 30 caracteres"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        'Try
        '    asd.Domicilio = "Un Domicilio Con mas de 50 caracteres ah re l0coooooooooooooooooooooooooooo"
        'Catch ex As Exception
        '    Console.WriteLine(ex.Message)
        'End Try
        Console.ReadKey()
    End Sub
End Module
