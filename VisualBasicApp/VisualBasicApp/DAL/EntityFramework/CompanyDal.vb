Public Class CompanyDal
    Public model As VBModel

    Public Function Add(Company As Company)
        model.Companies.Add(Company)
        model.SaveChanges()
    End Function

    Public Function Remove(companyId As Integer)
        Dim companyModel As Company = model.Companies.Find(companyId)
        model.Companies.Remove(companyModel)
        model.SaveChanges()
    End Function

    Public Function Update(Company As Company)
        Dim editToCompany As Company = model.Companies.Find(Company.CompanyId)
        editToCompany.CompanyName = Company.CompanyName
        model.SaveChanges()
    End Function

    Public Function GetCompany(companyId As Integer) As Company
        Dim company As Company = model.Companies.Find(companyId)
        Return company
    End Function

    Public Function GetUserCompany(userId As Integer) As Company
        Dim company As Company = From comp In model.Companies.ToList()
                                 Where comp.UserId = userId
                                 Select (comp.CompanyId, comp.CompanyName)
        Return company
    End Function

End Class
