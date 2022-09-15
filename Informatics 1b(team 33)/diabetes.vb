Option Infer Off
Option Strict On
Option Explicit On

Public Class diabetes



    Inherits disease


    Public Overrides Function symptoms() As String

        Return ": Urinate a lot, Have blurry vision Have numb or feet Have very dry skin."


    End Function
    Public Overrides Function treatment() As String

        Return ": insulin pumps weight loss surgery diet and exercise  emotional support"


    End Function

    Public Overrides Function totaltreatment() As Integer

        Return 0

    End Function

    Public Overrides Function averagetreatmentdistributed() As Double

        Return 0
    End Function

    Public Overrides Function totalpercentage() As Double

        Return 0

    End Function

End Class
