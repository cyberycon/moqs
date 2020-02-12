Public Class Dog
    Implements IAnimal

    Public Function MakeSound() As String Implements IAnimal.MakeSound
        Return "woof"
    End Function
End Class
