Imports EntidadesViajes

Public Class Paquete
    Implements IServicio
    Implements ICotizacion
    Private _descripcion As String
    Private _fechainicial As Date
    Private _fechafinal As Date
    Private _numeroDias As UShort
    Private _numeroPasajeros As UShort
    Sub New(descripcion As String, fecha As Date, fechafinal As Date)
        Me.Descripcion = descripcion
        Me.FechaInicial = fecha
        Me.FechaFinal = fechafinal
    End Sub
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

    Public Property FechaFinal As Date
        Get
            Return _fechafinal
        End Get
        Set(value As Date)
            _fechafinal = value
        End Set
    End Property



    Public Property NumeroDias As UShort
        Get
            Return _numeroDias
        End Get
        Set(value As UShort)
            _numeroDias = value
        End Set
    End Property
    Public Property NumeroPasajeros As UShort
        Get
            Return _numeroPasajeros
        End Get
        Set(value As UShort)
            _numeroPasajeros = value
        End Set
    End Property

    Public ReadOnly Property PrecioDolar As Decimal Implements ICotizacion.PrecioDolar
        Get
            'Sumatoria de los Precios de los Servicios
            Throw New NotImplementedException()
        End Get
    End Property

    Public ReadOnly Property PrecioPesos As Decimal Implements ICotizacion.PrecioPesos
        Get
            Return PrecioDolar * 62
        End Get
    End Property
End Class
