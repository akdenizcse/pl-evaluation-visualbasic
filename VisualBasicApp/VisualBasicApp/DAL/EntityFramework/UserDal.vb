Public Class UserDal
    Public model As VBModel

    Public Function Add(User As User)
        model.Users.Add(User)
        model.SaveChanges()
    End Function

    Public Function Remove(userId As Integer)
        Dim userModel As User = model.Users.Find(userId)
        model.Users.Remove(userModel)
        model.SaveChanges()
    End Function

    Public Function Update(user As User)
        Dim editToUser As User = model.Users.Find(user.UserId)
        editToUser.Email = user.Email
        editToUser.Password = user.Password
        model.SaveChanges()
    End Function

    Public Function GetUser(userId As Integer) As User
        Dim user As User = model.Users.Find(userId)
        Return user
    End Function

    Public Function Login(email As String, password As String) As User

        Dim queryResults = From user In model.Users.ToList()
                           Where user.Password = password
                           Where user.Email = email
                           Select (user.UserId, user.Email, user.Password)

        Return queryResults
    End Function

End Class
