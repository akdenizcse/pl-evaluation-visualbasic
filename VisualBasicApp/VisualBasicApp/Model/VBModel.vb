Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class VBModel
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=VBModel")
    End Sub

    Public Overridable Property Companies As DbSet(Of Company)
    Public Overridable Property Products As DbSet(Of Product)
    Public Overridable Property Users As DbSet(Of User)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    End Sub
End Class

