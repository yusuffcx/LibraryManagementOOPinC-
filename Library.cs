using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Library : ILibrary
    {
        private string name;
        private List<Book> books;
        private List<Member> members;
        private List<Staff> staffs;

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddStaff(Staff staff)
        {
            staffs.Add(staff);
        }

        public void AddMember(Member member)
        {
            members.Add(member);
        }
      
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                value = name;
            }
        }

        public List<Book>GetBooks()
        {
            return books;
        }

        public List<Member> GetMembers()
        {
            return members;
        }

        public List<Staff> GetStaff()
        {
            return staffs;
        }


        public Library(string name)
        {
            this.name = name;

            books = new List<Book>();
            members = new List<Member>();
            staffs = new List<Staff>();
        }
        
        public void ShowLibraryInfos()
        {
            Console.WriteLine("--------" + name + " bilgileri --------\n");

            Console.WriteLine("Kitaplar:\n");

            foreach (Book book in books)
            {
                Console.WriteLine(book.Title);
                Console.WriteLine(book.Author);
                Console.WriteLine(book.Isbn);
                Console.WriteLine();
            }
            Console.WriteLine();

            foreach (Member member in members)
            {
                Console.WriteLine(member.Firstname + " -- " + member.LastName + " -- " + member.MemberShipID);
            }

            Console.WriteLine();
            foreach (Staff staff in staffs)
            {
                Console.WriteLine(staff.Firstname + " -- " + staff.LastName + " -- " + staff.Position);
            }
        

        }
    
    }
}
