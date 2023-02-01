Module Exercice_7
    Sub Main()
        Dim i As Integer = 1

        Console.Write("Entrer un nombre entre 0 et 170 : ")
        Dim Nombre As Integer
        Nombre = Integer.Parse(Console.ReadLine)

        Dim total As Double = 1
        For i = 1 To Nombre
            total *= i
        Next
        Console.WriteLine("Resultat boucle FOR   : " & total.ToString)

        total = 1
        i = 1
        While i <= Nombre
            total *= i
            i += 1
        End While
        Console.WriteLine("Resultat boucle WHILE : " & total.ToString)

        total = 1
        i = 1
        Do
            total *= i
            i += 1
        Loop While i <= Nombre
        Console.WriteLine("Resultat boucle DO While   : " & total.ToString)

        total = 1
        i = 1
        Do
            total *= i
            i += 1
        Loop Until i > Nombre
        Console.WriteLine("Resultat boucle DO until   : " & total.ToString)


        total = 1
        i = 1
        Do
            total *= i
            If i = Nombre Then
                Exit Do
            End If
            i += 1
        Loop
        Console.WriteLine("Resultat boucle DO LOOP   : " & total.ToString)



        Console.ReadKey()
    End Sub
End Module
