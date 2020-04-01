using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            myClass myclass = new myClass("Jeppe", "Thorsgade", 2200);

            myClass myclass1 = new myClass("Mike", "Roskilde", 4000);

            myClass myclass2 = new myClass("Madeleine", "Roskilde", 4000);

            myclass.postnr = 2200;

            Console.WriteLine(myclass);

            Console.WriteLine(myclass1);

            Console.WriteLine(myclass2);
            


        }
    }
}
