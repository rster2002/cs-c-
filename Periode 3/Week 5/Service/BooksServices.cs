using DAL;
using Model;
using System.Collections.Generic;

namespace Service {
    public class BooksServices {
        BookDAO bookDAO = new BookDAO();

        public List<Book> getAll() => bookDAO.getAll();
    }
}
