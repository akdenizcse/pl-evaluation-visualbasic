Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class User
    Public Sub New()
        Companies = New HashSet(Of Company)()
    End Sub

    Public Property UserId As Integer

    <StringLength(100)>
    Public Property Email As String

    <StringLength(100)>
    Public Property Password As String

    Public Overridable Property Companies As ICollection(Of Company)
End Class
