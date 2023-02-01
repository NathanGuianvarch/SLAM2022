Module Exercice_4
    'Declaration des variables
    Dim montantHorsTaxe As Decimal
    Dim tauxTVA As Decimal
    Dim nombreArticle As Integer

    Dim PrixHorsTaxe As Decimal
    Dim montantTVA As Decimal
    Dim prixTTC As Decimal

    Sub Main()

        'Configuration de la console
        Console.ForegroundColor = ConsoleColor.Green
        Console.Title = "FACTURE"
        Console.SetWindowSize(80, 25)

        'Saisie des informations
        Console.Write("Entrer le montant HT : ")
        montantHorsTaxe = Decimal.Parse(Console.ReadLine)
        Console.Write("Entrer le nombre d'article : ")
        nombreArticle = Integer.Parse(Console.ReadLine())
        Console.Write("Entrer le Taux de la TVA : ")
        tauxTVA = Decimal.Parse(Console.ReadLine())

        'calcul des donnees
        PrixHorsTaxe = montantHorsTaxe * CDec(nombreArticle)
        montantTVA = (PrixHorsTaxe * tauxTVA) / 100
        prixTTC = montantTVA + PrixHorsTaxe

        'affichage des resultats
        Console.WriteLine()
        Console.WriteLine("Prix hors taxe : " & Math.Round(PrixHorsTaxe, 2).ToString)
        Console.WriteLine("Montant de la TVA : " & Math.Round(montantTVA, 2).ToString)
        Console.WriteLine("Prix TTC : " & Math.Round(prixTTC, 2).ToString)

        Console.ReadKey()
    End Sub
End Module
