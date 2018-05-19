Module Module1

    Sub Main()

        Dim secretKey As String = "abc"
        Dim myKey As String = "abcd"

        'If myKey = secretKey Then
        '    Console.WriteLine("OK")
        'End If

        If myKey = secretKey Then
            Console.WriteLine("OK")
        Else
            Console.WriteLine("NOT ok")
        End If

        Dim price1 As Integer = 80
        Dim price2 As Integer = 60


        If price1 < price2 Then
            Console.WriteLine("price1 < price2")
        ElseIf price1 = price2 Then
            Console.WriteLine("Price1 = price 2")
        Else
            Console.WriteLine("Price1 > price 2")
        End If

        Console.ReadLine()
    End Sub

End Module
