using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    public class ScientificBook : bookRegister
    {
        private string _Languige { get; set; }
        private int _Page { get; set; }

        public ScientificBook(string name, string author, int publicationDate, string languige, int value, string valueRegion, int page) : base(name, author, publicationDate)
        {
            this._Languige = languige;
            this._Page = page;
        }
        public void Print()
        {
            Console.WriteLine($"Book Name : {this.Name}");
            Console.WriteLine($"Book Author : {this.Author}");
            Console.WriteLine($"Book Publication Date : {this.PublicationDate}");
            Console.WriteLine($"Book Languige : {this._Languige}");
            Console.WriteLine($"Book Page : {this._Page}");
            Console.WriteLine("--------------------------------");
        }
    }
}
