using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    static class Global
    {
        private static int pageNumber;
        public static int PageNumber { get { return pageNumber; } set { pageNumber = value; } }


        private static int bookCover1;
        public static int BookCover1 { get { return bookCover1; } set { bookCover1 = value; } }

        private static int bookCover2;
        public static int BookCover2 { get { return bookCover2; } set { bookCover2 = value; } }

        private static int bookCover3;
        public static int BookCover3 { get { return bookCover3; } set { bookCover3 = value; } }

        private static int bookInfo;
        public static int BookInfo { get { return bookInfo; } set {bookInfo = value; } }
    }
}
