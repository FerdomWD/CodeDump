namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BabyName, where you will find your baby's one destined-to-have name!");
            Console.Write("My baby's gender is: ");
            string babyGender = Console.ReadLine();

            if (babyGender == "male")
            {
                string[] maleNames = { "Adam", "Alex", "Aaron", "Ben", "Carl", "Dan", "David",
                       "Edward", "Fred", "Frank", "George", "Hal", "Hank", "Ike",
                       "John", "Jack", "Joe", "Larry", "Monte", "Matthew", "Mark",
                       "Nathan", "Otto", "Paul", "Peter", "Roger", "Roger", "Steve",
                       "Thomas", "Tim", "Ty", "Victor", "Walter" };

                Random rnd = new Random();
                int randomMaleName = rnd.Next(0, maleNames.Length);
                string randomNameOutput = maleNames[randomMaleName];

                Console.WriteLine("Your little boy's name should be: " + randomNameOutput);

            }
            else if (babyGender == "female")
            {
                string[] femaleNames = { "Alice", "Barbara", "Carol", "Dorothy", "Elizabeth",
                         "Eileen", "Fiona", "Gloria", "Heather", "Irene", "Jane",
                         "Joan", "Karen", "Kelly", "Laura", "Marilyn", "Nancy",
                         "Patricia", "Rachel", "Sandra", "Toni", "Victoria",
                         "Wendy", "Yvonne" };

                Random rnd = new Random();
                int randomFemaleName = rnd.Next(0, femaleNames.Length);
                string randomFNameOutput = femaleNames[randomFemaleName];

                Console.WriteLine("Your little girl's name should be: " + randomFNameOutput);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.ReadLine();
        }
    }
}
