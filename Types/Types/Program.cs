namespace Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            byte age;
            bool pet;
            float footsize;
            Console.WriteLine("Hello, what's your name?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Do you have a pet?");
            pet = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("What is your size of food?");
            footsize = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("My name is {0}", name);
            Console.WriteLine("My age is {0}", age);
            Console.WriteLine("Do i have a pet? {0}", pet);
            Console.WriteLine("My shoe size is {0}", footsize);
        }
    }
}