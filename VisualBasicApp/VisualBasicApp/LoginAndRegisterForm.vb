Public Class LoginAndRegisterForm
    Dim efUserDAL As UserDal
    Public Shared userId As Integer
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As User = efUserDAL.Login(txtLoginEmail.Text, txtLoginPassword.Text)
        If user.UserId = 0 Then
            lblInfo.Text = "User cannot found! Please try again."
        Else
            MessageBox.Show("Welcome!")
            userId = user.UserId
            Dim changeForm As New CompaniesForm
            changeForm.Show()

        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim newUser As User
        newUser.Email = txtRegisterEmail.Text
        newUser.Password = txtRegisterPassword.Text
        efUserDAL.Add(newUser)
        MessageBox.Show("Welcome!")
        userId = newUser.UserId
        Dim changeForm As New CompaniesForm
        changeForm.Show()
    End Sub
End Class

