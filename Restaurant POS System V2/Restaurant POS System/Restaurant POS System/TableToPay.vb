Public Class TableToPay
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property
    Public Property TableToLookFor As Integer
    Public Property OrderToPayFor As Integer
    Public Property OrderAndTablePosInStack As Integer
    Public Property OrderToPayForTotal As Decimal

    Private Sub TableToPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim OccupiedTable As Integer

        BtnTbl1.Enabled = False
        BtnTbl2.Enabled = False
        BtnTbl3.Enabled = False
        BtnTbl4.Enabled = False
        BtnTbl5.Enabled = False
        BtnTbl6.Enabled = False
        BtnTbl7.Enabled = False
        BtnTbl8.Enabled = False
        BtnTbl9.Enabled = False
        BtnTbl10.Enabled = False
        BtnTbl11.Enabled = False
        BtnTbl12.Enabled = False
        BtnTbl14.Enabled = False
        BtnTbl15.Enabled = False
        BtnTbl16.Enabled = False

        For i = 0 To TopPointerTablesStack

            OccupiedTable = OccupiedTablesStack(i)

            Select Case OccupiedTable

                Case Is = 1
                    BtnTbl1.Enabled = True
                Case Is = 2
                    BtnTbl2.Enabled = True
                Case Is = 3
                    BtnTbl3.Enabled = True
                Case Is = 4
                    BtnTbl4.Enabled = True
                Case Is = 5
                    BtnTbl5.Enabled = True
                Case Is = 6
                    BtnTbl6.Enabled = True
                Case Is = 7
                    BtnTbl7.Enabled = True
                Case Is = 8
                    BtnTbl8.Enabled = True
                Case Is = 9
                    BtnTbl9.Enabled = True
                Case Is = 10
                    BtnTbl10.Enabled = True
                Case Is = 11
                    BtnTbl11.Enabled = True
                Case Is = 12
                    BtnTbl12.Enabled = True
                Case Is = 14
                    BtnTbl14.Enabled = True
                Case Is = 15
                    BtnTbl15.Enabled = True
                Case Is = 16
                    BtnTbl16.Enabled = True

            End Select

        Next

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Close()

    End Sub

    Private Sub BtnTbl1_Click(sender As Object, e As EventArgs) Handles BtnTbl1.Click

        TableToLookFor = 1
        OrderAndTablePosInStack = FindTable(TableToLookFor)
        OrderToPayFor = FindOrder(OrderAndTablePosInStack)
        OrderToPayForTotal = FindTotal(OrderAndTablePosInStack)

        Payment.Show()

    End Sub

    Private Sub BtnTbl2_Click(sender As Object, e As EventArgs) Handles BtnTbl2.Click

        TableToLookFor = 2

        OrderAndTablePosInStack = FindTable(TableToLookFor)
        OrderToPayFor = FindOrder(OrderAndTablePosInStack)
        OrderToPayForTotal = FindTotal(OrderAndTablePosInStack)

        Payment.Show()

    End Sub

    Private Sub BtnTbl3_Click(sender As Object, e As EventArgs) Handles BtnTbl3.Click

        TableToLookFor = 3

        OrderAndTablePosInStack = FindTable(TableToLookFor)
        OrderToPayFor = FindOrder(OrderAndTablePosInStack)
        OrderToPayForTotal = FindTotal(OrderAndTablePosInStack)

        Payment.Show()

    End Sub

    Private Sub BtnTbl4_Click(sender As Object, e As EventArgs) Handles BtnTbl4.Click

        TableToLookFor = 4

        OrderAndTablePosInStack = FindTable(TableToLookFor)
        OrderToPayFor = FindOrder(OrderAndTablePosInStack)
        OrderToPayForTotal = FindTotal(OrderAndTablePosInStack)

        Payment.Show()

    End Sub

    Private Sub BtnTbl5_Click(sender As Object, e As EventArgs) Handles BtnTbl5.Click

        TableToLookFor = 5

        OrderAndTablePosInStack = FindTable(TableToLookFor)
        OrderToPayFor = FindOrder(OrderAndTablePosInStack)
        OrderToPayForTotal = FindTotal(OrderAndTablePosInStack)

        Payment.Show()

    End Sub

    Private Sub BtnTbl6_Click(sender As Object, e As EventArgs) Handles BtnTbl6.Click

        TableToLookFor = 6

        OrderAndTablePosInStack = FindTable(TableToLookFor)
        OrderToPayFor = FindOrder(OrderAndTablePosInStack)
        OrderToPayForTotal = FindTotal(OrderAndTablePosInStack)

        Payment.Show()

    End Sub

    Private Sub BtnTbl7_Click(sender As Object, e As EventArgs) Handles BtnTbl7.Click

        TableToLookFor = 7

        OrderAndTablePosInStack = FindTable(TableToLookFor)
        OrderToPayFor = FindOrder(OrderAndTablePosInStack)
        OrderToPayForTotal = FindTotal(OrderAndTablePosInStack)

        Payment.Show()

    End Sub

    Private Sub BtnTbl8_Click(sender As Object, e As EventArgs) Handles BtnTbl8.Click

        TableToLookFor = 8

        OrderAndTablePosInStack = FindTable(TableToLookFor)
        OrderToPayFor = FindOrder(OrderAndTablePosInStack)
        OrderToPayForTotal = FindTotal(OrderAndTablePosInStack)

        Payment.Show()

    End Sub

    Private Sub BtnTbl9_Click(sender As Object, e As EventArgs) Handles BtnTbl9.Click

        TableToLookFor = 9

        OrderAndTablePosInStack = FindTable(TableToLookFor)
        OrderToPayFor = FindOrder(OrderAndTablePosInStack)
        OrderToPayForTotal = FindTotal(OrderAndTablePosInStack)

        Payment.Show()

    End Sub

    Private Sub BtnTbl10_Click(sender As Object, e As EventArgs) Handles BtnTbl10.Click

        TableToLookFor = 10

        OrderAndTablePosInStack = FindTable(TableToLookFor)
        OrderToPayFor = FindOrder(OrderAndTablePosInStack)
        OrderToPayForTotal = FindTotal(OrderAndTablePosInStack)

        Payment.Show()

    End Sub

    Private Sub BtnTbl11_Click(sender As Object, e As EventArgs) Handles BtnTbl11.Click

        TableToLookFor = 11

        OrderAndTablePosInStack = FindTable(TableToLookFor)
        OrderToPayFor = FindOrder(OrderAndTablePosInStack)
        OrderToPayForTotal = FindTotal(OrderAndTablePosInStack)

        Payment.Show()

    End Sub

    Private Sub BtnTbl12_Click(sender As Object, e As EventArgs) Handles BtnTbl12.Click

        TableToLookFor = 12

        OrderAndTablePosInStack = FindTable(TableToLookFor)
        OrderToPayFor = FindOrder(OrderAndTablePosInStack)
        OrderToPayForTotal = FindTotal(OrderAndTablePosInStack)

        Payment.Show()

    End Sub

    Private Sub BtnTbl14_Click(sender As Object, e As EventArgs) Handles BtnTbl14.Click

        TableToLookFor = 14

        OrderAndTablePosInStack = FindTable(TableToLookFor)
        OrderToPayFor = FindOrder(OrderAndTablePosInStack)
        OrderToPayForTotal = FindTotal(OrderAndTablePosInStack)

        Payment.Show()

    End Sub

    Private Sub BtnTbl15_Click(sender As Object, e As EventArgs) Handles BtnTbl15.Click

        TableToLookFor = 15

        OrderAndTablePosInStack = FindTable(TableToLookFor)
        OrderToPayFor = FindOrder(OrderAndTablePosInStack)
        OrderToPayForTotal = FindTotal(OrderAndTablePosInStack)

        Payment.Show()

    End Sub

    Private Sub BtnTbl16_Click(sender As Object, e As EventArgs) Handles BtnTbl16.Click

        TableToLookFor = 16

        OrderAndTablePosInStack = FindTable(TableToLookFor)
        OrderToPayFor = FindOrder(OrderAndTablePosInStack)
        OrderToPayForTotal = FindTotal(OrderAndTablePosInStack)

        Payment.Show()

    End Sub

End Class