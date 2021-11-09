using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asks the user to enter name
            //programm greets the user using their first name

            Console.WriteLine("Enter you first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Hello" + firstName + "!");



            Console.Read();
        }
    }
}
