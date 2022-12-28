using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace cSharpTutoria
{
    public  class Book
    {
      private static   List<Book> Collection = new List<Book>();

      private static List<Book> BorrowedBooks = new List<Book>();



         private string Name { get; set; }

         private string Autor { get; set; }

         private DateTime RegisteredDate { get; set; } 

        public Book(string name , string autor,DateTime date)
        {
            this.Name = name;
            this.Autor = autor;
            this.RegisteredDate = date;


            Collection.Add(this);

            Console.WriteLine($"{this.Name} successfully added to your Library");
        }

        public string Bookname()
        {
            return this.Name;
        }

        public string Autorname()
        {
            return this.Autor;
        }

        public DateTime DateRegistered()
        {
            return this.RegisteredDate;
        }



        public static void Details(string data)
        {
            

            foreach(var x in Collection)
            {
                if(x.Name == data)
                {
                    Console.WriteLine($"name: {x.Name}\nAutor:{x.Autor}");
                }
                else
                {
                    Console.WriteLine($"{data} Not Found");
                }
            }

            


            
        }


        public bool updateName(string name, bool Admin)
        {

            if (!Admin) return false;
            {
                this.Name = name;

                return true;
            }
           

        }

        public bool updateAutor(string name, bool Admin)
        {
            if (!Admin) return false;
            {
                this.Autor = name;

                return true;
            }
           

        }

        public bool updateDate(DateTime date, bool Admin)
        {

            if (!Admin) return false;
            {
                this.RegisteredDate = date;

                return true;
            }
            

        }


        public bool showCollection(bool Admin)
        {

            if (!Admin) return false;
            {
                foreach(var book in Collection)
                {
                    Console.WriteLine(book.Name);
                }
            }

            return true;

        }


        public bool showBorrowedCollection(bool Admin)
        {

            if (!Admin) return false;
            {
                foreach (var book in BorrowedBooks)
                {
                    Console.WriteLine(book.Name);
                }
            }

            return true;

        }


        public bool deleteBook(string name, bool Admin)
       
        {
            if (!Admin) return false;
            
            string message = "feedback";

            foreach (var x in Collection)
            {
                if(x.Name == name || x.Autor  == name)
                {
                    Collection.Remove(x);
                    message = $"{x.Name} successfully removed";
                    break;
                }
                else
                {
                    message = $"{name} not found";
                }


            }

            Console.WriteLine(message);

            return true;

        }


        public static bool borowedBook(string name , Users a)
        {
            bool message = false; ;

            foreach(var x in Collection)
            {
                if(x.Name == name)
                {
                    BorrowedBooks.Add(x);

                   message =  a.GetBook(x);

                    Collection.Remove(x);



                    

                    break;

                }
                else
                {
                    Console.WriteLine($"{name} not found");

                    message = false;

                }

            }
            return message;
        }


        public static void returnBook(Book a)
        {

            Collection.Add(a);


        }
    }
}

