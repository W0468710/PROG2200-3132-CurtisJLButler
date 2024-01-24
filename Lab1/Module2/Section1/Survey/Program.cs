using System.Xml.Linq;

namespace Survey
{
    class Data
    {
        public string FirstName;
        public string LastName;
        public string Month;
        public int Age;
        public int Day;

        public void Display()
        {
            //Prints an empty line to seperate the inputs and output fields a bit better
            Console.WriteLine("");


            Console.WriteLine("Your full name is: {0} {1}", FirstName, LastName);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("Your birth month is: {0}", Month);
            Console.WriteLine("Your birth day is: {0}", Day);

            if (Month == "march")
            {
                Console.WriteLine("You are an Aries.");
            }
            else if (Month == "april")
            {
                Console.WriteLine("You are a Taurus.");
            }
            else if (Month == "may")
            {
                Console.WriteLine("You are a Gemini");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();
            Console.WriteLine("What is your first name?");
            data.FirstName = TryAnswer();

            Console.WriteLine("What is your last name?");
            data.LastName = TryAnswer();

            Console.WriteLine("What is your age?");
            data.Age = int.Parse(TryAnswer());

            Console.WriteLine("What is your birth month?");
            data.Month = TryAnswer();

            Console.WriteLine("What is your birth day?");
            data.Day = int.Parse(TryAnswer());

            data.Display();

            static string TryAnswer()
            {
                var question = Console.ReadLine();
                if (question == "")
                {
                    Console.WriteLine("You didn't type anything, please try again.");
                }
                return question; 

                
            }


        }
    }
}
