namespace Day24Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chosee a oprtion");
            Console.WriteLine("1. UC1 - Validate First Name");
            Console.WriteLine("2. UC2 - Validate Last Name");
            Console.WriteLine("3. UC3 - Validate Email Address");
            Console.WriteLine("4. UC4 - Validate Mobile Number");
            Console.WriteLine("5. UC5 - Validate password Rule1 - Password should have minimum 8 characters");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FirstNamePattern1.ValidateFirstName();
                    break;
               
                case 2:
                    ValidateLastName2.ValidateLastName();
                    break;
                case 3:
                    ValidateEmail1.ValidateEmail();
                    break;
                case 4:
                    ValidateMobileNumber1.ValidateMobileNumber();
                    break;
                case 5:
                    PassWordRule1.ValidatePassword();
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
                



            }
        }
    }
}