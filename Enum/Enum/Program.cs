namespace Enum
{
    enum Semaphore : int
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //double a = 5;
            //double b = 2;
            //double result = a / b;
            //Console.WriteLine("5 / 2 = {0}", result);
            double result = 10 % 3;
            Console.WriteLine(result);
            byte age = (byte) int.Parse(Console.ReadLine());
            Console.WriteLine(age);
        }
    }
}