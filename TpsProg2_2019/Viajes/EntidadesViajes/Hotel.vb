Imports EntidadesViajes

Public Class Hotel
    Implements IServicio
    Implements ICotizacion

    Private _descripcion As String
    Private _fechainicial As Date
    Private _habitaciones As Byte
    Private _noches As Byte
    Private _precioDiaria As Decimal
    Private _ciudad As Ciudad

    Sub New(descripcion As String, fecha As Date, ciudad As Ciudad, noches As Byte, preciodiaria As Decimal)
        Me.Descripcion = descripcion
        Me.FechaInicial = fecha
        Me.Ciudad = ciudad
        Me.Noches = noches
        Me.PrecioDiaria = preciodiaria
    End Sub
    Public Property Habitaciones As Byte
        Get
            Return _habitaciones
        End Get
        Set(value As Byte)
            _habitaciones = value
        End Set
    End Property
    Public Property Noches As Byte
        Get
            Return _noches
        End Get
        Set(value As Byte)
            _noches = value
        End Set
    End Property
    Public Property PrecioDiaria As Decimal
        Get
            Return _precioDiaria
        End Get
        Set(value As Decimal)
            _precioDiaria = value
        End Set
    End Property
    Public Property Ciudad As Ciudad
        Get
            Return _ciudad
        End Get
        Set(value As Ciudad)
            _ciudad = value
        End Set
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

    Public ReadOnly Property PrecioPesos As Decimal Implements ICotizacion.PrecioPesos
        Get
            Return PrecioDolar * 62
        End Get
    End Property

    Public ReadOnly Property PrecioDolar As Decimal Implements ICotizacion.PrecioDolar
        Get
            Return PrecioDiaria * Noches
        End Get
    End Property
End Class
