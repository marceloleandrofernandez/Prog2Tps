Public Class Persona
    Inherits Cliente
    Private _nombre As String
    Private _apellido As String
    Private _documento As UInteger
    Sub New(nombre As String, apellido As String, documento As UInteger)
        MyBase.New()
        Me.Nombre = nombre
        Me.Apellido = apellido
        Me.Documento = documento
    End Sub
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 30 Then
                _nombre = value
            End If
        End Set
    End Property
    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 50 Then
                _apellido = value
            End If
        End Set
    End Property
    Public Property Documento As UInteger
        Get
            Return _documento
        End Get
        Set(value As UInteger)
            _documento = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Nombre + " " + Apellido + " " + Cuenta
    End Function
End Class
