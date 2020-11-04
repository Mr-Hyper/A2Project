Module SharedData

    Public SelectedTable As Integer
    Public OrderItemsPriceStack(255) As Decimal
    Public TopPointer As Integer = -1
    Public Total As Decimal
    Public SubTotal As Decimal

    Public Sub Push(ByVal Add)

        TopPointer = TopPointer + 1
        OrderItemsPriceStack(TopPointer) = Add

    End Sub

    Public Sub Pop(ByVal Position)

        For i = Position To TopPointer

            If OrderItemsPriceStack(i) = 0 Then

                OrderItemsPriceStack(i) = OrderItemsPriceStack(i + 1)

            Else

                OrderItemsPriceStack(i) = OrderItemsPriceStack(i + 1)

            End If

        Next

        TopPointer = TopPointer - 1

    End Sub

End Module
