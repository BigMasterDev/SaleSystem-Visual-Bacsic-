Public Class SqlDB : Inherits ConnectDB
    Public Overrides Sub Open()
        Console.WriteLine("SQL Server Openning...")
    End Sub

    Public Overrides Sub Close()
        Console.WriteLine("SQL Server Closing...")
    End Sub

End Class
