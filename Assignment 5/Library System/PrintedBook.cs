using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    class PrintedBook : Book
    {
        //additional variable
        private int pagecount = 0;

        public int Pagecount
        {
            get { return pagecount; }
            set { pagecount = value; }
        }

        public PrintedBook(string aTitle, string aAuthor, int aYearpublished, int aPagecount)
            : base(aTitle, aAuthor, aYearpublished)
        {
            Pagecount = aPagecount;
        }
        public override string ToString()
        {
            return $"{Title} by {Author} ({Yearpublished}), {Pagecount}";
        }
    }
}
