Option Infer Off
Option Strict On
Option Explicit On

Public Class TB
    Inherits disease



    Public Overrides Function treatment() As String
        Return "2 antibiotics (isoniazid and rifampicin) for 6 months.
                2 additional antibiotics (pyrazinamide and ethambutol) for the first 2 months of the 6-month treatment period.
               "
    End Function

    Public Overrides Function symptoms() As String
        Return "feelings of sickness or weakness, weight loss, fever, and night sweats. "
    End Function
End Class
