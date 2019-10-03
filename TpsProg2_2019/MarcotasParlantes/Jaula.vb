Public Class Jaula
    Private _nombre As String
    Private _loro As Loro
    Private _cotorras As List(Of Cotorra)

    Sub New()
        Me.Loro = New Loro
        Me._cotorras = New List(Of Cotorra)
        Me.Nombre = ""
    End Sub

    Public Property Loro As Loro
        Get
            Return _loro
        End Get
        Set(value As Loro)
            _loro = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Sub AddCotorra(coto As Cotorra)
        If _cotorras.Count < 3 Then
            _cotorras.Add(coto)
        End If
    End Sub
    Public Function getAllCotorras() As List(Of Cotorra)
        Return _cotorras
    End Function
    Public Overrides Function ToString() As String
        Return "Esta es La Jaula: " + Me.Nombre
    End Function

End Class
