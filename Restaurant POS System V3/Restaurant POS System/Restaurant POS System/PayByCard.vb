Imports System.IO
Imports System.Data.OleDb
Public Class PayByCard
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Public Property PaymentType As String = "Card"
    Public Property AmountGiven As Decimal

    Private Sub PayByCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FileReader As System.IO.StreamReader

        Payment.Close()

        LblFYI.Text = "Please ensure that you" & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & "enter the correct amount" & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & "into the Card Reader before" & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & "the Customer Pays By Card." & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & "After entering Amount Given," & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & "please Confirm this by clicking" & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & "the 'Confirm Button below." & Environment.NewLine()

        FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & TableToPay.OrderToPayFor & ".txt")
        TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
        FileReader.Close()

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Close()

    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click

        AmountGiven = TxtBoxAmountGiven.Text

        If AmountGiven >= TableToPay.OrderToPayForTotal Then

            MessageBox.Show("Amount Given Confirmed.")

        ElseIf AmountGiven < TableToPay.OrderToPayForTotal Then

            MessageBox.Show("Insufficient funds to pay for Order No. " & TableToPay.OrderToPayFor & ". Please enter a correct Amount and try again.", "Insufficient funds", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TxtBoxAmountGiven.Text = " "

        End If

    End Sub

    Private Sub BtnSubmitPaym_Click(sender As Object, e As EventArgs) Handles BtnSubmitPaym.Click
        Dim Result As MsgBoxResult
        Dim OrderNo As Integer
        Dim TableNo As Integer
        Dim Total As Decimal
        Dim FilePath As String

        OrderNo = TableToPay.OrderToPayFor
        TableNo = TableToPay.TableToLookFor
        Total = TableToPay.OrderToPayForTotal
        FilePath = "Submitted Orders\Order No. " & OrderNo & ".txt"
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

                ChangeDueParameter.Value = CDec(0.00)
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

            Try
                Dim sqlconn As New OleDb.OleDbConnection
                Dim sqlquery As New OleDb.OleDbCommand
                Dim connstring As String

                connstring = "Provider=Microsoft.Jet.Oledb.4.0;Data Source=Restaurant Transaction Database.mdb"
                sqlconn.ConnectionString = connstring
                sqlquery.Connection = sqlconn

                sqlconn.Open()

                sqlquery.CommandText = "INSERT INTO PastTransactions ([OrderNumber], [TableNumber], [Total], [AmountGiven], [ChangeDue], [PaymentType], [DateTimeOfTransaction]) VALUES (@OrderNumber, @TableNumber, @Total, @AmountGiven, @ChangeDue, @PaymentType, @DateTimeOfTransaction)"
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

                ChangeDueParameter.Value = CDec(0.00)
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

            If File.Exists(FilePath) Then

                File.Delete(FilePath)

            Else

                MessageBox.Show("The File Path '" & FilePath & "' does not exist or it has been deleted.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            MessageBox.Show("Payment for Order No. " & TableToPay.OrderToPayFor & " has been submitted.")

            Me.Close()

        Else

            MessageBox.Show("Navigating back to Payment Form...")

            Payment.Show()
            Me.Close()

        End If

    End Sub

End Class