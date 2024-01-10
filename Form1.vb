
Imports System.Configuration
Imports System.Diagnostics
Public Class frmMain
    Private batchProcess As Process
    Private Sub btnStartService_Click(sender As Object, e As EventArgs) Handles btnStartService.Click
        Try
            Dim batchProcessName As String = "start.bat"

            ' Check if the batch file process is already running
            If IsProcessRunning(batchProcessName) Then
                MessageBox.Show("The process is already running.")
                ' Disable the Start Service button
                btnStartService.Enabled = False
            Else
                Dim batchFilePath As String = "C:\Users\Brian\Documents\elderWatchAI\"

                batchProcess = New Process()
                batchProcess.StartInfo.FileName = "cmd.exe"
                batchProcess.StartInfo.Arguments = "/k cd /d C:\Users\Brian\Documents\elderWatchAI && " & batchFilePath & batchProcessName & ""
                batchProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
                batchProcess.Start()

                ' process.WaitForExit()

                ' Enable the Start Service button after the process finishes
                btnStartService.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckIfBatchFileIsRunning()
    End Sub

    Private Sub CheckIfBatchFileIsRunning()
        Dim batchProcessName As String = "start.bat"
        If IsProcessRunning(batchProcessName) Then
            MessageBox.Show("The process is already running.")
            ' Disable the Start Service button
            btnStartService.Enabled = False
        Else
            ' Enable the Start Service button
            btnStartService.Enabled = True
        End If
    End Sub

    Private Function IsProcessRunning(processName As String) As Boolean
        Dim processes() As Process = Process.GetProcessesByName(processName)
        Return processes.Length > 0
    End Function

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            batchProcess.Kill()
        Catch ex As Exception

        End Try
        Application.Exit()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = ConfigurationManager.AppSettings("Username")
        Dim password As String = ConfigurationManager.AppSettings("Password")

        If username Is Nothing And password Is Nothing Then
            Dim frmC As New frmCredentials
            frmC.Show()
        Else
            Dim frmL As New frmLogin
            If frmL.ShowDialog() <> DialogResult.OK Then
                frmL.Hide()
            Else
                frmL.Hide()
                Me.Hide()
                Dim frmM As New frmMainForm
                If frmM.ShowDialog() <> DialogResult.OK Then
                    frmM.Hide()
                    Me.Show()
                Else
                    frmM.Hide()
                End If


            End If

        End If
    End Sub
End Class
