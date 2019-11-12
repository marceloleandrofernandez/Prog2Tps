Public Class Entidad
    Private _nombre As String
    Private _domicilio As String

    Sub New(nombre As String, domicilio As String)
        Me.Nombre = nombre
        Me.Domicilio = domicilio

    End Sub
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length < 0 Or value.Length > 30 Then
                Throw New Exception("La Cadena debe contener maximo 30 caracteres")
            Else
                _nombre = value
            End If
        End Set
    End Property
    Public Property Domicilio As String
        Get
            Return _domicilio
        End Get
        Set(value As String)
            If value.Length < 0 Or value.Length > 50 Then
                Throw New Exception("La Cadena debe contener maximo 30 caracteres")
            Else
                _domicilio = value
            End If
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Nombre & Domicilio
    End Function


End Class
