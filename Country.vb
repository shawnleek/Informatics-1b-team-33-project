Option Strict On
Option Infer Off
Option Explicit On

Public Class Country

    Private _Name As String
    Private _Population As Integer
    Private _Regions() As Region
    Private _Type As String     'Developed, developing or third world country
    Private _HIVPercentage As Double  'Percentage of infected individuals nationally
    Private _TBPercentage  As Double


    Public Property TBRate As Double
        Set(value As Double)
            _TBRate = value
        End Set
        Get
            Return _TBRate
        End Get
    End Property

    Public Property HIVRate As Double
        Set(value As Double)
            _HIVRate = value
        End Set
        Get
            Return _HIVRate
        End Get
    End Property


    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Population As Integer
        Set(value As Integer)
            _Population = value
        End Set
        Get
            Return _Population
        End Get
    End Property

    Public Property Type As String
        Set(value As String)
            _Type = value
        End Set
        Get
            Return _Type
        End Get
    End Property


    Public Sub New(name As String, populationsize As Integer, numregions As Integer, CountryType As String, HIVRate As Double, TBRate As Double)

        _Type = CountryType
        _Population = populationsize
        _Name = name
        _HIVRate = HIVRate
        _TBRate = TBRate
        ReDim _Regions(numregions)

    End Sub




End Class
