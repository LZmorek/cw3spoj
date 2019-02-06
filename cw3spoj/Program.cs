using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw3spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers krokDrugi = new Numbers();
            krokDrugi.PoborIlosci();          
        }
    }
    class Numbers
    {
        public int PobierzLiczbe(int Liczba)
        {
            string end = "";
            do
            {
                try
                {
                    Console.WriteLine("prosze podac liczbe");
                    string liczbaStr = Console.ReadLine();
                    Liczba = Convert.ToInt32(liczbaStr);
                    if (Liczba >= 1 && Liczba <= 1000000000)
                    {
                        Console.WriteLine("poprawna liczba.Dziękuje");
                        end = "end";
                    }
                    else
                    {
                        Console.WriteLine("prosze podac poprawna liczbe z przedzialu 1-1 mld");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("nie prawidlowy format podanego znaku");
                }
            } while (end != "end");
            return Liczba;
        }
        public int Potegowanie(int podstawa, int wykladnik)

        {
            int wynik=podstawa;
            
            for (int i = 1; i <= wykladnik; i++)
            {
                wynik *= podstawa;
            }
            Console.WriteLine("wynik: " + (wynik % 10) + "");
            Console.ReadKey();
            return wynik;
            
        }
        public void PoborIlosci()
        {
            string end = "";
            int PodstawaPotegi = 1;
            int wykladnikPotegi = 1;
            do
            {
                try
                {
                    string iloscWejscSTR;
                    Console.WriteLine("prosze podac liczbe od 1 do 30: ");
                    iloscWejscSTR = Console.ReadLine();
                    int iloscWejsc = Convert.ToInt32(iloscWejscSTR);
                    if (iloscWejsc >= 1 && iloscWejsc <= 30)
                    {
                        Console.WriteLine("podano prawidlowa liczbe dziekuje");
                        for (int i = 0; i < iloscWejsc; i++)
                        {
                            Numbers krokpierwszy = new Numbers();
                            PodstawaPotegi = krokpierwszy.PobierzLiczbe(PodstawaPotegi);
                            wykladnikPotegi = krokpierwszy.PobierzLiczbe(wykladnikPotegi);
                            krokpierwszy.Potegowanie(PodstawaPotegi, wykladnikPotegi);
                        }
                        end = "end";
                    }
                    else
                    {
                        Console.WriteLine("podano bledna liczbe. sproboj ponownie");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("podano bledny znak( ma byc liczba calkowita z przedzialu 1-30");
                }

            } while (end != "end") ;
            
           }
        
        }
    }

