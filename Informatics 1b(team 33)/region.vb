Public Class region
    Private _name As String
    Private _landform As String
    Private _climate As String
    Private _type As String
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

    Public Property climate As String
        Get
            Return _climate
        End Get
        Set(value As String)
            _climate = value
        End Set
    End Property

    Public Property type As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property
End Class
