

Public Class country
    '-------------------------------------------------attributes----------------------------------------'
    Private _name As String
    Private _Type As String
    Private _landsize As Double
    Private _population As Integer
    Private _classification As String
    Private _regions() As Region
    Private _HIVRate As Double  'Percentage of infected individuals nationally
    Private _TBRate As Double
    Private _malariarate As Double  'Percentage of infected individuals nationally
    Private _diabetesrate As Double



    Public Sub New(numregion As Integer)
        ReDim _regions(numregion)
        For r As Integer = 1 To numregion
            _regions(r) = New Region
        Next
    End Sub

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
    Public Property regions(index As Integer) As Region
        Get
            Return _regions(index)
        End Get
        Set(value As Region)
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
Public Class diabetes
    Inherits disease

    '---------------------------------------------------------------------methods----------------------------------------------------------'
    Public Overrides Function symptoms() As String
        Return ": Urinate a lot, Have blurry vision Have numb or feet Have very dry skin."
    End Function
    Public Overrides Function treatment() As String

        Return ": insulin pumps weight loss surgery diet and exercise  emotional support"

    End Function



End Class
Public MustInherit Class disease
    '---------------------------------------------------------------------------attributes--------------------------------------------'
    Private _type As String
    Private _severity As String
    Private _cause As String

    '----------------------------------------------------------------------property procedures-------------------------------------------------'
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

    '--------------------------------------------------------------methods---------------------------------------------------------------'
    Public MustOverride Function treatment() As String
    Public MustOverride Function symptoms() As String


End Class
Public Class HIVAIDS
    Inherits disease
    '-------------------------------------------------------------methods ------------------------------------------------------'
    Public Overrides Function treatment() As String

        Return "pills, ARVs and shots"

    End Function

    Public Overrides Function symptoms() As String

        Return "Fever Headache , Sore throat ,painful mouth sores and Swollen lymph glands."

    End Function
End Class
Public Class malaria
    Inherits disease
    '-----------------------------------------------------------------methods-----------------------------------------------------------'
    Public Overrides Function treatment() As String
        Return "Atovaquone-proguanil and Primaquine phosphate
"


    End Function

    Public Overrides Function symptoms() As String
        Return "fever flu like illness  headache muscle aches tiredness shaking chills"



    End Function
End Class

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
    Public Function determinecondition(numpopulation As Integer) As String

        Dim total As Integer = Me.hivAids + Me.malaria + Me.tb + Me.malaria
        If numpopulation > total Then
            Return "Not a high risk area"
        Else
            Return "High risk area"
        End If

    End Function


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
Public Class TB
    Inherits disease
    '---------------------------------------------------------methods----------------------------------------------------------'
    Public Overrides Function treatment() As String
        Return "antibiotics,isoniazid, rifampicin and pyrazinamide."


    End Function

    Public Overrides Function symptoms() As String
        Return "feelings of sickness or weakness, weight loss, fever, and night sweats. "
    End Function
End Class
