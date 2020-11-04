Imports System.IO
Imports System.Data.OleDb
Public Class PayByCash
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Public Property PaymentType As String = "Cash"
    Public Property ChangeDue As Decimal
    Public Property AmountGiven As Decimal

    Private Sub PayByCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FileReader As System.IO.StreamReader

        Payment.Close()

        FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & TableToPay.OrderToPayFor & ".txt")
        TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
        FileReader.Close()

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Close()

    End Sub

    Private Sub TxtBoxAmountGiven_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxAmountGiven.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then

            e.Handled = True

        End If

    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click

        AmountGiven = TxtBoxAmountGiven.Text
        ChangeDue = AmountGiven - TableToPay.OrderToPayForTotal

        If ChangeDue >= 0 Then

            TxtBoxChangeDue.Text = FormatNumber(ChangeDue, 2)

        ElseIf ChangeDue < 0 Then

            MessageBox.Show("Insufficient funds to pay for " & TableToPay.OrderToPayFor & ". Please enter a correct Amount and try again.", "Insufficient funds", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TxtBoxChangeDue.Text = " "

        End If

    End Sub

    Private Sub BtnSubmitPaym_Click(sender As Object, e As EventArgs) Handles BtnSubmitPaym.Click
        Dim Result As MsgBoxResult
        Dim OrderNo As Integer
        Dim TableNo As Integer
        Dim Total As Decimal

        OrderNo = TableToPay.OrderToPayFor
        TableNo = TableToPay.TableToLookFor
        Total = TableToPay.OrderToPayForTotal
        Result = MessageBox.Show("Are you sure you have recieved Payment for Order No. " & TableToPay.OrderToPayFor & "?", "Payment recieved?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = MsgBoxResult.Yes Then

            Call PopOrder(TableToPay.OrderAndTablePosInStack)
            Call SortOrder(TableToPay.OrderAndTablePosInStack)
            Call PopTable(TableToPay.OrderAndTablePosInStack)
            Call SortTable(TableToPay.OrderAndTablePosInStack)
            Call PopTotal(TableToPay.OrderAndTablePosInStack)
            Call SortTotal(TableToPay.OrderAndTablePosInStack)

            Try
                Dim sqlconn As New OleDb.OleDbConnection
                Dim sqlquery As New OleDb.OleDbCommand
                Dim connstring As String

                connstring = "Provider=Microsoft.Jet.Oledb.4.0;Data Source=Restaurant Transaction Database.mdb"
                sqlconn.ConnectionString = connstring
                sqlquery.Connection = sqlconn

                sqlconn.Open()

                sqlquery.CommandText = "INSERT INTO CurrentDayTransactions ([OrderNumber], [TableNumber], [Total], [AmountGiven], [ChangeDue], [PaymentType], [DateTimeOfTransaction]) VALUES (@OrderNumber, @TableNumber, @Total, @AmountGiven, @ChangeDue, @PaymentType, @DateTimeOfTransaction)"
                sqlquery.Parameters.AddWithValue("@OrderNumber", OrderNo)
                sqlquery.Parameters.AddWithValue("@TableNumber", TableNo)

                Dim TotalParameter As New OleDbParameter("@Total", OleDbType.Decimal)

                TotalParameter.Value = CDec(Total)
                TotalParameter.Scale = 2
                sqlquery.Parameters.Add(TotalParameter)

                Dim AmountGivenParameter As New OleDbParameter("@AmountGiven", OleDbType.Decimal)

                AmountGivenParameter.Value = CDec(AmountGiven)
                AmountGivenParameter.Scale = 2
                sqlquery.Parameters.Add(AmountGivenParameter)

                Dim ChangeDueParameter As New OleDbParameter("@ChangeDue", OleDbType.Decimal)

                ChangeDueParameter.Value = CDec(ChangeDue)
                ChangeDueParameter.Scale = 2
                sqlquery.Parameters.Add(ChangeDueParameter)

                sqlquery.Parameters.AddWithValue("@PaymentType", PaymentType)

                Dim DateTimeOfTransParameter As New OleDbParameter("@DateTimeOfTransacton", OleDbType.Date)

                DateTimeOfTransParameter.Value = CDate(System.DateTime.Now)
                sqlquery.Parameters.Add(DateTimeOfTransParameter)

                sqlquery.ExecuteNonQuery()
                sqlconn.Close()

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

            MessageBox.Show("Payment for Order No. " & TableToPay.OrderToPayFor & " has been submitted.")

            Result = MessageBox.Show("Would you like to Print Receipt for Order No. " & TableToPay.OrderToPayFor & "?", "Print Receipt?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = MsgBoxResult.Yes Then

                PrintPayByCash.PrintTotal = TableToPay.OrderToPayForTotal
                PrintPayByCash.StringPass = TxtBoxOrderDetails.Text
                PrintPayByCash.Show()
                Me.Close()

            ElseIf Result = MsgBoxResult.No Then

                Me.Close()

            End If

        Else

            MessageBox.Show("Navigating back to Payment Form...")

            Payment.Show()
            Me.Close()

        End If

    End Sub

End Class