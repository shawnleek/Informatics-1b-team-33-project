
'---------------------------------------option statements --------------------------'
Option Infer Off
Option Strict On
Option Explicit On


Public Class Form1
    Private countries() As country
    Private incrementer As Integer
    Private regiontracker() As Integer
    Private Sub btnaddcountry_Click(sender As Object, e As EventArgs) Handles btnaddcountry.Click

        ReDim Preserve countries(incrementer)
        ReDim Preserve regiontracker(incrementer)
        Dim numregions As Integer

        numregions = CInt(InputBox("how many regions are available for country "))

        regiontracker(incrementer) = numregions

        Dim country As New country(numregions)
        country.name = InputBox("What is the name of the country ?", "COUNTRY")
        country.classification = InputBox("what is the classification of " & country.name)
        country.landsize = CDbl(InputBox("what is the land size of " & country.name))
        country.population = CInt(InputBox("what is the population of " & country.name))

        For r As Integer = 1 To numregions
            country.regions(r).name = InputBox("what is the name of region " & CStr(r))
            country.regions(r).population = CInt(InputBox("what is the population of " & country.regions(r).name))
            country.regions(r).climate = InputBox("how is the climate in " & country.regions(r).name)
            country.regions(r).size = CDbl(InputBox("what is the size of " & country.regions(r).name))
            country.regions(r).numfacilities = CInt(InputBox("how many healthcare facilities are available in " & country.regions(r).name))
            country.regions(r).hivAids = CInt(InputBox("how many people are living with HIV/AIDS :"))
            country.regions(r).malaria = CInt(InputBox("how many people are living with MALARIA : "))
            country.regions(r).diabetes = CInt(InputBox("how many people are living with DIABETES"))
            country.regions(r).tb = CInt(InputBox("how many people are living with TUBERCULOSIS"))
        Next

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
        Dim malaria As New malaria
        Dim diabetes As New diabetes
        Dim hivaids As New HIVAIDS
        Dim disease(4) As disease
        disease(4) = malaria
        disease(3) = diabetes
        disease(2) = hivaids
        disease(1) = tb

        ListBox5.Items.Add("SYMPTOMS :" & vbNewLine & disease(ListBox4.SelectedIndex + 1).symptoms)

        ListBox5.Items.Add("TREATMENTS :"disease(ListBox4.SelectedIndex + 1).treatment)


    End Sub
End Class
