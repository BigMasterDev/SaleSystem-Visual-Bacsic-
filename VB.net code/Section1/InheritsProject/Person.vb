Public Class Person
    Private _fullName As String
    Public Property FullName() As String
        Get
            Return _fullName
        End Get
        Set(ByVal value As String)
            _fullName = value
        End Set
    End Property

    Public Sub ShowData()
        Console.WriteLine("Name: {0}", FullName)
    End Sub

    Public Overridable Sub ShowInfo()
        Console.WriteLine("Name: {0}", FullName)
    End Sub

    'Overloading have argurment in same name sub
    Public Sub ShowData(_fullName As String)
        Console.WriteLine("Name: {0}", _fullName)
    End Sub

End Class
