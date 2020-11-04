Public Class Customer_Orders_Menu

    ' Following procedures pretty much do the same thing in that they load up specified Window Forms
    ' when a user presses a button on this form.

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

    Private Sub Customer_Orders_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

End Class