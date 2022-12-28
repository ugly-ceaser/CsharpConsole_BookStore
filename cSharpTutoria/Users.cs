using System;
using System.Collections.Generic;

namespace cSharpTutoria
{
    public class Users
    {

        private string firstName;

        private string secondName;

        private string pinCode;

       

        private List<Book> MyBook = new List<Book>();

        public static List<Users> Members = new List<Users>();

        public Users(string FirstName, string SecondName ,string pin )
        {
            this.firstName = FirstName;

            this.secondName = SecondName;

            this.pinCode = pin;

            Members.Add(this);

            Console.WriteLine("User created successfully");

            
        }

        public void allBooks()
        {
            if(MyBook.Count> 0 )
                foreach(var book in MyBook)
                {
                    Console.WriteLine(book.Bookname());
                }
            else
                Console.WriteLine("No books available");
        }

        public string getUserDetails()
        {
            return $"{this.firstName} {this.secondName}";
        }

        public bool GetBook(Book a)
        {
            MyBook.Add(a);

            return true;

        }


        public void ReturnBook (string name)
        {
            foreach(var book in MyBook)
            {

                if(book.Bookname() == name)
                {
                    MyBook.Remove(book);

                    Book.returnBook(book);

                }

            }
        }

        public  bool checkPin(string pin)
        {
            if(pin == this.pinCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       







       
    }
}

 