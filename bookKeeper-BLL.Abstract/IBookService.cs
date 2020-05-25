using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookKeeper_BLL.Abstract
{
    public interface IBookService
    {
        void AddBook(string name, string author, string review, int userId);
        void RemoveBook(string bookId, int userId);
        void EditBook(string name, string author, string review, int userId, int bookId);
        void ViewBooks(int userId);

    }
}