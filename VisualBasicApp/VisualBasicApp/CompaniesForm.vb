Public Class CompaniesForm
    Dim efCompanyDAL As CompanyDal
    Dim efProductDAL As ProductDal

    Dim userId As Integer = LoginAndRegisterForm.userId

    Public Sub Main()
        lblCompanyId.Text = efCompanyDAL.GetUserCompany(userId).CompanyId
        lblCompanyName.Text = efCompanyDAL.GetUserCompany(userId).CompanyName

        For Each item As Product In efProductDAL.GetProducts(efCompanyDAL.GetUserCompany(userId).CompanyId)
            lstProducts.Items.Add(item.ProductName)
        Next

    End Sub
End Class
