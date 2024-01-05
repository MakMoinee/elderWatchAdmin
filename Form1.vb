
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
        batchProcess.Kill()

    End Sub
End Class
