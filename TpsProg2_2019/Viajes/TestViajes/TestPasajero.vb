Imports EntidadesViajes
Module TestPasajero
    Sub Main()

        Dim pasajero As New Pasajero(555, "Ramonita", "Su casa", "18/12/2009")
        Dim tutor As New Pasajero(31911244, "Ramonaso", "Su casa", "21/09/1985")
        Console.WriteLine("Nombre: {0}", pasajero.Nombre)
        Console.WriteLine("Dni: {0}", pasajero.Dni)
        Console.WriteLine("Domicilio: {0}", pasajero.Domicilio)
        Console.WriteLine("Fecha Nacimiento: {0}", pasajero.FechaNacimiento)
        Console.WriteLine("Mayor de Esdad?: {0}", pasajero.isMayorDeEdad)


        If Not pasajero.isMayorDeEdad Then
            pasajero.Tutor = tutor
            Console.WriteLine("Tutor de {0} es {1}", pasajero.Nombre, pasajero.Tutor.Nombre)
            Console.WriteLine("Nombre: {0}", pasajero.Tutor.Nombre)
            Console.WriteLine("Dni: {0}", pasajero.Tutor.Dni)
            Console.WriteLine("Domicilio: {0}", pasajero.Tutor.Domicilio)
            Console.WriteLine("Fecha Nacimiento: {0}", pasajero.Tutor.FechaNacimiento)
            Console.WriteLine("Mayor de Esdad?: {0}", pasajero.Tutor.isMayorDeEdad)
        End If

        Try
            pasajero.Nombre = "Un Nombre Con mas de 30 caracteres"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            pasajero.Domicilio = "Un Domicilio Con mas de 50 caracteres ah re l0coooooooooooooooooooooooooooo"
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub
End Module
