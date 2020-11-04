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
        'Call PushTable(SelectedTable)
        'BtnTbl1.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl2_Click(sender As Object, e As EventArgs) Handles BtnTbl2.Click

        SelectedTable = 2
        'Call PushTable(SelectedTable)
        'BtnTbl2.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl3_Click(sender As Object, e As EventArgs) Handles BtnTbl3.Click

        SelectedTable = 3
        'Call PushTable(SelectedTable)
        'BtnTbl3.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl4_Click(sender As Object, e As EventArgs) Handles BtnTbl4.Click

        SelectedTable = 4
        'Call PushTable(SelectedTable)
        'BtnTbl4.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl5_Click(sender As Object, e As EventArgs) Handles BtnTbl5.Click

        SelectedTable = 5
        'Call PushTable(SelectedTable)
        'BtnTbl5.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl6_Click(sender As Object, e As EventArgs) Handles BtnTbl6.Click

        SelectedTable = 6
        'Call PushTable(SelectedTable)
        'BtnTbl6.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl7_Click(sender As Object, e As EventArgs) Handles BtnTbl7.Click

        SelectedTable = 7
        'Call PushTable(SelectedTable)
        'BtnTbl7.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl8_Click(sender As Object, e As EventArgs) Handles BtnTbl8.Click

        SelectedTable = 8
        'Call PushTable(SelectedTable)
        'BtnTbl8.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl9_Click(sender As Object, e As EventArgs) Handles BtnTbl9.Click

        SelectedTable = 9
        'Call PushTable(SelectedTable)
        'BtnTbl9.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl10_Click(sender As Object, e As EventArgs) Handles BtnTbl10.Click

        SelectedTable = 10
        'Call PushTable(SelectedTable)
        'BtnTbl10.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl11_Click(sender As Object, e As EventArgs) Handles BtnTbl11.Click

        SelectedTable = 11
        'Call PushTable(SelectedTable)
        'BtnTbl11.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl12_Click(sender As Object, e As EventArgs) Handles BtnTbl12.Click

        SelectedTable = 12
        'Call PushTable(SelectedTable)
        'BtnTbl12.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl14_Click(sender As Object, e As EventArgs) Handles BtnTbl14.Click

        SelectedTable = 14
        'Call PushTable(SelectedTable)
        'BtnTbl14.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl15_Click(sender As Object, e As EventArgs) Handles BtnTbl15.Click

        SelectedTable = 15
        'Call PushTable(SelectedTable)
        'BtnTbl15.Enabled = False
        Me.Hide()

    End Sub

    Private Sub BtnTbl16_Click(sender As Object, e As EventArgs) Handles BtnTbl16.Click

        SelectedTable = 16
        'Call PushTable(SelectedTable)
        'BtnTbl16.Enabled = False
        Me.Hide()

    End Sub

    Private Sub Tables_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

End Class