namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] calcType = { "+", "-", "*", "/" };
            Console.Write("Enter calcType: ");
            string input = Console.ReadLine();

            List<double> numbers = new List<double>();
            while (true)
            {
                Console.Write("Enter a number: ");
                double num = Convert.ToDouble(Console.ReadLine());
                numbers.Add(num);

                Console.Write("Are you done choosing numbers? (y/n): ");
                string done = Console.ReadLine();
                if (done == "y") break;
            }

            double result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (input == "+")
                {
                    result += numbers[i];
                }
                else if (input == "-")
                {
                    result -= numbers[i];
                }
                else if (input == "*")
                {
                    result *= numbers[i];
                }
                else if (input == "/")
                {
                    result /= numbers[i];
                }
                else
                {
                    Console.WriteLine("Invalid");
                    return;
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
