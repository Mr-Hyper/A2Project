Public Class Add_Customer_Order
    Public Property OrderNum As Integer

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Customer_Orders_Menu.Show()
        Me.Close()

    End Sub

    Private Sub FoodItems_Click(sender As Object, e As EventArgs) Handles ListBoxStarters.SelectedIndexChanged



    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
        Dim Quantity As String

        Quantity = Select_Quantity.LblQuantity.Text
        ListBoxOrderItems.Items.Add("x" & Quantity & " " & Me.ListBoxStarters.SelectedItem)

    End Sub

    Private Sub BtnSelQuantity_Click(sender As Object, e As EventArgs) Handles BtnSelQuantity.Click

        Select_Quantity.Show()

    End Sub

    Private Sub BtnRemoveItem_Click(sender As Object, e As EventArgs) Handles BtnRemoveItem.Click

        ListBoxOrderItems.Items.RemoveAt(ListBoxOrderItems.SelectedIndex())

    End Sub

    Private Sub Add_Customer_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OrderNum = Int(LblOrderNum.Text)
        OrderNum = OrderNum + 1
        LblOrderNum.Text = Str(OrderNum)

    End Sub

    Private Sub BtnSubmitOrder_Click(sender As Object, e As EventArgs) Handles BtnSubmitOrder.Click
        Dim File As System.IO.StreamWriter
        Dim i As Integer

        File = My.Computer.FileSystem.OpenTextFileWriter(LblOrderNumTitle.Text & LblOrderNum.Text & ".txt", True)

        File.WriteLine(LblOrderNumTitle.Text & " " & LblOrderNum.Text)
        For i = 0 To ListBoxOrderItems.Items.Count - 1

            File.WriteLine(ListBoxOrderItems.Items.Item(i))

        Next
        File.Close()

        OrderNum = OrderNum + 1
        LblOrderNum.Text = Str(OrderNum)

        ListBoxOrderItems.Items.Clear()

        MessageBox.Show("Order Number " & OrderNum - 1 & " has been sent to the Kitchen.")

        Customer_Orders_Menu.Show()
        Me.Hide()

    End Sub

End Class