using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class ScientificBook : BookRegister
    {
        private string _languige { get; set; }
        private int _page { get; set; }

        public ScientificBook(string name, string author, int publicationDate, string languige, int value, string valueRegion, int page) : base(name, author, publicationDate)
        {
            this._languige = languige;
            this._page = page;
        }
        public void Print()
        {
            Console.WriteLine($"Book Name : {this.Name}");
            Console.WriteLine($"Book Author : {this.Author}");
            Console.WriteLine($"Book Publication Date : {this.PublicationDate}");
            Console.WriteLine($"Book Languige : {this._languige}");
            Console.WriteLine($"Book Page : {this._page}");
            Console.WriteLine("--------------------------------");
        }
    }
}
