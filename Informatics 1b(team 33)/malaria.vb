Option Strict On
Option Infer Off
Option Explicit On


Public Class malaria
    Inherits disease

    Public Overrides Function treatment() As String
        Return "Atovaquone-proguanil,(Oracea, Vibramycin, others) & vbnewline & Primaquine phosphate
"


    End Function

    Public Overrides Function symptoms() As String
        Return "fever flu like illness  headache muscle aches & vbnewline & tirednes shaking chills"



    End Function
End Class
