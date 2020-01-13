﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodaproject
{



    /// <summary>
    /// test
    /// </summary>

    class Sodacrate
    {

        private List<Soda> availableSodas;
        private Soda[] flaskor = new Soda[24];
        public int antal_flaskor = 0; //Håller reda på antal flaskor

       
        public Sodacrate()
        {
            availableSodas = new List<Soda>();
            Soda soda1 = new Soda("Coca Cola", "läsk", 5);
            availableSodas.Add(soda1);
            Soda soda2 = new Soda("Coca Cola Zero", "lightläsk", 5);
            availableSodas.Add(soda2);
            Soda soda3 = new Soda("Hallonsoda", "läsk", 6);
            availableSodas.Add(soda3);
            Soda soda4 = new Soda("Ramlösa", "mineralvatten", 4);
            availableSodas.Add(soda4);

        }

        public void Run()
        {
              Console.Clear();
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
                        Console.WriteLine(flaskor[3].GetNamn());
                        break;

                    case 2:
                        print_crate();
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
            Console.WriteLine("Fyll din läskback med 25 läskflaskor. Välj en läsk åt gången:");

            //Läskalternativen synliga för användaren genereras med hjälp av availableSodas. 

            for (int i = 0; i < availableSodas.Count; i++)
            {
                Console.WriteLine("[" + (i+1) +"] "+ availableSodas[i].GetNamn()+ ", "+ availableSodas[i].GetPris()+ " kr");
            }

            Console.WriteLine("[0] Avbryt");


            //Användaren får nu skriva in värden för att välja läsk

            //Vi går igenom läskbacken och lägger till en soda i varje position. Varje soda är en sorts kopia av rätt sorts soda i availableSodas.

            for (int i = 0; i < 24; i++)
            {

                //användaren skriver in ett nummer som sparas som int
                string str1 = Console.ReadLine();


                //if (str1 == "0")
                //{
                //    break;
                //}

                if (str1 != "")
                {
                    int läskval = Convert.ToInt32(str1) - 1;

                    //beroende på numret på läskval läggs ett objekt av soda in i läskbacken

                    Soda newSoda = new Soda(availableSodas[läskval].GetNamn(), availableSodas[läskval].GetDryckestyp(), availableSodas[läskval].GetPris());

                    flaskor[i] = newSoda;

                    Console.WriteLine(flaskor[i].GetNamn());
                }
                else
                {
                    Console.WriteLine("Välj läsk genom att skriva en siffra, 1-" + (availableSodas.Count)+".");
                    i--;
                }

            }

        }


        

        public void print_crate()
        {
            Console.Clear();
            for (int i = 0; i < 24; i++)
            {
                Console.WriteLine(flaskor[i].GetNamn());

            }
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
