Public Class Empresa
    Inherits Cliente
    Private _razonSocial As String
    Private _cuit As String
    Sub New(razonSocial As String, cuit As String)
        MyBase.New
        Me.RazonSocial = razonSocial
        Me.Cuit = cuit
    End Sub
    Public Property RazonSocial As String
        Get
            Return _razonSocial
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 80 Then
                _razonSocial = value
            End If
        End Set
    End Property
    Public Property Cuit As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 13 Then
                _cuit = value
            End If
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Me.RazonSocial + " " + MyBase.Cuenta
    End Function
End Class
