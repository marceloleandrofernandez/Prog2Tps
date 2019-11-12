Imports EntidadesViajes
Module TestCliente
    Sub Main()
        Dim cliente As New Cliente("20-1233422", "Ramonita", "Su casa")
        Dim clienteNuevo As New Cliente("66-6666666-6", "Cliente Sospe", "Medio Oriente")
        Dim venta As New Venta(Date.Today(), cliente)
        Dim venta1 As New Venta(Date.Today(), clienteNuevo)
        Dim pasajero As New Pasajero(555, "Ramonita", "Su casa", "18/12/2009")
        Dim tutor As New Pasajero(31911244, "Ramonaso", "Su casa", "21/09/1985")


        Console.WriteLine("Test de Getters")
        Console.WriteLine("Fecha: {0}", cliente.Nombre)
        Console.WriteLine("Cliente Nombre: {0}", cliente.Domicilio)
        Console.WriteLine("Cliente Cuil-Cuit: {0}", cliente.Cuit_Cuil)

        cliente.addVenta(venta)
        cliente.addVenta(venta1)
        For Each item In cliente.getAllVentas()
            Console.WriteLine("Nombre PCliente: {0}", item.Cliente.Nombre)
        Next
        Console.WriteLine("Elimino una Venta")
        cliente.removeVenta(venta1)
        For Each item In cliente.getAllVentas()
            Console.WriteLine("Nombre Cliente: {0}", item.Cliente.Nombre)
        Next
        'Console.WriteLine("Origen: {0}", venta.Origen)
        'Console.WriteLine("Destino: {0}", venta.Destino)
        'Console.WriteLine("Precio: {0}", venta.PrecioPesos)


        Console.ReadKey()
    End Sub
End Module
