Imports System.IO
Public Class CustomerManagement
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Dim FileReader As System.IO.StreamReader
    Dim TableToLookFor As Integer
    Dim OrderAndTablePosInStack As Integer
    Dim OrderToLookFor As Integer

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        Me.Close()

    End Sub

    Private Sub CustomerManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim OccupiedTable As Integer

        LblFYI.Text = "Orders that have been submitted" & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & "will show up on their respective" & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & "Tables in the Restaurant Layout." & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & "Click on a Table with an" & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & "Order assigned to it, to show its" & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & "Details in the box above" & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & "A Table indicated with the" & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & "word 'Free', is un occuppied" & Environment.NewLine()
        LblFYI.Text = LblFYI.Text & "and has no Order assigned to it yet." & Environment.NewLine()

        BtnTbl1.Text = "Free"
        BtnTbl2.Text = "Free"
        BtnTbl3.Text = "Free"
        BtnTbl4.Text = "Free"
        BtnTbl5.Text = "Free"
        BtnTbl6.Text = "Free"
        BtnTbl7.Text = "Free"
        BtnTbl8.Text = "Free"
        BtnTbl9.Text = "Free"
        BtnTbl10.Text = "Free"
        BtnTbl11.Text = "Free"
        BtnTbl12.Text = "Free"
        BtnTbl14.Text = "Free"
        BtnTbl15.Text = "Free"
        BtnTbl16.Text = "Free"

        For i = 0 To TopPointerTablesStack

            OccupiedTable = OccupiedTablesStack(i)

            Select Case OccupiedTable

                Case Is = 1
                    BtnTbl1.Text = "Order No. " & OrdersSubmittedStack(i)
                Case Is = 2
                    BtnTbl2.Text = "Order No. " & OrdersSubmittedStack(i)
                Case Is = 3
                    BtnTbl3.Text = "Order No. " & OrdersSubmittedStack(i)
                Case Is = 4
                    BtnTbl4.Text = "Order No. " & OrdersSubmittedStack(i)
                Case Is = 5
                    BtnTbl5.Text = "Order No. " & OrdersSubmittedStack(i)
                Case Is = 6
                    BtnTbl6.Text = "Order No. " & OrdersSubmittedStack(i)
                Case Is = 7
                    BtnTbl7.Text = "Order No. " & OrdersSubmittedStack(i)
                Case Is = 8
                    BtnTbl8.Text = "Order No. " & OrdersSubmittedStack(i)
                Case Is = 9
                    BtnTbl9.Text = "Order No. " & OrdersSubmittedStack(i)
                Case Is = 10
                    BtnTbl10.Text = "Order No. " & OrdersSubmittedStack(i)
                Case Is = 11
                    BtnTbl11.Text = "Order No. " & OrdersSubmittedStack(i)
                Case Is = 12
                    BtnTbl12.Text = "Order No. " & OrdersSubmittedStack(i)
                Case Is = 14
                    BtnTbl14.Text = "Order No. " & OrdersSubmittedStack(i)
                Case Is = 15
                    BtnTbl15.Text = "Order No. " & OrdersSubmittedStack(i)
                Case Is = 16
                    BtnTbl16.Text = "Order No. " & OrdersSubmittedStack(i)

            End Select

        Next

    End Sub

    Private Sub BtnTbl1_Click(sender As Object, e As EventArgs) Handles BtnTbl1.Click

        If BtnTbl1.Text <> "Free" Then

            TableToLookFor = 1
            OrderAndTablePosInStack = FindTable(TableToLookFor)
            OrderToLookFor = OrdersSubmittedStack(OrderAndTablePosInStack)
            FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & OrderToLookFor & ".txt")
            TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
            FileReader.Close()

        Else

            MessageBox.Show("This Table is currently un occupied and has no Order assigned to it.")

        End If

    End Sub

    Private Sub BtnTbl2_Click(sender As Object, e As EventArgs) Handles BtnTbl2.Click

        If BtnTbl2.Text <> "Free" Then

            TableToLookFor = 2
            OrderAndTablePosInStack = FindTable(TableToLookFor)
            OrderToLookFor = OrdersSubmittedStack(OrderAndTablePosInStack)
            FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & OrderToLookFor & ".txt")
            TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
            FileReader.Close()

        Else

            MessageBox.Show("This Table is currently un occupied and has no Order assigned to it.")

        End If

    End Sub

    Private Sub BtnTbl3_Click(sender As Object, e As EventArgs) Handles BtnTbl3.Click

        If BtnTbl3.Text <> "Free" Then

            TableToLookFor = 3
            OrderAndTablePosInStack = FindTable(TableToLookFor)
            OrderToLookFor = OrdersSubmittedStack(OrderAndTablePosInStack)
            FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & OrderToLookFor & ".txt")
            TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
            FileReader.Close()

        Else

            MessageBox.Show("This Table is currently un occupied and has no Order assigned to it.")

        End If

    End Sub

    Private Sub BtnTbl4_Click(sender As Object, e As EventArgs) Handles BtnTbl4.Click

        If BtnTbl4.Text <> "Free" Then

            TableToLookFor = 4
            OrderAndTablePosInStack = FindTable(TableToLookFor)
            OrderToLookFor = OrdersSubmittedStack(OrderAndTablePosInStack)
            FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & OrderToLookFor & ".txt")
            TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
            FileReader.Close()

        Else

            MessageBox.Show("This Table is currently un occupied and has no Order assigned to it.")

        End If

    End Sub

    Private Sub BtnTbl5_Click(sender As Object, e As EventArgs) Handles BtnTbl5.Click

        If BtnTbl5.Text <> "Free" Then

            TableToLookFor = 5
            OrderAndTablePosInStack = FindTable(TableToLookFor)
            OrderToLookFor = OrdersSubmittedStack(OrderAndTablePosInStack)
            FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & OrderToLookFor & ".txt")
            TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
            FileReader.Close()

        Else

            MessageBox.Show("This Table is currently un occupied and has no Order assigned to it.")

        End If

    End Sub

    Private Sub BtnTbl6_Click(sender As Object, e As EventArgs) Handles BtnTbl6.Click

        If BtnTbl6.Text <> "Free" Then

            TableToLookFor = 6
            OrderAndTablePosInStack = FindTable(TableToLookFor)
            OrderToLookFor = OrdersSubmittedStack(OrderAndTablePosInStack)
            FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & OrderToLookFor & ".txt")
            TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
            FileReader.Close()

        Else

            MessageBox.Show("This Table is currently un occupied and has no Order assigned to it.")

        End If

    End Sub

    Private Sub BtnTbl7_Click(sender As Object, e As EventArgs) Handles BtnTbl7.Click

        If BtnTbl7.Text <> "Free" Then

            TableToLookFor = 7
            OrderAndTablePosInStack = FindTable(TableToLookFor)
            OrderToLookFor = OrdersSubmittedStack(OrderAndTablePosInStack)
            FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & OrderToLookFor & ".txt")
            TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
            FileReader.Close()

        Else

            MessageBox.Show("This Table is currently un occupied and has no Order assigned to it.")

        End If

    End Sub

    Private Sub BtnTbl8_Click(sender As Object, e As EventArgs) Handles BtnTbl8.Click

        If BtnTbl8.Text <> "Free" Then

            TableToLookFor = 8
            OrderAndTablePosInStack = FindTable(TableToLookFor)
            OrderToLookFor = OrdersSubmittedStack(OrderAndTablePosInStack)
            FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & OrderToLookFor & ".txt")
            TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
            FileReader.Close()

        Else

            MessageBox.Show("This Table is currently un occupied and has no Order assigned to it.")

        End If

    End Sub

    Private Sub BtnTbl9_Click(sender As Object, e As EventArgs) Handles BtnTbl9.Click

        If BtnTbl9.Text <> "Free" Then

            TableToLookFor = 9
            OrderAndTablePosInStack = FindTable(TableToLookFor)
            OrderToLookFor = OrdersSubmittedStack(OrderAndTablePosInStack)
            FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & OrderToLookFor & ".txt")
            TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
            FileReader.Close()

        Else

            MessageBox.Show("This Table is currently un occupied and has no Order assigned to it.")

        End If

    End Sub

    Private Sub BtnTbl10_Click(sender As Object, e As EventArgs) Handles BtnTbl10.Click

        If BtnTbl10.Text <> "Free" Then

            TableToLookFor = 10
            OrderAndTablePosInStack = FindTable(TableToLookFor)
            OrderToLookFor = OrdersSubmittedStack(OrderAndTablePosInStack)
            FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & OrderToLookFor & ".txt")
            TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
            FileReader.Close()

        Else

            MessageBox.Show("This Table is currently un occupied and has no Order assigned to it.")

        End If

    End Sub

    Private Sub BtnTbl11_Click(sender As Object, e As EventArgs) Handles BtnTbl11.Click

        If BtnTbl11.Text <> "Free" Then

            TableToLookFor = 11
            OrderAndTablePosInStack = FindTable(TableToLookFor)
            OrderToLookFor = OrdersSubmittedStack(OrderAndTablePosInStack)
            FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & OrderToLookFor & ".txt")
            TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
            FileReader.Close()

        Else

            MessageBox.Show("This Table is currently un occupied and has no Order assigned to it.")

        End If

    End Sub

    Private Sub BtnTbl12_Click(sender As Object, e As EventArgs) Handles BtnTbl12.Click

        If BtnTbl12.Text <> "Free" Then

            TableToLookFor = 12
            OrderAndTablePosInStack = FindTable(TableToLookFor)
            OrderToLookFor = OrdersSubmittedStack(OrderAndTablePosInStack)
            FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & OrderToLookFor & ".txt")
            TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
            FileReader.Close()

        Else

            MessageBox.Show("This Table is currently un occupied and has no Order assigned to it.")

        End If

    End Sub

    Private Sub BtnTbl14_Click(sender As Object, e As EventArgs) Handles BtnTbl14.Click

        If BtnTbl14.Text <> "Free" Then

            TableToLookFor = 14
            OrderAndTablePosInStack = FindTable(TableToLookFor)
            OrderToLookFor = OrdersSubmittedStack(OrderAndTablePosInStack)
            FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & OrderToLookFor & ".txt")
            TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
            FileReader.Close()

        Else

            MessageBox.Show("This Table is currently un occupied and has no Order assigned to it.")

        End If

    End Sub

    Private Sub BtnTbl15_Click(sender As Object, e As EventArgs) Handles BtnTbl15.Click

        If BtnTbl15.Text <> "Free" Then

            TableToLookFor = 15
            OrderAndTablePosInStack = FindTable(TableToLookFor)
            OrderToLookFor = OrdersSubmittedStack(OrderAndTablePosInStack)
            FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & OrderToLookFor & ".txt")
            TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
            FileReader.Close()

        Else

            MessageBox.Show("This Table is currently un occupied and has no Order assigned to it.")

        End If

    End Sub

    Private Sub BtnTbl16_Click(sender As Object, e As EventArgs) Handles BtnTbl16.Click

        If BtnTbl16.Text <> "Free" Then

            TableToLookFor = 16
            OrderAndTablePosInStack = FindTable(TableToLookFor)
            OrderToLookFor = OrdersSubmittedStack(OrderAndTablePosInStack)
            FileReader = My.Computer.FileSystem.OpenTextFileReader("Submitted Orders\Order No. " & OrderToLookFor & ".txt")
            TxtBoxOrderDetails.Text = FileReader.ReadToEnd()
            FileReader.Close()

        Else

            MessageBox.Show("This Table is currently un occupied and has no Order assigned to it.")

        End If

    End Sub

End Class