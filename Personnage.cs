using System;

public abstract class Personnage
{
    private int reputation;

    public Personnage(int reputation)
    {
        this.reputation = reputation;
    }

    public int getRep()
    {
        return this.reputation;
    }

static void Main(string[] args)
{
    Joueur test;
    test = new Joueur("Loïc","★",100);
    Console.WriteLine(test.getRep());
    Console.WriteLine(test.getPseudo());
    Console.WriteLine(test.getEtoiles());
}


}