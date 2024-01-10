Imports System.Configuration

Public Class frmLogin
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please Don't Leave Empty Fields")
        Else
            Dim username As String = ConfigurationManager.AppSettings("Username")
            Dim password As String = ConfigurationManager.AppSettings("Password")

            If username.Equals(txtUsername.Text) And password.Equals(txtPassword.Text) Then
                MessageBox.Show("Login Successfully")
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub
End Class