Imports System
Imports Xunit
Imports UsingMoqs
Imports Moq

Namespace XUnitTestProject1
    Public Class UsingMoqsTest
        <Fact>
        Sub DogMakesWoofSound()
            Dim dog As New Dog
            Assert.True(dog.MakeSound() = "woof")

        End Sub

        <Fact>
        Sub MegaphoneMakesAnimalLouder()
            Dim animalMock = New Mock(Of IAnimal)
            animalMock.Setup(Function(c) c.MakeSound()).Returns("oink")
            Dim megaphone As Megaphone = New Megaphone


            Assert.Equal("OINK", megaphone.Amplify(animalMock.Object))


        End Sub
    End Class

End Namespace

