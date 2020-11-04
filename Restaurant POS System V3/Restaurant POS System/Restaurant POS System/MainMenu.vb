Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration
Imports System.ComponentModel

Public Class MainMenu
    Public OrderNum As Integer
    Public IsSelected As Boolean

    Dim con1 As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=Restaurant Product Database Connect.mdb")

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Width As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim Height As Integer = Screen.PrimaryScreen.Bounds.Height

        Total = 0.00
        SubTotal = 0.00
        OrderNum = 1

        LblTotalValue.Text = "0.00"
        LblOrderNoInt.Text = OrderNum

    End Sub

    Private Sub BtnStarters_Click(sender As Object, e As EventArgs) Handles BtnStarters.Click
        Dim sql As String

        sql = "SELECT * FROM Starters"

        Dim adapter As New OleDbDataAdapter(sql, con1)
        Dim dt As New DataTable("Starters")
        adapter.Fill(dt)
        DataGridViewMainMenu.DataSource = dt

        Dim sql1 = "SELECT * FROM Starters"
        Dim adapter1 As New OleDbDataAdapter(sql1, con1)
        Dim cmd1 As New OleDbCommand(sql1, con1)
        con1.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()

        con1.Close()

    End Sub

    Private Sub BtnTandDish_Click(sender As Object, e As EventArgs) Handles BtnTandDish.Click
        Dim sql As String

        sql = "SELECT * FROM TandooriDishes"

        Dim adapter As New OleDbDataAdapter(sql, con1)
        Dim dt As New DataTable("TandooriDishes")
        adapter.Fill(dt)
        DataGridViewMainMenu.DataSource = dt

        Dim sql1 = "SELECT * FROM TandooriDishes"
        Dim adapter1 As New OleDbDataAdapter(sql1, con1)
        Dim cmd1 As New OleDbCommand(sql1, con1)
        con1.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()

        con1.Close()

    End Sub

    Private Sub BtnRice_Click(sender As Object, e As EventArgs) Handles BtnRice.Click
        Dim sql As String

        sql = "SELECT * FROM Rice"

        Dim adapter As New OleDbDataAdapter(sql, con1)
        Dim dt As New DataTable("Rice")
        adapter.Fill(dt)
        DataGridViewMainMenu.DataSource = dt

        Dim sql1 = "SELECT * FROM Rice"
        Dim adapter1 As New OleDbDataAdapter(sql1, con1)
        Dim cmd1 As New OleDbCommand(sql1, con1)
        con1.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()

        con1.Close()

    End Sub

    Private Sub BtnNan_Click(sender As Object, e As EventArgs) Handles BtnNan.Click
        Dim sql As String

        sql = "SELECT * FROM Nan"

        Dim adapter As New OleDbDataAdapter(sql, con1)
        Dim dt As New DataTable("Nan")
        adapter.Fill(dt)
        DataGridViewMainMenu.DataSource = dt

        Dim sql1 = "SELECT * FROM Nan"
        Dim adapter1 As New OleDbDataAdapter(sql1, con1)
        Dim cmd1 As New OleDbCommand(sql1, con1)
        con1.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()

        con1.Close()

    End Sub

    Private Sub BtnHousSpec_Click(sender As Object, e As EventArgs) Handles BtnHousSpec.Click
        Dim sql As String

        sql = "SELECT * FROM HouseSpecialities"

        Dim adapter As New OleDbDataAdapter(sql, con1)
        Dim dt As New DataTable("HouseSpecialities")
        adapter.Fill(dt)
        DataGridViewMainMenu.DataSource = dt

        Dim sql1 = "SELECT * FROM HouseSpecialities"
        Dim adapter1 As New OleDbDataAdapter(sql1, con1)
        Dim cmd1 As New OleDbCommand(sql1, con1)
        con1.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()

        con1.Close()

    End Sub

    Private Sub BtnAllTimeFav_Click(sender As Object, e As EventArgs) Handles BtnAllTimeFav.Click
        Dim sql As String

        sql = "SELECT * FROM AllTimeFavourites"

        Dim adapter As New OleDbDataAdapter(sql, con1)
        Dim dt As New DataTable("AllTimeFavourites")
        adapter.Fill(dt)
        DataGridViewMainMenu.DataSource = dt

        Dim sql1 = "SELECT * FROM AllTimeFavourites"
        Dim adapter1 As New OleDbDataAdapter(sql1, con1)
        Dim cmd1 As New OleDbCommand(sql1, con1)
        con1.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()

        con1.Close()


    End Sub

    Private Sub BtnSpecMildDish_Click(sender As Object, e As EventArgs) Handles BtnSpecMildDish.Click
        Dim sql As String

        sql = "SELECT * FROM SpecialMildDishes"

        Dim adapter As New OleDbDataAdapter(sql, con1)
        Dim dt As New DataTable("SpecialMildDishes")
        adapter.Fill(dt)
        DataGridViewMainMenu.DataSource = dt

        Dim sql1 = "SELECT * FROM SpecialMildDishes"
        Dim adapter1 As New OleDbDataAdapter(sql1, con1)
        Dim cmd1 As New OleDbCommand(sql1, con1)
        con1.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()

        con1.Close()


    End Sub

    Private Sub BtnFishDish_Click(sender As Object, e As EventArgs) Handles BtnFishDish.Click
        Dim sql As String

        sql = "SELECT * FROM FishDishes"

        Dim adapter As New OleDbDataAdapter(sql, con1)
        Dim dt As New DataTable("FishDishes")
        adapter.Fill(dt)
        DataGridViewMainMenu.DataSource = dt

        Dim sql1 = "SELECT * FROM FishDishes"
        Dim adapter1 As New OleDbDataAdapter(sql1, con1)
        Dim cmd1 As New OleDbCommand(sql1, con1)
        con1.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()

        con1.Close()

    End Sub

    Private Sub BtnBaltDIsh_Click(sender As Object, e As EventArgs) Handles BtnBaltDIsh.Click
        Dim sql As String

        sql = "SELECT * FROM BaltiDishes"

        Dim adapter As New OleDbDataAdapter(sql, con1)
        Dim dt As New DataTable("BaltiDishes")
        adapter.Fill(dt)
        DataGridViewMainMenu.DataSource = dt

        Dim sql1 = "SELECT * FROM BaltiDishes"
        Dim adapter1 As New OleDbDataAdapter(sql1, con1)
        Dim cmd1 As New OleDbCommand(sql1, con1)
        con1.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()

        con1.Close()

    End Sub

    Private Sub BtnVegMainDish_Click(sender As Object, e As EventArgs) Handles BtnVegMainDish.Click
        Dim sql As String

        sql = "SELECT * FROM VegetableMainDishes"

        Dim adapter As New OleDbDataAdapter(sql, con1)
        Dim dt As New DataTable("VegetableMainDishes")
        adapter.Fill(dt)
        DataGridViewMainMenu.DataSource = dt

        Dim sql1 = "SELECT * FROM VegetableMainDishes"
        Dim adapter1 As New OleDbDataAdapter(sql1, con1)
        Dim cmd1 As New OleDbCommand(sql1, con1)
        con1.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()

        con1.Close()

    End Sub

    Private Sub BtnBiryDish_Click(sender As Object, e As EventArgs) Handles BtnBiryDish.Click
        Dim sql As String

        sql = "SELECT * FROM BiryaniDishes"

        Dim adapter As New OleDbDataAdapter(sql, con1)
        Dim dt As New DataTable("BiryaniDishes")
        adapter.Fill(dt)
        DataGridViewMainMenu.DataSource = dt

        Dim sql1 = "SELECT * FROM BiryaniDishes"
        Dim adapter1 As New OleDbDataAdapter(sql1, con1)
        Dim cmd1 As New OleDbCommand(sql1, con1)
        con1.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()

        con1.Close()

    End Sub

    Private Sub BtnVegSideDish_Click(sender As Object, e As EventArgs) Handles BtnVegSideDish.Click
        Dim sql As String

        sql = "SELECT * FROM VegetableSideDishes"

        Dim adapter As New OleDbDataAdapter(sql, con1)
        Dim dt As New DataTable("VegetableSideDishes")
        adapter.Fill(dt)
        DataGridViewMainMenu.DataSource = dt

        Dim sql1 = "SELECT * FROM VegetableSideDishes"
        Dim adapter1 As New OleDbDataAdapter(sql1, con1)
        Dim cmd1 As New OleDbCommand(sql1, con1)
        con1.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()

        con1.Close()

    End Sub

    Private Sub BtnEngDish_Click(sender As Object, e As EventArgs) Handles BtnEngDish.Click
        Dim sql As String

        sql = "SELECT * FROM EnglishDishes"

        Dim adapter As New OleDbDataAdapter(sql, con1)
        Dim dt As New DataTable("EnglishDishes")
        adapter.Fill(dt)
        DataGridViewMainMenu.DataSource = dt

        Dim sql1 = "SELECT * FROM EnglishDishes"
        Dim adapter1 As New OleDbDataAdapter(sql1, con1)
        Dim cmd1 As New OleDbCommand(sql1, con1)
        con1.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()

        con1.Close()

    End Sub

    Private Sub BtnSetMeal_Click(sender As Object, e As EventArgs) Handles BtnSetMeal.Click
        Dim sql As String

        sql = "SELECT * FROM SetMeals"

        Dim adapter As New OleDbDataAdapter(sql, con1)
        Dim dt As New DataTable("SetMeals")
        adapter.Fill(dt)
        DataGridViewMainMenu.DataSource = dt

        Dim sql1 = "SELECT * FROM SetMeals"
        Dim adapter1 As New OleDbDataAdapter(sql1, con1)
        Dim cmd1 As New OleDbCommand(sql1, con1)
        con1.Open()
        Dim myreader As OleDbDataReader = cmd1.ExecuteReader
        myreader.Read()

        con1.Close()

    End Sub

    Private Sub DataGridViewMainMenu_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMainMenu.CellContentDoubleClick
        Dim ToAdd As Decimal

        If ListBoxOrderItems.Items.Count = 100 Then

            MessageBox.Show("Maximum number of Items added to Order No. " & LblOrderNoInt.Text & ", please remove some Items and try again.", "Maximum Items reached", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            ListBoxOrderItems.Items.Add("x" & QuantityBox.Value.ToString() & " " & DataGridViewMainMenu.CurrentRow.Cells(1).Value.ToString())

            ToAdd = DataGridViewMainMenu.CurrentRow.Cells(2).Value * QuantityBox.Value
            Total = FormatNumber(Total + ToAdd, 2)

            Call Push(ToAdd)

            LblTotalValue.Text = Total

        End If

    End Sub

    Private Sub BtnRemoveItem_Click(sender As Object, e As EventArgs) Handles BtnRemoveItem.Click
        Dim SelectedPosition As Integer

        If ListBoxOrderItems.SelectedIndex = -1 Then

            IsSelected = False

        Else

            IsSelected = True

        End If

        If ListBoxOrderItems.Items.Count = 0 Then

            MessageBox.Show("No Order Items to remove from Order No. " & LblOrderNoInt.Text, "Nothing to remove", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf IsSelected = False Then

            MessageBox.Show("No selected Item to remove. Please select an Item to remove from Order No. " & LblOrderNoInt.Text, "Nothing to remove", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            SelectedPosition = ListBoxOrderItems.SelectedIndex

            Total = Total - OrderItemsPriceStack(SelectedPosition)
            LblTotalValue.Text = Total

            ListBoxOrderItems.Items.RemoveAt(ListBoxOrderItems.SelectedIndex())

            Call Pop(SelectedPosition)
            Call Sort(SelectedPosition)
            'after successfully removing and item and deducting price from total, checks to see if the list box is empty one more time just to do the following
            If ListBoxOrderItems.Items.Count = 0 Then

                LblTotalValue.Text = "0.00"
                'at this point value of total is indeed 0 but the way the label displays it is weird so i just want it to display it like this instead
            End If

        End If

    End Sub

    Private Sub BtnClearItems_Click(sender As Object, e As EventArgs) Handles BtnClearItems.Click

        If ListBoxOrderItems.Items.Count = 0 Then

            MessageBox.Show("No Order Items to clear from Order No. " & LblOrderNoInt.Text, "Nothing to remove", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Total = 0.00
            LblTotalValue.Text = "0.00"

            For n = 0 To TopPointer

                OrderItemsPriceStack(n) = 0

            Next

            TopPointer = -1

            ListBoxOrderItems.Items.Clear()

        End If

    End Sub

    Private Sub ToolStrpSubmit_Click(sender As Object, e As EventArgs) Handles ToolStrpSubmit.Click
        Dim FileWriter As System.IO.StreamWriter
        Dim OrderNoToPass As Integer = OrderNum

        If ListBoxOrderItems.Items.Count = 0 Then

            MessageBox.Show("No Order Items to Submit in Order No. " & LblOrderNoInt.Text & ". Please add some Items and try again.", "Nothing to Submit", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf SelectedTable = 0 Then

            MessageBox.Show("No Table selected for Order No. " & LblOrderNoInt.Text & ". Please select a Table and try again.", "No Table selected", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Call PushTotalCost(Total)
            Call PushOrder(OrderNoToPass)
            Call PushTable(SelectedTable)
            Call TableStateOccupied(SelectedTable)

            FileWriter = My.Computer.FileSystem.OpenTextFileWriter("Submitted Orders\" & "Order No. " & OrderNum & ".txt", True)

            FileWriter.WriteLine("Order No. " & OrderNum)
            FileWriter.WriteLine("Table No. " & SelectedTable)
            For i = 0 To ListBoxOrderItems.Items.Count - 1

                FileWriter.WriteLine(ListBoxOrderItems.Items.Item(i))

            Next
            FileWriter.WriteLine("Total: £" & LblTotalValue.Text)
            FileWriter.Close()

            MessageBox.Show("Order Number " & OrderNum & " has been saved.")

            Total = 0.00
            SelectedTable = 0
            LblTotalValue.Text = "0.00"
            OrderNum = OrderNum + 1
            LblOrderNoInt.Text = Str(OrderNum)

            ListBoxOrderItems.Items.Clear()

        End If

    End Sub

    Private Sub ToolStrpPrint_Click(sender As Object, e As EventArgs) Handles ToolStrpPrint.Click
        Dim OBJ As New Print

        OBJ.StringPass = OBJ.StringPass & "Order No. " & OrderNum & Environment.NewLine() & "Table No. " & SelectedTable & Environment.NewLine()
        OBJ.PrintTotal = FormatNumber(LblTotalValue.Text, 2)
        For i = 0 To ListBoxOrderItems.Items.Count - 1

            OBJ.StringPass = OBJ.StringPass & ListBoxOrderItems.Items.Item(i) & Environment.NewLine()

        Next

        OBJ.Show()

    End Sub

    Private Sub ToolStrpTbl_Click(sender As Object, e As EventArgs) Handles ToolStrpTbl.Click

        Tables.Show()

    End Sub

    Private Sub ToolStrpPaym_Click(sender As Object, e As EventArgs) Handles ToolStrpPaym.Click

        TableToPay.Show()

    End Sub

    Private Sub ToolStrpCustMng_Click(sender As Object, e As EventArgs) Handles ToolStrpCustMng.Click

        CustomerManagement.Show()

    End Sub

    Private Sub ToolStrpPrdctMng_Click(sender As Object, e As EventArgs) Handles ToolStrpPrdctMng.Click

        ProductManagement.Show()

    End Sub

    Private Sub ToolStrpSalesAcc_Click(sender As Object, e As EventArgs) Handles ToolStrpSalesAcc.Click

        SalesAccounting.Show()

    End Sub

    Private Sub MainMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            Dim connstring As String

            connstring = "Provider=Microsoft.Jet.Oledb.4.0;Data Source=Restaurant Transaction Database.mdb"
            sqlconn.ConnectionString = connstring
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "DELETE * FROM CurrentDayTransactions"
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class
