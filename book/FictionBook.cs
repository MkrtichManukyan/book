using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    public class FictionBook : bookRegister
    {
        private string _Languige { get; set; }
        private int _Value { get; set; }
        private string _ValueRegion { get; set; }
        public FictionBook(string name, string author, int publicationDate, string languige, int value, string valueRegion) : base(name, author, publicationDate)
        {
            this._Languige = languige;
            this._Value = value;
            this._ValueRegion = valueRegion;
        }
        public void Print()
        {
            Console.WriteLine($"Book Name : {this.Name}");
            Console.WriteLine($"Book Author : {this.Author}");
            Console.WriteLine($"Book Publication Date : {this.PublicationDate}");
            Console.WriteLine($"Book Languige : {this._Languige}");
            Console.WriteLine($"Book Value : {this._Value} {this._ValueRegion}");
            Console.WriteLine("--------------------------------");
        }
    }
}
