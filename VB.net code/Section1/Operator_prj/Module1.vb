Module Module1

    Sub Main()

        Dim productPrice As Double = 10.25
        Dim productQTY As Integer = 100

        Dim productTotal As Double = productPrice * productQTY

        Console.WriteLine("Price Total : " & productTotal.ToString())
        Console.WriteLine("Price Total : {0}", productTotal.ToString())
        Console.ReadLine()
    End Sub

End Module
