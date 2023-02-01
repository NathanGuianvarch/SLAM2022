Module Exercice_8
    Sub Main()
        Dim nombre As Integer, i As Integer, essai As Integer = 0
        Randomize()
        nombre = Int(1000 * Rnd()) + 0
        Console.WriteLine(nombre)
        Do
            Console.ForegroundColor = ConsoleColor.White
            Console.Write("Entrez une valeur entre 0 et 1000 : ")
            essai += 1
            i = Integer.Parse(Console.ReadLine())
            If i > nombre Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Le nombre que vous avez saisis est trop grand... ")
            End If
            If i < nombre Then
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Le nombre que vous avez saisis est trop petit...")
            End If
            If i = nombre Then
                Console.ForegroundColor = ConsoleColor.Green
                Console.WriteLine("Le nombre que vous avez saisis en " + essai.ToString + " est le bon !")
            End If
        Loop
    End Sub
End Module