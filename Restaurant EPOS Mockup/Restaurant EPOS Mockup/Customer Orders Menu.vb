Public Class Customer_Orders_Menu

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click

        Me.Close()

    End Sub

    Private Sub BtnAddOrder_Click(sender As Object, e As EventArgs) Handles BtnAddOrder.Click

        Add_Customer_Order.Show()
        Me.Hide()

    End Sub

    Private Sub BtnRemoveOrder_Click(sender As Object, e As EventArgs) Handles BtnRemoveOrder.Click

        Remove_Customer_Order.Show()
        Me.Hide()

    End Sub

    Private Sub BtnEditOrder_Click(sender As Object, e As EventArgs) Handles BtnEditOrder.Click



    End Sub

End Class