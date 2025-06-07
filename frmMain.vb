Public Class frmMain
    Dim actionTime As Date

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 23
            cboHours.Items.Add(i)
        Next

        For j As Integer = 1 To 59
            cboMinutes.Items.Add(j)
        Next
    End Sub

    Private Sub tmrDisplayTime_Tick(sender As Object, e As EventArgs) Handles tmrDisplayTime.Tick
        lblCurrentTime.Text = TimeOfDay.ToLongTimeString
    End Sub

    Private Sub tmrCheckActionTime_Tick(sender As Object, e As EventArgs) Handles tmrCheckActionTime.Tick
        If Now > actionTime Then
            If rdbLogOff.Checked = True Then
                Process.Start("Shutdown", " -l -t 01")
            ElseIf rdbRestart.Checked = True Then
                Process.Start("Shutdown", "-r -t 01")
            ElseIf rdbShutdown.Checked = True Then
                Process.Start("Shutdown", "-s -t 01")
            End If
            Application.Exit()
        End If
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        If CDec(cboHours.Text) > 0 Or CDec(cboMinutes.Text) > 0 Then
            actionTime = Now.AddMinutes(CDbl(cboHours.Text) * 60 + CDbl(cboMinutes.Text))
            tmrCheckActionTime.Enabled = True

            MessageBox.Show("Status: The action is initiated for " & actionTime.ToLongTimeString)
            Me.Text = "Status: The action is initiated for " & actionTime.ToLongTimeString
        Else
            MessageBox.Show("Status: Please set time")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        tmrCheckActionTime.Enabled = False

        MessageBox.Show("Status: The last action was cancelled")
        Me.Text = "Status: The last action was cancelled"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
