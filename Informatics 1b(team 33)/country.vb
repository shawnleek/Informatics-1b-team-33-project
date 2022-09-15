
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


    Public Property tbpercentage As Double
        Set(value As Double)
            _TBPercentage = value
        End Set
        Get
            Return _TBPercentage
        End Get
    End Property
    Public Property hivpercentage As Double
        Set(value As Double)
            _HIVPercentage = value
        End Set
        Get
            Return _HIVPercentage
        End Get
    End Property
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



    Public Sub New(numregion As Integer)
        ReDim _regions(numregion)
        For r As Integer = 1 To numregion
            _regions(r) = New region
        Next
    End Sub

    '---------------------------------------------properties --------------------------------------------'
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
    Public Function hivratecalc(numregion As Integer) As Double
        Dim answer As Double
        For r As Integer = 1 To numregion

            answer += Me.regions(r).hivAids
        Next
        Return answer
    End Function

    Public Function malaria(numregion As Integer) As Double
        Dim answer As Double
        For r As Integer = 1 To numregion
            answer += Me.regions(r).malaria
        Next
        Return answer
    End Function

    Public Function tb(numregion As Integer) As Double
        Dim answer As Double
        For r As Integer = 1 To numregion
            answer += Me.regions(r).tb
        Next
        Return answer
    End Function

    Public Function diabetes(numregion As Integer) As Double
        Dim answer As Double
        For r As Integer = 1 To numregion
            answer += Me.regions(r).diabetes
        Next
        Return answer
    End Function




End Class
