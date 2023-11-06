using System.Reflection.Metadata.Ecma335;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            YourName();
            Add(5, 5);
            Subtract(5, 5);
            Multiply(5, 5);
            Divide(5, 5);
            Modulus(5, 5);
            //sum is my method that supports a range of arguments
            Sum(5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 55,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5);
        }
        public static void YourName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine($"Your name is {name}.  Your favorite color is {color}.  Your favorite animal is {animal}.  And lastly your favorite band is {band}.");
        }
        public static int Add(int a, int b)
        {
            int answer = a + b;
            Console.WriteLine($"The sum is: {answer} ");
            return answer;
        }
        public static int Subtract(int a, int b)
        {
            int answer = a - b;
            Console.WriteLine($"The difference is: {answer}.");
            return answer;
        }
        public static int Multiply(int a, int b)
        {
            int answer = a * b;
            Console.WriteLine($"Multiplied together, you get {answer}.");
            return answer;
        }

        public static double Divide(int a, int b)
        {
            double answer = a / b;
            Console.WriteLine($"Once Divided, you get {answer}.");
            return answer;
        }
        public static int Modulus(int a, int b)
        {
            int answer = a % b;
            Console.WriteLine($"The result is { answer }.");
            return answer;
        }
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum} ");
            return sum;
        }
    }
}
