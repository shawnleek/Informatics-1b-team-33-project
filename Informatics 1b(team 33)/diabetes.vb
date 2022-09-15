Option Infer Off
Option Strict On
Option Explicit On

Public Class diabetes



    Inherits disease


    Public Overrides Function symptoms() As String

        Return "Urinate (pee) a lot, often at night" & vbNewLine & "Lose weight without trying" & vbNewLine & "Are very hungry" & vbNewLine & "Have blurry vision" & vbNewLine & "  Have numb or tingling hands or feet" & vbNewLine & " Have very dry skin..& vb newline"







    End Function
    Public Overrides Function treatment() As String

        Return ": insulin pumps" & vbNewLine & ": weight loss surgery" & vbNewLine & ": diet and exercise " & vbNewLine & ": emotional support"





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
