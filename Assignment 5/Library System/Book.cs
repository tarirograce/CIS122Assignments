using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    class Book
    {
        //class variables
        private string title = "n/a";
        private string author = "n/a";
        private int yearpublished = 0;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set {author = value; }
        }
        public int Yearpublished
        {
            get { return yearpublished; }
            set { yearpublished = value; }
        }

        // constructors
        public Book(string aTitle, string aAuthor, int aYearpublished)
        {
            Title = aTitle;
            Author = aAuthor;
            Yearpublished = aYearpublished;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} ({Yearpublished})";
        }
    }
}
