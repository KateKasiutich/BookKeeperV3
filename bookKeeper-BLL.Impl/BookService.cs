using bookKeeper_BLL.Abstract;
using bookKeeper_DAL.Abstract.IInterfaces;
using bookKeeper_DAL.Impl;
using bookKeeper_DTO;
using bookKeeper_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bookKeeper_BLL.Impl
{
    public class BookService : IBookService
    {
        private readonly IBookRepository BookRepo;

        public BookService(IBookRepository bookRepo)
        {
        BookRepo = bookRepo;
        }

        public void AddBook(string name, string author, string review, int userId)
        {
            Book book = new Book();
            if (book.UserId != userId)
                throw new Exception("You are trying to edit another user's Book.");
            else
            book.Title = name;
            book.Author = author;
            book.Description = review;
            book.UserId = userId;
            BookRepo.Create(book);
            BookRepo.Save();
        }

        public void EditBook(string name, string author, string review, int userId, int bookId)
        {
            Book book = BookRepo.GetSingle(bookId);
            book.Title = name;
            book.Author = author;
            book.Description = review;
            BookRepo.Update(book);
            BookRepo.Save();
        }

        public IEnumerable<BookDto> GetBooks(int userId)
        {
            return BookRepo.GetUsersBooks(userId).Select(book => new BookDto(book.Title, book.Author, book.Description, book.BookId));
        }

        public void RemoveBook(int bookId, int userId)
        {
            Book book = BookRepo.GetSingle(bookId);
            if (book.UserId != userId)
                throw new Exception("You are trying to edit delete user's Book.");
            else
            BookRepo.Delete(bookId);
            BookRepo.Save();
        }
    }
}