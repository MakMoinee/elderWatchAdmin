Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class frmCredentials
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please Don't Leave Empty Fields")
        Else
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            config.AppSettings.Settings.Remove("Username")
            config.AppSettings.Settings.Add("Username", txtUsername.Text)
            config.AppSettings.Settings.Remove("Password")
            config.AppSettings.Settings.Add("Password", txtPassword.Text)
            config.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("appSettings")
            MessageBox.Show("Credentials set successfully!")
            Me.Close()
        End If


    End Sub
End Class