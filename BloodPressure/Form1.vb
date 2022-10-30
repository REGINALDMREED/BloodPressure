Public Class frmBloodPressure
    ''Class level variables
    Public Shared _intSizeOfArray As Integer = 16
    Public Shared _strPatientNames(_intSizeOfArray) As String
    Public Shared _strPatientId(_intSizeOfArray) As String
    Public Shared _intSystolic(_intSizeOfArray) As Integer

    Private Sub frmBloodPressure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event reads the patient text file and
        'intilize an instance of the StreamReader object and declare vaiables
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "C:\Users\Reed\Source\Repos\mtc-ist\cpt185chapter08hw-REGINALDMREED-3\BloodPressure\patient.txt"
        Dim intCount As Integer = 0
        Dim strFileError As String = "The file is not available. Restart when file is available."

        'Verify the file exists
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            'Read the file lin by line until the file is comleted
            Do While objReader.Peek <> -1
                _strPatientNames(intCount) = objReader.ReadLine()
                _strPatientId(intCount) = objReader.ReadLine()
                Console.WriteLine(_strPatientNames(intCount))
                Console.WriteLine(_strPatientId(intCount))
                Console.WriteLine(_intSystolic(intCount))
                intCount += 1
            Loop
            objReader.Close()
        Else
            MsgBox(strFileError,, "Error")
            Close()
        End If

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'This event writes consult text file line by line
        'Who have systolic level above 120
        'displays number of patients and average
        'systolic level
        'Declae variables

        Dim objWriter As New IO.StreamWriter("C:\Users\Reed\Source\Repos\mtc-ist\cpt185chapter08hw-REGINALDMREED-3\BloodPressure\consult.tx")
        Dim intCount As Integer = 0
        Dim intTotal As Integer = 0
        Dim intNum As Integer = 0
        Dim decAvg As Decimal
        For intCount = 0 To (_intSystolic.Length - 1)
            'intScores(inCount) = InputBox("Enter #" & (inCount + 1) & "Score of Semester", " Score of Semester")

            If _intSystolic(intCount) > 120 Then
                If IO.File.Exists("C:\Users\Reed\Source\Repos\mtc-ist\cpt185chapter08hw-REGINALDMREED-3\BloodPressure\patient.tx") Then
                    'Write the file line by line until the file is completed
                    objWriter.WriteLine(_strPatientNames(intCount))
                    objWriter.WriteLine(_intSystolic(intCount))
                    intNum += 1
                Else
                    MsgBox("The file is not available. Restart the program when the file is available",, "Error")
                    Close()
                End If
            End If
            intTotal += _intSystolic(intCount)


        Next
        'The file is closed
        objWriter.Close()
        'calculate Average systolic value of todays patient
        decAvg = intTotal / _intSystolic.Length
        'Display number of patient who had a systolic level above 120
        lblDisplayNum.Text = "The Number of Patients who had a Systolic level above 120 is" & vbNewLine & intNum.ToString()
        'Display Average systolic value of today's patient
        lblDisplayAvg.Text = "The Average Systolic of today's patients is" & decAvg.ToString("N2")
    End Sub

    Private Sub mnuDisplay_Click(sender As Object, e As EventArgs) Handles mnuDisplay.Click
        'this event display patient info in second form
        Dim frmSecond As New frmDisplayPatientInfo
        'Hide the form and show the display patient info
        Hide()
        frmSecond.ShowDialog()
    End Sub

    Private Sub mnuclear_Click(sender As Object, e As EventArgs) Handles mnuclear.Click
        'this event refresh the form objects
        lblDisplayNum.Text = ""
        lblDisplayAvg.Text = ""
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'This event close the application
        Application.Exit()
    End Sub
End Class
