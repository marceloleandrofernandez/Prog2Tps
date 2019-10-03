Public Class Linea
    Private _codigoArea As UShort
    Private _numero As UInteger
    Private _estado As String

    Public Property CodigoArea As UShort
        Get
            Return _codigoArea
        End Get
        Set(value As UShort)
            If value > 99 And value <= 9999 Then
                _codigoArea = value
            End If
        End Set
    End Property
    Public Property Numero As UInteger
        Get
            Return _numero
        End Get
        Set(value As UInteger)
            If value >= 100000 And value <= 9999999 Then
                _numero = value
            End If
        End Set
    End Property
    Public ReadOnly Property Estado As String
        Get
            Return _estado
        End Get
    End Property

    Sub New(codigoArea As UShort, numero As UInteger)
        Me.CodigoArea = codigoArea
        Me.Numero = numero
        Me._estado = "Activa"
    End Sub
    Public Sub Suspender()
        _estado = "Suspendida"
    End Sub
    Public Sub Reactivar()
        _estado = "Activa"
    End Sub
    Public Overrides Function ToString() As String
        Return CodigoArea & " " & Numero & " " & If(Me.Estado = "Suspendida", "Suspendida", "")
    End Function
End Class
