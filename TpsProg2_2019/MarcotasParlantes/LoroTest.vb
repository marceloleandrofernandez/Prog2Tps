Imports Entidades
Module LoroTest

    Sub Main()
        Dim loro As New Loro
        '******* Test de Setters ************

        loro.Nombre = "Panchito"
        loro.FechaNacimiento = "21/09/1985"
        loro.Escuchar("Hola")
        loro.Escuchar("Ke")
        loro.Escuchar("Ase")

        '******* Test de Getters ************

        Console.WriteLine("Nombre: {0}", loro.Nombre)
        Console.WriteLine("Edad: {0}", loro.Edad)
        Console.WriteLine("Fecha Naciemiento: {0}", loro.FechaNacimiento)
        Console.WriteLine("{0} Dice: {1}", loro.Nombre, loro.Hablar)
        Console.WriteLine("{0} Dice: {1}", loro.Nombre, loro.Hablar)
        Console.WriteLine("{0} Dice: {1}", loro.Nombre, loro.Hablar)
        Console.WriteLine("{0} Dice: {1}", loro.Nombre, loro.Hablar)





        Console.ReadKey()
    End Sub

End Module
