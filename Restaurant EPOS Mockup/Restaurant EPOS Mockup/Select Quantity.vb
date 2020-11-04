Public Class Select_Quantity

    Private Sub LblQuantity_Click(sender As Object, e As EventArgs) Handles LblQuantity.Click



    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        Dim QuantityPlus As Integer

        QuantityPlus = Int(LblQuantity.Text)
        QuantityPlus = QuantityPlus + 1

        LblQuantity.Text = Str(QuantityPlus)

    End Sub

    Private Sub BtnMinus_Click(sender As Object, e As EventArgs) Handles BtnMinus.Click
        Dim QuantityMinus As Integer

        If LblQuantity.Text > 0 Then

            QuantityMinus = Int(LblQuantity.Text)
            QuantityMinus = QuantityMinus - 1

            LblQuantity.Text = Str(QuantityMinus)

        End If

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        Me.Hide()

    End Sub

    Private Sub Select_Quantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblQuantity.Text = "0"

    End Sub

End Class