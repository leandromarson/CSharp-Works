using System;
using System.Collections.Generic;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("How many students in class: ");

            int studendsNumber;

            try
            {
                studendsNumber = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("\nNumber of students = "+studendsNumber);
                System.Console.WriteLine("Enter the name of students:\n");
               
               string[] students = new string[studendsNumber];
               for (int i = 0; i < students.Length; i++)
               {
                   students[i] = Console.ReadLine();
               }
               System.Console.WriteLine("--------------------------");
               Array.Sort(students);
               foreach (var item in students)
               {
                   System.Console.WriteLine(item);
               }



            }
            catch (Exception e)
            {                
                Console.WriteLine(e.Message);
            }

            
            
                        

            




            //List<string> shoppingList = new List<string>();

            // shoppingList.Add("Dreams");
            // shoppingList.Add("Caraibas");
            // shoppingList.Add("Doney");
            // shoppingList.Add("Karamara");
            
            // for (int i = 0; i < shoppingList.Count; i++)
            // {
            //     System.Console.WriteLine(shoppingList[i]);
            // }

            // shoppingList.Remove("Doney");
            // shoppingList.RemoveAt(0);

            // System.Console.WriteLine("------------------------");

            //  for (int i = 0; i < shoppingList.Count; i++)
            // {
            //     System.Console.WriteLine(shoppingList[i]);
            // }
            
            
            // string[] movies = new string[4];

            // System.Console.WriteLine("Type 4 movies");

            // for(int i=0; i<4; i++){
            //     movies[i] = Console.ReadLine();
            // }
            
            // System.Console.WriteLine("\nAlphabetically: ");

            // Array.Sort(movies);

            // for (int i = 0; i < movies.Length; i++)
            // {
            //     System.Console.WriteLine(movies[i]);
            // }           
            
            
            
            // string[] blabus = {"PinarêBA", "Oblateka", "Tonamela", "Porporremo", "Pinamba-Penaba-Amemo-Baba-Galu"};
            
            // for (int i = 1; i <= blabus.Length; i++)
            // {
            //     System.Console.WriteLine(i+" - "+blabus[i]);
            // }
            
            Console.ReadKey();
            
        }
    }
}
