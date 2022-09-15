Option Strict On
Option Infer Off
Option Explicit On




Public Class HIVAIDS
    Inherits disease

    Public Overrides Function treatment() As String

        Return "pills" & vbNewLine & "shots"

    End Function

    Public Overrides Function symptoms() As String

        Return "Fever " & vbNewLine & "Headache" & vbNewLine & "Muscle aches and joint pain" & vbNewLine & " Rash" & vbNewLine & "Sore throat and painful mouth sores" & vbNewLine & "Swollen lymph glands, mainly on the neck" & vbNewLine & "weight loss"





    End Function
End Class
