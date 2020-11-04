<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Orders_Menu
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
        Me.BtnAddOrder = New System.Windows.Forms.Button()
        Me.BtnRemoveOrder = New System.Windows.Forms.Button()
        Me.BtnEditOrder = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.LblSelActCOM = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnAddOrder
        '
        Me.BtnAddOrder.Location = New System.Drawing.Point(48, 190)
        Me.BtnAddOrder.Name = "BtnAddOrder"
        Me.BtnAddOrder.Size = New System.Drawing.Size(137, 73)
        Me.BtnAddOrder.TabIndex = 1
        Me.BtnAddOrder.Text = "Add Order"
        Me.BtnAddOrder.UseVisualStyleBackColor = True
        '
        'BtnRemoveOrder
        '
        Me.BtnRemoveOrder.Location = New System.Drawing.Point(332, 190)
        Me.BtnRemoveOrder.Name = "BtnRemoveOrder"
        Me.BtnRemoveOrder.Size = New System.Drawing.Size(137, 73)
        Me.BtnRemoveOrder.TabIndex = 1
        Me.BtnRemoveOrder.Text = "Remove Order"
        Me.BtnRemoveOrder.UseVisualStyleBackColor = True
        '
        'BtnEditOrder
        '
        Me.BtnEditOrder.Location = New System.Drawing.Point(615, 190)
        Me.BtnEditOrder.Name = "BtnEditOrder"
        Me.BtnEditOrder.Size = New System.Drawing.Size(137, 73)
        Me.BtnEditOrder.TabIndex = 1
        Me.BtnEditOrder.Text = "Edit Order"
        Me.BtnEditOrder.UseVisualStyleBackColor = True
        '
        'BtnHome
        '
        Me.BtnHome.Location = New System.Drawing.Point(12, 12)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(75, 23)
        Me.BtnHome.TabIndex = 2
        Me.BtnHome.Text = "Home"
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'LblSelActCOM
        '
        Me.LblSelActCOM.AutoSize = True
        Me.LblSelActCOM.Location = New System.Drawing.Point(285, 105)
        Me.LblSelActCOM.Name = "LblSelActCOM"
        Me.LblSelActCOM.Size = New System.Drawing.Size(216, 13)
        Me.LblSelActCOM.TabIndex = 3
        Me.LblSelActCOM.Text = "Select the action you would like to carry out:"
        '
        'Customer_Orders_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblSelActCOM)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.BtnEditOrder)
        Me.Controls.Add(Me.BtnRemoveOrder)
        Me.Controls.Add(Me.BtnAddOrder)
        Me.Name = "Customer_Orders_Menu"
        Me.Text = "Customer_Orders_Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAddOrder As Button
    Friend WithEvents BtnRemoveOrder As Button
    Friend WithEvents BtnEditOrder As Button
    Friend WithEvents BtnHome As Button
    Friend WithEvents LblSelActCOM As Label
End Class
