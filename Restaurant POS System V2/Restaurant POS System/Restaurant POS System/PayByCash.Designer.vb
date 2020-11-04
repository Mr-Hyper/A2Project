<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayByCash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayByCash))
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.TxtBoxOrderDetails = New System.Windows.Forms.TextBox()
        Me.LblAmountGiven = New System.Windows.Forms.Label()
        Me.TxtBoxAmountGiven = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSubmitPaym = New System.Windows.Forms.Button()
        Me.WatchTypingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LblGBPSign1 = New System.Windows.Forms.Label()
        Me.LblGBPSign2 = New System.Windows.Forms.Label()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.TxtBoxChangeDue = New System.Windows.Forms.TextBox()
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
        'TxtBoxOrderDetails
        '
        Me.TxtBoxOrderDetails.Location = New System.Drawing.Point(194, 46)
        Me.TxtBoxOrderDetails.Multiline = True
        Me.TxtBoxOrderDetails.Name = "TxtBoxOrderDetails"
        Me.TxtBoxOrderDetails.ReadOnly = True
        Me.TxtBoxOrderDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtBoxOrderDetails.Size = New System.Drawing.Size(239, 341)
        Me.TxtBoxOrderDetails.TabIndex = 2
        Me.TxtBoxOrderDetails.WordWrap = False
        '
        'LblAmountGiven
        '
        Me.LblAmountGiven.AutoSize = True
        Me.LblAmountGiven.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAmountGiven.Location = New System.Drawing.Point(35, 89)
        Me.LblAmountGiven.Name = "LblAmountGiven"
        Me.LblAmountGiven.Size = New System.Drawing.Size(127, 20)
        Me.LblAmountGiven.TabIndex = 3
        Me.LblAmountGiven.Text = "Amount Given:"
        '
        'TxtBoxAmountGiven
        '
        Me.TxtBoxAmountGiven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBoxAmountGiven.Location = New System.Drawing.Point(31, 113)
        Me.TxtBoxAmountGiven.Name = "TxtBoxAmountGiven"
        Me.TxtBoxAmountGiven.Size = New System.Drawing.Size(131, 20)
        Me.TxtBoxAmountGiven.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Change Due:"
        '
        'BtnSubmitPaym
        '
        Me.BtnSubmitPaym.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmitPaym.Location = New System.Drawing.Point(39, 272)
        Me.BtnSubmitPaym.Name = "BtnSubmitPaym"
        Me.BtnSubmitPaym.Size = New System.Drawing.Size(116, 67)
        Me.BtnSubmitPaym.TabIndex = 7
        Me.BtnSubmitPaym.Text = "Submit Payment"
        Me.BtnSubmitPaym.UseVisualStyleBackColor = True
        '
        'WatchTypingTimer
        '
        Me.WatchTypingTimer.Interval = 1000
        '
        'LblGBPSign1
        '
        Me.LblGBPSign1.AutoSize = True
        Me.LblGBPSign1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGBPSign1.Location = New System.Drawing.Point(12, 113)
        Me.LblGBPSign1.Name = "LblGBPSign1"
        Me.LblGBPSign1.Size = New System.Drawing.Size(19, 20)
        Me.LblGBPSign1.TabIndex = 8
        Me.LblGBPSign1.Text = "£"
        '
        'LblGBPSign2
        '
        Me.LblGBPSign2.AutoSize = True
        Me.LblGBPSign2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGBPSign2.Location = New System.Drawing.Point(12, 212)
        Me.LblGBPSign2.Name = "LblGBPSign2"
        Me.LblGBPSign2.Size = New System.Drawing.Size(19, 20)
        Me.LblGBPSign2.TabIndex = 9
        Me.LblGBPSign2.Text = "£"
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Location = New System.Drawing.Point(55, 139)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(80, 23)
        Me.BtnConfirm.TabIndex = 10
        Me.BtnConfirm.Text = "Confirm"
        Me.BtnConfirm.UseVisualStyleBackColor = True
        '
        'TxtBoxChangeDue
        '
        Me.TxtBoxChangeDue.Location = New System.Drawing.Point(31, 211)
        Me.TxtBoxChangeDue.Multiline = True
        Me.TxtBoxChangeDue.Name = "TxtBoxChangeDue"
        Me.TxtBoxChangeDue.ReadOnly = True
        Me.TxtBoxChangeDue.Size = New System.Drawing.Size(133, 21)
        Me.TxtBoxChangeDue.TabIndex = 6
        '
        'PayByCash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 399)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.LblGBPSign2)
        Me.Controls.Add(Me.LblGBPSign1)
        Me.Controls.Add(Me.BtnSubmitPaym)
        Me.Controls.Add(Me.TxtBoxChangeDue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtBoxAmountGiven)
        Me.Controls.Add(Me.LblAmountGiven)
        Me.Controls.Add(Me.TxtBoxOrderDetails)
        Me.Controls.Add(Me.BtnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PayByCash"
        Me.ShowInTaskbar = False
        Me.Text = "Pay By Cash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents TxtBoxOrderDetails As TextBox
    Friend WithEvents LblAmountGiven As Label
    Friend WithEvents TxtBoxAmountGiven As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSubmitPaym As Button
    Friend WithEvents WatchTypingTimer As Timer
    Friend WithEvents LblGBPSign1 As Label
    Friend WithEvents LblGBPSign2 As Label
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents TxtBoxChangeDue As TextBox
End Class
