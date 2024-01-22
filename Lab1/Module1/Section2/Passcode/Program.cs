namespace Passcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the passcode?");
            var code = Console.ReadLine();

            if (code == "secret")
            {
                Console.WriteLine("Authenticated");
            }
            else if(code != "secret")
            {
                Console.WriteLine("Not Authenticated");
            }
        }
    }
}
