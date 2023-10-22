Friend Class MyStack(Of T)
    Private stackList As List(Of T)

    ' Constructor de la pila
    Public Sub New()
        stackList = New List(Of T)()
    End Sub

    ' Método para agregar un elemento a la pila
    Public Sub Push(item As T)
        stackList.Add(item)
    End Sub

    ' Método para sacar y devolver el elemento superior de la pila
    Public Function Pop() As T
        If stackList.Count = 0 Then
            Throw New InvalidOperationException("La pila está vacía.")
        End If

        Dim lastIndex As Integer = stackList.Count - 1
        Dim poppedItem As T = stackList(lastIndex)
        stackList.RemoveAt(lastIndex)

        Return poppedItem
    End Function

    ' Método para ver el elemento en la cima de la pila sin sacarlo
    Public Function Peek() As T
        If stackList.Count = 0 Then
            Throw New InvalidOperationException("La pila está vacía.")
        End If

        Return stackList(stackList.Count - 1)
    End Function

    ' Propiedad para obtener la cantidad de elementos en la pila
    Public ReadOnly Property Count As Integer
        Get
            Return stackList.Count
        End Get
    End Property

    ' Indexador para acceder a elementos en la pila por índice
    Default Public ReadOnly Property Item(index As Integer) As T
        Get
            Return stackList(index)
        End Get
    End Property
End Class
