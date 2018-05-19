Module Module1

    Sub Main()
        'Build new oject C1 name follow class
        'Dim C1 As Customer = New Customer()

        'insert vaule into proppoty define C1 "John"
        'C1.CustFullName = "John"
        'Console.WriteLine(C1.CustFullName)

        'Use Method sub
        'C1.ShowData()

        'use Method function 
        'Dim myName As String = C1.ShowCust()
        'Console.WriteLine(myName)


        'Construtor parameter
        Dim c2 As Customer = New Customer("Toon")
        c2.ShowData()

        Console.ReadLine()
    End Sub

End Module
