using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    class EBook : Book
    {
        // additional variable
        private int filesizeMB = 0;

        public int FilesizeMB
        {
            get { return filesizeMB; }
            set { filesizeMB = value; }
        }
        public EBook(string aTitle, string aAuthor, int aYearpublished, int aFilesizeMB)
            : base(aTitle, aAuthor, aYearpublished)
        {
            FilesizeMB = aFilesizeMB;
        }
        public override string ToString()
        {
            return $"{Title} by {Author} ({Yearpublished}), {FilesizeMB}";
        }
    }
}
