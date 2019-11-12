Public Class Ciudad

    Private _nombre As String


    Sub New(nombre As String)
        Me.Nombre = nombre
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
End Class
