using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {

        private List<Literature> literatures;

        public Library() 
        { 
            literatures = new List<Literature>();
        }
        public void addToStock(Literature item) 
        {
            this.literatures.Add(item);
        }

        public string checkInLiterature(string title) {

            List<Literature> filtered = literatures.Where(literature => literature.Title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutLiterature(string title) {
            List<Literature> filtered = literatures.Where(literature => literature.Title.Equals(title)).ToList();

            if (filtered.Count() < 1) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
    }
}
