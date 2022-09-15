'------------------------------------------------------------option statement----------------------------------------------------'
Option Infer Off
Option Explicit On
Option Strict On

Public Class region
    '--------------------------------------------------------attributes----------------------------------------------------------'

    'variables 
    Private _name As String
    Private _climate As String
    Private _type As String
    Private _numinfected As Integer
    Private _numfacilities As Integer
    Private _size As Double
    Private _npopulation As Integer
    Private _numpeoplediabetes As Integer
    Private _numpeopletb As Integer
    Private _numpeoplemalaria As Integer
    Private _numpeoplehivaids As Integer

    '---------------------------------------------------------------property methods-----------------------------------------------------------------'
    Public Property numinfected As Integer
        Set(value As Integer)
            _numinfected = value
        End Set
        Get
            Return _numinfected
        End Get
    End Property

    Public Property malaria As Integer
        Set(value As Integer)
            _numpeoplemalaria = value
        End Set
        Get
            Return _numpeoplemalaria
        End Get
    End Property
    Public Property tb As Integer
        Set(value As Integer)
            _numpeopletb = value
        End Set
        Get
            Return _numpeopletb
        End Get
    End Property
    Public Property hivAids As Integer
        Set(value As Integer)
            _numpeoplehivaids = value
        End Set
        Get
            Return _numpeoplehivaids
        End Get
    End Property

    Public Property diabetes As Integer
        Set(value As Integer)
            _numpeoplediabetes = value
        End Set
        Get
            Return _numpeoplediabetes
        End Get
    End Property
    Public Property name As String
        Set(value As String)
            _name = value
        End Set
        Get
            Return _name
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


End Class
