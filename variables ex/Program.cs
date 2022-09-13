using System;

namespace variables_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "jay kay";
            int dogAge= 20;
            char middleInitial = 'A';
            bool isAlive= true;
            decimal weight = 70.5m;
            double height = 3.5;


            Console.WriteLine($"My dog's full name is {fullName} and his middle initial is {middleInitial}. He is {dogAge} years old and weighs {weight}lbs and is {height}ft tall. Is he alive: {isAlive}.");
        }
    }
}
