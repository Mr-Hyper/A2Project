<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Print
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Print))
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnPrintPreview = New System.Windows.Forms.Button()
        Me.TxtBoxOrderItemsPrint = New System.Windows.Forms.TextBox()
        Me.PrintOrderDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintOrder = New System.Drawing.Printing.PrintDocument()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.ComboBoxPrinterSelect = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(303, 100)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(116, 67)
        Me.BtnPrint.TabIndex = 0
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Location = New System.Drawing.Point(303, 278)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(116, 67)
        Me.BtnPrintPreview.TabIndex = 1
        Me.BtnPrintPreview.Text = "Print Preview"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'TxtBoxOrderItemsPrint
        '
        Me.TxtBoxOrderItemsPrint.Location = New System.Drawing.Point(12, 53)
        Me.TxtBoxOrderItemsPrint.Multiline = True
        Me.TxtBoxOrderItemsPrint.Name = "TxtBoxOrderItemsPrint"
        Me.TxtBoxOrderItemsPrint.ReadOnly = True
        Me.TxtBoxOrderItemsPrint.Size = New System.Drawing.Size(261, 334)
        Me.TxtBoxOrderItemsPrint.TabIndex = 2
        '
        'PrintOrderDialog
        '
        Me.PrintOrderDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintOrderDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintOrderDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintOrderDialog.Document = Me.PrintOrder
        Me.PrintOrderDialog.Enabled = True
        Me.PrintOrderDialog.Icon = CType(resources.GetObject("PrintOrderDialog.Icon"), System.Drawing.Icon)
        Me.PrintOrderDialog.Name = "PrintPreviewDialog1"
        Me.PrintOrderDialog.Visible = False
        '
        'PrintOrder
        '
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(12, 12)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 3
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'ComboBoxPrinterSelect
        '
        Me.ComboBoxPrinterSelect.FormattingEnabled = True
        Me.ComboBoxPrinterSelect.Location = New System.Drawing.Point(93, 14)
        Me.ComboBoxPrinterSelect.Name = "ComboBoxPrinterSelect"
        Me.ComboBoxPrinterSelect.Size = New System.Drawing.Size(180, 21)
        Me.ComboBoxPrinterSelect.TabIndex = 4
        '
        'Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 399)
        Me.Controls.Add(Me.ComboBoxPrinterSelect)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.TxtBoxOrderItemsPrint)
        Me.Controls.Add(Me.BtnPrintPreview)
        Me.Controls.Add(Me.BtnPrint)
        Me.Name = "Print"
        Me.Text = "  "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnPrintPreview As Button
    Friend WithEvents TxtBoxOrderItemsPrint As TextBox
    Friend WithEvents PrintOrderDialog As PrintPreviewDialog
    Friend WithEvents PrintOrder As Printing.PrintDocument
    Friend WithEvents BtnBack As Button
    Friend WithEvents ComboBoxPrinterSelect As ComboBox
End Class
