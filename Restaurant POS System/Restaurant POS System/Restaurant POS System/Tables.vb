Public Class Tables
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Hide()

    End Sub

    Private Sub BtnTbl1_Click(sender As Object, e As EventArgs) Handles BtnTbl1.Click

        SelectedTable = 1
        BtnTbl1.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl2_Click(sender As Object, e As EventArgs) Handles BtnTbl2.Click

        SelectedTable = 2
        BtnTbl2.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl3_Click(sender As Object, e As EventArgs) Handles BtnTbl3.Click

        SelectedTable = 3
        BtnTbl3.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl4_Click(sender As Object, e As EventArgs) Handles BtnTbl4.Click

        SelectedTable = 4
        BtnTbl4.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl5_Click(sender As Object, e As EventArgs) Handles BtnTbl5.Click

        SelectedTable = 5
        BtnTbl5.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl6_Click(sender As Object, e As EventArgs) Handles BtnTbl6.Click

        SelectedTable = 6
        BtnTbl6.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl7_Click(sender As Object, e As EventArgs) Handles BtnTbl7.Click

        SelectedTable = 7
        BtnTbl7.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl8_Click(sender As Object, e As EventArgs) Handles BtnTbl8.Click

        SelectedTable = 8
        BtnTbl8.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl9_Click(sender As Object, e As EventArgs) Handles BtnTbl9.Click

        SelectedTable = 9
        BtnTbl9.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl10_Click(sender As Object, e As EventArgs) Handles BtnTbl10.Click

        SelectedTable = 10
        BtnTbl10.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl11_Click(sender As Object, e As EventArgs) Handles BtnTbl11.Click

        SelectedTable = 11
        BtnTbl11.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl12_Click(sender As Object, e As EventArgs) Handles BtnTbl12.Click

        SelectedTable = 12
        BtnTbl12.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl14_Click(sender As Object, e As EventArgs) Handles BtnTbl14.Click

        SelectedTable = 14
        BtnTbl14.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl15_Click(sender As Object, e As EventArgs) Handles BtnTbl15.Click

        SelectedTable = 15
        BtnTbl15.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl16_Click(sender As Object, e As EventArgs) Handles BtnTbl16.Click

        SelectedTable = 16
        BtnTbl16.Enabled = False
        Me.Hide()

    End Sub

    Private Sub Tables_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

End Class