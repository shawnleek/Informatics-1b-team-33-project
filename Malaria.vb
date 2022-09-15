Public Class Malaria

    Public MustInherit Class Diesease

        Private Numofwaterbodies As Integer
        Private AreaSize As Double

        Private Function RiskFactor(AreaSize As Integer, numWaterbodies As Integer) As String

            Dim ratio As Double
            Dim risk As String

            ratio = numWaterbodies / AreaSize * 10000

            If ratio < 0.5 Then
                risk = "Low Risk Area"
            ElseIf ratio > 0.5 And ratio < 2 Then
                risk = "Moderate Risk Area"
                ' SUGGESTIONS ->these should be output to the user
                ' Create alerts for the people in this place to wear long sleeved shirts
                '-provide insecticides (mosquito replellants)
                '-Provide vaccines for people living in this area
            Else
                risk = "High Risk Area"
                'SUGGESTIONS->these should be output to the user
                '-High priority, must be the first to get vaccines 
                'Create alerts for the people in this place to wear long sleeved shirts
                '-Ensure theres a surplus of antibiotics in the local clinics
                '-Put up warning signs for mosquito hotspots as they are the carriers of the plasmodium parasite.


            End If


        End Function








    End Class
End Class
