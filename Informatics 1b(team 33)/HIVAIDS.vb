﻿Option Strict On
Option Infer Off
Option Explicit On




Public Class HIVAIDS
    Inherits disease

    Public Overrides Function treatment() As String

        Return "pills
                shots"
    End Function

    Public Overrides Function symptoms() As String

        Return "Fever.
                Headache.
                Muscle aches and joint pain.
                Rash.
                Sore throat and painful mouth sores.
                Swollen lymph glands, mainly on the neck.
                Diarrhea.
                Weight loss."
    End Function
End Class