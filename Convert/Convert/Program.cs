namespace Converti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");

            //byte age = (byte) int.Parse(Console.ReadLine());
            //byte age = byte.Parse(Console.ReadLine());
            byte age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Your name is {0} and age is {1}", name, age);
            Console.WriteLine("What is your favorite day of week?");
            DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);

            var a = 5;
        }
    }
}