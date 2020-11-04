<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnCustOrd = New System.Windows.Forms.Button()
        Me.BtnSalesAcc = New System.Windows.Forms.Button()
        Me.BtnSettings = New System.Windows.Forms.Button()
        Me.LblSelActMM = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCustOrd
        '
        Me.BtnCustOrd.Location = New System.Drawing.Point(41, 162)
        Me.BtnCustOrd.Name = "BtnCustOrd"
        Me.BtnCustOrd.Size = New System.Drawing.Size(137, 73)
        Me.BtnCustOrd.TabIndex = 0
        Me.BtnCustOrd.Text = "Customer Orders"
        Me.BtnCustOrd.UseVisualStyleBackColor = True
        '
        'BtnSalesAcc
        '
        Me.BtnSalesAcc.Location = New System.Drawing.Point(295, 162)
        Me.BtnSalesAcc.Name = "BtnSalesAcc"
        Me.BtnSalesAcc.Size = New System.Drawing.Size(137, 73)
        Me.BtnSalesAcc.TabIndex = 0
        Me.BtnSalesAcc.Text = "Sales Accounting"
        Me.BtnSalesAcc.UseVisualStyleBackColor = True
        '
        'BtnSettings
        '
        Me.BtnSettings.Location = New System.Drawing.Point(553, 162)
        Me.BtnSettings.Name = "BtnSettings"
        Me.BtnSettings.Size = New System.Drawing.Size(137, 73)
        Me.BtnSettings.TabIndex = 0
        Me.BtnSettings.Text = "Settings"
        Me.BtnSettings.UseVisualStyleBackColor = True
        '
        'LblSelActMM
        '
        Me.LblSelActMM.AutoSize = True
        Me.LblSelActMM.Location = New System.Drawing.Point(283, 77)
        Me.LblSelActMM.Name = "LblSelActMM"
        Me.LblSelActMM.Size = New System.Drawing.Size(165, 13)
        Me.LblSelActMM.TabIndex = 1
        Me.LblSelActMM.Text = "What would you like to do today?"
        Me.LblSelActMM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 419)
        Me.Controls.Add(Me.LblSelActMM)
        Me.Controls.Add(Me.BtnSettings)
        Me.Controls.Add(Me.BtnSalesAcc)
        Me.Controls.Add(Me.BtnCustOrd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCustOrd As Button
    Friend WithEvents BtnSalesAcc As Button
    Friend WithEvents BtnSettings As Button
    Friend WithEvents LblSelActMM As Label
End Class
