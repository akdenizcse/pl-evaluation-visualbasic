Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Company
    Public Sub New()
        Products = New HashSet(Of Product)()
    End Sub

    Public Property CompanyId As Integer

    <StringLength(100)>
    Public Property CompanyName As String

    Public Property UserId As Integer?

    Public Overridable Property User As User

    Public Overridable Property Products As ICollection(Of Product)
End Class
