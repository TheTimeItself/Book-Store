﻿using BookStoreBL.Interfaces;
using BookStoreDL.Interfaces;
using BookStoreModels.Models;

namespace BookStoreBL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public void Add(Book book)
        {
            _bookRepository.Add(book);
        }

        public void Add(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }

        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Book? GetByID(int id)
        {
            return _bookRepository.GetByID(id);
        }

        public void Update(Book book)
        {
            _bookRepository.Update(book);
        }
    }
}
