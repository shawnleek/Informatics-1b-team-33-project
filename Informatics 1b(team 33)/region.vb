Public Class region
    Private _name As String
    Private _landform As String
    Private _size As Double
    Private _population As Integer
    Private _nfacilities As Integer
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

    Public Property size As Double
        Get
            Return _size
        End Get
        Set(value As Double)
            _size = value
        End Set
    End Property

    Public Property poplulation As Integer
        Get
            Return _population
        End Get
        Set(value As Integer)
            _population = value
        End Set
    End Property

    Public Property nfacilities As Integer
        Get
            Return _nfacilities
        End Get
        Set(value As Integer)
            _nfacilities = value
        End Set
    End Property
End Class
