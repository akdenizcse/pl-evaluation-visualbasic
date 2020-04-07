Public Class ProductDal
    Public model As VBModel

    Public Function Add(product As Product)
        model.Products.Add(product)
        model.SaveChanges()
    End Function

    Public Function Remove(productId As Integer)
        Dim productModel As Product = model.Products.Find(productId)
        model.Products.Remove(productModel)
        model.SaveChanges()
    End Function

    Public Function Update(product As Product)
        Dim editToProduct As Product = model.Products.Find(product.ProductId)
        editToProduct.ProductName = product.ProductName
        model.SaveChanges()
    End Function

    Public Function GetProduct(productId As Integer) As Product
        Dim product As Product = model.Products.Find(productId)
        Return product
    End Function

    Public Function GetProducts(companyId As Integer) As List(Of Product)
        Dim products As List(Of Product) = From prod In model.Products.ToList()
                                           Where prod.CompanyId = companyId
                                           Select (prod.ProductId, prod.ProductName)
        Return products
    End Function

End Class
