<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginAndRegisterForm
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtLoginEmail = New System.Windows.Forms.TextBox()
        Me.txtLoginPassword = New System.Windows.Forms.TextBox()
        Me.lblLoginEmail = New System.Windows.Forms.Label()
        Me.lblLoginPassword = New System.Windows.Forms.Label()
        Me.lblRegisterPassword = New System.Windows.Forms.Label()
        Me.lblRegisterEmail = New System.Windows.Forms.Label()
        Me.txtRegisterPassword = New System.Windows.Forms.TextBox()
        Me.txtRegisterEmail = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtLoginEmail
        '
        Me.txtLoginEmail.Location = New System.Drawing.Point(181, 125)
        Me.txtLoginEmail.Name = "txtLoginEmail"
        Me.txtLoginEmail.Size = New System.Drawing.Size(100, 22)
        Me.txtLoginEmail.TabIndex = 0
        '
        'txtLoginPassword
        '
        Me.txtLoginPassword.Location = New System.Drawing.Point(181, 169)
        Me.txtLoginPassword.Name = "txtLoginPassword"
        Me.txtLoginPassword.Size = New System.Drawing.Size(100, 22)
        Me.txtLoginPassword.TabIndex = 1
        '
        'lblLoginEmail
        '
        Me.lblLoginEmail.AutoSize = True
        Me.lblLoginEmail.Location = New System.Drawing.Point(78, 125)
        Me.lblLoginEmail.Name = "lblLoginEmail"
        Me.lblLoginEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblLoginEmail.TabIndex = 2
        Me.lblLoginEmail.Text = "Email"
        '
        'lblLoginPassword
        '
        Me.lblLoginPassword.AutoSize = True
        Me.lblLoginPassword.Location = New System.Drawing.Point(78, 169)
        Me.lblLoginPassword.Name = "lblLoginPassword"
        Me.lblLoginPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblLoginPassword.TabIndex = 3
        Me.lblLoginPassword.Text = "Password"
        '
        'lblRegisterPassword
        '
        Me.lblRegisterPassword.AutoSize = True
        Me.lblRegisterPassword.Location = New System.Drawing.Point(521, 178)
        Me.lblRegisterPassword.Name = "lblRegisterPassword"
        Me.lblRegisterPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblRegisterPassword.TabIndex = 7
        Me.lblRegisterPassword.Text = "Password"
        '
        'lblRegisterEmail
        '
        Me.lblRegisterEmail.AutoSize = True
        Me.lblRegisterEmail.Location = New System.Drawing.Point(521, 134)
        Me.lblRegisterEmail.Name = "lblRegisterEmail"
        Me.lblRegisterEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblRegisterEmail.TabIndex = 6
        Me.lblRegisterEmail.Text = "Email"
        '
        'txtRegisterPassword
        '
        Me.txtRegisterPassword.Location = New System.Drawing.Point(624, 178)
        Me.txtRegisterPassword.Name = "txtRegisterPassword"
        Me.txtRegisterPassword.Size = New System.Drawing.Size(100, 22)
        Me.txtRegisterPassword.TabIndex = 5
        '
        'txtRegisterEmail
        '
        Me.txtRegisterEmail.Location = New System.Drawing.Point(624, 134)
        Me.txtRegisterEmail.Name = "txtRegisterEmail"
        Me.txtRegisterEmail.Size = New System.Drawing.Size(100, 22)
        Me.txtRegisterEmail.TabIndex = 4
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(181, 209)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(624, 228)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 9
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(144, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "LOGIN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(583, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "REGISTER"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(95, 265)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 17)
        Me.lblInfo.TabIndex = 12
        '
        'LoginAndRegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblRegisterPassword)
        Me.Controls.Add(Me.lblRegisterEmail)
        Me.Controls.Add(Me.txtRegisterPassword)
        Me.Controls.Add(Me.txtRegisterEmail)
        Me.Controls.Add(Me.lblLoginPassword)
        Me.Controls.Add(Me.lblLoginEmail)
        Me.Controls.Add(Me.txtLoginPassword)
        Me.Controls.Add(Me.txtLoginEmail)
        Me.Name = "LoginAndRegisterForm"
        Me.Text = "LoginAndRegisterForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLoginEmail As TextBox
    Friend WithEvents txtLoginPassword As TextBox
    Friend WithEvents lblLoginEmail As Label
    Friend WithEvents lblLoginPassword As Label
    Friend WithEvents lblRegisterPassword As Label
    Friend WithEvents lblRegisterEmail As Label
    Friend WithEvents txtRegisterPassword As TextBox
    Friend WithEvents txtRegisterEmail As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblInfo As Label
End Class
