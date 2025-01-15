using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class TestsExercise2
    {
        //author name, contact info, website
        [Test]
        public void TestGetAuthor()
        {
            Book a = new Book("Harry Potter", new MyAuthor("J. K. Rowling", "JK@hotmail.com", "www.JK.com"));

            Assert.That(a.Author.Name, Is.EqualTo("J. K. Rowling"));
        }

        public void TestGetAuthorContactInfo()
        {
            Book b = new Book("Lord of the rings", new MyAuthor("J.R.R. Tolkien", "Tolkien@frodo.com", "www.LOTR.com"));

            Assert.That(b.Author.ContactInfo, Is.EqualTo("Tolkien@frodo.com"));
        }

        public void TestGetAuthorWebsite()
        {
            Book b = new Book("Lord of the rings", new MyAuthor("J.R.R. Tolkien", "Tolkien@frodo.com", "www.LOTR.com"));

            Assert.That(b.Author.Website, Is.EqualTo("www.LOTR.com"));
        }
    }
}