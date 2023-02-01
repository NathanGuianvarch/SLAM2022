Module Exercice_9
    Dim nbProduits As Integer

    'declaration d'une structure
    Public Structure Produit
        Dim Numero As Integer
        Dim Designation As String
        Dim Prix As Double
        Dim Quantite As Integer
    End Structure
    Public Structure Panier
        Dim Produit As Integer
        Dim Quantite As String
    End Structure

    'declaration du tableau de structure
    Dim MesProduits(100) As Produit
    Dim MonPanier As Panier


    Sub Main()

        MesProduits(1).Designation = "Banane"
        MesProduits(1).Numero = 1
        MesProduits(1).Quantite = 2
        MesProduits(1).Prix = 0.89

        MesProduits(2).Designation = "Pomme"
        MesProduits(2).Numero = 2
        MesProduits(2).Quantite = 4
        MesProduits(2).Prix = 0.5

        MesProduits(3).Designation = "Orange"
        MesProduits(3).Numero = 3
        MesProduits(3).Quantite = 6
        MesProduits(3).Prix = 0.3

        MesProduits(4).Designation = "Pain"
        MesProduits(4).Numero = 4
        MesProduits(4).Quantite = 1
        MesProduits(4).Prix = 0.95

        MesProduits(5).Designation = "Croissant"
        MesProduits(5).Numero = 5
        MesProduits(5).Quantite = 1
        MesProduits(5).Prix = 1.0

        nbProduits = 5

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("         TICKET DE CAISSE")
        Console.WriteLine("-----------------------------------")
        Console.WriteLine(Format(Date.Now, "Le dddd dd MMMM yyyy à HH:mm"))
        Console.WriteLine()
        Console.WriteLine(nbProduits.ToString & " articles")
        Console.WriteLine()
        Dim prixTotal As Double = 0.0
        Dim prixProd As Double
        For i = 1 To nbProduits
            Console.WriteLine(MesProduits(i).Quantite.ToString & " " & MesProduits(i).Designation.PadLeft(12) & " " & Math.Round(MesProduits(i).Prix, 2).ToString.PadRight(10))
            prixProd = MesProduits(i).Prix * MesProduits(i).Quantite
            Console.WriteLine("                             " & Math.Round(prixProd, 2).ToString)
            prixTotal = prixTotal + prixProd
        Next i

        Console.WriteLine("                             ----")

        Console.Write("TOTAL :                      ")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine(prixTotal.ToString)
        Console.ForegroundColor = ConsoleColor.White

        Console.WriteLine()
        Console.WriteLine("Merci de votre visite")
        Console.WriteLine("-----------------------------------")

        Console.ReadKey()
    End Sub
End Module