﻿
' *****************************************************************
' Team Number: 33
' Team Member 1 Details: Sibanda, m 221157790
' Team Member 2 Details: tshukudu,T  222041905)
' Team Member 3 Details: mabuza NG 202100584
' Team Member 4 Details: DZUNISANI ,PM 218064321 
' Practical: Team Project
' Class name: malaria
' *****************************************************************


Option Strict On
Option Infer Off
Option Explicit On


Public Class malaria
    Inherits disease
    '-----------------------------------------------------------------methods-----------------------------------------------------------'
    Public Overrides Function treatment() As String
        Return "Atovaquone-proguanil and Primaquine phosphate
"


    End Function

    Public Overrides Function symptoms() As String
        Return "fever flu like illness  headache muscle aches tiredness shaking chills"



    End Function
End Class
