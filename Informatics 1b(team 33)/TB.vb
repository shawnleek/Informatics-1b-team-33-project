Option Infer Off
Option Strict On
Option Explicit On

Public Class TB
    Private _isoniazid As Integer = 50000
    Private _pyrazinamid As Integer = 100000
    Private _ethambutol As Integer = 10000

    Public ReadOnly Property isoniazid As Integer
        Get
            Return _isoniazid
        End Get
    End Property

    Public ReadOnly Property pyrazinamid As Integer
        Get
            Return _pyrazinamid
        End Get
    End Property

    Public ReadOnly Property ethambutol As Integer
        Get
            Return _ethambutol
        End Get
    End Property
End Class
