Public Class PayByCard



    Private Sub PayByCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Payment.Close()

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Close()

    End Sub

End Class