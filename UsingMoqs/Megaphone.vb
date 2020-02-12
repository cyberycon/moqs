Public Class Megaphone
    Function Amplify(Animal As IAnimal) As String
        Return Animal.MakeSound().ToUpper()

    End Function
End Class
