using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programowanie_sem1
{
    class Program
    {
         //static void Main(string[] args)
       // {
            //1 podaj imie i nazwisko i wypisz na ekran

            /*string zmienna;

            Console.Write("podaj imie i nazwisko: ");
            zmienna = Console.ReadLine();
            Console.WriteLine("witaj, {0}!", zmienna);

            Console.ReadKey();
            */



            //2 podaj dlugosc boku i wyswietl objetosc

            /*int x;

            Console.Write("podaj dlugosc boku: ");
            x = Convert.ToInt16(Console.ReadLine());

            Console.Write("objetosc: {0}", x * x * x);

            Console.ReadKey();
            */


            //3 podaj liczbe i sprawdz czy jest parzysta/np
            /*
            int x;

            Console.Write("podaj liczbe: ");
            x = Convert.ToInt16(Console.ReadLine());

            if (x % 2 == 0)
                Console.Write("liczba jest parzysta");
            else
                Console.Write("liczba jest nieparzysta");

            Console.ReadKey();*/


            //4 3 liczby podaj min max i srednia

            /*Console.WriteLine("podaj 3 liczby: ");
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            int c = Convert.ToInt16(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("max: {0}", a);
                if (b > c)
                {

                    Console.WriteLine("min: {0}", c);

                }
                else
                    Console.WriteLine("min: {0}", b);
            }

            else
            {
                if (b > c)
                    Console.WriteLine("max: {0}", b);
                else
                    Console.WriteLine("max: {0}", c);

                Console.WriteLine("min: {0}", a);
            }
            double srednia = (a + b + c) / 3;

            Console.WriteLine("srednia: {0}", srednia);
            Console.ReadKey();*/


            //5 sprawdz czy rok jest przestepny

            /*Console.Write("podaj rok: ");

            int rok = Convert.ToInt16(Console.ReadLine());

            if (rok % 4 == 0)
            {
                if (rok % 100 == 0 && rok % 400 != 0)
                    Console.Write("rok {0} nie jest przestepny", rok);
                else
                    Console.Write("rok {0} jest przestepny", rok);
            }
            else
                Console.Write("rok nie jest przestepny");

            Console.ReadKey();*/


            //6 podaj liczbe i wyswietl odpowiadajacy jej miesiac

            /*Console.Write("podaj liczbe: ");
            int dzien = Convert.ToInt16(Console.ReadLine());

            switch (dzien)
            {
                case 1:
                    Console.Write("styczen");
                    break;
                case 2:
                    Console.Write("luty");
                    break;
                case 3:
                    Console.Write("marzec");
                    break;
                case 4:
                    Console.Write("kwiecien");
                    break;
                case 5:
                    Console.Write("maj");
                    break;
                case 6:
                    Console.Write("czerwiec");
                    break;
                case 7:
                    Console.Write("lipiec");
                    break;
                case 8:
                    Console.Write("sierpien");
                    break;
                case 9:
                    Console.Write("wrzesien");
                    break;
                case 10:
                    Console.Write("pazdziernik");
                    break;
                case 11:
                    Console.Write("listopad");
                    break;
                case 12:
                    Console.Write("grudzien");
                    break;
                default:
                    Console.Write("nie ma takiego miesiaca");
                    break;
            }
            
            Console.ReadKey();*/


            //7 wyswietlanie liczb od 0 do 999
            /*
            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();*/


            //8 obliczanie poteg liczby 2

            /*int potega;

            Console.Write("podaj liczbe: ");
            potega = Int32.Parse(Console.ReadLine()); //tryparse - oddaje true/false, out "zmienna"
         
                for(int i = 0; i < potega; i++)
                {
                    Console.Write("{0} ", Math.Pow(2, i));
                }
            
            Console.ReadKey();*/

            //9 tabliczka mnozenia

            /*int wiersze,kolumny;

            Console.WriteLine("podaj liczbe wierszy: ");
            wiersze = Int32.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbe kolumn: ");
            kolumny = Int32.Parse(Console.ReadLine());
       
            for(int i = 1; i <= wiersze; i++)
            {
                for(int j = 1; j <= kolumny; j++)
                {
                    Console.Write("{0}\t",i*j);
                }
                Console.Write("\n");
            }

            Console.ReadKey();
            */



            //10 nieparzyste do tysiaca
            /*
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0 || i % 11 == 0)
                    Console.Write("{0} ", i);
            }
            Console.ReadKey();*/


            //11 trojkaty


            /*for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* \t");
                }
                Console.Write("\n");
            }

            Console.Write("\n");

            for (int i = 10; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* \t");
                }
                Console.Write("\n");
            }

            Console.Write("\n");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("\t");
                }
                for (int j = 0; j < (10 - i); j++)
                {
                    Console.Write("*\t");
                }
                Console.Write("\n");
            }

            Console.Write("\n");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > (i + 1); j--)
                {
                    Console.Write("\t");
                }
                for (int j = i; j >= 0; j--)
                {
                    Console.Write("*\t");
                }
                Console.Write("\n");
            }

            Console.Write("\n");

            Console.ReadKey();*/


            //12  od 1 do 100 co 3 while
            /*int liczba = 1;

            while (liczba <= 100)
            {
                Console.WriteLine(liczba);
                liczba += 3;
            }
            Console.ReadKey();*/


            //12 do while suma kolenych liczb do momentu wpisania 0

            /*int liczba;
            int suma = 0;

            do
            {
                liczba = Int32.Parse(Console.ReadLine());
                suma += liczba;
                Console.WriteLine("Twoja liczba: {0}",liczba);
                Console.WriteLine("Suma: {0}", suma);
            } while (liczba != 0);
            Console.WriteLine("Koniec programu");

            Console.ReadKey();*/


            //13 silnia


            /*int liczba, silnia = 1;
            liczba = Int32.Parse(Console.ReadLine());

            while (liczba > 1)
            {
                silnia *= liczba--;
                //silnia = silnia * liczba;
                //liczba--;
            }
            Console.WriteLine(silnia);

            Console.ReadKey();*/

            //14 tablica

            /*string[] tab = new string[4] { "w1", "w2", "w3", "w4" };
            //tab[0]="w1" itd

            foreach (string element in tab)
                Console.WriteLine(element);
            //for (int i = 0; i < tab.Length; i++)
              //  Console.WriteLine(tab[i]);

            Console.ReadKey();*/

            //15 generator liczb losowych

            /*
            Random generator = new Random();
            int[] tab = new int[10];

            //Console.WriteLine(generator.Next(3));

            Console.WriteLine("liczenie w tablicy");
            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = generator.Next(20); //next(1,21) od 1 do 20 bez 21
                Console.WriteLine(tab[i]);
            }

            Console.WriteLine("\nParzyste");
            for(int i = tab.Length - 1; i >= 0; i--)
            {
                if (tab[i] % 2 == 0)
                    Console.WriteLine(tab[i]);
            }

            float suma = 0;
            for(int i = 0; i < tab.Length; i++)
            {
                suma += tab[i];
            }
            float srednia = suma / tab.Length;
            Console.WriteLine("\nSrednia: {0}", srednia);

            int minimum;
            minimum = tab[0];
            for(int i = 0; i < tab.Length; i++)
            {
                if (minimum > tab[i])
                    minimum = tab[i];
            }
            Console.WriteLine("\nMinimum: {0}", minimum);
            */


            //16 wpisywanie liczb do tablicy i ich wypisywanie i parzyste
            /*int[] tab = new int[10];

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("podaj {0} liczbe: ", i + 1);
                tab[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("\n");
            for(int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.Write("\n");

            for(int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 2 == 0)
                    Console.WriteLine(tab[i]);
            }

            for(int i = tab.Length - 1; i >= 0; i--)
            {
                if (tab[i] % 2 == 0)
                    Console.WriteLine(tab[i]);
            }

            Console.ReadKey();*/


            //17 totolotek losowanie 6 z 49 i zabezpieczenie przed podaniem tekstu zamiast liczby

            /*Console.Write("podaj liczbe powtorzen losowania: ");

            int x,tmp;
            Random losowa = new Random();
            int[] tab = new int[6];

            try
            {
                x = Int16.Parse(Console.ReadLine());
                for (int y = 0; y < x; y++)
                {
                    for (int i = 0; i < tab.Length; i++)
                    {
                        tab[i] = losowa.Next(1, 50); //do 49

                        for (int j = 0; j < i; j++)
                            if (tab[i] == tab[j]) i--;
                    }
                    for (int j = 0; j < tab.Length - 1; j++)
                    {
                        for (int i = 0; i < tab.Length - 1; i++)
                            if (tab[i] > tab[i + 1])
                            {
                                tmp = tab[i + 1];
                                tab[i + 1] = tab[i];
                                tab[i] = tmp;
                            }
                    }
                    foreach (int liczba in tab)
                        Console.Write("{0}, ", liczba);

                    Console.WriteLine();
                }
            }catch(FormatException ex)
            {
                Console.WriteLine("podaj liczbe nie wyraz");
            }
            Console.ReadKey();*/


            //18 przechwyc w kalkulatorze dzielenie przez zero, overflow i inne wyjatki

            /*Console.Write("podaj dwie liczby: ");

            try
            {
                int x, y;
                x = Int16.Parse(Console.ReadLine());
                y = Int16.Parse(Console.ReadLine());

                Console.Write("\nsuma: {0}\nroznica: {1}\niloczyn: {2}\niloraz: {3}", x + y, x - y, x * y, Math.Round(((double)x / y), 2));
            }
            catch(FormatException ex)
            {
                Console.WriteLine("podaj liczbe nie wyraz");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("nie mozna dzielic przez zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message); //domyslny komunikat o bledzie
            }
            Console.ReadKey();*/


            //19 funkcja silnia 
            //trzeba zakomentowac maina
           /* private static int liczSilnie(int i) {//int zwraca liczbe
            {
                if (i == 0)
                    return 1;
                else
                    return i * liczSilnie(i - 1);
            }
            }
        static void Main(string[] args)
        {
            Console.Write("podaj dla jakiej liczby chcesz obliczyc silnie: ");

            try
            {
                int x = Int16.Parse(Console.ReadLine());
                if (x < 0)
                    throw new FormatException();

                Console.WriteLine("{0}! = {1}", x, liczSilnie(x));
            }
            catch(FormatException ex)
            {
                Console.WriteLine("bledna liczba");
            }
            Console.ReadKey();
        }*/


        //20 pole i obwod kola o podanym promieniu
         private static double obliczPole(double x)
        {
            return Math.Round(x * x * Math.PI, 4);

        }
        private static double obliczObwod(double x)
        {
            return Math.Round(2 * Math.PI * x, 4);
        }

        static void Main(string[] args)
        {
            Console.Write("podaj promien: ");
            try
            {
                double x = Convert.ToDouble(Console.ReadLine());
                if (x < 0)
                    throw new FormatException();

                Console.WriteLine("pole kola o promieniu {0} wynosi {1}, a obwod {2}", x, obliczPole(x), obliczObwod(x));
            }
            catch (FormatException)
            {
                Console.WriteLine("bledna liczba");
            }
            Console.ReadKey();
        }
    }
}
