using System;
class Program {

    static void Main(string[] args)
{
    string choix;
    bool verif=false;

    Console.WriteLine("Merci de saisir votre pseudo de joueur !");
    string nom_j1=Console.ReadLine();

    Joueur j1;
    j1 = new Joueur(nom_j1,"*",0);

// Définition des aliments :
//-------------------------------
// Pain 
//-------------------------------
    Campagne campagne;
    campagne = new Campagne("Campagne");
    Nature nature;
    nature = new Nature("Nature");
    Sesame sesame;
    sesame = new Sesame("Sesame");
    Mie mie;
    mie = new Mie("Mie");
//-------------------------------
// Legume
//-------------------------------
    Oignon oignon;
    oignon = new Oignon("Oignon");
    Salade salade;
    salade = new Salade("Salade");
    Tomate tomate;
    tomate = new Tomate("Tomate");
//-------------------------------
// Viande
//-------------------------------
    Steak steak;
    steak = new Steak("Steak");
    Poulet poulet;
    poulet = new Poulet("Poulet");
    Bacon bacon;
    bacon = new Bacon("Bacon");
    Rumsteak rumsteak;
    rumsteak = new Rumsteak("Rumsteak");
//-------------------------------
// Fromage
//-------------------------------
    Cheddar cheddar;
    cheddar = new Cheddar("Cheddar");
    Emmental emmental;
    emmental = new Emmental("Emmental");
    Parmesan parmesan;
    parmesan = new Parmesan("Parmesan");
//-------------------------------
// Sauces
//-------------------------------
    Poivre poivre;
    poivre = new Poivre("Poivre");
    Ketchup ketchup;
    ketchup = new Ketchup("Ketchup");
    Moutarde moutarde;
    moutarde = new Moutarde("Moutarde");
    Mayo mayo;
    mayo = new Mayo("Mayo");
//-------------------------------
    
    Pain co1=null;
    Sauce co2=null;
    Fromage co3=null;
    Legume co4=null;
    Viande co5=null;
    Pain co6=null;


//-------------------------------
// Clients
//-------------------------------

    Client c1;
    c1 = new Client("ZAERCHER","Lucas","<Bonjour, je veux un burger simple ! Mais je n'aime que le steak et pas les oignons -_- >",0,oignon,steak);



    do {
    Console.WriteLine("----------------------------------------------------------------------------------------");
    Console.WriteLine("Votre pseudo : "+j1.getPseudo()+" / Votre réputation : "+j1.getRep()+" / Vos étoiles : "+j1.getEtoiles());
    Console.WriteLine("----------------------------------------------------------------------------------------");

    Console.WriteLine("Appuyer sur une touche pour recevoir un client...");
    Console.ReadLine();
    Console.WriteLine("Voici votre premier client :"+c1.getPrenom()+" "+c1.getNom());
    Console.WriteLine(c1.getDialogue());

    Console.WriteLine("");

    do {
    Console.WriteLine("Choisir votre première couche :");
    Console.WriteLine("1.Campagne / 2.Sésame / 3.Nature / 4.Mie");
    choix = Console.ReadLine();
    if (choix==campagne.getAffichage())
    {       
        co1=campagne;
        verif=true;
    }
    else if (choix==sesame.getAffichage())
    {
        co1=sesame;
        verif=true;
    }
    else if (choix==mie.getAffichage())
    {
        co1=mie;
        verif=true;
    }
    else if (choix==nature.getAffichage())
    {
        co1=nature;
        verif=true;
    }
    else {
        Console.WriteLine("Choix invalide...");
    }
    }while(verif!=true);

    verif=false;

    do {
    Console.WriteLine("");
    Console.WriteLine("Choisir votre deuxième couche :");
    Console.WriteLine("1.Ketchup / 2.Mayo / 3.Poivre / 4.Moutarde");
    choix = Console.ReadLine();
    if (choix==ketchup.getAffichage())
    {       
        co2=ketchup;
        verif=true;
    }
    else if (choix==mayo.getAffichage())
    {
        co2=mayo;
        verif=true;
    }
    else if (choix==poivre.getAffichage())
    {
        co2=poivre;
        verif=true;
    }
    else if (choix==moutarde.getAffichage())
    {
        co2=moutarde;
        verif=true;
    }
    else {
        Console.WriteLine("Choix invalide...");
    }
    }while(verif!=true);
    verif=false;

    do {
    Console.WriteLine("");
    Console.WriteLine("Choisir votre troisième couche :");
    Console.WriteLine("1.Cheddar / 2.Emmental / 3.Parmesan");
    choix = Console.ReadLine();
    if (choix==cheddar.getAffichage())
    {       
        co3=cheddar;
        verif=true;
    }
    else if (choix==emmental.getAffichage())
    {
        co3=emmental;
        verif=true;
    }
    else if (choix==parmesan.getAffichage())
    {
        co3=parmesan;
        verif=true;
    }
    else {
        Console.WriteLine("Choix invalide...");
    }
    }while(verif!=true);
    verif=false;

    do {
    Console.WriteLine("");
    Console.WriteLine("Choisir votre quatrième couche :");
    Console.WriteLine("1.Salade / 2.Tomate / 3.Oignon");
    choix = Console.ReadLine();
    if (choix==salade.getAffichage())
    {       
        co4=salade;
        verif=true;
    }
    else if (choix==tomate.getAffichage())
    {
        co4=tomate;
        verif=true;
    }
    else if (choix==oignon.getAffichage())
    {
        co4=oignon;
        verif=true;
    }
    else {
        Console.WriteLine("Choix invalide...");
    }
    }while(verif!=true);
    verif=false;

    do {

    Console.WriteLine("");
    Console.WriteLine("Choisir votre cinquième couche :");
    Console.WriteLine("1.Steak / 2.Poulet / 3.Bacon / 4.Rumsteak");
    choix = Console.ReadLine();
    if (choix==steak.getAffichage())
    {       
        co5=steak;
        verif=true;
    }
    else if (choix==poulet.getAffichage())
    {
        co5=poulet;
        verif=true;
    }
    else if (choix==bacon.getAffichage())
    {
        co5=bacon;
        verif=true;
    }
    else if (choix==rumsteak.getAffichage())
    {
        co5=rumsteak;
        verif=true;
    }
    else {
        Console.WriteLine("Choix invalide...");
    }
    }while(verif!=true);
    verif=false;

    do {

    Console.WriteLine("");
    Console.WriteLine("Choisir votre dernière couche :");
    Console.WriteLine("1.Campagne / 2.Sésame / 3.Nature / 4.Mie");
    choix = Console.ReadLine();
    if (choix==campagne.getAffichage())
    {       
        co6=campagne;
        verif=true;
    }
    else if (choix==sesame.getAffichage())
    {
        co6=sesame;
        verif=true;
    }
    else if (choix==mie.getAffichage())
    {
        co6=mie;
        verif=true;
    }
    else if (choix==nature.getAffichage())
    {
        co6=nature;
        verif=true;
    }
    else {
        Console.WriteLine("Choix invalide...");
    }
    }while(verif!=true);

    verif=false;

    Burger bj_1;
    bj_1 = new Burger(co1,co2,co3,co4,co5,co6);

    Console.WriteLine("");
    Console.WriteLine("Votre burger est constitué de :");
    Console.WriteLine(bj_1.getCouche(1));
    Console.WriteLine(bj_1.getCouche(2));
    Console.WriteLine(bj_1.getCouche(3));
    Console.WriteLine(bj_1.getCouche(4));
    Console.WriteLine(bj_1.getCouche(5));
    Console.WriteLine(bj_1.getCouche(6));

    Console.WriteLine(" ");
    Console.WriteLine("Vérification du burger :");
    Console.WriteLine("Appuyer sur une touche pour continuer...");
    Console.ReadLine();
    
    if (c1.verifB1(bj_1)==true && c1.verifB2(bj_1)==false) 
    {
        Console.WriteLine(c1.getPrenom()+" : Merci le burger était parfait !");
        j1.updateRep(10);
    }
    else if (c1.verifB1(bj_1)==false && c1.verifB2(bj_1)==false)
    {
        Console.WriteLine(c1.getPrenom()+" : Je trouve qu'il manquait quelque chose...");
        j1.updateRep(5);
    }
    else if (c1.verifB1(bj_1)==true && c1.verifB2(bj_1)==true)
    {
        Console.WriteLine(c1.getPrenom()+" : Y'a un truc que je peux pas manger là-dedans");
        j1.updateRep(-5);
    }
    else {
        Console.WriteLine(c1.getPrenom()+" : HORRIBLE !");
        j1.updateRep(-10);
    }

    Console.WriteLine(" ");

    }while(j1.getRep()>=0);

}

}

