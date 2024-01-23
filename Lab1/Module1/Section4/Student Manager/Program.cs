namespace Student_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class?");
            var studentCount = int.Parse(Console.ReadLine());

            var studentData = new object[studentCount, 2];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Student Name: ");
                studentData[i, 0] = Console.ReadLine();

                Console.WriteLine("Student Grade: "); // Change to "Student Grade" instead of "Student Number"
                studentData[i, 1] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentData[i, 0], studentData[i, 1]);
            }
        }
    }
}