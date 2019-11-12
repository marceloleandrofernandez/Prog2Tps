Imports EntidadesViajes
Module TestClientePasajero
    Sub Main()
        Dim pasajero As New ClientePasajero("20-1233422", 555, "Ramonita", "Su casa", "18/12/2009")
        Dim pasajero2 As New ClientePasajero("20-1233422-33", 555, "Ramonota", "Su casa", "18/12/2029", 44444444)

        Console.WriteLine("Nombre: {0}", pasajero.Nombre)
        Console.WriteLine("Dni: {0}", pasajero.Dni)
        Console.WriteLine("Domicilio: {0}", pasajero.Domicilio)
        Console.WriteLine("Fecha Nacimiento: {0}", pasajero.FechaNacimiento)


        Console.WriteLine("SobreCarga2")


        Console.WriteLine("Nombre: {0}", pasajero2.Nombre)
        Console.WriteLine("Dni: {0}", pasajero2.Dni)
        Console.WriteLine("Domicilio: {0}", pasajero2.Domicilio)
        Console.WriteLine("Fecha Nacimiento: {0}", pasajero2.FechaNacimiento)
        Console.WriteLine("Pasaporte: {0}", pasajero2.Pasaporte)


        Console.ReadKey()

    End Sub
End Module
