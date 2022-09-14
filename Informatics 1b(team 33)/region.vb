'option statement
Option Infer Off
Option Explicit On
Option Strict On

Public Class region

    Private _diseases() As disease
    'variables 
    Private _name As String
    Private _climate As String
    Private _type As String
    Private _numfacilities As Integer
    Private _size As Double
    Private _npopulation As Integer


    'property methods
    Public Property name As String
        Set(value As String)
            _name = name
        End Set
        Get
            Return _name
        End Get
    End Property

    Public Property diseases(index As Integer) As disease
        Get
            Return _diseases(index)
        End Get
        Set(value As disease)
            _diseases(index) = value
        End Set
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
    Public Property size As Double
        Get
            Return _size
        End Get
        Set(value As Double)
            _size = value
        End Set
    End Property

    Public Property numfacilities As Integer
        Get
            Return _numfacilities

        End Get
        Set(value As Integer)
            _numfacilities = value
        End Set
    End Property
    Public Property population As Integer
        Get
            Return _npopulation
        End Get
        Set(value As Integer)
            _npopulation = value
        End Set
    End Property

    'method
    Public Function percentage(ninfected As Integer) As Double
        Return _npopulation / ninfected
    End Function
End Class
