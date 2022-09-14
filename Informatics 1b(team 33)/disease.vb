'option statements 
Option Infer Off
Option Strict On
Option Explicit On
Public MustInherit Class disease

    Private _type As String
    Private _severity As String
    Private _cause As String
    Private _numinfected As Integer

    Public Property type As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property

    Public Property severity As String
        Get
            Return _severity

        End Get
        Set(value As String)
            _severity = value
        End Set
    End Property

    Public Property cause As String
        Get
            Return _cause
        End Get
        Set(value As String)
            _cause = value
        End Set
    End Property

    Public Property numinfected As Integer
        Get
            Return _numinfected
        End Get
        Set(value As Integer)
            _numinfected = value
        End Set
    End Property

    Public Overridable Function totaltreatment() As Integer
        Return 0
    End Function

    Public Overridable Function averagetreatmentdistributed() As Double
        Return 0
    End Function

    Public Overridable Function totalpercentage() As Double
        Return 0
    End Function
End Class
