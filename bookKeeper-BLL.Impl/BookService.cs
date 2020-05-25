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
            BookRepo.Create(book);
            BookRepo.Save();
        }

        public void EditBook(string name, string author, string review, int userId, int bookId)
        {
            BookRepo.GetSingle(bookId);
            //тут я не совсем понимаю, как дальше менять значения
            //тем более, что я извлекла не класс, а запись о книге
            BookRepo.Save();

        }

        public IEnumerable<BookDto> GetBooks(int userId)
        {
            //return BookRepo.GetUsersBooks(userId);
            //я понимаю, что строчка вверху - это неправильно, поскольку нам, видимо, нужно взаимодейстовать
            // c BookDto, но я не понимаю, как это с делать
            // соответственоо, я не знаю, как сделать проверку
        }

        public void RemoveBook(int bookId, int userId)
        {
            //проверка
            BookRepo.Delete(bookId);
            BookRepo.Save();
            
        }
    }
}