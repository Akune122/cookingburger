using System;

public class Personnage
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
    Personnage test;
    test = new Personnage(100);
    Console.WriteLine(test.getRep());
}


}