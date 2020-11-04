<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.BtnTandDish = New System.Windows.Forms.Button()
        Me.BtnHousSpec = New System.Windows.Forms.Button()
        Me.BtnAllTimeFav = New System.Windows.Forms.Button()
        Me.BtnSpecMildDish = New System.Windows.Forms.Button()
        Me.BtnFishDish = New System.Windows.Forms.Button()
        Me.BtnBaltDIsh = New System.Windows.Forms.Button()
        Me.BtnVegMainDish = New System.Windows.Forms.Button()
        Me.BtnBiryDish = New System.Windows.Forms.Button()
        Me.BtnVegSideDish = New System.Windows.Forms.Button()
        Me.BtnRice = New System.Windows.Forms.Button()
        Me.BtnNan = New System.Windows.Forms.Button()
        Me.BtnEngDish = New System.Windows.Forms.Button()
        Me.BtnSetMeal = New System.Windows.Forms.Button()
        Me.BtnLager = New System.Windows.Forms.Button()
        Me.BtnBeer = New System.Windows.Forms.Button()
        Me.BtnCider = New System.Windows.Forms.Button()
        Me.BtnWine = New System.Windows.Forms.Button()
        Me.BtnSoftDrink = New System.Windows.Forms.Button()
        Me.BtnWater = New System.Windows.Forms.Button()
        Me.BtnStarters = New System.Windows.Forms.Button()
        Me.GrpBoxDish = New System.Windows.Forms.GroupBox()
        Me.GrpBoxDrink = New System.Windows.Forms.GroupBox()
        Me.ListBoxOrderItems = New System.Windows.Forms.ListBox()
        Me.LblTotalValue = New System.Windows.Forms.Label()
        Me.LblTotalMainMenu = New System.Windows.Forms.Label()
        Me.ToolStripMainMen = New System.Windows.Forms.ToolStrip()
        Me.ToolStrpSubmit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrpPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrpTbl = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrpPaym = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrpCustMng = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrpPrdctMng = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrpSalesAcc = New System.Windows.Forms.ToolStripButton()
        Me.LblOrderNoString = New System.Windows.Forms.Label()
        Me.LblOrderNoInt = New System.Windows.Forms.Label()
        Me.DataGridViewMainMenu = New System.Windows.Forms.DataGridView()
        Me.AccompanimentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestaurantProductDatabaseConnectDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Restaurant_Product_Database_ConnectDataSet = New Restaurant_POS_System.Restaurant_Product_Database_ConnectDataSet()
        Me.AccompanimentsTableAdapter = New Restaurant_POS_System.Restaurant_Product_Database_ConnectDataSetTableAdapters.AccompanimentsTableAdapter()
        Me.BtnRemoveItem = New System.Windows.Forms.Button()
        Me.BtnClearItems = New System.Windows.Forms.Button()
        Me.QuantityBox = New System.Windows.Forms.NumericUpDown()
        Me.ToolStripMainMen.SuspendLayout()
        CType(Me.DataGridViewMainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccompanimentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantProductDatabaseConnectDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Restaurant_Product_Database_ConnectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnTandDish
        '
        Me.BtnTandDish.Location = New System.Drawing.Point(351, 93)
        Me.BtnTandDish.Name = "BtnTandDish"
        Me.BtnTandDish.Size = New System.Drawing.Size(69, 40)
        Me.BtnTandDish.TabIndex = 1
        Me.BtnTandDish.Text = "Tandoori Dishes"
        Me.BtnTandDish.UseVisualStyleBackColor = True
        '
        'BtnHousSpec
        '
        Me.BtnHousSpec.Location = New System.Drawing.Point(276, 139)
        Me.BtnHousSpec.Name = "BtnHousSpec"
        Me.BtnHousSpec.Size = New System.Drawing.Size(69, 40)
        Me.BtnHousSpec.TabIndex = 2
        Me.BtnHousSpec.Text = "House Specialities"
        Me.BtnHousSpec.UseVisualStyleBackColor = True
        '
        'BtnAllTimeFav
        '
        Me.BtnAllTimeFav.Location = New System.Drawing.Point(351, 139)
        Me.BtnAllTimeFav.Name = "BtnAllTimeFav"
        Me.BtnAllTimeFav.Size = New System.Drawing.Size(69, 40)
        Me.BtnAllTimeFav.TabIndex = 3
        Me.BtnAllTimeFav.Text = "All Time Favourites"
        Me.BtnAllTimeFav.UseVisualStyleBackColor = True
        '
        'BtnSpecMildDish
        '
        Me.BtnSpecMildDish.Location = New System.Drawing.Point(276, 185)
        Me.BtnSpecMildDish.Name = "BtnSpecMildDish"
        Me.BtnSpecMildDish.Size = New System.Drawing.Size(69, 40)
        Me.BtnSpecMildDish.TabIndex = 4
        Me.BtnSpecMildDish.Text = "Special Mild Dishes"
        Me.BtnSpecMildDish.UseVisualStyleBackColor = True
        '
        'BtnFishDish
        '
        Me.BtnFishDish.Location = New System.Drawing.Point(351, 185)
        Me.BtnFishDish.Name = "BtnFishDish"
        Me.BtnFishDish.Size = New System.Drawing.Size(69, 40)
        Me.BtnFishDish.TabIndex = 5
        Me.BtnFishDish.Text = "Fish Dishes"
        Me.BtnFishDish.UseVisualStyleBackColor = True
        '
        'BtnBaltDIsh
        '
        Me.BtnBaltDIsh.Location = New System.Drawing.Point(276, 231)
        Me.BtnBaltDIsh.Name = "BtnBaltDIsh"
        Me.BtnBaltDIsh.Size = New System.Drawing.Size(69, 40)
        Me.BtnBaltDIsh.TabIndex = 6
        Me.BtnBaltDIsh.Text = "Balti Dishes"
        Me.BtnBaltDIsh.UseVisualStyleBackColor = True
        '
        'BtnVegMainDish
        '
        Me.BtnVegMainDish.Location = New System.Drawing.Point(351, 231)
        Me.BtnVegMainDish.Name = "BtnVegMainDish"
        Me.BtnVegMainDish.Size = New System.Drawing.Size(69, 40)
        Me.BtnVegMainDish.TabIndex = 7
        Me.BtnVegMainDish.Text = "Veg Main Dishes"
        Me.BtnVegMainDish.UseVisualStyleBackColor = True
        '
        'BtnBiryDish
        '
        Me.BtnBiryDish.Location = New System.Drawing.Point(276, 277)
        Me.BtnBiryDish.Name = "BtnBiryDish"
        Me.BtnBiryDish.Size = New System.Drawing.Size(69, 40)
        Me.BtnBiryDish.TabIndex = 8
        Me.BtnBiryDish.Text = "Biryani Dishes"
        Me.BtnBiryDish.UseVisualStyleBackColor = True
        '
        'BtnVegSideDish
        '
        Me.BtnVegSideDish.Location = New System.Drawing.Point(351, 277)
        Me.BtnVegSideDish.Name = "BtnVegSideDish"
        Me.BtnVegSideDish.Size = New System.Drawing.Size(69, 40)
        Me.BtnVegSideDish.TabIndex = 9
        Me.BtnVegSideDish.Text = "Veg Side Dishes"
        Me.BtnVegSideDish.UseVisualStyleBackColor = True
        '
        'BtnRice
        '
        Me.BtnRice.Location = New System.Drawing.Point(276, 323)
        Me.BtnRice.Name = "BtnRice"
        Me.BtnRice.Size = New System.Drawing.Size(69, 40)
        Me.BtnRice.TabIndex = 10
        Me.BtnRice.Text = "Rice"
        Me.BtnRice.UseVisualStyleBackColor = True
        '
        'BtnNan
        '
        Me.BtnNan.Location = New System.Drawing.Point(351, 323)
        Me.BtnNan.Name = "BtnNan"
        Me.BtnNan.Size = New System.Drawing.Size(69, 40)
        Me.BtnNan.TabIndex = 11
        Me.BtnNan.Text = "Nan"
        Me.BtnNan.UseVisualStyleBackColor = True
        '
        'BtnEngDish
        '
        Me.BtnEngDish.Location = New System.Drawing.Point(276, 369)
        Me.BtnEngDish.Name = "BtnEngDish"
        Me.BtnEngDish.Size = New System.Drawing.Size(69, 40)
        Me.BtnEngDish.TabIndex = 12
        Me.BtnEngDish.Text = "English Dishes"
        Me.BtnEngDish.UseVisualStyleBackColor = True
        '
        'BtnSetMeal
        '
        Me.BtnSetMeal.Location = New System.Drawing.Point(351, 369)
        Me.BtnSetMeal.Name = "BtnSetMeal"
        Me.BtnSetMeal.Size = New System.Drawing.Size(69, 40)
        Me.BtnSetMeal.TabIndex = 13
        Me.BtnSetMeal.Text = "Set Meals"
        Me.BtnSetMeal.UseVisualStyleBackColor = True
        '
        'BtnLager
        '
        Me.BtnLager.Location = New System.Drawing.Point(446, 144)
        Me.BtnLager.Name = "BtnLager"
        Me.BtnLager.Size = New System.Drawing.Size(69, 31)
        Me.BtnLager.TabIndex = 14
        Me.BtnLager.Text = "Lagers"
        Me.BtnLager.UseVisualStyleBackColor = True
        '
        'BtnBeer
        '
        Me.BtnBeer.Location = New System.Drawing.Point(446, 181)
        Me.BtnBeer.Name = "BtnBeer"
        Me.BtnBeer.Size = New System.Drawing.Size(69, 31)
        Me.BtnBeer.TabIndex = 15
        Me.BtnBeer.Text = "Beers"
        Me.BtnBeer.UseVisualStyleBackColor = True
        '
        'BtnCider
        '
        Me.BtnCider.Location = New System.Drawing.Point(446, 218)
        Me.BtnCider.Name = "BtnCider"
        Me.BtnCider.Size = New System.Drawing.Size(69, 31)
        Me.BtnCider.TabIndex = 16
        Me.BtnCider.Text = "Ciders"
        Me.BtnCider.UseVisualStyleBackColor = True
        '
        'BtnWine
        '
        Me.BtnWine.Location = New System.Drawing.Point(446, 255)
        Me.BtnWine.Name = "BtnWine"
        Me.BtnWine.Size = New System.Drawing.Size(69, 31)
        Me.BtnWine.TabIndex = 17
        Me.BtnWine.Text = "Wines"
        Me.BtnWine.UseVisualStyleBackColor = True
        '
        'BtnSoftDrink
        '
        Me.BtnSoftDrink.Location = New System.Drawing.Point(446, 292)
        Me.BtnSoftDrink.Name = "BtnSoftDrink"
        Me.BtnSoftDrink.Size = New System.Drawing.Size(69, 31)
        Me.BtnSoftDrink.TabIndex = 18
        Me.BtnSoftDrink.Text = "Soft Drinks"
        Me.BtnSoftDrink.UseVisualStyleBackColor = True
        '
        'BtnWater
        '
        Me.BtnWater.Location = New System.Drawing.Point(446, 329)
        Me.BtnWater.Name = "BtnWater"
        Me.BtnWater.Size = New System.Drawing.Size(69, 31)
        Me.BtnWater.TabIndex = 19
        Me.BtnWater.Text = "Water"
        Me.BtnWater.UseVisualStyleBackColor = True
        '
        'BtnStarters
        '
        Me.BtnStarters.Location = New System.Drawing.Point(276, 93)
        Me.BtnStarters.Name = "BtnStarters"
        Me.BtnStarters.Size = New System.Drawing.Size(69, 40)
        Me.BtnStarters.TabIndex = 0
        Me.BtnStarters.Text = "Starters"
        Me.BtnStarters.UseVisualStyleBackColor = True
        '
        'GrpBoxDish
        '
        Me.GrpBoxDish.Location = New System.Drawing.Point(266, 77)
        Me.GrpBoxDish.Name = "GrpBoxDish"
        Me.GrpBoxDish.Size = New System.Drawing.Size(163, 342)
        Me.GrpBoxDish.TabIndex = 20
        Me.GrpBoxDish.TabStop = False
        Me.GrpBoxDish.Text = "Dishes"
        '
        'GrpBoxDrink
        '
        Me.GrpBoxDrink.Location = New System.Drawing.Point(435, 126)
        Me.GrpBoxDrink.Name = "GrpBoxDrink"
        Me.GrpBoxDrink.Size = New System.Drawing.Size(92, 245)
        Me.GrpBoxDrink.TabIndex = 21
        Me.GrpBoxDrink.TabStop = False
        Me.GrpBoxDrink.Text = "Drinks"
        '
        'ListBoxOrderItems
        '
        Me.ListBoxOrderItems.FormattingEnabled = True
        Me.ListBoxOrderItems.Location = New System.Drawing.Point(12, 51)
        Me.ListBoxOrderItems.Name = "ListBoxOrderItems"
        Me.ListBoxOrderItems.Size = New System.Drawing.Size(238, 368)
        Me.ListBoxOrderItems.TabIndex = 22
        '
        'LblTotalValue
        '
        Me.LblTotalValue.AutoSize = True
        Me.LblTotalValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalValue.Location = New System.Drawing.Point(122, 465)
        Me.LblTotalValue.Name = "LblTotalValue"
        Me.LblTotalValue.Size = New System.Drawing.Size(58, 25)
        Me.LblTotalValue.TabIndex = 23
        Me.LblTotalValue.Text = "0.00"
        '
        'LblTotalMainMenu
        '
        Me.LblTotalMainMenu.AutoSize = True
        Me.LblTotalMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalMainMenu.Location = New System.Drawing.Point(12, 465)
        Me.LblTotalMainMenu.Name = "LblTotalMainMenu"
        Me.LblTotalMainMenu.Size = New System.Drawing.Size(112, 25)
        Me.LblTotalMainMenu.TabIndex = 24
        Me.LblTotalMainMenu.Text = "TOTAL: £"
        '
        'ToolStripMainMen
        '
        Me.ToolStripMainMen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStrpSubmit, Me.ToolStrpPrint, Me.ToolStrpTbl, Me.ToolStrpPaym, Me.ToolStripSeparator1, Me.ToolStrpCustMng, Me.ToolStrpPrdctMng, Me.ToolStrpSalesAcc})
        Me.ToolStripMainMen.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMainMen.Name = "ToolStripMainMen"
        Me.ToolStripMainMen.Size = New System.Drawing.Size(906, 25)
        Me.ToolStripMainMen.TabIndex = 25
        Me.ToolStripMainMen.Text = "ToolStrip1"
        '
        'ToolStrpSubmit
        '
        Me.ToolStrpSubmit.Image = CType(resources.GetObject("ToolStrpSubmit.Image"), System.Drawing.Image)
        Me.ToolStrpSubmit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrpSubmit.Name = "ToolStrpSubmit"
        Me.ToolStrpSubmit.Size = New System.Drawing.Size(65, 22)
        Me.ToolStrpSubmit.Text = "Submit"
        '
        'ToolStrpPrint
        '
        Me.ToolStrpPrint.Image = CType(resources.GetObject("ToolStrpPrint.Image"), System.Drawing.Image)
        Me.ToolStrpPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrpPrint.Name = "ToolStrpPrint"
        Me.ToolStrpPrint.Size = New System.Drawing.Size(52, 22)
        Me.ToolStrpPrint.Text = "Print"
        '
        'ToolStrpTbl
        '
        Me.ToolStrpTbl.Image = CType(resources.GetObject("ToolStrpTbl.Image"), System.Drawing.Image)
        Me.ToolStrpTbl.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrpTbl.Name = "ToolStrpTbl"
        Me.ToolStrpTbl.Size = New System.Drawing.Size(60, 22)
        Me.ToolStrpTbl.Text = "Tables"
        '
        'ToolStrpPaym
        '
        Me.ToolStrpPaym.Image = CType(resources.GetObject("ToolStrpPaym.Image"), System.Drawing.Image)
        Me.ToolStrpPaym.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrpPaym.Name = "ToolStrpPaym"
        Me.ToolStrpPaym.Size = New System.Drawing.Size(74, 22)
        Me.ToolStrpPaym.Text = "Payment"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrpCustMng
        '
        Me.ToolStrpCustMng.Image = CType(resources.GetObject("ToolStrpCustMng.Image"), System.Drawing.Image)
        Me.ToolStrpCustMng.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrpCustMng.Name = "ToolStrpCustMng"
        Me.ToolStrpCustMng.Size = New System.Drawing.Size(153, 22)
        Me.ToolStrpCustMng.Text = "Customer Management"
        '
        'ToolStrpPrdctMng
        '
        Me.ToolStrpPrdctMng.Image = CType(resources.GetObject("ToolStrpPrdctMng.Image"), System.Drawing.Image)
        Me.ToolStrpPrdctMng.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrpPrdctMng.Name = "ToolStrpPrdctMng"
        Me.ToolStrpPrdctMng.Size = New System.Drawing.Size(143, 22)
        Me.ToolStrpPrdctMng.Text = "Product Management"
        '
        'ToolStrpSalesAcc
        '
        Me.ToolStrpSalesAcc.Image = CType(resources.GetObject("ToolStrpSalesAcc.Image"), System.Drawing.Image)
        Me.ToolStrpSalesAcc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStrpSalesAcc.Name = "ToolStrpSalesAcc"
        Me.ToolStrpSalesAcc.Size = New System.Drawing.Size(118, 22)
        Me.ToolStrpSalesAcc.Text = "Sales Accounting"
        '
        'LblOrderNoString
        '
        Me.LblOrderNoString.AutoSize = True
        Me.LblOrderNoString.Location = New System.Drawing.Point(88, 35)
        Me.LblOrderNoString.Name = "LblOrderNoString"
        Me.LblOrderNoString.Size = New System.Drawing.Size(56, 13)
        Me.LblOrderNoString.TabIndex = 26
        Me.LblOrderNoString.Text = "Order No. "
        '
        'LblOrderNoInt
        '
        Me.LblOrderNoInt.AutoSize = True
        Me.LblOrderNoInt.Location = New System.Drawing.Point(141, 35)
        Me.LblOrderNoInt.Name = "LblOrderNoInt"
        Me.LblOrderNoInt.Size = New System.Drawing.Size(13, 13)
        Me.LblOrderNoInt.TabIndex = 27
        Me.LblOrderNoInt.Text = "0"
        '
        'DataGridViewMainMenu
        '
        Me.DataGridViewMainMenu.AllowUserToAddRows = False
        Me.DataGridViewMainMenu.AllowUserToDeleteRows = False
        Me.DataGridViewMainMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewMainMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMainMenu.Location = New System.Drawing.Point(545, 51)
        Me.DataGridViewMainMenu.MultiSelect = False
        Me.DataGridViewMainMenu.Name = "DataGridViewMainMenu"
        Me.DataGridViewMainMenu.ReadOnly = True
        Me.DataGridViewMainMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewMainMenu.Size = New System.Drawing.Size(341, 420)
        Me.DataGridViewMainMenu.TabIndex = 28
        '
        'AccompanimentsBindingSource
        '
        Me.AccompanimentsBindingSource.DataMember = "Accompaniments"
        Me.AccompanimentsBindingSource.DataSource = Me.RestaurantProductDatabaseConnectDataSetBindingSource
        '
        'RestaurantProductDatabaseConnectDataSetBindingSource
        '
        Me.RestaurantProductDatabaseConnectDataSetBindingSource.DataSource = Me.Restaurant_Product_Database_ConnectDataSet
        Me.RestaurantProductDatabaseConnectDataSetBindingSource.Position = 0
        '
        'Restaurant_Product_Database_ConnectDataSet
        '
        Me.Restaurant_Product_Database_ConnectDataSet.DataSetName = "Restaurant_Product_Database_ConnectDataSet"
        Me.Restaurant_Product_Database_ConnectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccompanimentsTableAdapter
        '
        Me.AccompanimentsTableAdapter.ClearBeforeFill = True
        '
        'BtnRemoveItem
        '
        Me.BtnRemoveItem.Location = New System.Drawing.Point(99, 425)
        Me.BtnRemoveItem.Name = "BtnRemoveItem"
        Me.BtnRemoveItem.Size = New System.Drawing.Size(81, 23)
        Me.BtnRemoveItem.TabIndex = 29
        Me.BtnRemoveItem.Text = "Remove Item"
        Me.BtnRemoveItem.UseVisualStyleBackColor = True
        '
        'BtnClearItems
        '
        Me.BtnClearItems.Location = New System.Drawing.Point(12, 425)
        Me.BtnClearItems.Name = "BtnClearItems"
        Me.BtnClearItems.Size = New System.Drawing.Size(81, 23)
        Me.BtnClearItems.TabIndex = 30
        Me.BtnClearItems.Text = "Clear Items"
        Me.BtnClearItems.UseVisualStyleBackColor = True
        '
        'QuantityBox
        '
        Me.QuantityBox.Location = New System.Drawing.Point(186, 425)
        Me.QuantityBox.Name = "QuantityBox"
        Me.QuantityBox.Size = New System.Drawing.Size(64, 20)
        Me.QuantityBox.TabIndex = 31
        Me.QuantityBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 515)
        Me.Controls.Add(Me.QuantityBox)
        Me.Controls.Add(Me.BtnClearItems)
        Me.Controls.Add(Me.BtnRemoveItem)
        Me.Controls.Add(Me.DataGridViewMainMenu)
        Me.Controls.Add(Me.LblOrderNoInt)
        Me.Controls.Add(Me.LblOrderNoString)
        Me.Controls.Add(Me.ToolStripMainMen)
        Me.Controls.Add(Me.LblTotalMainMenu)
        Me.Controls.Add(Me.LblTotalValue)
        Me.Controls.Add(Me.ListBoxOrderItems)
        Me.Controls.Add(Me.BtnWater)
        Me.Controls.Add(Me.BtnSoftDrink)
        Me.Controls.Add(Me.BtnWine)
        Me.Controls.Add(Me.BtnCider)
        Me.Controls.Add(Me.BtnBeer)
        Me.Controls.Add(Me.BtnLager)
        Me.Controls.Add(Me.BtnSetMeal)
        Me.Controls.Add(Me.BtnEngDish)
        Me.Controls.Add(Me.BtnNan)
        Me.Controls.Add(Me.BtnRice)
        Me.Controls.Add(Me.BtnVegSideDish)
        Me.Controls.Add(Me.BtnBiryDish)
        Me.Controls.Add(Me.BtnVegMainDish)
        Me.Controls.Add(Me.BtnBaltDIsh)
        Me.Controls.Add(Me.BtnFishDish)
        Me.Controls.Add(Me.BtnSpecMildDish)
        Me.Controls.Add(Me.BtnAllTimeFav)
        Me.Controls.Add(Me.BtnHousSpec)
        Me.Controls.Add(Me.BtnTandDish)
        Me.Controls.Add(Me.BtnStarters)
        Me.Controls.Add(Me.GrpBoxDish)
        Me.Controls.Add(Me.GrpBoxDrink)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ToolStripMainMen.ResumeLayout(False)
        Me.ToolStripMainMen.PerformLayout()
        CType(Me.DataGridViewMainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccompanimentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantProductDatabaseConnectDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Restaurant_Product_Database_ConnectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnTandDish As Button
    Friend WithEvents BtnHousSpec As Button
    Friend WithEvents BtnAllTimeFav As Button
    Friend WithEvents BtnSpecMildDish As Button
    Friend WithEvents BtnFishDish As Button
    Friend WithEvents BtnBaltDIsh As Button
    Friend WithEvents BtnVegMainDish As Button
    Friend WithEvents BtnBiryDish As Button
    Friend WithEvents BtnVegSideDish As Button
    Friend WithEvents BtnRice As Button
    Friend WithEvents BtnNan As Button
    Friend WithEvents BtnEngDish As Button
    Friend WithEvents BtnSetMeal As Button
    Friend WithEvents BtnLager As Button
    Friend WithEvents BtnBeer As Button
    Friend WithEvents BtnCider As Button
    Friend WithEvents BtnWine As Button
    Friend WithEvents BtnSoftDrink As Button
    Friend WithEvents BtnWater As Button
    Friend WithEvents BtnStarters As Button
    Friend WithEvents GrpBoxDish As GroupBox
    Friend WithEvents GrpBoxDrink As GroupBox
    Friend WithEvents ListBoxOrderItems As ListBox
    Friend WithEvents LblTotalValue As Label
    Friend WithEvents LblTotalMainMenu As Label
    Friend WithEvents ToolStripMainMen As ToolStrip
    Friend WithEvents ToolStrpSubmit As ToolStripButton
    Friend WithEvents ToolStrpPrint As ToolStripButton
    Friend WithEvents ToolStrpTbl As ToolStripButton
    Friend WithEvents ToolStrpPaym As ToolStripButton
    Friend WithEvents ToolStrpCustMng As ToolStripButton
    Friend WithEvents ToolStrpPrdctMng As ToolStripButton
    Friend WithEvents ToolStrpSalesAcc As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LblOrderNoString As Label
    Friend WithEvents LblOrderNoInt As Label
    Friend WithEvents DataGridViewMainMenu As DataGridView
    Friend WithEvents RestaurantProductDatabaseConnectDataSetBindingSource As BindingSource
    Friend WithEvents Restaurant_Product_Database_ConnectDataSet As Restaurant_Product_Database_ConnectDataSet
    Friend WithEvents AccompanimentsBindingSource As BindingSource
    Friend WithEvents AccompanimentsTableAdapter As Restaurant_Product_Database_ConnectDataSetTableAdapters.AccompanimentsTableAdapter
    Friend WithEvents BtnRemoveItem As Button
    Friend WithEvents BtnClearItems As Button
    Friend WithEvents QuantityBox As NumericUpDown
End Class
