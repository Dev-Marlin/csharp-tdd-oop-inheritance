using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class MyAuthor : IAuthor
    {
        public string Name { get; }

        public string ContactInfo { get; }

        public string Website { get; }

        public MyAuthor(string name, string contactInfo, string website)
        {
            Name = name;
            ContactInfo = contactInfo;
            Website = website;
        }
    }
}
