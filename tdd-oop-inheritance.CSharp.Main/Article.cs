using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : Literature 
    {
        IAuthor author;
        public Article(string title, IAuthor author) : base(title) 
        {
            this.author = author;
        }    
    }
}
