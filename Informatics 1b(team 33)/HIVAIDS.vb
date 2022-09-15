Option Strict On
Option Infer Off
Option Explicit On




Public Class HIVAIDS
    Inherits disease

    Public Overrides Function treatment() As String

        Return "pills, ARVs and shots"

    End Function

    Public Overrides Function symptoms() As String

        Return "Fever Headache , Sore throat ,painful mouth sores and Swollen lymph glands."

    End Function
End Class
