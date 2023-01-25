using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your angle: ");
        int degrees = Convert.ToInt32(Console.ReadLine());

        double radians = degrees * (Math.PI / 180);
        double roundedNumber = Math.Round(radians, 3);
        string output = roundedNumber.ToString();

        Console.WriteLine("Radians: " + output);

        Console.ReadLine();
    }
}
