Public Class Cliente
    Inherits Entidad
    Private _cuit_cuil As String
    Private _ventas As List(Of Venta) ' Falta implementar VENTA

    Sub New(cuit_cuil As String, nombre As String, domicilio As String)
        MyBase.New(nombre, domicilio)
        Me.Cuit_Cuil = cuit_cuil
        Me._ventas = New List(Of Venta)
    End Sub
    Public Sub addVenta(venta As Venta)
        venta.Cliente = Me
        _ventas.Add(venta)
    End Sub
    Public Sub removeVenta(venta As Venta)
        venta.Cliente = Nothing
        _ventas.Remove(venta)
    End Sub
    Public Function getAllVentas() As List(Of Venta)
        Return _ventas
    End Function

    Public Property Cuit_Cuil As String
        Get
            Return _cuit_cuil
        End Get
        Set(value As String)
            If value.Length < 0 Or value.Length > 13 Then
                Throw New Exception("La Cadena debe contener maximo 30 caracteres")
            Else
                _cuit_cuil = value
            End If
        End Set
    End Property
End Class
