<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintPayByCash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintPayByCash))
        Me.ComboBoxPrinterSelect = New System.Windows.Forms.ComboBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.TxtBoxOrderItemsPrint = New System.Windows.Forms.TextBox()
        Me.BtnPrintPreview = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.PrintOrder = New System.Drawing.Printing.PrintDocument()
        Me.PrintOrderDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'ComboBoxPrinterSelect
        '
        Me.ComboBoxPrinterSelect.FormattingEnabled = True
        Me.ComboBoxPrinterSelect.Location = New System.Drawing.Point(93, 14)
        Me.ComboBoxPrinterSelect.Name = "ComboBoxPrinterSelect"
        Me.ComboBoxPrinterSelect.Size = New System.Drawing.Size(180, 21)
        Me.ComboBoxPrinterSelect.TabIndex = 9
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(12, 12)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 8
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'TxtBoxOrderItemsPrint
        '
        Me.TxtBoxOrderItemsPrint.Location = New System.Drawing.Point(12, 53)
        Me.TxtBoxOrderItemsPrint.Multiline = True
        Me.TxtBoxOrderItemsPrint.Name = "TxtBoxOrderItemsPrint"
        Me.TxtBoxOrderItemsPrint.ReadOnly = True
        Me.TxtBoxOrderItemsPrint.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtBoxOrderItemsPrint.Size = New System.Drawing.Size(261, 334)
        Me.TxtBoxOrderItemsPrint.TabIndex = 7
        Me.TxtBoxOrderItemsPrint.WordWrap = False
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Location = New System.Drawing.Point(303, 278)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(116, 67)
        Me.BtnPrintPreview.TabIndex = 6
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(303, 100)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(116, 67)
        Me.BtnPrint.TabIndex = 5
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'PrintOrder
        '
        '
        'PrintOrderDialog
        '
        Me.PrintOrderDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintOrderDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintOrderDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintOrderDialog.Document = Me.PrintOrder
        Me.PrintOrderDialog.Enabled = True
        Me.PrintOrderDialog.Icon = CType(resources.GetObject("PrintOrderDialog.Icon"), System.Drawing.Icon)
        Me.PrintOrderDialog.Name = "PrintOrderDialog"
        Me.PrintOrderDialog.Visible = False
        '
        'PrintPayByCash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 399)
        Me.Controls.Add(Me.ComboBoxPrinterSelect)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.TxtBoxOrderItemsPrint)
        Me.Controls.Add(Me.BtnPrintPreview)
        Me.Controls.Add(Me.BtnPrint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintPayByCash"
        Me.ShowInTaskbar = False
        Me.Text = "PrintPayByCash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxPrinterSelect As ComboBox
    Friend WithEvents BtnBack As Button
    Friend WithEvents TxtBoxOrderItemsPrint As TextBox
    Friend WithEvents BtnPrintPreview As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents PrintOrder As Printing.PrintDocument
    Friend WithEvents PrintOrderDialog As PrintPreviewDialog
End Class
