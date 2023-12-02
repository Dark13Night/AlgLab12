using System;
using System.Net;
using RazorModels;

namespace RazorServices
{
    public interface IAuthorsRepository
    {
        public IEnumerable<Author> GetAllAuthors();
        public Author? GetAuthor(int id);
        public Author Add(Author author);
        public Author Update(Author uAuthor);
        public Author Delete(int id);
    }
}
