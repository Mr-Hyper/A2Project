Public Class Remove_Customer_Order

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Customer_Orders_Menu.Show()
        Me.Close()

    End Sub

    Private Sub BtnRemoveOrder_Click(sender As Object, e As EventArgs) Handles BtnRemoveOrder.Click

        ListBoxOrders.SelectedItems.Clear()

    End Sub

End Class