Imports EntidadesViajes
Module TestVenta
    Sub Main()
        Dim cliente As New Cliente("20-1233422", "Ramonita", "Su casa")
        Dim venta As New Venta(Date.Today(), cliente)
        Dim pasajero As New Pasajero(555, "Ramonita", "Su casa", "18/12/2009")
        Dim tutor As New Pasajero(31911244, "Ramonaso", "Su casa", "21/09/1985")


        Console.WriteLine("Test de Getters")
        Console.WriteLine("Fecha: {0}", venta.Fecha)
        Console.WriteLine("Cliente Nombre: {0}", venta.Cliente.Nombre)
        Console.WriteLine("Cliente Cuil-Cuit: {0}", venta.Cliente.Cuit_Cuil)
        Console.WriteLine("Cliente Domicilio: {0}", venta.Cliente.Domicilio)
        venta.addPasajero(pasajero)
        venta.addPasajero(tutor)
        For Each item In venta.getAllPasajeros()
            Console.WriteLine("Nombre Pasajero: {0}", item.Nombre)
        Next
        Console.WriteLine("Elimino un Pasajero")
        venta.removePasajero(tutor)
        For Each item In venta.getAllPasajeros()
            Console.WriteLine("Nombre Pasajero: {0}", item.Nombre)
        Next
        'Console.WriteLine("Origen: {0}", venta.Origen)
        'Console.WriteLine("Destino: {0}", venta.Destino)
        'Console.WriteLine("Precio: {0}", venta.PrecioPesos)

        Console.WriteLine("Test de Setters")
        venta.Fecha = "22/12/2019"
        venta.Cliente.Nombre = "RAmonA"
        venta.Cliente.Cuit_Cuil = "20-12544977-9"
        venta.Cliente.Domicilio = "Otra Casa"
        'venta.Asientos = 3
        'venta.PrecioUnitario = 50.59


        Console.WriteLine("Test de Getters")
        Console.WriteLine("Fecha: {0}", venta.Fecha)
        Console.WriteLine("Cliente Nombre: {0}", venta.Cliente.Nombre)
        Console.WriteLine("Cliente Cuil-Cuit: {0}", venta.Cliente.Cuit_Cuil)
        Console.WriteLine("Cliente Domicilio: {0}", venta.Cliente.Domicilio)

        Console.ReadKey()
    End Sub
End Module
