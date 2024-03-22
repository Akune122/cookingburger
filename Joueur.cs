public class Joueur:Personnage 
{
    private string pseudo;
    private string etoiles;

    public Joueur(string pseudo,string etoiles,int reputation):
    base(reputation)
    {
        this.pseudo=pseudo;
        this.etoiles=etoiles;
    }

    public string getPseudo()
    {
        return this.pseudo;
    }

    public string getEtoiles()
    {
        return this.etoiles;
    }

    public void updateEtoiles()
    {
        if (this.getRep()<50 && this.getRep()>0) {
            this.etoiles = "*";
    }
    else if (this.getRep()>50) {
            this.etoiles = "**";
    }
    else if (this.getRep()<0) {
            this.etoiles = "";
    }
    }

}