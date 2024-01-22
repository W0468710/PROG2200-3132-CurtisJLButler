namespace Passcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What is the passcode?");
                var code = Console.ReadLine();

                if (code == "secret")
                {
                    Console.WriteLine("Authenticated");
                    break;
                }else
                {
                    Console.WriteLine("Not Authenticated, please try again");
                }
            }
            
            
        }
    }
}
