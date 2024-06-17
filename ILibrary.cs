using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp1
{
    internal interface ILibrary
    {
        public void AddBook(Book book);
        public void AddStaff(Staff staff);
        public void ShowLibraryInfos();
        public void AddMember(Member member);
    }
}
