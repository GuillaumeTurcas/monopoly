using System;
using System.Collections.Generic;

public class Jeux
{
    public Jeux()
    {
        Console.WriteLine("Party initialized");
    }

    public void StringGames(List<Joueur> listJoueurs)
    {
        for (int i = 0; i < listJoueurs.Count; i++)
        {
            string inJail = "False";
            if (listJoueurs[i].Tinjail != 0) 
            { inJail = "True - " + listJoueurs[i].Tinjail + " turn(s) left in jail"; }
            Console.WriteLine("\n" + listJoueurs[i].Name + " :\n-Position : " + listJoueurs[i].Pos + "\n-In Jail : " + inJail);
        }
    }

    static int De()
    {
        Random rnd = new Random();
        return rnd.Next(1, 6);
    }

    public Joueur Turn(Joueur joueur)
    {
        Console.WriteLine("\n" + joueur.Name + ":");
        int turn = 1;
        int count = 0;
        int position = joueur.Pos;

        if (joueur.Tinjail == 0)
        {
            while (turn != 0)
            {
                turn--;
                count++;
                int de1 = De(); int de2 = De();
                Console.WriteLine("De 1 : " + de1 + "\nDe 2 : " + de2);
                if (de1 == de2) { turn += 1; }
                if (count == 3) { position = 10; turn = 0; joueur.Tinjail = 3; }
                else
                {
                    if (position == 30) { position = 10; turn = 0; joueur.Tinjail = 3; }
                    else { position += de1 + de2; }
                }
            }
        }

        else
        {
            joueur.Tinjail--;
            int de1 = De(); int de2 = De();
            Console.WriteLine("\nDe 1 : " + de1 + "\nDe 2 : " + de2);
            if (de1 == de2) { position += de1 + de2; }
        }

        joueur.Pos = position % 40;
        return joueur;
    }
}