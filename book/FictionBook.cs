using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class FictionBook : BookRegister
    {
        private string _languige { get; set; }
        private int _value { get; set; }
        private string _valueRegion { get; set; }
        public FictionBook(string name, string author, int publicationDate, string languige, int value, string valueRegion) : base(name, author, publicationDate)
        {
            this._languige = languige;
            this._value = value;
            this._valueRegion = valueRegion;
        }
        public void Print()
        {
            Console.WriteLine($"Book Name : {this.Name}");
            Console.WriteLine($"Book Author : {this.Author}");
            Console.WriteLine($"Book Publication Date : {this.PublicationDate}");
            Console.WriteLine($"Book Languige : {this._languige}");
            Console.WriteLine($"Book Value : {this._value} {this._valueRegion}");
            Console.WriteLine("--------------------------------");
        }
    }
}
