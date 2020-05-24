using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Web;
using bookKeeper_Entity;
using bookKeeper_DAL.Abstract.IInterfaces;

namespace bookKeeper_DAL.Impl
{
    public class BookRepository : IBookRepository
    {
        private readonly DataBaseContext db;

        public BookRepository (DataBaseContext context)
        {
            db = context;
        }

        public void Create(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
        }

        public void Update(Book book)
        {
            db.Books.Update(book);
            db.SaveChanges();
        }

        public void Delete(int bookId)
        {
            Book res = db.Books.Find(bookId);
            db.Books.Remove(res);
        }

        public Book GetSingle(int id)
        {
            return db.Books.Find(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return db.Books.ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

         IEnumerable<Book> IBookRepository.GetUsersBooks(int userId)
        {
            var books = (from book in db.Books
                          where book.UserId == userId
                          select book).ToList();
            return books;
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
