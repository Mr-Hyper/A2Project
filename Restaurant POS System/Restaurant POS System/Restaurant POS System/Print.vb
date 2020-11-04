Imports System.Management
Imports System.Drawing.Printing
Public Class Print
    Public Property StringPass As String

    Private Sub Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pkInstalledPrinters As String
        Dim Receipt As String

        For Each pkInstalledPrinters In PrinterSettings.InstalledPrinters

            ComboBoxPrinterSelect.Items.Add(pkInstalledPrinters)

        Next pkInstalledPrinters
        ComboBoxPrinterSelect.SelectedIndex = 0

        Receipt = "Bengal Blue" & Environment.NewLine()
        Receipt = Receipt & "17-19 Walton Rd" & Environment.NewLine()
        Receipt = Receipt & "Aylesbury HP21 7SR" & Environment.NewLine()
        Receipt = Receipt & "-------------------------------------------------------------------------------------" & Environment.NewLine()
        Receipt = Receipt & System.DateTime.Now & Environment.NewLine()
        Receipt = Receipt & "-------------------------------------------------------------------------------------" & Environment.NewLine()
        Receipt = Receipt & StringPass
        Receipt = Receipt & "-------------------------------------------------------------------------------------" & Environment.NewLine()
        Receipt = Receipt & "Payment - " & Environment.NewLine()
        Receipt = Receipt & "Subtotal: £" & CStr(SubTotal) & Environment.NewLine()
        Receipt = Receipt & "VAT: £0.00" & Environment.NewLine()
        Receipt = Receipt & "Total: £" & CStr(Total) & Environment.NewLine()
        Receipt = Receipt & "-------------------------------------------------------------------------------------" & Environment.NewLine()
        Receipt = Receipt & "Please come again." & Environment.NewLine()
        Receipt = Receipt & "Thank You."

        TxtBoxOrderItemsPrint.Text = Receipt

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

        PrintOrder.PrinterSettings.PrinterName = ComboBoxPrinterSelect.Text
        PrintOrder.Print()

    End Sub

    Private Sub BtnPrintPreview_Click(sender As Object, e As EventArgs) Handles BtnPrintPreview.Click

        PrintOrderDialog.ShowDialog()

    End Sub

    Private Sub PrintOrderDialog_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintOrder.PrintPage
        Dim Font1 As New Font("arial", 16, FontStyle.Regular)

        e.Graphics.DrawString(TxtBoxOrderItemsPrint.Text, Font1, Brushes.Black, 100, 100)

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Close()

    End Sub

End Class