Public Class Form1

    ' Declaramos una instancia de la clase MyStack(Of String) para manejar la pila de cadenas.
    Private stringStack As MyStack(Of String)
    Public Sub New()
        InitializeComponent()
        ' Creamos una nueva instancia de MyStack(Of String) para la pila de cadenas.
        stringStack = New MyStack(Of String)()
    End Sub

    ' Método para actualizar la lista de elementos en la pila en el ListBox.
    Private Sub UpdateStackListBox()
        ' Borramos todos los elementos en el ListBox.
        StackListBox.Items.Clear()

        ' Iteramos a través de la pila (desde el elemento superior al inferior).
        For i As Integer = stringStack.Count - 1 To 0 Step -1
            Dim item As String = stringStack(i)
            ' Agregamos cada elemento al ListBox.
            StackListBox.Items.Add(item)
        Next
    End Sub

    Private Sub PushButton_Click(sender As Object, e As EventArgs) Handles PushButton.Click
        ' Obtenemos el elemento desde el cuadro de texto de entrada.
        Dim item As String = InputTextBox.Text
        ' Agregamos el elemento a la pila.
        stringStack.Push(item)
        ' Actualizamos la lista en el ListBox.
        UpdateStackListBox()
        ' Limpiamos el cuadro de texto de entrada.
        InputTextBox.Clear()
    End Sub

    Private Sub PopButton_Click(sender As Object, e As EventArgs) Handles PopButton.Click
        Try
            ' Intentamos sacar un elemento de la pila.
            Dim poppedItem As String = stringStack.Pop()
            ' Mostramos un mensaje con el elemento desapilado.
            MessageBox.Show("Elemento desapilado: " & poppedItem)
            ' Actualizamos la lista en el ListBox.
            UpdateStackListBox()
        Catch ex As InvalidOperationException
            ' Capturamos una excepción si la pila está vacía.
            MessageBox.Show("La pila está vacía. No se pueden desapilar elementos.")
        End Try
    End Sub

    Private Sub PeekButton_Click(sender As Object, e As EventArgs) Handles PeekButton.Click
        Try
            ' Intentamos ver el elemento en la cima de la pila sin sacarlo.
            Dim topItem As String = stringStack.Peek()
            ' Mostramos un mensaje con el elemento en la cima de la pila.
            MessageBox.Show("Elemento en la cima de la pila: " & topItem)
        Catch ex As InvalidOperationException
            ' Capturamos una excepción si la pila está vacía.
            MessageBox.Show("La pila está vacía. No hay elementos para ver.")
        End Try
    End Sub
End Class
