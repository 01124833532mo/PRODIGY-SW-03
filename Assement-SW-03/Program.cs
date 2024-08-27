
namespace Assement_SW_03
{
    internal class Program
    {
        static bool flag = false;

        static void Main(string[] args)
        {

            List<User> users = new List<User>();
            int chois;


            while (true) {
                User user = new User();

                Console.WriteLine($"1-Add User \n2-Update Data of User \n3-Delete User\n4-Print All User");

                if (int.TryParse(Console.ReadLine(), out chois))
                {
                    if (chois == 1)
                    {
                        user.AddUser(users);
                    }
                    else if (chois == 2)
                    {

                        user.UpdateUser(users);
                    }
                    else if (chois == 3)
                    {
                        user.DeleteUser(users);

                    }
                    else if (chois == 4) {
                        user.DeleteUser(users);
                    }
                    else
                    {
                        Console.WriteLine("Unvalid number please enter correct number ");
                    }
                    checkCountinue();

                    if (flag)
                    {
                        break;
                    }
                }


                else
                {
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.WriteLine("==========================================================");
                }
            }


        }

        private static void checkCountinue()
        {
            string? input;
            User user = new User();

            do
            {
                Console.WriteLine("Do you want to try anything else ? \n Y for yes || N for no");
                input = Console.ReadLine();

            } while ((string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))|| user.IsDigit(input) );



            if (input == "Y" || input == "y")
            {
                Console.WriteLine($"===================================================================");
            }
            else if (input == "N" || input == "n")
            {
                flag = true;
            }

        }
    }
}
