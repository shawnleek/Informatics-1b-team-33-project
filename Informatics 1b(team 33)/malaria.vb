Option Strict On
Option Infer Off
Option Explicit On


Public Class malaria
    Inherits disease

    Public Overrides Function treatment() As String
        Return "Atovaquone-proguanil (Malarone)
                Quinine sulfate (Qualaquin) with doxycycline (Oracea, Vibramycin, others)
                Primaquine phosphate."
    End Function

    Public Overrides Function symptoms() As String
        Return "fever
                flu like illness
                headache 
                muscle aches 
                tiredness  
                shaking chills
                              "
    End Function
End Class
