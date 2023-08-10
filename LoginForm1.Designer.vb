<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents OK As Button
    Friend WithEvents Cancel As Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LoginForm1))
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        TxtUsername = New TextBox()
        TxtPassword = New TextBox()
        OK = New Button()
        Cancel = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.BackColor = Color.Transparent
        UsernameLabel.Location = New Point(186, 118)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(220, 23)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "Username"
        UsernameLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.BackColor = Color.Transparent
        PasswordLabel.Location = New Point(186, 237)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(220, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "Password"
        PasswordLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Location = New Point(186, 154)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(220, 23)
        TxtUsername.TabIndex = 1
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(186, 263)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(220, 23)
        TxtPassword.TabIndex = 3
        ' 
        ' OK
        ' 
        OK.Location = New Point(249, 310)
        OK.Name = "OK"
        OK.Size = New Size(94, 23)
        OK.TabIndex = 4
        OK.Text = "&Login"
        ' 
        ' Cancel
        ' 
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Location = New Point(512, 310)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 23)
        Cancel.TabIndex = 5
        Cancel.Text = "&Sair"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Gill Sans Ultra Bold", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(156, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(312, 69)
        Label1.TabIndex = 6
        Label1.Text = "FutWorld"
        ' 
        ' LoginForm1
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        CancelButton = Cancel
        ClientSize = New Size(618, 345)
        Controls.Add(Label1)
        Controls.Add(Cancel)
        Controls.Add(OK)
        Controls.Add(TxtPassword)
        Controls.Add(TxtUsername)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm1"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
End Class
