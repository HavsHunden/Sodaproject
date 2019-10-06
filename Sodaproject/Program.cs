using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodaproject
{
    //En klass för själva läskbacken skapas. 
    class Sodacrate
    {
        //Här skapas en vektor som kan innehålla objekt av klassen soda, som i sin tur har olika egenskaper.
        private Soda[] sodaCrateArray = new Soda[25];
        int menyval; // deklareras här för att användas i metoden Run()

        private int i;//deklareras här för att användas i metoden add_soda
   
        public void Run()
        {
            //den här metoden körs i en loop tills det att användaren avslutat programmet
            
            do
            {
               
                //Här ligger en meny i vilken användaren matar in en int. 
                Console.WriteLine("Välkommen till läskbackssimulatorn! Gör ett val:");
                Console.WriteLine("[1] Lägg till läsk");
                Console.WriteLine("[2] Skriv ut innehåll");
                Console.WriteLine("[3] Beräkna pris");
                Console.WriteLine("[4] Ta bort läsk");
                Console.WriteLine("[5] Avsluta");

                //Då användaren kommer att skriva in ett nummer, konverteras den inmatade strängen till en int.
                string str = Console.ReadLine(); 
                menyval = Convert.ToInt32(str);

                //Här kopplas knapptryckningen till de olika metoder som finns för läskbacken
                switch (menyval)
                {
                    case 1:
                        //metoden add-soda anropas
                        add_soda();
                        break;

                    case 2:
                        //metodanrop av metod som skriver ut innehållet
                        print_crate();

                        break;

                    case 3:
                        //anropar metod som beräknar och skriver ut priset
                        calc_total();
                        break;

                    case 4:
                        //ersätter en läsk med en annan
                        remove_soda();
                        break;

                    case 5:
                        //avslutar programmet
                        Console.WriteLine("Programmet avslutas.");
                        break;


                }
            }
            while (menyval != 5); // Så länge användaren inte trycker 5, körs loopen
        }

        public void add_soda()
        {

            //De olika läsksorterna att välja på skrivs ut
            Console.WriteLine("Fyll din läskback med 25 läskflaskor. Välj en läsk åt gången:");
            Console.WriteLine("[1] Coca cola, 5 kr");
            Console.WriteLine("[2] Coca Cola Zero, 5 kr");
            Console.WriteLine("[3] Hallonsoda, 6 kr");
            Console.WriteLine("[4] Sockerdricka, 4 kr");
            Console.WriteLine("[5] Fanta, 5 kr");
            Console.WriteLine("[6] Grappo, 5 kr");
            Console.WriteLine("[7] Ramlösa, 4 kr");
            Console.WriteLine("[8] Loka Citron, 4 kr");
            Console.WriteLine("[9] Norrlands guld 3,5 %, 6 kr");
            Console.WriteLine("[10] Pripps blå 3,5%, 6 kr");



            //Här kan användaren via en for-loop och knapptryckningar lägga in en läsk i backen i taget. 
            for (int i = 0; i < 25; i++)
                {
                    //användaren skriver in ett nummer som sparas som int
                    string str1 = Console.ReadLine();
                    int läskval = Convert.ToInt32(str1);

                    //beroende på numret på läskval läggs ett objekt av soda in i läskbacken
                    //om exempelvis läskval = 1 ska soda1 läggas i läskbacksvektorn
                    switch (läskval)
                    {
                        case 1:
                        Soda soda1 = new Soda("Coca Cola", "läsk", 5);
                        sodaCrateArray[i] = soda1;
                        Console.WriteLine("Du lade till " + soda1.GetNamn());
                        break;

                        case 2:
                        Soda soda2 = new Soda("Coca Cola Zero", "lightläsk", 5);
                        sodaCrateArray[i] = soda2;
                        Console.WriteLine("Du lade till " + soda2.GetNamn());
                        break;


                        case 3:
                        Soda soda3 = new Soda("Hallonsoda", "läsk", 6);
                        sodaCrateArray[i] = soda3;
                        Console.WriteLine("Du lade till " + soda3.GetNamn());
                        break;


                        case 4:
                        Soda soda4 = new Soda("Sockerdricka", "läsk", 4);
                        sodaCrateArray[i] = soda4;
                        Console.WriteLine("Du lade till " + soda4.GetNamn());
                        break;

                        case 5:
                        Soda soda5 = new Soda("Fanta", "läsk", 5);
                        sodaCrateArray[i] = soda5;
                        Console.WriteLine("Du lade till " + soda5.GetNamn());
                        break;

                        case 6:
                        Soda soda6 = new Soda("Grappo", "läsk", 5);
                        sodaCrateArray[i] = soda6;
                        Console.WriteLine("Du lade till " + soda6.GetNamn());
                        break;

                        case 7:
                        Soda soda7 = new Soda("Ramlösa", "mineralvatten", 4);
                        sodaCrateArray[i] = soda7;
                        Console.WriteLine("Du lade till " + soda7.GetNamn());
                        break;

                        case 8:
                        Soda soda8 = new Soda("Loka Citron", "mineralvatten", 4);
                        sodaCrateArray[i] = soda8;
                        Console.WriteLine("Du lade till " + soda8.GetNamn());
                        break;

                        case 9:
                        Soda soda9 = new Soda("Norrlands Guld 3,5%", "öl", 6);
                        sodaCrateArray[i] = soda9;
                        Console.WriteLine("Du lade till " + soda9.GetNamn());
                        break;

                        case 10:
                        Soda soda10 = new Soda("Pripps blå 3,5%", "öl", 6);
                        sodaCrateArray[i] = soda10;
                        Console.WriteLine("Du lade till " + soda10.GetNamn());
                        break;

                }


                }
            Console.WriteLine("Backen är full! Tryck valfri tangent för att återgå till menyn.");
            Console.ReadKey();

        }

        public void remove_soda()
        {
            //metoden ersätter en läsk i backen med en annan
            Console.Clear();

            Console.WriteLine("Backen innehåller:");
            for (int i = 0; i < 25; i++)
            {//går först igenom vektorn i Sodacrate och kontrollerar om platsen är tom, vilket då skrivs ut
             //om det finns en läsk på varje plats, skrivs namn på läsken ut.

                if (sodaCrateArray[i] == null)
                {
                    Console.WriteLine("Platsen är tom!");
                }


                else if (sodaCrateArray[i] != null)
                {
                    //Här skrivs namnen ut och numret på positionen skrivs ut framför det (som ju måste vara i+1 då i från början är noll)
                    Console.WriteLine(i+1 + ". " + sodaCrateArray[i].GetNamn());
                }

            }
            if (sodaCrateArray[i] != null)
            {
                //om det finns en läsk på varje plats i vektorn får användaren välja en plats i den
                Console.WriteLine("För att ändra läsk, välj dess plats i backen:");
                string str = Console.ReadLine(); 
                int flaska = Convert.ToInt32(str);//flaska blir då numret på platsen i backen


                //De olika läsksorterna skrivs ut på samma sätt som i add_soda
                Console.WriteLine("Välj en ny läsk:");
                Console.WriteLine("[1] Coca cola, 5 kr");
                Console.WriteLine("[2] Coca Cola Zero, 5 kr");
                Console.WriteLine("[3] Hallonsoda, 6 kr");
                Console.WriteLine("[4] Sockerdricka, 4 kr");
                Console.WriteLine("[5] Fanta, 5 kr");
                Console.WriteLine("[6] Grappo, 5 kr");
                Console.WriteLine("[7] Ramlösa, 4 kr");
                Console.WriteLine("[8] Loka Citron, 4 kr");
                Console.WriteLine("[9] Norrlands guld 3,5 %, 6 kr");
                Console.WriteLine("[10] Pripps blå 3,5%, 6 kr");

                //knapptryckningen kopplas till en switch-sats som lägger in en ny läsk på vald plats
                str = Console.ReadLine(); 
                int smak = Convert.ToInt32(str);

                switch (smak)
                {
                    case 1:

                        Soda soda1 = new Soda("Coca Cola", "läsk", 5);
                        sodaCrateArray[flaska - 1] = soda1;//1 måste subtraheras från flaska eftersom indexeringen hos vektorn börjar på 0
                        break;

                    case 2:

                        Soda soda2 = new Soda("Coca Cola Zero", "lightläsk", 5);
                        sodaCrateArray[flaska - 1] = soda2;
                        break;


                    case 3:
                        Soda soda3 = new Soda("Hallonsoda", "läsk", 6);
                        sodaCrateArray[flaska - 1] = soda3;
                        break;


                    case 4:
                        Soda soda4 = new Soda("Sockerdricka", "läsk", 4);
                        sodaCrateArray[flaska - 1] = soda4;
                        break;

                    case 5:
                        Soda soda5 = new Soda("Fanta", "läsk", 5);
                        sodaCrateArray[flaska - 1] = soda5;
                        break;

                    case 6:
                        Soda soda6 = new Soda("Grappo", "läsk", 5);
                        sodaCrateArray[flaska - 1] = soda6;
                        break;

                    case 7:
                        Soda soda7 = new Soda("Ramlösa", "mineralvatten", 4);
                        sodaCrateArray[flaska - 1] = soda7;
                        break;

                    case 8:
                        Soda soda8 = new Soda("Loka citron", "mineralvatten", 4);
                        sodaCrateArray[flaska - 1] = soda8;
                        break;

                    case 9:
                        Soda soda9 = new Soda("Norrlands Guld", "öl", 6);
                        sodaCrateArray[flaska - 1] = soda9;
                        break;

                    case 10:
                        Soda soda10 = new Soda("Pripps blå", "öl", 6);
                        sodaCrateArray[flaska - 1] = soda10;
                        break;

                }
            }
            //om läskbacken är tom fås detta meddelande, men detta blir en upprepning.
            else if (sodaCrateArray[i] == null)
            {
                Console.WriteLine("Läskbacken är tom. Tryck valfri tangent för att återgå till menyn");
                Console.ReadKey();
            }

        }
        

        public void print_crate()
        {
            Console.Clear();
            //bool flaskorFinns = false;

           


            for (int i = 0; i < 25; i++)
            {
                if (sodaCrateArray [i]!=null)
                {

                Console.WriteLine(sodaCrateArray[i].GetNamn() + ", " + sodaCrateArray[i].GetDryckestyp());
                }
              
            }

           if (sodaCrateArray[i]== null)
            {
                Console.WriteLine("Backen är tom. Tryck valfri tangent för att återgå till menyn");
                Console.ReadKey();
            }


            

        }

        public void calc_total()
        {
            Console.Clear();

            bool flaskorFinns = false;

            int sum = 0;
            
            for (int i = 0; i < 25; i++)
            {
              
                if(sodaCrateArray [i]!= null)
                {
                    flaskorFinns = true;
                    sum = sum + sodaCrateArray[i].GetPris();
                }



            }

            if (flaskorFinns)
            {
                Console.WriteLine("Läsken i backen kostar " + sum + " kr. Tryck valfri tangent för att återgå till menyn");
                Console.ReadKey();
            }
            else if(flaskorFinns==false)
            {
                Console.WriteLine("Backen är tom. Tryck valfri tangent för att återgå till menyn");
                Console.ReadKey();
            }
        
         
        }
      
    }

    class Soda
    {

        //här ska vi ha en konstruktor för var och en av variablerna
        private string namn;
        private string dryckestyp;
        private int pris;

        public Soda(string v1, string v2, int v3)
        {
            this.namn = v1;
            this.dryckestyp = v2;
            this.pris = v3;
        }

        //nedanstående är olika metoder för att returnera namn, dryckestyp och pris
        public string GetNamn()
        {
            return namn;
        }

        public string GetDryckestyp()
        {
            return dryckestyp;
        }
        public int GetPris()
        {
            return pris;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //Skapar ett objekt av klassen Sodacrate som heter sodacrate
            var sodacrate = new Sodacrate();


            sodacrate.Run();
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
} 
