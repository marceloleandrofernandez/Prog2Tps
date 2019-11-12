Imports EntidadesViajes
Module TestEntidad
    Sub Main()
        Dim Ent As New Entidad("Juan Carlos", "Un Domicilio")

        Console.WriteLine("Nombre: {0}", Ent.Nombre)
        Console.WriteLine("Domicilio: {0}", Ent.Domicilio)
        'Excepciones
        Try
            Ent.Nombre = "Un Nombre Con mas de 30 caracteres"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Ent.Domicilio = "Un Domicilio Con mas de 50 caracteres ah re l0coooooooooooooooooooooooooooo"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try



        Console.ReadKey()
    End Sub
End Module
