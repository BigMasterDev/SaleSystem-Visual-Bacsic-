Module Module1

    Sub Main()
        Dim productName As String
        Dim productPrice As Double
        Dim productNum As Integer
        Dim productStatus As Char = "1"
        Dim productStatus2 As Integer
        Dim productBrand As String = "500"


        productName = "Coke"
        productPrice = 30.25
        productNum = 100

        'Integer.Parse Change type char to integer
        'productStatus2 = Integer.Parse(productStatus)
        productStatus2 = Integer.Parse(productBrand)
        Dim productStatus3 As Integer = CInt(productBrand)


        Console.WriteLine(productName)
        Console.WriteLine(productPrice)
        Console.WriteLine(productNum)
        Console.WriteLine(productStatus2)
        Console.WriteLine(productStatus3)


        Console.ReadLine()

    End Sub

End Module
