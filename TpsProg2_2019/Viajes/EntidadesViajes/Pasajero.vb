Imports EntidadesViajes

Public Class Pasajero
    Inherits Entidad
    Implements IPasajero
    Private _dni As UInteger
    Private _fechanacimiento As Date
    Private _pasaporte As UInteger
    Private _tutor As Pasajero

    Sub New(dni As UInteger, nombre As String, domicilio As String, fechanacimiento As Date)
        MyBase.New(nombre, domicilio)
        Me.FechaNacimiento = fechanacimiento
        Me.Dni = dni
        Me.Tutor = Nothing
    End Sub
    Public Property Tutor As Pasajero
        Get
            Return _tutor
        End Get
        Set(value As Pasajero)
            _tutor = value
        End Set
    End Property
    Public Property Dni As UInteger Implements IPasajero.Dni
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            _dni = value
        End Set
    End Property

    Public Property FechaNacimiento As Date Implements IPasajero.FechaNacimiento
        Get
            Return _fechanacimiento
        End Get
        Set(value As Date)
            _fechanacimiento = value
        End Set
    End Property

    Public Property Pasaporte As UInteger Implements IPasajero.Pasaporte
        Get
            Return _pasaporte
        End Get
        Set(value As UInteger)
            _pasaporte = value
        End Set
    End Property
    Public Function isMayorDeEdad() As Boolean
        If Date.Now().Year - FechaNacimiento.Year < 17 Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
