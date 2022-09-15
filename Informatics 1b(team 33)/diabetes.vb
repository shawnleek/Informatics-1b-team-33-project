Option Infer Off
Option Strict On
Option Explicit On

Public Class diabetes



    Inherits disease


    Public Overrides Function symptoms() As String

        Return "Urinate (pee) a lot, often at night.
                Are very thirsty.
                Lose weight without trying.
                Are very hungry.
                Have blurry vision.
                Have numb or tingling hands or feet.
                Feel very tired.
                Have very dry skin."

    End Function
    Public Overrides Function treatment() As String

        Return "insulin pumps
                weight loss surgery
                diet and exercise 
                emotional support
                                 "

    End Function

    Public Overrides Function totaltreatment() As Integer



    End Function

    Public Overrides Function averagetreatmentdistributed() As Double


    End Function

    Public Overrides Function totalpercentage() As Double



    End Function

End Class
