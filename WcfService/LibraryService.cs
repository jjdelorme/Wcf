using System;
using System.Collections.Generic;

namespace LibraryServiceSolution
{
    class LibraryService : ILibraryService
    {
        private List<Book> books;

        public LibraryService()
        {
            books = new List<Book>();
            for (int i = 0; i < 20; ++i)
            {
                books.Add(new Book { ID = i, Name = "Name " + i });
            }
        }

        public Book SearchBook(string bookName)
        {
            return books.Find(w => w.Name == bookName);
        }
    }
}