using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Survey
{
    class Data
    {


        enum Months
        {
            Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec
        }

        public string FirstName;
        public string LastName;
        public int Month;
        public int Age;
        public int Day;

        public void Display()
        {
            // Prints an empty line to separate the inputs and output fields a bit better
            Console.WriteLine("");


            Console.WriteLine("Your full name is: {0} {1}", FirstName, LastName);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("Your birth month is: {0}", Month);
            Console.WriteLine("Your birth day is: {0}", Day);

            switch ((Months)Month)
            {
                case Months.Jan:
                    Console.WriteLine("You are an Aquarius.");
                    break;
                case Months.Feb:
                    Console.WriteLine("You are an Pisces.");
                    break;
                case Months.Mar:
                    Console.WriteLine("You are an Aries.");
                    break;
                case Months.Apr:
                    Console.WriteLine("You are a Taurus.");
                    break;
                case Months.May:
                    Console.WriteLine("You are a Gemini");
                    break;
                case Months.Jun:
                    Console.WriteLine("You are a Cancer");
                    break;
                case Months.Jul:
                    Console.WriteLine("You are a Leo");
                    break;
                case Months.Aug:
                    Console.WriteLine("You are a Virgo");
                    break;
                case Months.Sep:
                    Console.WriteLine("You are a Libra");
                    break;
                case Months.Oct:
                    Console.WriteLine("You are a Scorpio");
                    break;
                case Months.Nov:
                    Console.WriteLine("You are a Sagittarius");
                    break;
                case Months.Dec:
                    Console.WriteLine("You are a Capricorn");
                    break;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();
            Console.WriteLine("What is your first name?");
            data.FirstName = TryAnswer("name");

            Console.WriteLine("What is your last name?");
            data.LastName = TryAnswer("name");

            Console.WriteLine("What is your age?");
            data.Age = int.Parse(TryAnswer("age"));

            Console.WriteLine("What is your birth month?");
            data.Month = int.Parse(TryAnswer("month"));

            Console.WriteLine("What is your birth day?");
            data.Day = int.Parse(TryAnswer("day"));

            data.Display();

            static string TryAnswer(string entryType)
            {
                while (true)
                {
                    var question = Console.ReadLine();

                    if (entryType == "month")
                    {
                        if (question == "")
                        {
                            Console.WriteLine("You didn't type anything, please try again.");
                        }
                        else if ((int.Parse(question) > 12 || int.Parse(question) < 1))
                        {
                            Console.WriteLine("That is not a month");
                        }
                        else if ((int.Parse(question) < 12 || int.Parse(question) > 1))
                        {
                            return question;
                            break;
                        }
                    }
                    else if (entryType == "day")
                    {
                        if (question == "")
                        {
                            Console.WriteLine("You didn't type anything, please try again.");
                        }
                        else if ((int.Parse(question) > 31 || int.Parse(question) < 1))
                        {
                            Console.WriteLine("That is not a day");
                        }
                        else if ((int.Parse(question) < 31 || int.Parse(question) > 1))
                        {
                            return question;
                            break;
                        }
                    }
                    else if (question == "")
                    {
                        Console.WriteLine("You didn't type anything, please try again.");
                    }
                    else
                    {
                        return question;
                        break;
                    }
                }
            }
        }
    }
}
