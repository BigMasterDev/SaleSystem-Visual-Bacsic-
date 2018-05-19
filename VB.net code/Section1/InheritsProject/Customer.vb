Public Class Customer
    Inherits Person

    Private _address As String
    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set
    End Property

    Public Sub ShowDataCust()
        Console.WriteLine("Name : {0} address : {1}", FullName, Address)
    End Sub

    Public Overrides Sub ShowInfo()
        MyBase.ShowInfo()
        Console.WriteLine("Address: {0}", Address)
    End Sub

End Class
