using System;
using System.Collections.Generic;
using System.Linq;

public static class Extensions
{
    public static bool find<T>(this List<T> list, T target)
    {
        List<T> results = list.FindAll(x => x.Equals(target));
        return results.Count > 0;
    }
}

namespace CSharpUnityAss191
{
    class Program
    {

        static void Main(string[] args)
        {


            string[] stringArray = new string[5];
            stringArray[0] = "Hello";
            stringArray[1] = "How";
            stringArray[2] = "are";
            stringArray[3] = "you";
            stringArray[4] = "Today?";

            Console.WriteLine("Hello! Please enter a short string of text.");
            string newInput = Console.ReadLine();

            List<string> list = new List<string>(stringArray.ToList());
            list.Add(newInput);
            stringArray = list.ToArray();
            foreach (var elem in stringArray)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine("You spin me right round.");

            int x = 0;
            Console.WriteLine(x);

            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
            }
            Console.WriteLine("Or you used to anyway.");

            Console.WriteLine("Get Ready to jump!");
            int y = 0;
            Console.WriteLine("Jump");
            y++;

            while (y < 10)
            {
                Console.WriteLine(y + " Jump!");
                y++;
            }

            Console.WriteLine("Get Ready to duck!");
            int z = 0;
            Console.WriteLine("Quack");
            z++;

            while (z <= 10)
            {
                Console.WriteLine(z + " Quack!");
                z++;
            }

            Console.WriteLine("Food for thought.");

            List<string> FRUITS = new List<string>();
            FRUITS.Add("APPLE");
            FRUITS.Add("BANANA");
            FRUITS.Add("KIWI");
            FRUITS.Add("CHERRY");
            FRUITS.Add("APRICOT");
            FRUITS.Add("GRAPE");


            bool fruitBool = true;
            while (fruitBool == true)
            {
                Console.WriteLine("Search through the list by alphabetical letters. \n" +
                "Enter a letter to search for: ");
                string searchLetter = Console.ReadLine();

                

                List<string> fruitNew = new List<string>();
                fruitNew.Clear();

                foreach (var FRUIT in FRUITS.Where(s => s.IndexOf(searchLetter) == 0))
                {
                    fruitNew.Add(FRUIT);
                }
                    if (fruitNew.Count == 0)
                    {
                        Console.WriteLine("No elements matched your search criteria.");
                    }
                    else
                    {
                        foreach (var fru in fruitNew)
                        {
                        int index = FRUITS.FindIndex(a => a.Contains(fru));

                            Console.WriteLine(fru + " at an index of " + index);
                            fruitBool = false;
                            break;
                        }
                    }
            }

            

            Console.WriteLine("More food for thought.");

            List<string> VEGGIES = new List<string>();
            VEGGIES.Add("Carrot");
            VEGGIES.Add("Zuchini");
            VEGGIES.Add("Potato");
            VEGGIES.Add("Squash");
            VEGGIES.Add("Potato");
            VEGGIES.Add("Broccoli");


            bool vegBool = true;
            while (vegBool == true)
            {
                Console.WriteLine("Search through the list by alphabetical letters. \n" +
                "Enter a letter to search for: ");
                string searchLetter2 = Console.ReadLine();



                List<string> vegNew = new List<string>();
                vegNew.Clear();

                
                    foreach (var veg in VEGGIES.Where(s => s.IndexOf(searchLetter2) == 0))

                    {
                        vegNew.Add(veg);
                    }
                
                if (vegNew.Count == 0)
                {
                    Console.WriteLine("No elements matched your search criteria.");
                }
                else
                {
                    foreach (var veg in vegNew)
                    {
                        int index = VEGGIES.FindIndex(a => a.Contains(veg));

                        Console.WriteLine(veg + " at an index of " + index);
                    }
                    vegBool = false;
                    break;
                }
            }

            Console.WriteLine("Some last morsels for thought.");

            List<string> MEATS = new List<string>();
            MEATS.Add("Beef");
            MEATS.Add("Pork");
            MEATS.Add("Venison");
            MEATS.Add("Tuna");
            MEATS.Add("Pork");
            MEATS.Add("Chicken");
            MEATS.Add("Ribs");

            foreach (var meat in MEATS)
            {
                if (MEATS.Count(e => e == meat) > 1)
                {
                    Console.WriteLine(meat + " is elsewhere on the list");
                }
                else 
                {
                    Console.WriteLine(meat + " is a unique item");
                }
            }
        }
    }
}
