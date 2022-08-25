using System;
using Test.classes;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        public static string CakesInCups(string a, string b) { return a + b; }

        public static int Names(string a, char b)
        {
            int antal = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    antal++;
                }
            }
            return antal;
        }

        public static int Dice()
        {
            Random rnd = new Random();
            return rnd.Next(1, 6);
        }

        public static int MegaDice()
        {
            Random rnd = new Random();
            int final = 0;
            int roll = rnd.Next(1, 11);
            while (roll == 10)
            {
                final += 10;
                roll = rnd.Next(1, 11);

            }
            final += roll;

            return final;
        }

        public static int TimesDice()
        {
            Random rnd = new Random();
            int final = 1;
            int roll = rnd.Next(0, 9);
            while (roll == 1)
            {
                final *= 2;
                roll = rnd.Next(0, 9);
            }
            final *= roll;
            return final;
        }

        public static int SuccesDice()
        {
            Random rnd = new Random();
            int succes = 0;
            for (int i = 0; i < 10000; i++)
            {
                int roll1 = rnd.Next(1, 11);
                int roll2 = rnd.Next(1, 11);
                if (roll1 == roll2)
                {
                    succes++;
                }
            }
            float result = ((float)succes / 10000) * 100;
            return (int)result;
        }

        public static int MegaSuccesDice()
        {
            Random rnd = new Random();
            int succes = 0;
            int antalTerninger = 5;
            bool fits = false;
            int[] numbers = new int[antalTerninger];
            for (int i = 0; i < 10000; i++)
            {
                for (int k = 0; k < antalTerninger; k++)
                {
                    numbers[k] = rnd.Next(1, 11);

                }
                for (int q = 0; q < antalTerninger; q++)
                {
                    for (int w = 0; w < antalTerninger; w++)
                    {
                        if (numbers[q] == numbers[w] && q != w)
                        {
                            fits = true;
                        }

                    }
                }
                if (fits == true)
                {
                    succes++;
                    fits = false;
                }

            }
            float result = ((float)succes / 10000) * 100;
            return (int)result;
        }

        public static void RotateArray()
        {
            int[] numbers = new int[5] { 3, 8, 9, 7, 6 };
            var temp = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = temp;

        }

        public static int PairArray()
        {
            int[] numbers = new int[7] { 9, 3, 9, 3, 9, 7, 9 };
            int pairs = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                bool partners = false;
                for (int q = 0; q < numbers.Length; q++)
                {
                    if (numbers[i] == numbers[q] && i != q)
                    {
                        partners = true;
                    }

                }
                if (!partners)
                {
                    return numbers[i];
                }
            }
            return pairs;
        }


        static void Main(string[] args)
        {
            //Person petOwner = new Person("Danielle Jensen", 25, "Magicroad 9238");

            //Pet adobtedDog = new Pet("Dog", "Sammy", 2, "Golden Retriever", petOwner);

            //string ix = CakesInCups("Rainbows and cupcakes", "Today is a warm day");
            //Console.WriteLine(ix);

            //int Letters = Names("Ditte Toftegaard", 't');
            //Console.WriteLine(Letters);


            //Console.WriteLine(Dice());

            //Console.WriteLine("MegaDice " + MegaDice());

            //Console.WriteLine("TimesDice " + TimesDice());

            //Console.WriteLine(SuccesDice());

            //Console.WriteLine(MegaSuccesDice());

            //Console.WriteLine([{ 0}], string.Join(", ", numbers));

            Console.WriteLine(PairArray());


            //string rainbow = "Cupcakes";
            //int cupcakes = 10;
            //float raindrops = 5.60f;
            //float blah = cupcakes*raindrops;

            //Console.WriteLine(blah);

            //int[] cake = new int[5];

            //cake[0] = 5;
            //cake[1] = 10;
            //cake[2] = 15;
            //cake[3] = 20;
            //cake[4] = 25;

            //List<Spørgeskema> liste = new List<Spørgeskema>();


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Velkommen til spørgeskemaet!");
            //    Console.WriteLine("Der vil være 5 spørgsmål til dig i dag");
            //    Console.WriteLine("Ready?");
            //    Console.WriteLine("Hvad hed dit første kæledyr? (Hvis du har haft et?)");
            //    string petName = Console.ReadLine();
            //    Console.WriteLine("Hvad er din yndlings ret?");
            //    string favouriteFood = Console.ReadLine();
            //    Console.WriteLine("Hvilken music genre er du til?");
            //    string music = Console.ReadLine();
            //    Console.WriteLine("Hvilken hobby har du?");
            //    string hobby = Console.ReadLine();
            //    Console.WriteLine("Hvor gammel er du?");
            //    int age = int.Parse(Console.ReadLine());

            //    Spørgeskema AboutYou = new Spørgeskema(petName, favouriteFood, music, hobby, age);
            //    liste.Add(AboutYou);
            //    Console.WriteLine("\n Du svarede \n");
            //    Console.WriteLine(AboutYou);
            //}




        }
    }
}
