Public Class Form1

    Public Sub Startup()
        Dim Orders(49) As String


    End Sub

    Private Sub BtnCustOrd_Click(sender As Object, e As EventArgs) Handles BtnCustOrd.Click

        Customer_Orders_Menu.Show()

    End Sub

    Private Sub BtnSalesAcc_Click(sender As Object, e As EventArgs) Handles BtnSalesAcc.Click

        Sales_Accounting.Show()

    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click

        Settings.Show()

    End Sub

End Class
