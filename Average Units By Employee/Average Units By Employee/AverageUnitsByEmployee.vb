' Author: Lovish Grover
' Date: February 26, 2020
' Description:This program is to calculate the units shipped by 3 employees of a company for a week.
' For each employee user can enter units for 7 days and in end program will calculate average units of that employee.
' After entering seven days units for each employee it will calculate overall average for all of the employees.
' Some of the code is taken by Resources provided by Prof. Kyle Chapman


Option Strict On
Public Class AverageUnitsByEmployee
    ' Variable Declarations
    Dim day As Integer = 0
    Dim employees As Integer = 0
    Dim averageWeeklyUnits As Double
    Dim totalWeeklyUnits As Integer
    Dim averageOverallUnits As Double
    Dim totalOverallUnits As Integer

    Const DaysInWeek As Integer = 7
    Const NumberOfEmployees As Integer = 3

    Dim ShippedUnits(NumberOfEmployees - 1, DaysInWeek - 1) As Integer

    Dim outputLabelArray() As Label
    Dim outputTextboxArray() As TextBox


#Region "Event Handlers"
    ''' <summary>
    ''' When the form loads, initialize array of controls
    ''' </summary>

    Private Sub AverageUnitsByEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        outputTextboxArray = {txtUnitsShipped1, txtUnitsShipped2, txtUnitsShipped3}
        outputLabelArray = {lblAverageUnits1, lblAverageUnits2, lblAverageUnits3}

    End Sub
    ''' <summary>
    ''' To exit the form 
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' To reset the form, setdefault procedure is called to clear or re-enble the controls
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefaults()

    End Sub

    ''' <summary>
    ''' Calculates the average for each employee as well as overall average
    ''' Check range validation and whole number validation and shows error message if range is not valid.
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim currentQuantity As Integer
        Const MinimumQuantityRequired As Integer = 0
        Const MaximumQuantityRequired As Integer = 5000

        If Integer.TryParse(txtUnitsShipped.Text, ShippedUnits(employees, day)) Then
            currentQuantity = ShippedUnits(employees, day)
            If currentQuantity >= MinimumQuantityRequired And currentQuantity <= MaximumQuantityRequired Then

                outputTextboxArray(employees).Text &= ShippedUnits(employees, day) & vbCrLf

                ' increments the day
                day += 1
                txtUnitsShipped.Clear()

                ' If we have reached Day 7, calculate the average
                If day = DaysInWeek Then

                    totalWeeklyUnits = 0

                    For dayCounter As Integer = 0 To DaysInWeek - 1
                        totalWeeklyUnits += ShippedUnits(employees, dayCounter)
                    Next

                    ' Calculate and show average units for employee 
                    averageWeeklyUnits = totalWeeklyUnits / DaysInWeek

                    ' Show the average and Day
                    outputLabelArray(employees).Text = "Average: " & Math.Round(averageWeeklyUnits, 2)

                    day = 0
                    employees += 1

                End If


                lblDay.Text = "Day " & (day + 1)

                If employees = NumberOfEmployees Then

                    totalOverallUnits = 0

                    For Each dailyTemperature In ShippedUnits
                        totalOverallUnits += dailyTemperature
                    Next

                    ' Calculate and show average units for employee
                    averageOverallUnits = totalOverallUnits / ShippedUnits.Length
                    lblOverallAverage.Text = "Average: " & Math.Round(averageOverallUnits, 2)

                    lblDay.Text = "Done"

                    ' This can disable all the input-related control
                    txtUnitsShipped.Enabled = False
                    btnEnter.Enabled = False
                    btnReset.Focus()

                End If

                ' If the number is not between the range shows the error message
            Else
                'show error message if te value is not between the specific range. 
                MessageBox.Show("Please enter a numeric value between 0 to 5000.")
                txtUnitsShipped.Focus()
            End If

        Else
            ' If the number other than whole number shows the error message
            MessageBox.Show("Shipped Units must be entered as a number.")
            txtUnitsShipped.SelectAll()
            txtUnitsShipped.Focus()
        End If

    End Sub
#End Region

#Region "Procedures"
    ''' <summary>
    ''' Set default sub procedure, Clears all the input and output text boxes and labels
    ''' and after one complete cycle re enable all the controls and focus and reset the form 
    ''' to its default state.
    ''' </summary>
    Sub SetDefaults()
        ' Clear all the textboxes
        txtUnitsShipped.Clear()
        txtUnitsShipped1.Clear()
        txtUnitsShipped2.Clear()
        txtUnitsShipped3.Clear()

        ' Clear the labels 
        lblAverageUnits1.Text = String.Empty
        lblAverageUnits2.Text = String.Empty
        lblAverageUnits3.Text = String.Empty
        lblOverallAverage.Text = String.Empty

        ' Re-enable input controls
        txtUnitsShipped.Enabled = True
        btnEnter.Enabled = True

        ' Set default values
        employees = 0
        day = 0
        lblDay.Text = "Day " & (day + 1)

        ' Set focus 
        txtUnitsShipped.Focus()

    End Sub
#End Region
End Class
