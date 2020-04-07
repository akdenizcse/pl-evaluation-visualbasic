<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CompaniesForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lstProducts = New System.Windows.Forms.ListView()
        Me.lblCompanyId = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Location = New System.Drawing.Point(39, 30)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(108, 17)
        Me.lblCompanyName.TabIndex = 0
        Me.lblCompanyName.Text = "Company Name"
        '
        'lstProducts
        '
        Me.lstProducts.HideSelection = False
        Me.lstProducts.Location = New System.Drawing.Point(232, 30)
        Me.lstProducts.Name = "lstProducts"
        Me.lstProducts.Size = New System.Drawing.Size(330, 340)
        Me.lstProducts.TabIndex = 1
        Me.lstProducts.UseCompatibleStateImageBehavior = False
        '
        'lblCompanyId
        '
        Me.lblCompanyId.AutoSize = True
        Me.lblCompanyId.Location = New System.Drawing.Point(42, 68)
        Me.lblCompanyId.Name = "lblCompanyId"
        Me.lblCompanyId.Size = New System.Drawing.Size(0, 17)
        Me.lblCompanyId.TabIndex = 2
        '
        'CompaniesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCompanyId)
        Me.Controls.Add(Me.lstProducts)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Name = "CompaniesForm"
        Me.Text = "CompaniesForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCompanyName As Label
    Friend WithEvents lstProducts As ListView
    Friend WithEvents lblCompanyId As Label
End Class
