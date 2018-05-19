Module Module1

    Sub Main()

        Dim myAge(3) As Integer
        myAge(0) = 10
        myAge(1) = 25
        myAge(2) = 30


        'Console.WriteLine(myAge(3))

        For i As Integer = 0 To 3
            Console.WriteLine(myAge(i))
        Next i

        Dim employee As New ArrayList
        employee.Add("werayoot")
        employee.Add(18)
        employee.Add("codingqqq")

        For Each em In employee
            Console.WriteLine(em)
        Next em

        Try
            Dim num1 As Integer
            Dim num2 As Integer
            num1 = 2
            num2 = 0
            Dim result As Integer = num1 / num2
            Console.WriteLine(result)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Throw
        End Try

        Console.ReadLine()
    End Sub

End Module
