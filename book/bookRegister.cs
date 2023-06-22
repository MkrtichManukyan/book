using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class BookRegister
    {
        protected string Name { get; set; }
        protected string Author { get; set; }
        protected int PublicationDate { get; set; }

        public BookRegister(string name, string author, int publicationDate)
        {
            Name = name;
            Author = author;
            PublicationDate = publicationDate;
        }
    }
}
