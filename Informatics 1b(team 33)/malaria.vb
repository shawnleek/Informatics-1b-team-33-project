Option Strict On
Option Infer Off
Option Explicit On


Public Class malaria
    Inherits disease

    Public Overrides Function treatment() As String
        Return "Atovaquone-proguanil and Primaquine phosphate
"


    End Function

    Public Overrides Function symptoms() As String
        Return "fever flu like illness  headache muscle aches tirednes shaking chills"



    End Function
End Class
