Public Class Loro
    Private _nombre As String
    Private _edad As Short
    Private _fechaNacimiento As Date
    Private _memoria As Queue
    Private _frase As String

    Sub New()
        Me.Nombre = ""
        Me.FechaNacimiento = "01/01/1900"
        Me._memoria = New Queue
    End Sub
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public ReadOnly Property Edad As Short
        Get
            Return CalcularEdad()
        End Get
    End Property
    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property
    Private Property Frase As String
        Get
            Return _frase
        End Get
        Set(value As String)
            _frase += value + " "
        End Set
    End Property
    Public Overridable Sub Escuchar(frase As String)
        _memoria.Enqueue(frase)
    End Sub
    Public Function Hablar() As String
        If _memoria.Count > 0 Then
            Me.Frase = _memoria.Dequeue
            Return Me.Frase
        Else
            Return Me.Frase
        End If
    End Function
    Private Function CalcularEdad() As Short
        Return DateDiff(DateInterval.Year, FechaNacimiento, Date.Now)
    End Function
    Public Overrides Function ToString() As String
        Return Nombre
    End Function


End Class
