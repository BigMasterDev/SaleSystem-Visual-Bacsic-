Public Class Customer
    'Propoty
    Private _custFullName As String
    Public Property CustFullName() As String
        Get
            Return _custFullName
        End Get
        Set(ByVal value As String)
            _custFullName = value
        End Set
    End Property

    'Method 1 sub 2 function
    Public Sub ShowData()
        Console.WriteLine("Customer Name {0}", _custFullName)
    End Sub
    Public Function ShowCust() As String
        Return _custFullName
    End Function

    'Constructor 2 type 1 no parameter 2 parameter
    'no parameter
    Public Sub New()
        Console.WriteLine("Constructor strating......")
    End Sub
    'parameter
    Public Sub New(ByVal cName As String)
        _custFullName = cName
        Console.WriteLine("Constructor with customer name {0}", _custFullName)
    End Sub

End Class
