Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration
Public Class MainMenu
    Public OrderNum As Integer

    Dim con1 As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=Restaurant Product Database Connect.mdb")

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        ListBoxOrderItems.Items.Add("x" & QuantityBox.Value.ToString() & " " & DataGridViewMainMenu.CurrentRow.Cells(1).Value.ToString())

        ToAdd = DataGridViewMainMenu.CurrentRow.Cells(2).Value * QuantityBox.Value
        Total = Total + ToAdd

        Call Push(ToAdd)

        'TopPointer = TopPointer + 1
        'OrderItemsPriceStack(TopPointer) = DataGridViewMainMenu.CurrentRow.Cells(2).Value

        LblTotalValue.Text = Total

        'For i = FirstPointer To LastPointer - 1



        'Next

    End Sub

    Private Sub BtnRemoveItem_Click(sender As Object, e As EventArgs) Handles BtnRemoveItem.Click
        Dim SelectedPosition As Integer

        SelectedPosition = ListBoxOrderItems.SelectedIndex

        Total = Total - OrderItemsPriceStack(SelectedPosition)
        OrderItemsPriceStack(SelectedPosition) = 0
        LblTotalValue.Text = Total

        ListBoxOrderItems.Items.RemoveAt(ListBoxOrderItems.SelectedIndex())

        'MessageBox.Show("Position is " & SelectedPosition)
        'For n = 0 To TopPointer + 1

        'MessageBox.Show("index " & n & " is " & OrderItemsPriceStack(n))

        'Next

        Call Pop(SelectedPosition)

        'For i = Position To TopPointer - 1

        'If OrderItemsPriceStack(Position) = 0 Then

        'OrderItemsPriceStack(Position) = OrderItemsPriceStack(Position + 1)

        'Else

        'OrderItemsPriceStack(Position) = OrderItemsPriceStack(Position + 1)

        'End If

        'Next

        'TopPointer = TopPointer - 1

        'MessageBox.Show("Position is " & SelectedPosition)
        'For d = 0 To TopPointer + 1

        'ageBox.Show("index " & d & " is " & OrderItemsPriceStack(d))

        'Next

    End Sub

    Private Sub BtnClearItems_Click(sender As Object, e As EventArgs) Handles BtnClearItems.Click

        Total = 0.00
        LblTotalValue.Text = "0.00"

        'For d = 0 To TopPointer

        'ageBox.Show("BEFORE CLEARING")
        'MessageBox.Show("Index " & d & " value is " & OrderItemsPriceStack(d))

        'Next

        For n = 0 To TopPointer

            OrderItemsPriceStack(n) = 0

        Next

        'For i = 0 To 10

        'MessageBox.Show("AFTER CLEARING")
        'MessageBox.Show("Index " & i & " value is " & OrderItemsPriceStack(i))

        'Next

        TopPointer = -1

        ListBoxOrderItems.Items.Clear()

    End Sub

    Private Sub ToolStrpSubmit_Click(sender As Object, e As EventArgs) Handles ToolStrpSubmit.Click
        Dim FileWriter As System.IO.StreamWriter
        Dim i As Integer

        FileWriter = My.Computer.FileSystem.OpenTextFileWriter(LblOrderNoString.Text & LblOrderNoInt.Text & ".txt", True)

        FileWriter.WriteLine(LblOrderNoString.Text & " " & LblOrderNoInt.Text)
        FileWriter.WriteLine("Table No. " & SelectedTable)
        For i = 0 To ListBoxOrderItems.Items.Count - 1

            FileWriter.WriteLine(ListBoxOrderItems.Items.Item(i))

        Next
        FileWriter.WriteLine("Total: £" & LblTotalValue.Text)
        FileWriter.Close()

        MessageBox.Show("Order Number " & OrderNum & " has been saved.")

        Total = 0.00
        LblTotalValue.Text = "0.00"
        OrderNum = OrderNum + 1
        LblOrderNoInt.Text = Str(OrderNum)

        ListBoxOrderItems.Items.Clear()

    End Sub

    Private Sub ToolStrpPrint_Click(sender As Object, e As EventArgs) Handles ToolStrpPrint.Click
        Dim OBJ As New Print

        OBJ.StringPass = OBJ.StringPass & LblOrderNoString.Text & " " & LblOrderNoInt.Text & Environment.NewLine() & "Table No. " & SelectedTable & Environment.NewLine()
        For i = 0 To ListBoxOrderItems.Items.Count - 1

            OBJ.StringPass = OBJ.StringPass & ListBoxOrderItems.Items.Item(i) & Environment.NewLine()

        Next

        OBJ.Show()

    End Sub

    Private Sub ToolStrpTbl_Click(sender As Object, e As EventArgs) Handles ToolStrpTbl.Click

        Tables.Show()

    End Sub

    Private Sub ToolStrpPaym_Click(sender As Object, e As EventArgs) Handles ToolStrpPaym.Click

        Payment.Show()

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

End Class
