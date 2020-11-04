Public Class Payment
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Close()

    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TableToPay.Hide()

        LblOrderToPayFor.Text = CStr(TableToPay.OrderToPayFor)

    End Sub

    Private Sub BtnPayByCash_Click(sender As Object, e As EventArgs) Handles BtnPayByCash.Click

        PayByCash.Show()

    End Sub

    Private Sub BtnPayByCard_Click(sender As Object, e As EventArgs) Handles BtnPayByCard.Click

        PayByCard.Show()

    End Sub

End Class
