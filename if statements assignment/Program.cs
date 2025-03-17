namespace if_statements_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part1();

            //Part2();

            Part3();
        }
        public static void Part1()
        {
            string planet;
            double weight;
            Console.WriteLine("What is your earth weight in pounds?");
            double.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("What planet are you visiting?");
            Console.WriteLine("1. Venus   2. Mars   3. Jupiter   4. Saturn   5. Uranus   6. Neptune");
            planet = Console.ReadLine();

            if (planet.ToLower() == "venus" || planet == "1")
                Console.WriteLine("You will be " + (weight * 0.78) + " lbs");

            else if (planet.ToLower() == "mars" || planet == "2")
                Console.WriteLine("You will be " + (weight * 0.39) + " lbs");

            else if (planet.ToLower() == "jupiter" || planet == "3")
                Console.WriteLine("you will be " + (weight * 2.65) + " lbs");

            else if (planet.ToLower() == "saturn" || planet == "4")
                Console.WriteLine("You will be " + (weight * 1.17) + " lbs");

            else if (planet.ToLower() == "uranus" || planet == "five")
                Console.WriteLine("You will be " + (weight * 1.05) + " lbs");

            else if (planet.ToLower() == "neptune" || planet == "6")
                Console.WriteLine("You will be " + (weight * 1.23) + " lbs");

            else
                Console.WriteLine("planet not found");
        }
        public static void Part2()
        {
            int guess, number = 2;
            Console.WriteLine("Let's play a game!");
            Console.WriteLine("Guess the seceret number (1 - 10)");
            Int32.TryParse(Console.ReadLine(), out guess);

            if (guess == 2)
                Console.WriteLine("CORRECT");

            else
                Console.WriteLine("INCORRECT");

            Console.WriteLine("Press ENTER to find the correct number");
            Console.ReadLine();
            Console.WriteLine("The correct number was " + number);
        }
        public static void Part3()
        {
            string answer1, answer2, answer3, answer4;
            Console.WriteLine("1. Who assasinated Aberham Lincon?");
            answer1 = Console.ReadLine();
            
            if (answer1.ToLower() == "john wilkes booth")
                Console.WriteLine("That's correct! Great job");

            else 
                Console.WriteLine("Not even close...");

            Console.WriteLine("2. What is the smallest prime number?");
            answer2 = Console.ReadLine();

            if (answer2 == "2" || answer2.ToLower() == "two")
                Console.WriteLine("Correct! you are a math wizard!");

            else
                Console.WriteLine("Incorrect...keep in mind, the number is the lowest EVEN number possible.");

            Console.WriteLine("What colour does blue and yellow make?");
            Console.WriteLine("1. Green    2. Purple   3. Brown");
            answer3 = Console.ReadLine();

            if (answer3.ToLower() == "green" || answer3 == "1")
                Console.WriteLine("Correct! You must be an artist!");

            else
                Console.WriteLine("Incorrect...Sorry");

            Console.WriteLine("Dolphins are mammals - True/False");
            answer4 = Console.ReadLine();

            if (answer4.ToLower() == "true")
                Console.WriteLine("Correct! You are so smart!");

            else if (answer4.ToLower() == "false")
                Console.WriteLine("Nice try! But no.");
            
        }
    }
}
