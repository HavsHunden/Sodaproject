using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodaproject
{
    class Sodacrate
    {
        private int[] flaskor = new int[24];
        private int antal_flaskor = 0; //Håller reda på antal flaskor

        public void Run()
        {

            //skapar 4 objekt av klassen soda. De ges namn, pris och dryckestyp
            var soda1 = new Soda("Coca Cola", "läsk", 5);
            var soda2 = new Soda("Coca Cola Zero", "lightläsk", 5);
            var soda3 = new Soda("S", "läsk", 6);
            var soda4 = new Soda("Ramlösa", "mineralvatten", 4);
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
            //Här vill jag att namnet på soda ska skrivas ut 
            Console.WriteLine("Fyll din läskback med 25 läskflaskor. Välj en läsk åt gången:");
            Console.WriteLine("[1] namn 1");
            Console.WriteLine("[2] namn 2");
            Console.WriteLine("[3] namn 3");
            Console.WriteLine("[4] namn 4");
            //+ ett val för att slumpa läsk



            //Det användaren skriver in är en siffra som nu ska kopplas till en dryck
            //om läskval = 1 ska soda1 läggas i sodacrate-vektorn
            //kan man ha en viss siffra som egenskap och lägga i klassen soda?

            //Vi går igenom läskbacken och lägger till en soda i varje position
            for (int i = 0; i < 25; i++)
            {
                string str1 = Console.ReadLine(); //användarens val
                int läskval = Convert.ToInt32(str1);//konverteras till en int då det ju är ett nummer vi får
                if (läskval == 1)
                {
                    flaskor[i] = läskval;
                }

                //skriv ut namnet på läsken som har lagts till
                Console.WriteLine("Du lade till:"); //+ drycken som lagts till);
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

        public string namn;
        public string dryckestyp;
        public int pris;

        //här ska vi ha en konstruktor för var och en av variablerna
        private string v1;
        private string v2;
        private int v3;

        public Soda(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
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
