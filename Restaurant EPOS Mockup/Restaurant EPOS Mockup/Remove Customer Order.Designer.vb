<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Remove_Customer_Order
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
        Me.ListBoxOrders = New System.Windows.Forms.ListBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnRemoveOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxOrders
        '
        Me.ListBoxOrders.FormattingEnabled = True
        Me.ListBoxOrders.Location = New System.Drawing.Point(12, 64)
        Me.ListBoxOrders.Name = "ListBoxOrders"
        Me.ListBoxOrders.Size = New System.Drawing.Size(188, 329)
        Me.ListBoxOrders.TabIndex = 0
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
        'BtnRemoveOrder
        '
        Me.BtnRemoveOrder.Location = New System.Drawing.Point(245, 82)
        Me.BtnRemoveOrder.Name = "BtnRemoveOrder"
        Me.BtnRemoveOrder.Size = New System.Drawing.Size(87, 41)
        Me.BtnRemoveOrder.TabIndex = 2
        Me.BtnRemoveOrder.Text = "Remove Order"
        Me.BtnRemoveOrder.UseVisualStyleBackColor = True
        '
        'Remove_Customer_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnRemoveOrder)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.ListBoxOrders)
        Me.Name = "Remove_Customer_Order"
        Me.Text = "Remove_Customer_Order"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxOrders As ListBox
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnRemoveOrder As Button
End Class
