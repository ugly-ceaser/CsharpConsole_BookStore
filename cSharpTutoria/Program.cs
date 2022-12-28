using System;

namespace cSharpTutoria
{
    class Program
    {
        public static string Reply;



        public static void AdminProcess()
        {
            while (true)
            {
                Console.Write("Enter Admin Entrance KeyCode or Enter 0000 to go back\n\n Reponse: ");
                Reply = Console.ReadLine();
                if (Reply == "12345")
                {
                    while (true)
                    {
                        Console.WriteLine("\n\n");
                        Console.Write("(1)View All Admin\n\n(2)Register New Admin\n\nEnter 0000 to go back\n\nResponse:  ");

                        Reply = Console.ReadLine();

                        if (Reply == "1" || Reply.ToLower().Contains("view"))
                        {
                            Console.WriteLine("\n\n");

                            Console.WriteLine("Admin Names Are ;\n");

                            Admin.ViewAllAdmin();

                            Console.WriteLine("\n\n");


                        }
                        else if (Reply == "2" || Reply.ToLower().Contains("register"))
                        {
                            Console.WriteLine("Fill the following form");
                            Console.WriteLine("\n");
                            Console.Write("Name : ");
                            string AdminName = Console.ReadLine();

                            Console.WriteLine("\n");

                            Console.Write("Personal Pin : ");
                            string pin = Console.ReadLine();


                            Console.WriteLine("\n\n");
                            Admin Admin1 = new Admin(AdminName, pin);

                            Console.WriteLine("\n\n");



                        }
                        else if (Reply == "0000")
                        {
                            break;
                        }

                    }
                    break;
                }
                else if (Reply == "0000")
                {
                    break;
                }

            }

        }




        static void Main(string[] args)
        {

            





            while (true)
            {
                Console.WriteLine("Welcome To Bookish");

                Console.WriteLine("");



                Console.WriteLine("My name is Martha :) \n\nHow may i help you!");

                while (true)
                {
                    Console.WriteLine("Are you a User or an Admin\n\n1:User\n2Admin\n\nEnter 0000 to go back\n\n");
                    Console.Write("Response: ");
                    Reply = Console.ReadLine();

                    if(Reply.ToLower() == "user" || Reply == "1")
                    {
                        while (true)
                        {
                            Console.WriteLine("Welcome to Bookish Once more :)");

                            Console.WriteLine("Choose\n1: To Create New user Accounts\n2: To Login into Your Account\n 0000 to go back");
                            Console.Write("Reply :");
                            Reply = Console.ReadLine();

                            if(Reply == "1" || Reply.ToLower().Contains("create"))
                            {
                                Console.WriteLine("Please fill the following form");
                                Console.Write("Name: ");
                                string Name = Console.ReadLine();
                                Console.Write("Second Name: ");
                                string Secondname = Console.ReadLine();
                                Console.Write("Private Pin: ");
                                string PrivatePin = Console.ReadLine();

                                Users newUser = new Users(Name, Secondname, PrivatePin);
                                break;
                            }else if(Reply == "2" || Reply.ToLower().Contains("login"))
                            {
                                bool status= false ;
                                Users currentUser = new Users("john","doe","0000");
                                string pin;
                                string Name;

                                Console.WriteLine("Whats your Private Pin and first Namm" );
                                while (true)
                                {

                                    Console.Write("Pin: ");
                                     pin = Console.ReadLine();

                                    Console.Write("FirstName: ");
                                    Name = Console.ReadLine();

                                    foreach (var user in Users.Members)
                                    {
                                        if (user.checkPin(pin) && user.getUserDetails().Contains(Name))
                                        {
                                            currentUser = user;
                                            status = true;
                                            
                                            break;
                
                                        }
             
                                    }
                                    break;

                                }

                                if(status == false)
                                {
                                    Console.WriteLine("Invalid pin");
                                    break;
                                }
                                else
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("1:View books\n2:View Details\n0000 to go back");

                                        Console.Write("Reply :");
                                        string choice = Console.ReadLine();

                                        if (choice == "1")
                                        {
                                            Console.WriteLine($"welcome {currentUser.getUserDetails()}\n Your Books are ");
                                            currentUser.allBooks();
                                        }else if(choice == "0000")
                                        {
                                            break;
                                        }

                                    }
                                    



                                }



                             
                            }else if(Reply == "0000")
                            {
                                break;
                            }
                        }

                       
                        break;
                    }else if (Reply.ToLower() == "admin" || Reply == "2")
                    {


                        AdminProcess();



                    }
                    

                    else if (Reply == "0000")
                    {
                        break;
                    }


                }































                Console.WriteLine("");

                Console.Write("Do you wish to Exit\nyes or no\n reply :");

                 Reply = Console.ReadLine();

                Console.WriteLine("");

                if(Reply.ToLower() == "yes")
                {

                    Console.WriteLine("\nBye ;) \n");
                    break;
                }
            }
            






           

           


          




            Console.ReadKey();
            
        }
    }
}
