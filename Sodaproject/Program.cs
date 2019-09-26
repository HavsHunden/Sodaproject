using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodaproject
{
    class Sodacrate
    {
        private Soda[] flaskor = new Soda[24];
        public int antal_flaskor = 0; //Håller reda på antal flaskor

       

        public void Run()
        {

            //skapar 4 objekt av klassen soda. De ges namn, pris och dryckestyp

           
          
            
          
            //de här objekten kan man sedan välja på i add_soda 
            
            

            do
            {
                //En meny i vilken användaren matar in en int. 
                Console.WriteLine("Välkommen till läskbackssimulatorn! Gör ett val");
                Console.WriteLine("[1] Lägg till läsk");
                Console.WriteLine("[2] Skriv ut innehåll");
                Console.WriteLine("[3] Beräkna pris");
                Console.WriteLine("[4] Avsluta");

                //jag vill att den här menyn försvinner när en metod körs

                string str = Console.ReadLine(); //användarens val
                int menyval = Convert.ToInt32(str);

                //här kopplas knapptryckningen till de olika metoder som finns för läskbacken
                switch (menyval)
                {
                    case 1:
                        //metoden add-soda anropas
                        add_soda();
                        
                        break;

                    case 2:
                        //gå till metod
                        break;
                    case 3:
                        //gå till metod
                        break;
                    case 4:
                        //gå till metod
                        break;

                }
            }
            while (antal_flaskor < 24);
        }

        public void add_soda()
        {
            

            Console.Clear();
            //Namnet från listan skrivs ut för vardera läsk
            Console.WriteLine("Fyll din läskback med 25 läskflaskor. Välj en läsk åt gången:");
            Console.WriteLine("[1]" + flaskor);
            Console.WriteLine("[2]" + flaskor);
            Console.WriteLine("[3]" + flaskor);
            Console.WriteLine("[4]" + flaskor);
            //+ ett val för att slumpa läsk

           

            //Det användaren skriver in är en siffra som nu ska kopplas till en dryck
            //om läskval = 1 ska soda1 läggas i sodacrate-vektorn
            //kan man ha en viss siffra som egenskap och lägga i klassen soda?

            //Vi går igenom läskbacken och lägger till en soda i varje position
            for (int i = 0; i < 25; i++)
            {
                //användaren skriver in ett nummer som sparas som int
                string str1 = Console.ReadLine(); 
                int läskval = Convert.ToInt32(str1);

                //beroende på numret på läskval läggs ett objekt av soda in i läskbacken
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


        

        public void print_crate()
        {
            //kod här
            //Missa inte hjälpkoden som finns i projektbeskrivningen
            //Där beskrivs hur man löser det med tomma positioner i vektorn
        }

        public int calc_total()
        {
            return 1;

            //kod här
            //Tänk på att inte räkna med tomma positioner i vektorn
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
