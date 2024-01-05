<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnStartService = New Button()
        Label1 = New Label()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' btnStartService
        ' 
        btnStartService.Location = New Point(55, 135)
        btnStartService.Name = "btnStartService"
        btnStartService.Size = New Size(314, 94)
        btnStartService.TabIndex = 0
        btnStartService.Text = "Start Service"
        btnStartService.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(200, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(336, 50)
        Label1.TabIndex = 1
        Label1.Text = "Elder Watch Admin"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(388, 135)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(314, 94)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(770, 291)
        Controls.Add(btnLogin)
        Controls.Add(Label1)
        Controls.Add(btnStartService)
        MaximizeBox = False
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStartService As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button

End Class
