
' *****************************************************************
' Team Number: 33
' Team Member 1 Details: Sibanda, m 221157790
' Team Member 2 Details: tshukudu,T  222041905)
' Team Member 3 Details: mabuza NG 202100584
' Team Member 4 Details: DZUNISANI ,PM 218064321 
' Practical: Team Project
' Class name: disease
' *****************************************************************



'option statements 
Option Infer Off
Option Strict On
Option Explicit On
Public MustInherit Class disease
    '---------------------------------------------------------------------------attributes--------------------------------------------'
    Private _type As String
    Private _severity As String
    Private _cause As String

    '----------------------------------------------------------------------property procedures-------------------------------------------------'
    Public Property type As String
        Get
            Return _type
        End Get
        Set(value As String)
            _type = value
        End Set
    End Property

    Public Property severity As String
        Get
            Return _severity

        End Get
        Set(value As String)
            _severity = value
        End Set
    End Property

    Public Property cause As String
        Get
            Return _cause
        End Get
        Set(value As String)
            _cause = value
        End Set
    End Property

    '--------------------------------------------------------------methods---------------------------------------------------------------'
    Public MustOverride Function treatment() As String
    Public MustOverride Function symptoms() As String


End Class
