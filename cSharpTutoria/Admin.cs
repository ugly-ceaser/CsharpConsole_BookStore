using System;
using System.Collections.Generic;

namespace cSharpTutoria
{
    public class Admin
    {
        private static List<Admin> Admins = new List<Admin>();

        private string firstName { get; set; }

        private readonly string pin;

        public Admin(string name, string pin)
        {
            this.firstName = name;
            this.pin = pin;

            Admins.Add(this);

            Console.WriteLine($"{this.firstName} successfully added as an Admin");

        }


        public bool AdminValidation(string pin)
        {
            if(pin == this.pin)
            {
                return true;
            }
            else
            {
                Console.WriteLine("incorrect pin");
                return false;

            }
        }


        public static void ViewAllAdmin()
        {
            foreach(var admin in Admins)
            {
                Console.WriteLine(admin.firstName);
            }
        }




        

        




        
    }
}

