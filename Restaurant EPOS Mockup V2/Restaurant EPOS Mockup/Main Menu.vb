Public Class Form1

    Public Sub Startup()
        Dim Orders(49) As String


    End Sub

    ' The following procedures will load up the specified Window Forms when a user presses a button
    ' on this Menu.

    Private Sub BtnCustOrd_Click(sender As Object, e As EventArgs) Handles BtnCustOrd.Click
        ' Loads Customer Orders Menu when that specific button is pressed.
        Customer_Orders_Menu.Show()

    End Sub

    Private Sub BtnSalesAcc_Click(sender As Object, e As EventArgs) Handles BtnSalesAcc.Click
        ' Loads Sales Accounting Menu when that specific button is pressed.
        Sales_Accounting.Show()

    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        ' Loads Settings Menu when that specific button is pressed.
        Settings.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

