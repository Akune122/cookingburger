using System;
class Program {

    static void Main(string[] args)
{
    string choix;
    bool verif=false;

    Console.WriteLine("Merci de saisir votre pseudo de joueur !");
    string nom_j1=Console.ReadLine();
    Console.WriteLine("Appuyer sur une touche commencer la partie !");
    Console.ReadLine();

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
// Définition des couches
//-------------------------------
    Pain co1=null;
    Sauce co2=null;
    Fromage co3=null;
    Legume co4=null;
    Viande co5=null;
    Pain co6=null;
//-------------------------------
//Critique HISTOIRES
//-------------------------------

string histoire_claire="  Claire BASTIEN est une pilote de Formule 1 connue dans le monde entier !\n 133 victoires en grand prix, + de 200 podiums et + de 100 poles positions.\n Elle a révelé son secret après son 8ème sacre de championne du monde.\n Elle mange énormément de frommage en quadrilatère avec des côtés identiques dans des burgers et adore visiter les plus grands restaurants du monde.\n En revanche, elle est allergique aux cepe...";

//-------------------------------
// Clients
//-------------------------------

Client c1;
c1 = new Client("ZAERCHER","Lucas","<Bonjour, je veux un burger simple ! Mais je n'aime que le steak et pas les oignons -_- >",0,oignon,steak);

Client c2;
c2 = new Client("HERBAULT","Mathieu","<Bonjour, je voudrai un burger avec du rumsteak mais surtout pas de cheddar je suis gourmet.On est pas au mcdo. >",0,cheddar,rumsteak);

Client c3;
c3 = new Client("ZAERCHER","Olga","<Miaou miaou ! Miaou miaou ! Miaou miaou ! Miaou miaou ! Miaou miaou ! Miaou miaou ! (Vous croyez entendre poulet et tomate)>",0,tomate,poulet);

Client c4;
c4 = new Client("ZAERCHER","Yves","<Bonjour mon petit gars, j'aimerai un burger avec de la salade absolument mais je n'aime pas l'emmental !>",0,emmental,salade);

Critique critique1;
critique1 = new Critique(histoire_claire,"31/07/2005","BASTIEN","Claire","<Bonjour, j'aimerai manger aujourd'hui.>",20,oignon,cheddar);

Client c5;
c5 = new Client("BASTIEN","Cerise","<Miaou miaou ! Miaou miaou ! Miaou miaou ! Miaou miaou ! Miaou miaou ! Miaou miaou ! (Vous croyez entendre steak et parmesan)>",0,parmesan,steak);

Client c6;
c6 = new Client("SAMARAS","Ken","<Yo man, tu me fais un petit plat pas trop mal stp ;) Je kiff grave de bacon mais pas les tomates>",0,tomate,bacon);

//-------------------------------
// Listes Client
//-------------------------------

Client[] rep0 = new Client[] {c1,c2,c3,c4,c5,c6};
Critique[] rep20 = new Critique[] {critique1};


//-------------------------------
// Code
//-------------------------------
do{
    do {
    foreach (var client in rep0) {
        j1.updateEtoiles1();
        if (j1.getRep()>50 || j1.getRep()<0)
    {
        continue;
    }
    Console.WriteLine("----------------------------------------------------------------------------------------");
    Console.WriteLine("Votre pseudo : "+j1.getPseudo()+" / Votre réputation : "+j1.getRep()+" / Vos étoiles : "+j1.getEtoiles());
    Console.WriteLine("----------------------------------------------------------------------------------------");

    Console.WriteLine("Appuyer sur une touche pour recevoir un client...");
    Console.ReadLine();
    Console.WriteLine("Voici votre premier client :"+client.getPrenom()+" "+client.getNom());
    Console.WriteLine(client.getDialogue());

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
    
    if (client.verifB1(bj_1)==true && client.verifB2(bj_1)==false) 
    {
        Console.WriteLine(client.getPrenom()+" : Merci le burger était parfait !");
        j1.updateRep(10);
    }
    else if (client.verifB1(bj_1)==false && client.verifB2(bj_1)==false)
    {
        Console.WriteLine(client.getPrenom()+" : Je trouve qu'il manquait quelque chose...");
        j1.updateRep(5);
    }
    else if (client.verifB1(bj_1)==true && client.verifB2(bj_1)==true)
    {
        Console.WriteLine(client.getPrenom()+" : Y'a un truc que je peux pas manger là-dedans !");
        j1.updateRep(-5);
    }
    else {
        Console.WriteLine(client.getPrenom()+" : HORRIBLE !");
        j1.updateRep(-10);
    }

    Console.WriteLine("");
    Console.WriteLine("Continuer à jouer...");
    Console.ReadLine();
    }

    }while(j1.getRep()>=0 && j1.getRep()<50);



//-------------------------------------------------------------------------------------------------------------------
//Suite du code (reputation>20)
//-------------------------------------------------------------------------------------------------------------------
    do {
    foreach (var client in rep20) {
        j1.updateEtoiles2();
        if (j1.getRep()>100 || j1.getRep()<70)
    {
        continue;
    }
    Console.WriteLine("----------------------------------------------------------------------------------------");
    Console.WriteLine("Votre pseudo : "+j1.getPseudo()+" / Votre réputation : "+j1.getRep()+" / Vos étoiles : "+j1.getEtoiles());
    Console.WriteLine("----------------------------------------------------------------------------------------");

    Console.WriteLine("Appuyer sur une touche pour recevoir un client...");
    Console.ReadLine();
    Console.WriteLine("Voici votre premier client :"+client.getPrenom()+" "+client.getNom());
    Console.WriteLine(client.getDialogue());
    Console.WriteLine("");
    Console.WriteLine("Voulez-vous entendre son histoire ?");
    Console.WriteLine("Oui/Non");
    choix = Console.ReadLine();
    Console.WriteLine("");
    if (choix=="Oui")
    {
        Console.WriteLine("Voici l'histoire de "+client.getPrenom());
        Console.WriteLine(client.getHistoire());
    }
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
    
    if (client.verifB1(bj_1)==true && client.verifB2(bj_1)==false) 
    {
        Console.WriteLine(client.getPrenom()+" : Merci le burger était parfait !");
        j1.updateRep(25);
    }
    else if (client.verifB1(bj_1)==false && client.verifB2(bj_1)==false)
    {
        Console.WriteLine(client.getPrenom()+" : Je trouve qu'il manquait quelque chose...");
        j1.updateRep(10);
    }
    else if (client.verifB1(bj_1)==true && client.verifB2(bj_1)==true)
    {
        Console.WriteLine(client.getPrenom()+" : Y'a un truc que je peux pas manger là-dedans !");
        j1.updateRep(-10);
    }
    else {
        Console.WriteLine(client.getPrenom()+" : HORRIBLE !");
        j1.updateRep(-15);
    }

    Console.WriteLine("");
    Console.WriteLine("Continuer à jouer...");
    Console.ReadLine();
    }

    }while(j1.getRep()>=70 && j1.getRep()<100);

}while(j1.getRep()>0);

if (j1.getRep()>100)
{
    Console.WriteLine("----------------------------------------------------------------------------------------");
    Console.WriteLine("Votre pseudo : "+j1.getPseudo()+" / Votre réputation : "+j1.getRep()+" / Vos étoiles : "+j1.getEtoiles());
    Console.WriteLine("----------------------------------------------------------------------------------------");
    Console.WriteLine("Bravo ! Voous êtes le chef le plus connu de France grâce à vos burgers !");
}
else {
    Console.WriteLine("----------------------------------------------------------------------------------------");
    Console.WriteLine("Votre pseudo : "+j1.getPseudo()+" / Votre réputation : "+j1.getRep()+" / Vos étoiles : "+j1.getEtoiles());
    Console.WriteLine("----------------------------------------------------------------------------------------");
    Console.WriteLine("Vous avez perdu, votre réputation est en dessous de 0, vous faites faillite !");
}

} 

}

