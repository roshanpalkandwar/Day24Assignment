namespace Day24Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chosee a oprtion");
            Console.WriteLine("1. UC1 - Validate First Name");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FirstNamePattern1.ValidateFirstName();
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;

            }
        }
    }
}