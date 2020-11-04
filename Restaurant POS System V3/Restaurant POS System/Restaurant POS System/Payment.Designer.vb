<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.LblPayingForString = New System.Windows.Forms.Label()
        Me.LblOrderToPayFor = New System.Windows.Forms.Label()
        Me.BtnPayByCash = New System.Windows.Forms.Button()
        Me.BtnPayByCard = New System.Windows.Forms.Button()
        Me.GrpBoxPaymOps = New System.Windows.Forms.GroupBox()
        Me.GrpBoxPaymOps.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(13, 13)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 0
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'LblPayingForString
        '
        Me.LblPayingForString.AutoSize = True
        Me.LblPayingForString.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPayingForString.Location = New System.Drawing.Point(37, 51)
        Me.LblPayingForString.Name = "LblPayingForString"
        Me.LblPayingForString.Size = New System.Drawing.Size(235, 25)
        Me.LblPayingForString.TabIndex = 1
        Me.LblPayingForString.Text = "Paying for: Order No."
        '
        'LblOrderToPayFor
        '
        Me.LblOrderToPayFor.AutoSize = True
        Me.LblOrderToPayFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrderToPayFor.Location = New System.Drawing.Point(264, 51)
        Me.LblOrderToPayFor.Name = "LblOrderToPayFor"
        Me.LblOrderToPayFor.Size = New System.Drawing.Size(25, 25)
        Me.LblOrderToPayFor.TabIndex = 2
        Me.LblOrderToPayFor.Text = "0"
        '
        'BtnPayByCash
        '
        Me.BtnPayByCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPayByCash.Location = New System.Drawing.Point(32, 18)
        Me.BtnPayByCash.Name = "BtnPayByCash"
        Me.BtnPayByCash.Size = New System.Drawing.Size(104, 74)
        Me.BtnPayByCash.TabIndex = 3
        Me.BtnPayByCash.Text = "Pay By Cash"
        Me.BtnPayByCash.UseVisualStyleBackColor = True
        '
        'BtnPayByCard
        '
        Me.BtnPayByCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPayByCard.Location = New System.Drawing.Point(172, 18)
        Me.BtnPayByCard.Name = "BtnPayByCard"
        Me.BtnPayByCard.Size = New System.Drawing.Size(104, 74)
        Me.BtnPayByCard.TabIndex = 4
        Me.BtnPayByCard.Text = "Pay By Card"
        Me.BtnPayByCard.UseVisualStyleBackColor = True
        '
        'GrpBoxPaymOps
        '
        Me.GrpBoxPaymOps.Controls.Add(Me.BtnPayByCard)
        Me.GrpBoxPaymOps.Controls.Add(Me.BtnPayByCash)
        Me.GrpBoxPaymOps.Location = New System.Drawing.Point(10, 90)
        Me.GrpBoxPaymOps.Name = "GrpBoxPaymOps"
        Me.GrpBoxPaymOps.Size = New System.Drawing.Size(307, 102)
        Me.GrpBoxPaymOps.TabIndex = 5
        Me.GrpBoxPaymOps.TabStop = False
        Me.GrpBoxPaymOps.Text = "Please select a Payment Option:"
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 201)
        Me.Controls.Add(Me.LblOrderToPayFor)
        Me.Controls.Add(Me.LblPayingForString)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.GrpBoxPaymOps)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Payment"
        Me.ShowInTaskbar = False
        Me.Text = "Payment"
        Me.GrpBoxPaymOps.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents LblPayingForString As Label
    Friend WithEvents LblOrderToPayFor As Label
    Friend WithEvents BtnPayByCash As Button
    Friend WithEvents BtnPayByCard As Button
    Friend WithEvents GrpBoxPaymOps As GroupBox
End Class
