public class Critique:Client
{
    private string histoire;
    private string date_naissance;

    public Critique(string histoire,string date_naissance,string nom,string prenom,string dialogue,int reputation,Aliment allergique,Aliment primordial):
    base(nom,prenom,dialogue,reputation,allergique,primordial,burger)
    {
        this.histoire=histoire;
        this.date_naissance=date_naissance;
    }

    public string getHistoire()
    {
        return this.histoire;
    }

    public string getDateNaissance()
    {
        return this.date_naissance;
    }
}