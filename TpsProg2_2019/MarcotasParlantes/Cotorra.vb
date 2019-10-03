Public Class Cotorra
    Inherits Loro
    Private _edadHumana As UShort
    Private _ignorar As Boolean
    Sub New()
        MyBase.New
        Me._edadHumana = 0
        Me._ignorar = False
    End Sub
    Private Property Ignorar As Boolean
        Get
            Return _ignorar
        End Get
        Set(value As Boolean)
            _ignorar = value
        End Set
    End Property
    Public ReadOnly Property EdadHumana As UShort
        Get
            Return Edad * 2
        End Get
    End Property
    Public Overrides Sub Escuchar(frase As String)
        If (Ignorar) Then
            Me.Ignorar = False
        Else
            MyBase.Escuchar(frase)
            Me.Ignorar = True
        End If
    End Sub


End Class
