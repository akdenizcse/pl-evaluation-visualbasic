Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Product
    Public Property ProductId As Integer

    <StringLength(100)>
    Public Property ProductName As String

    Public Property CompanyId As Integer?

    Public Overridable Property Company As Company
End Class

