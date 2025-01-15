using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : Literature
    {
        public IAuthor Author {get;}
        public Book(string title, IAuthor Author) : base(title)
        {
            this.Author = Author;
        }

    }
}
