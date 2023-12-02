using RazorModels;
using System;

namespace RazorServices
{
    public class MockAuthorsRepository : IAuthorsRepository
    {
        private List<Author> __authors;

        public MockAuthorsRepository()
        {
            __authors = new List<Author>()
            {
                new Author()
                {
                    AuthorId = 0,
                    Name = "Akine",
                    Email = "akine@www.com"
                },
                new Author()
                {
                    AuthorId = 1,
                    Name = "Kat",
                    Email = "kittyKat@alice.com"
                },
                new Author()
                {
                    AuthorId = 2,
                    Name = "Alexis",
                    Email = "Axe@say.com"
                }
            };
        }

        public Author Add(Author author)
        {
            author.AuthorId = __authors.Max(x => x.AuthorId) + 1;
            __authors.Add(author);
            return author;
        }

        public Author Delete(int id)
        {
            var author = __authors.FirstOrDefault(p => p.AuthorId == id);
            if (author != null)
            {
                __authors.Remove(author);
            }
            return author;
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return __authors;
        }

        public Author? GetAuthor(int id)
        {
            return __authors.FirstOrDefault(p => p.AuthorId == id);
        }

        public Author Update(Author uAuthor)
        {
            Author pass = __authors.FirstOrDefault(p => p.AuthorId == uAuthor.AuthorId);
            if (pass != null)
            {
                pass.Name = uAuthor.Name;
                pass.Email = uAuthor.Email;
            }
            return pass;
        }
    }
}