public abstract class Aliment
{
    private string affichage;

    public Aliment(string affichage)
    {
        this.affichage=affichage;
    }

    public string getAffichage()
    {
        return this.affichage;
    }
}