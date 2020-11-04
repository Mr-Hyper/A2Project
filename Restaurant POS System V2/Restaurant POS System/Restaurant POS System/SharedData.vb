Module SharedData

    Public SelectedTable As Integer

    Public OrderItemsPriceStack(99) As Decimal
    Public TopPointer As Integer = -1

    Public Total As Decimal
    Public SubTotal As Decimal

    Public OccupiedTablesStack(15) As Integer
    Public TopPointerTablesStack As Integer = -1

    Public OrdersSubmittedStack(15) As Integer
    Public TopPointerOrdersStack As Integer = -1

    Public OrdersTotalCostStack(15) As Decimal
    Public TopPointerTotalStack As Integer = -1

    Public Sub TableStateOccupied(ByVal TableOccupied)

        Select Case TableOccupied

            Case Is = 1
                Tables.BtnTbl1.Enabled = False
            Case Is = 2
                Tables.BtnTbl2.Enabled = False
            Case Is = 3
                Tables.BtnTbl3.Enabled = False
            Case Is = 4
                Tables.BtnTbl4.Enabled = False
            Case Is = 5
                Tables.BtnTbl5.Enabled = False
            Case Is = 6
                Tables.BtnTbl6.Enabled = False
            Case Is = 7
                Tables.BtnTbl7.Enabled = False
            Case Is = 8
                Tables.BtnTbl8.Enabled = False
            Case Is = 9
                Tables.BtnTbl9.Enabled = False
            Case Is = 10
                Tables.BtnTbl10.Enabled = False
            Case Is = 11
                Tables.BtnTbl11.Enabled = False
            Case Is = 12
                Tables.BtnTbl12.Enabled = False
            Case Is = 14
                Tables.BtnTbl14.Enabled = False
            Case Is = 15
                Tables.BtnTbl15.Enabled = False
            Case Is = 16
                Tables.BtnTbl16.Enabled = False

        End Select

    End Sub

    Public Sub Push(ByVal Add)

        TopPointer = TopPointer + 1
        OrderItemsPriceStack(TopPointer) = Add

    End Sub

    Public Sub Pop(ByVal Position)

        OrderItemsPriceStack(Position) = 0

    End Sub

    Public Sub Sort(Position)

        For i = Position To TopPointer

            If OrderItemsPriceStack(i) = 0 Then

                OrderItemsPriceStack(i) = OrderItemsPriceStack(i + 1)

            Else

                OrderItemsPriceStack(i) = OrderItemsPriceStack(i + 1)

            End If

        Next

        TopPointer = TopPointer - 1

    End Sub

    Public Sub PushOrder(ByVal OrderNoToAdd)

        TopPointerOrdersStack = TopPointerOrdersStack + 1
        OrdersSubmittedStack(TopPointerOrdersStack) = OrderNoToAdd

    End Sub

    Public Sub PopOrder(ByVal PosOrder)

        OrdersSubmittedStack(PosOrder) = 0

    End Sub

    Public Sub SortOrder(ByVal PosOrder)

        For i = PosOrder To TopPointerOrdersStack

            If OrdersSubmittedStack(i) = 0 Then

                OrdersSubmittedStack(i) = OrdersSubmittedStack(i + 1)

            Else

                OrdersSubmittedStack(i) = OrdersSubmittedStack(i + 1)

            End If

        Next

        TopPointerOrdersStack = TopPointerOrdersStack - 1

    End Sub

    Public Sub PushTable(ByVal TableNoToAdd)

        TopPointerTablesStack = TopPointerTablesStack + 1
        OccupiedTablesStack(TopPointerTablesStack) = TableNoToAdd

    End Sub

    Public Sub PopTable(ByVal PosTable)
        Dim UnOccupiedTable As Integer

        UnOccupiedTable = OccupiedTablesStack(PosTable)

        Select Case UnOccupiedTable

            Case Is = 1
                Tables.BtnTbl1.Enabled = True
                TableToPay.BtnTbl1.Enabled = False
            Case Is = 2
                Tables.BtnTbl2.Enabled = True
                TableToPay.BtnTbl2.Enabled = False
            Case Is = 3
                Tables.BtnTbl3.Enabled = True
                TableToPay.BtnTbl3.Enabled = False
            Case Is = 4
                Tables.BtnTbl4.Enabled = True
                TableToPay.BtnTbl4.Enabled = False
            Case Is = 5
                Tables.BtnTbl5.Enabled = True
                TableToPay.BtnTbl5.Enabled = False
            Case Is = 6
                Tables.BtnTbl6.Enabled = True
                TableToPay.BtnTbl6.Enabled = False
            Case Is = 7
                Tables.BtnTbl7.Enabled = True
                TableToPay.BtnTbl7.Enabled = False
            Case Is = 8
                Tables.BtnTbl8.Enabled = True
                TableToPay.BtnTbl8.Enabled = False
            Case Is = 9
                Tables.BtnTbl9.Enabled = True
                TableToPay.BtnTbl9.Enabled = False
            Case Is = 10
                Tables.BtnTbl10.Enabled = True
                TableToPay.BtnTbl10.Enabled = False
            Case Is = 11
                Tables.BtnTbl11.Enabled = True
                TableToPay.BtnTbl12.Enabled = False
            Case Is = 12
                Tables.BtnTbl12.Enabled = True
                TableToPay.BtnTbl12.Enabled = False
            Case Is = 14
                Tables.BtnTbl14.Enabled = True
                TableToPay.BtnTbl14.Enabled = False
            Case Is = 15
                Tables.BtnTbl15.Enabled = True
                TableToPay.BtnTbl15.Enabled = False
            Case Is = 16
                Tables.BtnTbl16.Enabled = True
                TableToPay.BtnTbl16.Enabled = False

        End Select

        OccupiedTablesStack(PosTable) = 0

    End Sub

    Public Sub SortTable(ByVal PosTable)

        For i = PosTable To TopPointerTablesStack

            If OccupiedTablesStack(i) = 0 Then

                OccupiedTablesStack(i) = OccupiedTablesStack(i + 1)

            Else

                OccupiedTablesStack(i) = OccupiedTablesStack(i + 1)

            End If

        Next

        TopPointerTablesStack = TopPointerTablesStack - 1

    End Sub

    Public Sub PushTotalCost(ByVal TotalCostToAdd)

        TopPointerTotalStack = TopPointerTotalStack + 1
        OrdersTotalCostStack(TopPointerTotalStack) = TotalCostToAdd

    End Sub

    Public Sub PopTotal(ByVal PosTotal)

        OrdersTotalCostStack(PosTotal) = 0.00

    End Sub

    Public Sub SortTotal(ByVal PosTotal)

        For i = PosTotal To TopPointerTotalStack

            If OrdersTotalCostStack(i) = 0 Then

                OrdersTotalCostStack(i) = OrdersTotalCostStack(i + 1)

            Else

                OrdersTotalCostStack(i) = OrdersTotalCostStack(i + 1)

            End If

        Next

        TopPointerTotalStack = TopPointerTotalStack - 1

    End Sub

    Public Function FindTable(ByVal LookUpTable)
        Dim LocatedPos As Integer

        For i = 0 To TopPointerTablesStack

            If OccupiedTablesStack(i) = LookUpTable Then

                LocatedPos = i

            End If

        Next

        Return LocatedPos

    End Function

    Public Function FindOrder(ByVal OrderPosInStack)

        Return OrdersSubmittedStack(OrderPosInStack)

    End Function

    Public Function FindTotal(ByVal TotalPosInStack)

        Return OrdersTotalCostStack(TotalPosInStack)

    End Function

    'Public Sub FindOrder(ByVal TableNo, ByVal OrderNo)
    'Dim s As String

    's = My.Computer.FileSystem.ReadAllText("Submitted Orders")

    '.Contains(TableNo) = True Then

    'MessageBox.Show("String was found")

    'End If

    'End Sub

End Module
