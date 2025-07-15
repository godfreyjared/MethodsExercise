namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();

            Console.WriteLine($"One day, {userName} was walking through the woods wearing a {favColor} shirt. \n {userName} saw a {favAnimal}. \n The animal also liked listening to {favBand}.");
        }

        public static int Add(int numOne, int numTwo)
        {

            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {

            return numOne - numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {

            return numOne / numTwo;
        }

        public static int Muiltiply(int numOne, int numTwo)
        {

            return numOne * numTwo;
        }

        static void Main(string[] args)
        {
            Madlib();
            Console.WriteLine(Add(numOne:2, numTwo:2));
            Console.WriteLine(Subtract(numOne: 2, numTwo: 2));
            Console.WriteLine(Divide(numOne: 2, numTwo: 2));
            Console.WriteLine(Muiltiply(numOne: 2, numTwo: 2));
        }
    }
}
