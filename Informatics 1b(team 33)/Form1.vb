
'---------------------------------------option statements --------------------------'
Option Infer Off
Option Strict On
Option Explicit On


Public Class Form1
    Private countries() As country
    Private incrementer As Integer
    Private regiontracker() As Integer
    Private risktracker() As String
    Private Sub btnaddcountry_Click(sender As Object, e As EventArgs) Handles btnaddcountry.Click

        ReDim Preserve countries(incrementer)
        ReDim Preserve regiontracker(incrementer)
        ReDim Preserve risktracker(incrementer)
        Dim numregions As Integer

        numregions = CInt(InputBox("how many regions are available for the country "))

        regiontracker(incrementer) = numregions

        Dim country As New country(numregions)
        country.name = InputBox("What is the name of the country ?", "COUNTRY")
        country.classification = InputBox("what is the classification of " & country.name,, "developing")
        country.landsize = CDbl(InputBox("what is the land size of " & country.name))
        country.population = CInt(InputBox("what is the population of " & country.name))

        For r As Integer = 1 To numregions
            country.regions(r).name = InputBox("what is the name of region " & CStr(r))
            country.regions(r).population = CInt(InputBox("what is the population of " & country.regions(r).name))
            country.regions(r).climate = InputBox("how is the climate in " & country.regions(r).name,, "cold")
            country.regions(r).size = CDbl(InputBox("what is the size of " & country.regions(r).name))
            country.regions(r).numfacilities = CInt(InputBox("how many healthcare facilities are available in " & country.regions(r).name))
            country.regions(r).hivAids = CInt(InputBox("how many people are living with HIV/AIDS :"))
            country.regions(r).malaria = CInt(InputBox("how many people are living with MALARIA : "))
            country.regions(r).diabetes = CInt(InputBox("how many people are living with DIABETES"))
            country.regions(r).tb = CInt(InputBox("how many people are living with TUBERCULOSIS"))

        Next r

        risktracker(incrementer) = country.regions(incrementer + 1).determinecondition(country.regions(incrementer + 1).population)
        country.malariacalc(regiontracker(incrementer))
        country.hivratecalc(regiontracker(incrementer))
        country.tbcalc(regiontracker(incrementer))
        country.diabetescalc(regiontracker(incrementer))
        countries(incrementer) = country
        incrementer += 1
        ListBox1.Items.Add(country.name)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        ListBox2.Items.Clear()
        For r As Integer = 1 To regiontracker(r)
            ListBox2.Items.Add(countries(ListBox1.SelectedIndex).regions(r).name)
        Next




    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        ListBox3.Items.Clear()
        ListBox3.Items.Add("name :" & countries(ListBox1.SelectedIndex).regions(ListBox2.SelectedIndex + 1).name)

        ListBox3.Items.Add("Climate :" & countries(ListBox1.SelectedIndex).regions(ListBox2.SelectedIndex + 1).climate)
        ListBox3.Items.Add("Population size :" & countries(ListBox1.SelectedIndex).regions(ListBox2.SelectedIndex + 1).population)
        ListBox3.Items.Add("Healthcare facilities :" & countries(ListBox1.SelectedIndex).regions(ListBox2.SelectedIndex + 1).numfacilities)
        ListBox3.Items.Add("HIV/AIDS :" & countries(ListBox1.SelectedIndex).regions(ListBox2.SelectedIndex + 1).hivAids)
        ListBox3.Items.Add("Malaria :" & countries(ListBox1.SelectedIndex).regions(ListBox2.SelectedIndex + 1).malaria)
        ListBox3.Items.Add("Tuberculosis :" & countries(ListBox1.SelectedIndex).regions(ListBox2.SelectedIndex + 1).tb)
        ListBox3.Items.Add("Diabetes :" & countries(ListBox1.SelectedIndex).regions(ListBox2.SelectedIndex + 1).diabetes)


    End Sub

    Private Sub btninfor_Click(sender As Object, e As EventArgs) Handles btninfor.Click
        '---------------------------------------------------addinng diseases into display listbox 4---------------------------------------------------'
        '                                                                                                                                             '

        ListBox4.Items.Add("malaria")
        ListBox4.Items.Add("HIV/AIDS")
        ListBox4.Items.Add("Diabetes")
        ListBox4.Items.Add("Tuberculosis")



    End Sub

    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        '-----------------------------------------viewing details about each disease----------------------------------------------------'
        '                                                                                                                               '

        ListBox5.Items.Clear()
        Dim tb As New TB
        tb.severity = "medium severe"
        tb.type = "lung disease"
        tb.cause = "smoke ,cigarretes and toxic gases"
        Dim malaria As New malaria
        malaria.severity = "very severe"
        malaria.type = "stomach disease"
        malaria.cause = "dirty enviroments "
        Dim diabetes As New diabetes
        diabetes.severity = "severe"
        diabetes.type = "Body disease"
        diabetes.cause = "sugar etc"
        Dim hivaids As New HIVAIDS
        hivaids.severity = "medium severe"
        hivaids.type = "immune system"
        hivaids.cause = "unprotected sex "
        Dim disease(4) As disease

        disease(0) = malaria
        disease(2) = diabetes
        disease(1) = hivaids
        disease(3) = tb
        '---------------------------------------------------------------------polymorphism-------------------------------------------------------------------------------'
        ListBox5.Items.Add("SYMPTOMS :" & vbNewLine & disease(ListBox4.SelectedIndex).symptoms)

        ListBox5.Items.Add("TREATMENTS :" & disease(ListBox4.SelectedIndex).treatment)
        '----------------------------------------------------------------------------------------------------------------------------------------------------------------'


        ListBox5.Items.Add("Severity :" & disease(ListBox4.SelectedIndex).severity)
        ListBox5.Items.Add("Type :" & disease(ListBox4.SelectedIndex).type)
        ListBox5.Items.Add("Cause :" & disease(ListBox4.SelectedIndex).cause)

    End Sub

    Private Sub btncountrydetails_Click(sender As Object, e As EventArgs) Handles btncountrydetails.Click
        '------------------------------------------------------showing country details -----------------------------------------------------'
        '                                                                                                                                   '
        For c As Integer = 0 To incrementer - 1
            MsgBox("country name :" & countries(c).name & vbNewLine & "classification :" & countries(c).classification & vbNewLine & "population size :" & countries(c).population & vbNewLine & "HIVAIDS rate :" & Format(countries(c).HIVRate, "0.00") & vbNewLine & "TB rate :" & Format(countries(c).TBRate, "0.00") & vbNewLine & "Diabetes rate :" & Format(countries(c).diabetesrate, "0.00") & vbNewLine & "Malaria rate :" & Format(countries(c).malariarate, "0.00") & vbNewLine & "Risk :" & risktracker(c))

        Next




    End Sub
End Class
