Public Class region
    Private _name As String
    Private _landform As String

    Public Property name As String
        Set(value As String)
            _name = name
        End Set
        Get
            Return _name
        End Get
    End Property
    Public Property landform As String
        Set(value As String)
            _landform = landform
        End Set
        Get
            Return _landform
        End Get
    End Property
End Class
