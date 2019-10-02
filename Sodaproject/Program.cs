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
        private Soda[] flaskor = new Soda[24];
        int menyval; // deklareras här för att användas i metoden Run()
        private int i;

        public void Run()
        {
            //den här metoden körs i en loop tills det att användaren avslutat programmet
            
            do
            {
               
                //Här ligger en meny i vilken användaren matar in en int. 
                Console.WriteLine("Välkommen till läskbackssimulatorn! Gör ett val");
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
                        Console.WriteLine("Läsken i backen kostar " + calc_total() +" kr.");
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
            //Här kan användaren via en for-loop och knapptryckningar lägga in en läsk i backen i taget. 
            for (int i = 0; i < 5; i++)
            {
               
                Console.Clear();
                //De olika läsksorterna skrivs ut
                Console.WriteLine("Fyll din läskback med 25 läskflaskor. Välj en läsk åt gången:");
                Console.WriteLine("[1] Coca cola, 5 kr");
                Console.WriteLine("[2] Coca Cola Zero, 5 kr");
                Console.WriteLine("[3] Hallonsoda, 6 kr");
                Console.WriteLine("[4] Ramlösa, 4 kr");

                //användaren skriver in ett nummer som sparas som int
                string str1 = Console.ReadLine(); 
                int läskval = Convert.ToInt32(str1);
                
                //beroende på numret på läskval läggs ett objekt av soda in i läskbacken
                //om exempelvis läskval = 1 ska soda1 läggas i läskbacksvektorn
                switch (läskval)
                {


                    case 1:

                    Soda soda1 = new Soda("Coca Cola", "läsk", 5);

                    flaskor [i] = soda1; 
                    break;

                    case 2:
                   
                    Soda soda2 = new Soda("Coca Cola Zero", "lightläsk", 5);
                    flaskor[i] = soda2;
                    break;


                    case 3:
                    Soda soda3 = new Soda("Hallonsoda", "läsk", 6);
                    flaskor[i] = soda3;
                    break;


                    case 4:
                    Soda soda4 = new Soda("Ramlösa", "mineralvatten", 4);
                    flaskor[i] = soda4;
                    break;

                }

                
            }

        }

        public void remove_soda()
        {
            
            Console.Clear();

            Console.WriteLine("Backen innehåller:");
            for (int i = 0; i < 5; i++)
            {

                if (flaskor[i] == null)
                {
                    Console.WriteLine("Platsen är tom!");
                }


                else if (flaskor[i] != null)
                {
                    Console.WriteLine(i+1 + ". " + flaskor[i].GetNamn());
                }

            }
            if (flaskor[i] != null)
            {


                //print_crate();
                Console.WriteLine("För att ändra läsk, välj dess plats i backen:");
                string str = Console.ReadLine(); //användarens val
                int flaska = Convert.ToInt32(str);

                Console.WriteLine("Välj en ny läsk:");
                Console.WriteLine("[1] Coca cola, 5 kr");
                Console.WriteLine("[2] Coca Cola Zero, 5 kr");
                Console.WriteLine("[3] Hallonsoda, 6 kr");
                Console.WriteLine("[4] Ramlösa, 4 kr");


                str = Console.ReadLine(); //användarens val
                int smak = Convert.ToInt32(str);

                switch (smak)
                {
                    case 1:

                        Soda soda1 = new Soda("Coca Cola", "läsk", 5);
                        flaskor[flaska - 1] = soda1;
                        break;

                    case 2:

                        Soda soda2 = new Soda("Coca Cola Zero", "lightläsk", 5);
                        flaskor[flaska - 1] = soda2;
                        break;


                    case 3:
                        Soda soda3 = new Soda("Hallonsoda", "läsk", 6);
                        flaskor[flaska - 1] = soda3;
                        break;


                    case 4:
                        Soda soda4 = new Soda("Ramlösa", "mineralvatten", 4);
                        flaskor[flaska - 1] = soda4;
                        break;
                }
            }

            else if (flaskor[i] == null)
            {
                Console.WriteLine("Läskbacken är tom. Tryck valfri tangent för att återgå till menyn");
                Console.ReadKey();
            }

        }
        

        public void print_crate()
        {
            Console.Clear();
         
            for (int i = 0; i < 5; i++)
            {
               
                if (flaskor [i] == null)
                {
                Console.WriteLine("Platsen är tom!");
                }
               

                else if (flaskor [i]!= null)
                {
                    Console.WriteLine(flaskor[i].GetNamn() +", " + flaskor[i].GetDryckestyp());
                }

            }

        }

        public int calc_total()
        {
            Console.Clear();
           
            int sum = 0;
            
            for (int i = 0; i < 5; i++)
            {

                sum = sum + flaskor[i].GetPris();

            }
            return sum;
         
        }

        public void find_soda()
        {
            //Betyg C
            //Beskrivs i läroboken på sidan 147 och framåt (kodexempel på sidan 149)
            //Man ska kunna söka efter ett namn
            //Man kan använda string-metoderna ToLower() eller ToUpper() 
        }

        public void sort_sodas()
        {
            //Betyg A-C
            //Beskrivs i läroboken på sidan 147 och framåt (kodexempel på sidan 159)
            //Man ska kunna sortera vektorn med flaskor och med bubble sort
            //Det är mycket svårt att sortera efter bokstavsordning - är inte flaskorna egna objekt utan bara strängar...
            //... går det bra att sortera efter längden på namnet istället. 
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
