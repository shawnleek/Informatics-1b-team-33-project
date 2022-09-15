Option Strict On
Option Infer Off
Option Explicit On


Public Class malaria
    Inherits disease

    Public Overrides Function treatment() As String
        Return "Atovaquone-proguanil,
(Oracea, Vibramycin, others) & vbnewline & Primaquine phosphate"


    End Function

    Public Overrides Function symptoms() As String
        Return "fever & vbnewline &  flu like illness & vbnewline &  headache" & vbNewLine & "muscle aches & vbnewline & tiredness " & vbNewLine & "shaking chills"






    End Function
End Class
