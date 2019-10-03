Imports Entidades
Module CotorraTest
    Sub Main()
        Dim Coto As New Cotorra
        '******* Test de Setters ************

        Coto.Nombre = "Panchito"
        Coto.FechaNacimiento = "21/09/1985"
        Console.WriteLine("{0} Escucha: {1}", Coto.Nombre, "Hola")
        Coto.Escuchar("Hola")
        Console.WriteLine("{0} Escucha: {1}", Coto.Nombre, "Ke")
        Coto.Escuchar("Ke")
        Console.WriteLine("{0} Escucha: {1}", Coto.Nombre, "Ase")
        Coto.Escuchar("Ase")
        Console.WriteLine("{0} Escucha: {1}", Coto.Nombre, "Gato")
        Coto.Escuchar("Gato")
        Console.WriteLine("{0} Escucha: {1}", Coto.Nombre, "Macri")
        Coto.Escuchar("Macri")
        '******* Test de Getters ************

        Console.WriteLine("Nombre: {0}", Coto.Nombre)
        Console.WriteLine("Edad: {0}", Coto.Edad)
        Console.WriteLine("Edad Humana: {0}", Coto.EdadHumana)
        Console.WriteLine("Fecha Naciemiento: {0}", Coto.FechaNacimiento)
        Console.WriteLine("{0} Dice: {1}", Coto.Nombre, Coto.Hablar)
        Console.WriteLine("{0} Dice: {1}", Coto.Nombre, Coto.Hablar)
        Console.WriteLine("{0} Dice: {1}", Coto.Nombre, Coto.Hablar)
        Console.WriteLine("{0} Dice: {1}", Coto.Nombre, Coto.Hablar)





        Console.ReadKey()

    End Sub
End Module
