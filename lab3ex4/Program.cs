using System;
using System.Linq;

namespace lab3ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Ex 4
            //  Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la tastatura. Scrieti functii care vor returna
            //  • Cel mai mare numar din vector
            //  • Cel mai mic numar din vector
            //  • Numerele divizibile cu 3
            //  Dificultate ridicata
            //  • Numerele prime din vector
            //  Apelati functiile si afisati-le rezultatele

            int n = int.Parse(Console.ReadLine());
            int[] vector = ReadVector(n);
            ShowVector(vector);
            ShowMaxVector(vector);
            ShowMinVector(vector);
            ShowPrimeNum(vector);
            ShowNumDivByThree(vector);
        }

        static int[] ReadVector(int n)
        {
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele vectorului");

            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            return v;
        }
        //pentru vizibilitate am lasat afisarea arrayului (totodata este mai usor de vazut min max in felul acesta)
        static void ShowVector(int[] vectorToShow)
        {
            Console.WriteLine("Afisam vectorul");

            for (int i = 0; i < vectorToShow.Length; i++)
            {
                Console.WriteLine(vectorToShow[i]);
            }
        }

        static void ShowMaxVector(int[] vectorMaxToShow)
        {
            Console.WriteLine("Afisam vectorul max");

            int max = vectorMaxToShow.Max();
            Console.WriteLine(max);

        }

        static void ShowMinVector(int[] vectorMinToShow)
        {
            Console.WriteLine("Afisam vectorul min");

            int min = vectorMinToShow.Min();
            Console.WriteLine(min);
        }

        static void ShowPrimeNum(int[] vectorPrimeNumber)
        {
            int j;

            for (int i = 0; i < vectorPrimeNumber.Length; i++)
            {
                for (j = 2; j < vectorPrimeNumber[i]; j++)
                    if ((vectorPrimeNumber[i] % 2 == 0))
                    {
                        Console.WriteLine("{0} : NU este numar prim", +vectorPrimeNumber[i]);
                        break;
                    }

                if (j == vectorPrimeNumber[i])
                {
                    Console.WriteLine("{0} : Este numar prim", +vectorPrimeNumber[i]);
                }

            }
        }

        static void ShowNumDivByThree(int[] vectorShowNumDBT)
        {
            int j;

            for (int i = 0; i < vectorShowNumDBT.Length; i++)
            {
                for (j = 0; j < vectorShowNumDBT[i]; j++)
                    if ((vectorShowNumDBT[i] % 3 == 0))
                    {
                        Console.WriteLine("{0} : este divizibil cu 3", +vectorShowNumDBT[i]);
                        break;
                    }
            }
        }
    }

}



