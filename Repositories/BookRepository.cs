﻿using LibApp.Interfaces;
using LibApp.Data;
using LibApp.Models;
using System.Collections.Generic;
namespace LibApp.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Book> GetBooks()
        {
            return _context.Books;
        }

        Book GetBookById(int id) => _context.Books.Find(id);
        void AddBook(Book book) => _context.Books.Add(book);
        void UpdateBook(Book book) => _context.Books.Update(book);
        void DeleteBook(int id) => _context.Books.Remove(GetBookById(id));
        void Save() => _context.SaveChanges();
    }
}
