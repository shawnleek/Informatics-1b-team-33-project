
Option Strict On
Option Infer Off
Option Explicit On




Public Class country
    '-------------------------------------------------attributes----------------------------------------'
    Private _name As String
    Private _Type As String
    Private _landsize As Double
    Private _population As Integer
    Private _classification As String
    Private _regions() As region
    Private _HIVRate As Double  'Percentage of infected individuals nationally
    Private _TBRate As Double
    Private _malariarate As Double  'Percentage of infected individuals nationally
    Private _diabetesrate As Double

    '----------------------------------------------------------------property methods--------------------------------------------------'


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
    Public Property malariarate As Double
        Set(value As Double)
            _malariarate = value
        End Set
        Get
            Return _malariarate
        End Get
    End Property
    Public Property diabetesrate As Double
        Set(value As Double)
            _diabetesrate = value
        End Set
        Get
            Return _diabetesrate
        End Get
    End Property



    Public Sub New(numregion As Integer)
        ReDim _regions(numregion)
        For r As Integer = 1 To numregion
            _regions(r) = New region
        Next
    End Sub

    Public Property name As String
        Set(value As String)
            _name = value
        End Set
        Get
            Return _name
        End Get
    End Property

    Public Property landsize As Double
        Set(value As Double)
            _landsize = value
        End Set
        Get
            Return _landsize
        End Get
    End Property
    Public Property population As Integer
        Set(value As Integer)
            _population = value
        End Set
        Get
            Return _population
        End Get
    End Property
    Public Property classification As String
        Set(value As String)
            _classification = value
        End Set
        Get
            Return _classification
        End Get
    End Property
    Public Property regions(index As Integer) As region
        Get
            Return _regions(index)
        End Get
        Set(value As region)
            _regions(index) = value
        End Set
    End Property

    '--------------------------------------------------------------------------methods-------------------------------------------------------------------------------------'
    Public Function hivratecalc(numregion As Integer) As Double
        Dim answer As Integer
        For r As Integer = 1 To numregion

            answer += Me.regions(r).hivAids
            _HIVRate = (answer / Me._population) * 100
        Next
        Return _HIVRate
    End Function

    Public Function malariacalc(numregion As Integer) As Double
        Dim answer As Integer
        For r As Integer = 1 To numregion

            answer += Me.regions(r).malaria
            _malariarate = (answer / Me._population) * 100
        Next
        Return _malariarate
    End Function

    Public Function tbcalc(numregion As Integer) As Double
        Dim answer As Integer
        For r As Integer = 1 To numregion
            answer += Me.regions(r).tb
            _TBRate = (answer / Me.population) * 100
        Next
        Return _TBRate
    End Function

    Public Function diabetescalc(numregion As Integer) As Double
        Dim answer As Integer
        For r As Integer = 1 To numregion
            answer += Me.regions(r).diabetes

            _diabetesrate = (answer / Me._population) * 100
        Next
        Return _diabetesrate
    End Function





End Class
