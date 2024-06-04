namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine(Add(17,4));
            Console.WriteLine(Subtract(17,4));
            Console.WriteLine(Multiply(17,4));
            Console.WriteLine(DivisonAndModulus(17,4));
            */
            Console.WriteLine("Enter decimal to calculate radius");
            double userInput = double.Parse(Console.ReadLine());
            AreaOfCircle(userInput);
            
        }
        static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        static int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
        static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        static string DivisonAndModulus(int num1, int num2)
        {
            int divisionResult = num1 / num2;
            int modulusResult = num1 % num2;
            string output = $"{num1} / {num2} {divisionResult} remainder {modulusResult}";
            return output;
        }
        public static double AreaOfCircle(double radius)
        {
            double pi = Math.PI; 
            double pow = Math.Pow(radius, 2);
            double result = pi* pow;

            Console.WriteLine($"The area of a circle with a radius of {radius} is {result}");
            return result;
        }
    }
}
