using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace IJscozaak
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            int altijd = 0;

            do
            {
                string[] bakjeOfHoorntje = { "Bakje", "Klein Hoorntje", "Middel Hoorntje", "Groot Hoorntje" };
                double[] prijsBakjeOfHoorntje = { 1, 0.50, 1, 1.50 };
                string[] smaakjes = { "Aarbei", "Banaan", "Vanille", "Chocola", "Smurfenijs", "Bosbes" };
                string[] toppings = { "Slagroom", "Chocola", "Discodip" };
                int[] keuzeIjsbol = { 0, 0, 0, 0, 0, 0 };
                int keuzeBakjeOfHoorntje = 100;
                int keuzetoppings = 0;
                double totaalBedrag = 0;
                

                Console.WriteLine("Hallo en welkom bij Ijscozaak Sundae.");


                int herhaal = 0;
                do
                {
                    Console.WriteLine("\n"+"Wilt u een bakje of hoorntje?");

                    int num1 = 1;
                    for (int i = 0; i < prijsBakjeOfHoorntje.Length; i++)
                    {
                        Console.WriteLine(num1 + ". " + bakjeOfHoorntje[i] + " " + prijsBakjeOfHoorntje[i] + " euro");
                        num1++;
                    }

                    Console.WriteLine("\n" + "Vul uw keuze in en druk op enter");

                    try
                    {
                        keuzeBakjeOfHoorntje = Convert.ToInt32((Console.ReadLine()));
                    }
                    catch (Exception)
                    {

                    }


                    if (keuzeBakjeOfHoorntje < bakjeOfHoorntje.Length + 1)
                    {
                        herhaal = 1;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n" + "Dat is geen correctie invoer");
                        Console.WriteLine("Probeer het nogmaals");
                    }


                }
                while (herhaal == 0);


                keuzeIjsbol = Bolletjes(keuzeBakjeOfHoorntje, smaakjes);

                keuzetoppings = Toppings(toppings);

                totaalBedrag = Berekening(bakjeOfHoorntje, prijsBakjeOfHoorntje, keuzeBakjeOfHoorntje, smaakjes, keuzeIjsbol, toppings, keuzetoppings);

                Console.WriteLine("\n" + "In totaal kost u dit:");
                Console.WriteLine(totaalBedrag+" euro");
                Console.WriteLine("U kunt afrekenen bij de kassa");
                Console.ReadLine();

                Console.Clear();

            } while (altijd == 0);
            
























            static int[] Bolletjes(int grootte, string[] smaakjes)
            {

                int[] keuzeIjsbol = { 0, 0, 0, 0, 0, 0, 0 };
                int teller = 0;
                int herhaal2 = 0;
                int herhaal3 = 0;
                int meerBol = 0;

                Console.Clear();
                Console.WriteLine("Welke bolletjes wilt u?");
                Console.WriteLine("U kunt maximaal 6 bolletjes ijs kiezen");
                Console.WriteLine("");
                do
                {
                    int herhaal = 0;
                    teller++;
                    do
                    {

                        
                        Console.WriteLine("Vul uw keuze in en druk op enter");


                        int num1 = 1;
                        for (int i = 0; i < smaakjes.Length; i++)
                        {
                            Console.WriteLine(num1 + ". " + smaakjes[i] + " " + "1" + " euro");
                            num1++;
                        }

                        try
                        {
                            keuzeIjsbol[teller] = Convert.ToInt32((Console.ReadLine()));
                        }
                        catch (Exception)
                        {
                            keuzeIjsbol[teller] = 7;

                        }


                        if (keuzeIjsbol[teller] < smaakjes.Length+1 )
                        {
                            herhaal = 1;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n" + "Dat is geen correctie invoer");
                            Console.WriteLine("Probeer het nogmaals");
                            Console.WriteLine("");

                        }


                    }
                    while (herhaal == 0);

                    do
                    {
                        if (teller < 6)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Wilt u nog een Bolletje?");
                            Console.WriteLine("\n" + "1. Ja");
                            Console.WriteLine("2. Nee");
                            Console.WriteLine("");
                            Console.WriteLine("Vul uw keuze in en druk op enter");
                            Console.WriteLine("");

                            try
                            {
                                meerBol = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                meerBol = 3;
                            }

                            if (meerBol == 1)
                            {
                                herhaal3 = 1;
                            }
                            else if (meerBol == 2)
                            {
                                herhaal2 = 1;
                                herhaal3 = 1;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("\n" + "Dat is geen correctie invoer");
                                Console.WriteLine("Probeer het nogmaals");
                            }

                        }
                        else herhaal2 = 1;
                        

                    } while (herhaal3 == 0);

                    
                    Console.Clear();
                 
                    
                } while (herhaal2 == 0);



                return keuzeIjsbol;


            }

        }


        static int Toppings(string[] toppings)
        {
            int GeenTopping = 0;
            int herhaal = 0;
            Console.Clear();

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Wilt u een topping");
                Console.WriteLine("\n" + "1. Ja");
                Console.WriteLine("2. Nee");
                Console.WriteLine("");
                Console.WriteLine("Vul uw keuze in en druk op enter");
                Console.WriteLine("");

                try
                {
                    GeenTopping = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    GeenTopping = 3;
                }

                if (GeenTopping == 1)
                {
                    herhaal = 1;
                }
                else if (GeenTopping == 2)
                {
                    return 0;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n" + "Dat is geen correctie invoer");
                    Console.WriteLine("Probeer het nogmaals");
                }
            } while (herhaal == 0);

            Console.Clear();
            Console.WriteLine("We hebben 3 soorten toppings");
            Console.WriteLine("U kunt er 1 kiezen");
            Console.WriteLine("");


            int herhaal2 = 0;
            int keuzetopping = 0;

            do
            {


                Console.WriteLine("Vul uw keuze in en druk op enter");


                int num1 = 1;
                for (int i = 0; i < toppings.Length; i++)
                {
                    Console.WriteLine(num1 + ". " + toppings[i] + " " + "0,50" + " euro");
                    num1++;
                }

                try
                {
                    keuzetopping = Convert.ToInt32((Console.ReadLine()));
                }
                catch (Exception)
                {
                    keuzetopping = 20;
                }


                if (keuzetopping < toppings.Length + 1)
                {
                    herhaal2 = 1;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n" + "Dat is geen correctie invoer");
                    Console.WriteLine("Probeer het nogmaals");
                    Console.WriteLine("");

                }


            }
            while (herhaal2 == 0);

            return keuzetopping;

        }

        static double Berekening(string[] bakjeOfHoorntje, double[] prijsBakjeOfHoorntje, int keuzeBakjeOfHoorntje, string[] smaakjes, int[] keuzeIjsbol, string[] toppings, int keuzetoppings)
        {
            double totaalBedrag = 0;

            Console.Clear();
            Console.WriteLine("U heeft besteld:");
            Console.WriteLine("\n" + bakjeOfHoorntje[keuzeBakjeOfHoorntje-1] + " " + prijsBakjeOfHoorntje[keuzeBakjeOfHoorntje-1] + " euro");
            totaalBedrag = totaalBedrag + prijsBakjeOfHoorntje[keuzeBakjeOfHoorntje-1];

            int num = 0;
            for (int i = 0; i < smaakjes.Length+1; i++)
            {
                

                if (keuzeIjsbol[num] > 0)
                {
                    Console.WriteLine(smaakjes[keuzeIjsbol[num]-1] + " " + "1" + " euro");
                    totaalBedrag = totaalBedrag + 1;
                }               
                num++;
            }

            if (keuzetoppings > 0)
            {
                Console.WriteLine(toppings[keuzetoppings-1] + " topping" + " 0,50 cent");
                totaalBedrag = totaalBedrag + 0.50;
            }
            else
            {
                Console.WriteLine("U heeft geen topping");
            }
;
            return totaalBedrag;
        }
    }
}



