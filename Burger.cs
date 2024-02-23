public class Burger
{
    private Aliment couche1;
    private Aliment couche2;
    private Aliment couche3;
    private Aliment couche4;
    private Aliment couche5;
    private Aliment couche6;


    public Burger(Aliment couche1,Aliment couche2,Aliment couche3,Aliment couche4,Aliment couche5,Aliment couche6)
    {
        this.couche1 = couche1;
        this.couche2 = couche2;
        this.couche3 = couche3;
        this.couche4 = couche4;
        this.couche5 = couche5;
        this.couche6 = couche6;
    }

    public string getCouche(int i)
    {
        if (i==1) {
            return this.couche1.getAffichage();
        }
        if (i==2) {
            return this.couche2.getAffichage();
        }
        if (i==3) {
            return this.couche3.getAffichage();
        }
        if (i==4) {
            return this.couche4.getAffichage();
        }
        if (i==5) {
            return this.couche5.getAffichage();
        }
        if (i==6) {
            return this.couche6.getAffichage();
        }
        else {
            return "Couche inexistante";
        }
    }

}