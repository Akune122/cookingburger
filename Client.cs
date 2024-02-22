public class Client:Personnage 
{
    private string nom;
    private string prenom;
    private string dialogue;

    public Client(string nom,string prenom,string dialogue,int reputation):
    base(reputation)
    {
        this.nom=nom;
        this.prenom=prenom;
        this.dialogue=dialogue;
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
}