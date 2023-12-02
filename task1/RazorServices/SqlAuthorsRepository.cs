using RazorModels;
using System;


namespace RazorServices
{
    public class SqlAuthorsRepository : IAuthorsRepository
    {
        private AppDbContext __db;

        public SqlAuthorsRepository(AppDbContext db)
        {
            __db = db;
        }

        public Author Add(Author author)
        {
            __db.Authors.Add(author);
            __db.SaveChanges();
            return author;
        }

        public Author Delete(int id)
        {
            var passToDel = __db.Authors.Find(id);

            if (passToDel != null)
            {
                __db.Authors.Remove(passToDel);
                __db.SaveChanges();
            }
            return passToDel;
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return __db.Authors;
        }

        public Author? GetAuthor(int id)
        {
            return __db.Authors.Find(id);
        }

        public Author Update(Author uAuthor)
        {
            var pass = __db.Authors.Attach(uAuthor);
            pass.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            __db.SaveChanges();
            return uAuthor;
        }
    }
}
