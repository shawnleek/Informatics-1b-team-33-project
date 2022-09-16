
' *****************************************************************
' Team Number: 33
' Team Member 1 Details: Sibanda, m 221157790
' Team Member 2 Details: tshukudu,T  222041905)
' Team Member 3 Details: mabuza NG 202100584
' Team Member 4 Details: DZUNISANI ,PM 218064321 
' Practical: Team Project
' Class name: tb
' *****************************************************************

Option Infer Off
Option Strict On
Option Explicit On

Public Class TB
    Inherits disease
    '---------------------------------------------------------methods----------------------------------------------------------'
    Public Overrides Function treatment() As String
        Return "antibiotics,isoniazid, rifampicin and pyrazinamide."


    End Function

    Public Overrides Function symptoms() As String
        Return "feelings of sickness or weakness, weight loss, fever, and night sweats. "
    End Function
End Class
