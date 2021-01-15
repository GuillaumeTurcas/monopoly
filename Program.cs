using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many players you are (2-6) ?");
        int c = Convert.ToInt32(Console.ReadLine());
        List<Joueur> listJoueurs = new List<Joueur>();
        for (int i = 0; i < c; i++)
        {
            listJoueurs.Add(Factory.CreateJoueur());
            listJoueurs[i].Name = Convert.ToString(i);
        }
        Jeux jeux = new Jeux();
        Console.WriteLine("How many turn do you want befor the end ?");
        int t = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            Console.WriteLine("\nTurn : " + i);
            for (int j = 0; j < listJoueurs.Count; j++) { listJoueurs[j] = jeux.Turn(listJoueurs[j]); }
            jeux.StringGames(listJoueurs);
            Console.ReadKey();
        }
        Console.ReadKey();
    }    
}

