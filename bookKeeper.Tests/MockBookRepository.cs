using bookKeeper_DAL.Abstract.IInterfaces;
using bookKeeper_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookKeeper.Tests
{
    class MockBookRepository : IBookRepository
    {
        public Dictionary<int, Book> Books;

        public void Create(Book item)
        {
            Books.Add(item.BookId, item);
        }

        public void Delete(int id)
        {
            Books.Remove(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return Books.Values;
        }

        public Book GetSingle(int id)
        {
            return Books[id];
        }

        public IEnumerable<Book> GetUsersBooks(int userId)
        {
            return Books.Values.Where(book => book.UserId == userId);
        }

        public void Save()
        {
            // Do nothing
        }

        public void Update(Book item)
        {
            Books[item.BookId] = item;
        }

        public void Dispose()
        {
            Books.Clear();
        }
    }
}

