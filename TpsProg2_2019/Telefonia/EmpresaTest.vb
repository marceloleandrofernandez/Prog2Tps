Imports TelefoniaEntidades
Module EmpresaTest
    Sub Main()
        Dim cli As New Cliente
        Dim emp As New Empresa("RAzonSo", "27-77777777-8")
        emp.Cuenta = 123456
        Console.WriteLine("Razon Social: {0}", emp.RazonSocial)
        Console.WriteLine("Cuit: {0}", emp.Cuit)
        Console.WriteLine("Razon Cuenta: {0}", emp.Cuenta)





        Console.ReadKey()

    End Sub
End Module
