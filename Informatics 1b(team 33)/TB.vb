Option Infer Off
Option Strict On
Option Explicit On

Public Class TB
    Inherits disease



    Public Overrides Function treatment() As String
        Return "antibiotics,isoniazid, rifampicin and pyrazinamide."


    End Function

    Public Overrides Function symptoms() As String
        Return "feelings of sickness or weakness, weight loss, fever, and night sweats. "
    End Function
End Class
