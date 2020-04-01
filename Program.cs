using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            myClass myclass = new myClass("Jeppe", "Thorsgade");

            myclass.postnr = 2200;

            Console.WriteLine(myclass);
            


        }
    }
}
