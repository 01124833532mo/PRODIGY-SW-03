using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assement_SW_03
{
   
    internal class User
    {


        public string? Name { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }


        public void AddUser(List<User> users)
        {
            Console.WriteLine($"============================Add User================================");

            string? newname;
            do
            {
                Console.WriteLine("please Add valid your name ");
             newname=  Console.ReadLine();

            } while ((string.IsNullOrEmpty(newname) || string.IsNullOrWhiteSpace(newname) || IsContainDigit(newname)));
            string? newphonenumber;
            do
            {
                Console.WriteLine("please Add your phone valid ");

                 newphonenumber= Console.ReadLine();
            } while (!IsDigit(newphonenumber??string.Empty) || (string.IsNullOrEmpty(newphonenumber) || string.IsNullOrWhiteSpace(newphonenumber)));


            string? newemail;
            do
            {
                Console.WriteLine("please Add valid your email ");
                newemail = Console.ReadLine();

            } while ((string.IsNullOrEmpty(newemail) || string.IsNullOrWhiteSpace(newemail)));

            User newuser = new User()
            {
                Name = newname,
                PhoneNumber = newphonenumber,
                Email = newemail

            };

            users.Add(newuser);

            Console.WriteLine($"============================User Information you Enterd================================");
            Console.WriteLine($"Name: {newuser.Name}");
            Console.WriteLine($"Email: {newuser.PhoneNumber}");
            Console.WriteLine($"Phone Number: {newuser.Email}");
        }
        public void UpdateUser(List<User> users)
        {
            Console.WriteLine($"============================Update Data================================");

            Console.WriteLine("plese enter your phonenumber to update ");
            Console.WriteLine();

            string? newPhonenumber = Console.ReadLine();

            var foundedUser = users.FirstOrDefault(p => p.PhoneNumber == newPhonenumber);

            bool flag = false;
            if (foundedUser != null)
            {
                int choseToEdit;

                do
                {
                    Console.Write("1-Edit Name: \n2-Edit Email: \n3-Edit PhoneNumber: \n4-all data");
                    Console.WriteLine();
                    Console.WriteLine("Enter   ");

                } while (!int.TryParse(Console.ReadLine(),out choseToEdit));
                if (choseToEdit == 1)
                {
                    string? newname;
                    do
                    {
                        Console.WriteLine("please Add valid your name ");
                        newname = Console.ReadLine();

                    } while ((string.IsNullOrEmpty(newname) || string.IsNullOrWhiteSpace(newname) || IsContainDigit(newname)));
                    foundedUser.Name = newname;
                    flag = true;
                }
                else if (choseToEdit == 2)
                {
                    string? newemail;
                    do
                    {
                        Console.WriteLine("please Add valid your email ");
                        newemail = Console.ReadLine();

                    } while ((string.IsNullOrEmpty(newemail) || string.IsNullOrWhiteSpace(newemail)));

                    foundedUser.Email = newemail;
                    flag = true;

                }
                else if (choseToEdit == 3)
                {
                    string? newphonenumber;
                    do
                    {
                        Console.WriteLine("please Add your phone valid ");

                        newphonenumber = Console.ReadLine();
                    } while (!IsDigit(newphonenumber ?? string.Empty) || (string.IsNullOrEmpty(newphonenumber) || string.IsNullOrWhiteSpace(newphonenumber)));
                    foundedUser.PhoneNumber = newPhonenumber;
                    flag = true;
                }
                else if (choseToEdit == 4)
                {
                    string? newname;
                    do
                    {
                        Console.WriteLine("please Add valid your name ");
                        newname = Console.ReadLine();

                    } while ((string.IsNullOrEmpty(newname) || string.IsNullOrWhiteSpace(newname) || IsContainDigit(newname)));
                    foundedUser.Name = newname;
                    string? newphonenumber;
                    do
                    {
                        Console.WriteLine("please Add your phone valid ");

                        newphonenumber = Console.ReadLine();
                    } while (!IsDigit(newphonenumber ?? string.Empty) || (string.IsNullOrEmpty(newphonenumber) || string.IsNullOrWhiteSpace(newphonenumber)));
                    foundedUser.PhoneNumber = newphonenumber;
                    string? newemail;
                    do
                    {
                        Console.WriteLine("please Add valid your email ");
                        newemail = Console.ReadLine();

                    } while ((string.IsNullOrEmpty(newemail) || string.IsNullOrWhiteSpace(newemail)));
                    foundedUser.Email = newemail;


                    flag = true;
                }
                else
                {
                    Console.WriteLine("Wrong Number Try Again From First"); ;
                }
                if (flag == true)
                {
                    Console.WriteLine($"============================New User Information you Edited================================");
                    Console.WriteLine($"Name: {foundedUser.Name}");
                    Console.WriteLine($"Email: {foundedUser.Email}");
                    Console.WriteLine($"Phone Number: {foundedUser.PhoneNumber}");
                }

            }
            else
            {
                Console.WriteLine("No user Like this");
            }

        }

        public void DeleteUser(List<User> users)
        {
            Console.WriteLine($"============================Delete User================================");
            string? newphonenumber;
            do
            {
                Console.WriteLine("please Add your phone valid to delete ");

                newphonenumber = Console.ReadLine();
            } while (!IsDigit(newphonenumber ?? string.Empty) || (string.IsNullOrEmpty(newphonenumber) || string.IsNullOrWhiteSpace(newphonenumber)));
            var Foundeduser = users.FirstOrDefault(x => x.PhoneNumber == newphonenumber);
            var name = Foundeduser.Name;
            if (Foundeduser != null)
            {
                users.Remove(Foundeduser);
                Console.WriteLine($"- YOU DELETE USER : {name}.");

            }
            else
            {
                Console.WriteLine("No user Like this");
            }
        }

        public void PrintAllUser(List<User> users)
        {
            Console.WriteLine($"============================print User================================");

            int count = 1;
            if (users.Count == 0)
            {
                Console.WriteLine("No users in Memory ");
            }

            else
            {
                foreach (User user in users)
                {

                    Console.WriteLine($"User {count}");
                    Console.WriteLine($"Name: {user.Name}");
                    Console.WriteLine($"Email: {user.Email}");
                    Console.WriteLine($"Phone Number: {user.PhoneNumber}");
                    count++;
                    if (count <= users.Count)
                    {
                        Console.WriteLine("-------------------------------");

                    }
                }

            }

        }
        public bool IsDigit(string name)
        {
            foreach (char c in name)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsContainDigit(string name)
        {
            foreach (char c in name)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
