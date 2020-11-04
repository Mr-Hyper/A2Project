<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayByCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayByCard))
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnSubmitPaym = New System.Windows.Forms.Button()
        Me.TxtBoxOrderDetails = New System.Windows.Forms.TextBox()
        Me.LblFYI = New System.Windows.Forms.Label()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.LblGBPSign1 = New System.Windows.Forms.Label()
        Me.TxtBoxAmountGiven = New System.Windows.Forms.TextBox()
        Me.LblAmountGiven = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(12, 12)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 1
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnSubmitPaym
        '
        Me.BtnSubmitPaym.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmitPaym.Location = New System.Drawing.Point(35, 285)
        Me.BtnSubmitPaym.Name = "BtnSubmitPaym"
        Me.BtnSubmitPaym.Size = New System.Drawing.Size(116, 67)
        Me.BtnSubmitPaym.TabIndex = 16
        Me.BtnSubmitPaym.Text = "Submit Payment"
        Me.BtnSubmitPaym.UseVisualStyleBackColor = True
        '
        'TxtBoxOrderDetails
        '
        Me.TxtBoxOrderDetails.Location = New System.Drawing.Point(194, 46)
        Me.TxtBoxOrderDetails.Multiline = True
        Me.TxtBoxOrderDetails.Name = "TxtBoxOrderDetails"
        Me.TxtBoxOrderDetails.ReadOnly = True
        Me.TxtBoxOrderDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtBoxOrderDetails.Size = New System.Drawing.Size(239, 341)
        Me.TxtBoxOrderDetails.TabIndex = 11
        Me.TxtBoxOrderDetails.WordWrap = False
        '
        'LblFYI
        '
        Me.LblFYI.AutoSize = True
        Me.LblFYI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFYI.Location = New System.Drawing.Point(9, 49)
        Me.LblFYI.Name = "LblFYI"
        Me.LblFYI.Size = New System.Drawing.Size(86, 13)
        Me.LblFYI.TabIndex = 17
        Me.LblFYI.Text = "FYI Text Here"
        Me.LblFYI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Location = New System.Drawing.Point(59, 221)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(80, 23)
        Me.BtnConfirm.TabIndex = 21
        Me.BtnConfirm.Text = "Confirm"
        Me.BtnConfirm.UseVisualStyleBackColor = True
        '
        'LblGBPSign1
        '
        Me.LblGBPSign1.AutoSize = True
        Me.LblGBPSign1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGBPSign1.Location = New System.Drawing.Point(16, 195)
        Me.LblGBPSign1.Name = "LblGBPSign1"
        Me.LblGBPSign1.Size = New System.Drawing.Size(19, 20)
        Me.LblGBPSign1.TabIndex = 20
        Me.LblGBPSign1.Text = "£"
        '
        'TxtBoxAmountGiven
        '
        Me.TxtBoxAmountGiven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBoxAmountGiven.Location = New System.Drawing.Point(35, 195)
        Me.TxtBoxAmountGiven.Name = "TxtBoxAmountGiven"
        Me.TxtBoxAmountGiven.Size = New System.Drawing.Size(131, 20)
        Me.TxtBoxAmountGiven.TabIndex = 19
        '
        'LblAmountGiven
        '
        Me.LblAmountGiven.AutoSize = True
        Me.LblAmountGiven.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountGiven.Location = New System.Drawing.Point(39, 171)
        Me.LblAmountGiven.Name = "LblAmountGiven"
        Me.LblAmountGiven.Size = New System.Drawing.Size(127, 20)
        Me.LblAmountGiven.TabIndex = 18
        Me.LblAmountGiven.Text = "Amount Given:"
        '
        'PayByCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 399)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.LblGBPSign1)
        Me.Controls.Add(Me.TxtBoxAmountGiven)
        Me.Controls.Add(Me.LblAmountGiven)
        Me.Controls.Add(Me.LblFYI)
        Me.Controls.Add(Me.BtnSubmitPaym)
        Me.Controls.Add(Me.TxtBoxOrderDetails)
        Me.Controls.Add(Me.BtnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PayByCard"
        Me.Text = "Pay By Card"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnSubmitPaym As Button
    Friend WithEvents TxtBoxOrderDetails As TextBox
    Friend WithEvents LblFYI As Label
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents LblGBPSign1 As Label
    Friend WithEvents TxtBoxAmountGiven As TextBox
    Friend WithEvents LblAmountGiven As Label
End Class
