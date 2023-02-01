Module Exercice_3
    Dim nombre As Single

    Sub Main()

        Console.Write("Entrer un nombre : ")
        nombre = Single.Parse(Console.ReadLine())
        nombre += +1.2
        Console.WriteLine("Nombre + 1,2 =  " & nombre.ToString)

        Console.ReadKey()

    End Sub
End Module
