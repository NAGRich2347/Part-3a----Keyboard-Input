using System;

namespace Part_3a____Keyboard_Input
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int age;
            string response;
            Console.WriteLine("Say Hello!");
            response = Console.ReadLine();
            Console.WriteLine("You said: " + response);
            Console.WriteLine("Please enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your age is {age}.");
            Console.ReadLine();
        }
    }
}
