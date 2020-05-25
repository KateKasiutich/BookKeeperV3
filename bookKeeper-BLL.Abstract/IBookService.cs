using bookKeeper_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookKeeper_BLL.Abstract
{
    public interface IBookService
    {
        void AddBook(string name, string author, string review, int userId);
        void RemoveBook(int bookId, int userId);
        void EditBook(string name, string author, string review, int userId, int bookId);
        IEnumerable<BookDto> GetBooks(int userId);

    }
}