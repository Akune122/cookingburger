public class Client:Personnage 
{
    private string nom;
    private string prenom;
    private string dialogue;
    private Aliment allergique;
    private Aliment primordial;

    public Client(string nom,string prenom,string dialogue,int reputation,Aliment allergique,Aliment primordial):
    base(reputation)
    {
        this.nom=nom;
        this.prenom=prenom;
        this.dialogue=dialogue;
        this.allergique=allergique;
        this.primordial=primordial;
    }

    public string getNom()
    {
        return this.nom;
    }

    public string getPrenom()
    {
        return this.prenom;
    }

    public string getDialogue()
    {
        return this.dialogue;
    }

    public bool verifB1(Burger burger)
    {
        for (int i=1;i<7;i++)
    {
        if (burger.getCouche(i)==this.primordial.getAffichage())
        {
            return true;
        }
    }
    return false ;
    }

    public bool verifB2(Burger burger)
    {
        for (int i=1;i<7;i++)
    {
        if (burger.getCouche(i)==this.allergique.getAffichage())
        {
            return true;
        }
    }
    return false ;
    }
}