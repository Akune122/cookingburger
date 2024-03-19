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

    public void updateRep(int i)
    {
        this.reputation = this.reputation+i;
    }

}