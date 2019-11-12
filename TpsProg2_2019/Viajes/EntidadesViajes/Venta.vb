Imports EntidadesViajes

Public Class Venta
    Implements ICotizacion
    Private _fecha As Date
    Private _cliente As Cliente
    Private _pasajeros As List(Of Pasajero)
    Shared _cotizacionDolarPesos As Decimal
    Sub New(fecha As Date, cliente As Cliente)
        Me.Cliente = cliente
        Me.Fecha = fecha
        Me._pasajeros = New List(Of Pasajero)
    End Sub
    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Friend Set(value As Cliente)
            _cliente = value
        End Set
    End Property
    Shared Property CotizacionDolarPesos As Decimal
        Get
            Return _cotizacionDolarPesos
        End Get
        Set(value As Decimal)
            _cotizacionDolarPesos = value
        End Set
    End Property

    Public ReadOnly Property PrecioDolar As Decimal Implements ICotizacion.PrecioDolar
        Get
            Throw New NotImplementedException() 'ni idea de donde sale este precio
        End Get
    End Property

    Public ReadOnly Property PrecioPesos As Decimal Implements ICotizacion.PrecioPesos
        Get
            Throw New NotImplementedException() ' este deberia ser PrecioDolar * 60 y algo
        End Get
    End Property
    Public Function PrecioTotal() As Decimal
        Return Nothing 'sumatoria de precios de la lista de servicios o paquetes?
    End Function
    Public Sub addPasajero(pasajero As Pasajero)
        _pasajeros.Add(pasajero)
    End Sub
    Public Sub removePasajero(pasajero As Pasajero)
        _pasajeros.Remove(pasajero)
    End Sub
    Public Function getAllPasajeros() As List(Of Pasajero)
        Return _pasajeros
    End Function
End Class
