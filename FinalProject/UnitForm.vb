Option Strict On

'Author:         Joshua Lopez
'Student Number: 100503113
'File Name:      lab3
'Date Created:   February 25, 2019
'Description:    A Visual Basic Form Program that takes user inputs for 
'                units shipped by each employee and calculates the average 
'                for three employees and calculates the daily average for 
'                the company.

Public Class frmUnit

    'constants
    Const MIN_INPUT = 0
    Const MAX_INPUT = 1000

    Dim day As Integer = 1

    Const ERROR_MESSAGE_RANGE = "Please ensure the units shipped are between 0 and 1000!"
    Const ERROR_MESSAGE_DATA_TYPE = "Please ensure that a numerical value has been input!"
    Const ERROR_MESSAGE_NOT_WHOLE_NUMBER = "Please enter a whole number!"

    Const indexEmployeeOne As Integer = 0
    Const indexEmployeeTwo As Integer = 1
    Const indexEmployeeThree As Integer = 2

    Dim arrayEmployeeUnits As Integer()() = New Integer(2)() {}

    Dim employeeOne As Integer()
    Dim employeeTwo As Integer()
    Dim employeeThree As Integer()



    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Array_Load(sender As Object, e As EventArgs)

        arrayEmployeeUnits(indexEmployeeOne) = employeeOne
        arrayEmployeeUnits(indexEmployeeTwo) = employeeTwo
        arrayEmployeeUnits(indexEmployeeThree) = employeeThree



    End Sub

    ''' <summary>
    ''' Button to close the Application.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub
    ''' <summary>
    ''' Button to reset the form to original state
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Call resetForm()

    End Sub
    ''' <summary>
    ''' Button used to enter new data and prompt to calculate the average
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim unitsInput As String = txtUnitInput.Text


        For day As Integer = 1 To 7 Step +1

            If (unitInputValidation(unitsInput)) Then

                Call updateDataEmployeeOne()

                If (day < 7) Then

                    day = day + 1
                    lblDayCounter.Text = "Day " + day.ToString

                Else

                    ' average units calc

                End If

            End If

        Next
        ' If (unitInputValidation(unitsInput)) Then



        ' (day < 7) Then

        '  day = day + 1
        'lblDayCounter.Text = "Day " + day.ToString

        '   Else


        ' End If

        ' End If
        ' send to validation

        ' add to array

        'print in display from array value 

        '+1 to counter up to 7 or to certain array field if possible

        ' when 7 inputs for employee 1 send to avg calc

        ' display avg calc

        ' change focus to employee 2 make bold do same as emp 1

        ' when all done avg and display comp avg

        ' disallow further inputs



    End Sub

    'validation - error msg box

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Function unitInputValidation(ByVal input As String) As Boolean

        Dim inputInteger As Integer
        Dim validOui As Boolean = False

        If (inputInteger = CInt(input)) Then

            MessageBox.Show(ERROR_MESSAGE_DATA_TYPE)

            If (input.Equals(inputInteger.ToString)) Then

                MessageBox.Show(ERROR_MESSAGE_NOT_WHOLE_NUMBER)

                If (inputInteger >= MIN_INPUT And inputInteger <= MAX_INPUT) Then

                    MessageBox.Show(ERROR_MESSAGE_RANGE)

                Else

                    validOui = True

                End If

            End If

        End If

        unitInputValidation = validOui

        'Dim unitInput As Integer

        'If CBool(CInt(input)) Then

        'MessageBox.Show(ERROR_MESSAGE_DATA_TYPE)

        'If (input >= MIN_INPUT And input <= MAX_INPUT) Then

        ' MessageBox.Show(ERROR_MESSAGE_RANGE)

        '   End If

        ' End If

    End Function

    'array

    'average employee calc
    ' Function averageEmployeeUnit(By Val )
    'average per day calc

    'program flow

    'reset form


    ''' <summary>
    ''' 
    ''' </summary>
    Sub resetForm()

        'return lblDayCounter to "Day 1"
        day = 1
        'return bold highlight to "Employee 1"





        'return input to "lblEmployeeOne" 
        'return focus to "lblUnits"
        'Clear array data
        Array.Clear(employeeOne, 0, employeeOne.Length)
        Array.Clear(employeeTwo, 0, employeeTwo.Length)
        Array.Clear(employeeThree, 0, employeeThree.Length)
        'clear "txtEmployeeOneInput"
        txtEmployeeOneInput.Text = ""
        'clear "txtEmployeeTwoInput"
        txtEmployeeTwoInput.Text = ""
        'clear "txtEmployeeThreeInput"
        txtEmployeeThreeInput.Text = ""
        'clear "lblEmployeeOneAverage"
        lblEmployeeOneAverage.Text = ""
        'clear "lblEmployeeTwoAverage"
        lblEmployeeTwoAverage.Text = ""
        'clear "lblEmployeeThreeAverage"
        lblEmployeeThreeAverage.Text = ""
        'clear "lblAverageShippedDaily"
        lblAverageShippedDaily.Text = ""
        'clear variables???




    End Sub


    Sub updateDataEmployeeOne()
        Dim outputOne As String = ""

        For counter As Integer = 1 To day Step 1

            outputOne += employeeOne(counter - 1).ToString + vbCrLf

        Next

        txtEmployeeOneInput.Text = outputOne

    End Sub

    Sub updateDataEmployeeTwo()
        Dim outputTwo As String = ""

        For counter As Integer = 1 To day Step 1

            outputTwo += employeeTwo(counter - 1).ToString + vbCrLf

        Next

        txtEmployeeTwoInput.Text = outputTwo

    End Sub

    Sub updateDataEmployeeThree()
        Dim outputThree As String = ""

        For counter As Integer = 1 To day Step 1

            outputThree += employeeThree(counter - 1).ToString + vbCrLf

        Next

        txtEmployeeThreeInput.Text = outputThree

    End Sub

End Class
