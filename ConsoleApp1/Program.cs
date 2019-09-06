using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#SucksLikeHell");
            Console.WriteLine("Why do you hate c#?");
            string cSharpSucksLikeHell;
            cSharpSucksLikeHell = Console.ReadLine();
            Console.WriteLine(" Hello " + cSharpSucksLikeHell);
            Console.WriteLine("How much you hate c#?");
            int dislikeTowardsCSharp;
            dislikeTowardsCSharp = int.Parse(Console.ReadLine());
            int differenceFromLovetoCSharp = 10 - dislikeTowardsCSharp;
            Console.WriteLine(" Your hate's difference from loving c# is ...  " + differenceFromLovetoCSharp);
            Console.ReadLine();
        }
    }
}
