namespace GradingGR
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the grade of the student: ");
            double sGrade = Convert.ToDouble(Console.ReadLine());

            if(sGrade >= 20)
            {
                Console.WriteLine("Excellent");
            }else if(sGrade >= 16.1 && sGrade < 18)
            {
                Console.WriteLine("Near Excellent");
            }else if(sGrade >= 13.1 && sGrade < 16)
            {
                Console.WriteLine("Good");
            }
            else if(sGrade >= 9.5 && sGrade < 13)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            
            Console.ReadLine();
        }
    }
}
