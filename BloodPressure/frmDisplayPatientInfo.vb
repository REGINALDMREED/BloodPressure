Public Class frmDisplayPatientInfo
    Private Sub frmDisplayPatientInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this event display patient info in listbox object
        Dim intItem As Integer = 0
        'Display the _strPatientNames
        For intItem = 0 To frmBloodPressure._strPatientNames.Length - 2
            lstDisplayInfo.Items.Add(frmBloodPressure._strPatientNames(intItem) _
             & " : " & frmBloodPressure._intSystolic(intItem))
        Next

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'this event returns in the main form
        Dim frmFirst As New frmBloodPressure
        Hide()
        frmFirst.ShowDialog()
    End Sub
End Class