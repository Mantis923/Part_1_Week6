/// HomeWork-Week 6(Graded Assignment)    
/// File Name: HomeWork6
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola
/// 
///This is a code created to copy an Array.First an array is initialized
///with ten items.First An array variable is declared and assigned with ten items in
///it.A second array variable is created. A new array with the same 
///length is given.Length property is used to get the size of the original 
///array is used. A loop reads values from the original array and places
///it into the new one.Print both arrays, original and new.
///



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] scores = new int[10] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };
            int[] copyScored = new int[10];

            Console.WriteLine("The first set of scores are: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(scores[i]);

            }
            Console.WriteLine("\nThe second set of scores are: ");
            for (int i = 0; i < scores.Length; i++)
            {
                copyScored[i] = scores[i];
                Console.WriteLine(copyScored[i]);

            }


            Console.ReadLine();
        }
    }
}
