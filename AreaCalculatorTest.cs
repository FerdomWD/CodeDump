// Just some testing arround with code combined with some math stuff, I'm learning so not the cleanest :P
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select shape: 1. Square, 2. Rectangle, 3. Trapezoid: ");
            string shape = Console.ReadLine();

            Console.Write("Enter value of side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value of side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Console.Write("If trapezoid, enter bigB: ");
            double bigB = Convert.ToDouble(Console.ReadLine());
            Console.Write("And VerticalA: ");
            double verticalA = Convert.ToDouble(Console.ReadLine());

            if (shape == "1")
            {
                Console.WriteLine(sideA * sideA);
            }else if (shape == "2")
            {
                Console.WriteLine(sideA * sideB);
            }else if (shape == "3")
            { 
                Console.WriteLine(bigB + sideB * verticalA / 2);
            }
            
            Console.ReadLine();
        }
    }
}
