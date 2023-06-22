using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    public class bookRegister
    {
        protected string Name { get; set; }
        protected string Author { get; set; }
        protected int PublicationDate { get; set; }

        public bookRegister(string name, string author, int publicationDate)
        {
            Name = name;
            Author = author;
            PublicationDate = publicationDate;
        }
    }
}
