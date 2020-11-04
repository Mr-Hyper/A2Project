<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Customer_Order
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
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.ListBoxStarters = New System.Windows.Forms.ListBox()
        Me.LblStarters = New System.Windows.Forms.Label()
        Me.LblOrderNumTitle = New System.Windows.Forms.Label()
        Me.LblOrderNum = New System.Windows.Forms.Label()
        Me.GrpBoxDishes = New System.Windows.Forms.GroupBox()
        Me.BtnRemoveItem = New System.Windows.Forms.Button()
        Me.BtnSelQuantity = New System.Windows.Forms.Button()
        Me.BtnAddItem = New System.Windows.Forms.Button()
        Me.ListBoxOrderItems = New System.Windows.Forms.ListBox()
        Me.BtnSubmitOrder = New System.Windows.Forms.Button()
        Me.GrpBoxDishes.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(12, 12)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 0
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'ListBoxStarters
        '
        Me.ListBoxStarters.FormattingEnabled = True
        Me.ListBoxStarters.Items.AddRange(New Object() {"Aloo Matar Ki Tikka", "Bharwan Baigan", "Chicken Chat", "Chicken Pakora ", "Chicken Paneer Starter ", "Fish Kebab Starter", "Garlic Mushrooms", "King Prawn Butterfly", "Lamb Chops Starter", "Meat Mixed Starter for Two", "Mulligatawny Soup", "Onion Bhajee", "Prawn Cocktail", "Puri", "Samosa", "Stuffed Pepper with", "Sunheri Samosa", "Tandoori Chicken Starter", "Tikka Starter", "Veg Mixed Starter for Two"})
        Me.ListBoxStarters.Location = New System.Drawing.Point(6, 64)
        Me.ListBoxStarters.Name = "ListBoxStarters"
        Me.ListBoxStarters.Size = New System.Drawing.Size(151, 264)
        Me.ListBoxStarters.TabIndex = 1
        '
        'LblStarters
        '
        Me.LblStarters.AutoSize = True
        Me.LblStarters.Location = New System.Drawing.Point(73, 93)
        Me.LblStarters.Name = "LblStarters"
        Me.LblStarters.Size = New System.Drawing.Size(43, 13)
        Me.LblStarters.TabIndex = 2
        Me.LblStarters.Text = "Starters"
        '
        'LblOrderNumTitle
        '
        Me.LblOrderNumTitle.AutoSize = True
        Me.LblOrderNumTitle.Location = New System.Drawing.Point(632, 40)
        Me.LblOrderNumTitle.Name = "LblOrderNumTitle"
        Me.LblOrderNumTitle.Size = New System.Drawing.Size(53, 13)
        Me.LblOrderNumTitle.TabIndex = 4
        Me.LblOrderNumTitle.Text = "Order No."
        '
        'LblOrderNum
        '
        Me.LblOrderNum.AutoSize = True
        Me.LblOrderNum.Location = New System.Drawing.Point(691, 40)
        Me.LblOrderNum.Name = "LblOrderNum"
        Me.LblOrderNum.Size = New System.Drawing.Size(13, 13)
        Me.LblOrderNum.TabIndex = 5
        Me.LblOrderNum.Text = "0"
        '
        'GrpBoxDishes
        '
        Me.GrpBoxDishes.Controls.Add(Me.BtnRemoveItem)
        Me.GrpBoxDishes.Controls.Add(Me.BtnSelQuantity)
        Me.GrpBoxDishes.Controls.Add(Me.BtnAddItem)
        Me.GrpBoxDishes.Controls.Add(Me.ListBoxStarters)
        Me.GrpBoxDishes.Location = New System.Drawing.Point(12, 57)
        Me.GrpBoxDishes.Name = "GrpBoxDishes"
        Me.GrpBoxDishes.Size = New System.Drawing.Size(364, 381)
        Me.GrpBoxDishes.TabIndex = 6
        Me.GrpBoxDishes.TabStop = False
        Me.GrpBoxDishes.Text = "Select Dishes, Choose Amount and Add or Remove them from the Order."
        '
        'BtnRemoveItem
        '
        Me.BtnRemoveItem.Location = New System.Drawing.Point(216, 287)
        Me.BtnRemoveItem.Name = "BtnRemoveItem"
        Me.BtnRemoveItem.Size = New System.Drawing.Size(87, 41)
        Me.BtnRemoveItem.TabIndex = 0
        Me.BtnRemoveItem.Text = "Remove Item"
        Me.BtnRemoveItem.UseVisualStyleBackColor = True
        '
        'BtnSelQuantity
        '
        Me.BtnSelQuantity.Location = New System.Drawing.Point(216, 64)
        Me.BtnSelQuantity.Name = "BtnSelQuantity"
        Me.BtnSelQuantity.Size = New System.Drawing.Size(87, 41)
        Me.BtnSelQuantity.TabIndex = 0
        Me.BtnSelQuantity.Text = "Select Quantity"
        Me.BtnSelQuantity.UseVisualStyleBackColor = True
        '
        'BtnAddItem
        '
        Me.BtnAddItem.Location = New System.Drawing.Point(216, 176)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(87, 41)
        Me.BtnAddItem.TabIndex = 0
        Me.BtnAddItem.Text = "Add Item"
        Me.BtnAddItem.UseVisualStyleBackColor = True
        '
        'ListBoxOrderItems
        '
        Me.ListBoxOrderItems.FormattingEnabled = True
        Me.ListBoxOrderItems.Location = New System.Drawing.Point(557, 56)
        Me.ListBoxOrderItems.Name = "ListBoxOrderItems"
        Me.ListBoxOrderItems.Size = New System.Drawing.Size(231, 329)
        Me.ListBoxOrderItems.TabIndex = 7
        '
        'BtnSubmitOrder
        '
        Me.BtnSubmitOrder.Location = New System.Drawing.Point(635, 391)
        Me.BtnSubmitOrder.Name = "BtnSubmitOrder"
        Me.BtnSubmitOrder.Size = New System.Drawing.Size(87, 41)
        Me.BtnSubmitOrder.TabIndex = 8
        Me.BtnSubmitOrder.Text = "Submit Order"
        Me.BtnSubmitOrder.UseVisualStyleBackColor = True
        '
        'Add_Customer_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnSubmitOrder)
        Me.Controls.Add(Me.ListBoxOrderItems)
        Me.Controls.Add(Me.LblOrderNum)
        Me.Controls.Add(Me.LblOrderNumTitle)
        Me.Controls.Add(Me.LblStarters)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.GrpBoxDishes)
        Me.Name = "Add_Customer_Order"
        Me.Text = "Add_Customer_Order"
        Me.GrpBoxDishes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBack As Button
    Friend WithEvents ListBoxStarters As ListBox
    Friend WithEvents LblStarters As Label
    Friend WithEvents LblOrderNumTitle As Label
    Friend WithEvents LblOrderNum As Label
    Friend WithEvents GrpBoxDishes As GroupBox
    Friend WithEvents BtnRemoveItem As Button
    Friend WithEvents BtnAddItem As Button
    Friend WithEvents ListBoxOrderItems As ListBox
    Friend WithEvents BtnSelQuantity As Button
    Friend WithEvents BtnSubmitOrder As Button
End Class
