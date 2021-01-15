using System;
using System.Collections.Generic;

public static class Factory
{
    public static Joueur CreateJoueur()
    {
        return new Joueur();
    }
}


public class Joueur
{
    private string name;
    private int pos ;
    private int tinjail;

    public string Name { get => name; set => name = value; }
    public int Pos { get => pos; set => pos = value; }
    public int Tinjail { get => tinjail; set => tinjail = value; }

    public Joueur()
    {
        pos = 0;
        tinjail = 0;
    }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }
}


