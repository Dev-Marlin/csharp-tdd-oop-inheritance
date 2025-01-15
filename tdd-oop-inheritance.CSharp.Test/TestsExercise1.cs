using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class TestsExercise1
    {
        [Test]
        public void TestCheckInNotLoanedBook()
        {
            Library lib = new Library();

            lib.addToStock(new Book("Harry Potter", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Book("Lord of the rings", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Article("Science", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Newspaper("Robbery somewhere"));
            lib.addToStock(new Newspaper("Its gonna rain, like.. alot..."));

            string search = "Science";


            Assert.That(lib.checkInLiterature(search), Is.EqualTo("item is not currently on loan"));
        }

        [Test]
        public void TestCheckIn()
        {
            Library lib = new Library();

            lib.addToStock(new Book("Harry Potter", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Book("Lord of the rings", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Article("Science", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Newspaper("Robbery somewhere"));
            lib.addToStock(new Newspaper("Its gonna rain, like.. alot..."));

            string search = "Science";
            lib.checkOutLiterature(search);


            Assert.That("item has been checked in", Is.EqualTo(lib.checkInLiterature(search)));
        }

        [Test]
        public void TestCheckInBookNotExisting()
        {
            Library lib = new Library();

            lib.addToStock(new Book("Harry Potter", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Book("Lord of the rings", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Article("Science", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Newspaper("Robbery somewhere"));
            lib.addToStock(new Newspaper("Its gonna rain, like.. alot..."));

            string search = "Starwars";


            Assert.That("item is not part of the library's collection", Is.EqualTo(lib.checkInLiterature(search)));
        }

        [Test]
        public void TestCheckOutBookIn()
        {
            Library lib = new Library();

            lib.addToStock(new Book("Harry Potter", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Book("Lord of the rings", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Article("Science", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Newspaper("Robbery somewhere"));
            lib.addToStock(new Newspaper("Its gonna rain, like.. alot..."));

            string search = "Science";

            Assert.That(lib.checkOutLiterature(search), Is.EqualTo("item has been checked out"));
        }

        [Test]
        public void TestCheckOutBookLoaned()
        {
            Library lib = new Library();

            lib.addToStock(new Book("Harry Potter", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Book("Lord of the rings", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Article("Science", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Newspaper("Robbery somewhere"));
            lib.addToStock(new Newspaper("Its gonna rain, like.. alot..."));

            string search = "Science";

            lib.checkOutLiterature(search);

            Assert.That(lib.checkOutLiterature(search), Is.EqualTo("item is currently on loan"));
        }

        [Test]
        public void TestCheckOutBookNotExisting()
        {
            Library lib = new Library();

            lib.addToStock(new Book("Harry Potter", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Book("Lord of the rings", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Article("Science", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com")));
            lib.addToStock(new Newspaper("Robbery somewhere"));
            lib.addToStock(new Newspaper("Its gonna rain, like.. alot..."));

            string search = "Starwars";


            Assert.That(lib.checkOutLiterature(search), Is.EqualTo("item is not part of the library's collection"));
        }
    }
}