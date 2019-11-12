Imports EntidadesViajes

Public Class Pasaje
    Implements IServicio
    Implements ICotizacion
    Private _descripcion As String
    Private _fechainicial As Date
    Private _precioUnitario As Decimal
    Private _asientos As Byte
    Private _origen As Ciudad
    Private _destino As Ciudad
    Sub New(descripcion As String, fecha As Date, precio As Decimal, asientos As Byte, origen As Ciudad, destino As Ciudad)
        Me.Descripcion = descripcion
        Me.FechaInicial = fecha
        Me.PrecioUnitario = precio
        Me.Asientos = asientos
        Me.Origen = origen
        Me.Destino = destino

    End Sub
    Public Property Origen As Ciudad
        Get
            Return _origen
        End Get
        Set(value As Ciudad)
            _origen = value
        End Set
    End Property
    Public Property Destino As Ciudad
        Get
            Return _destino
        End Get
        Set(value As Ciudad)
            _destino = value
        End Set
    End Property
    Public Property PrecioUnitario As Decimal
        Get
            Return _precioUnitario
        End Get
        Set(value As Decimal)
            _precioUnitario = value
        End Set
    End Property
    Public Property Asientos As Byte
        Get
            Return _asientos
        End Get
        Set(value As Byte)
            _asientos = value
        End Set
    End Property
    Public ReadOnly Property PrecioPesos As Decimal Implements ICotizacion.PrecioPesos
        Get
            Return PrecioDolar * 62
        End Get
    End Property

    Public ReadOnly Property PrecioDolar As Decimal Implements ICotizacion.PrecioDolar
        Get
            Return PrecioUnitario * Asientos
        End Get
    End Property

    Public Property Descripcion As String Implements IServicio.Descripcion
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property FechaInicial As Date Implements IServicio.FechaInicial
        Get
            Return _fechainicial
        End Get
        Set(value As Date)
            _fechainicial = value
        End Set
    End Property
End Class
