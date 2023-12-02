using RazorModels;
using System;


namespace RazorServices
{
    public class SqlStatiesRepository : IStatiesRepository
    {
        private AppDbContext __db;

        public SqlStatiesRepository(AppDbContext db)
        {
            __db = db;
        }

        public Statie Add(Statie statie)
        {
            throw new NotImplementedException();
        }

        public Statie Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Statie> GetAllStaties()
        {
            throw new NotImplementedException();
        }

        public Statie? GetStatie(int id)
        {
            throw new NotImplementedException();
        }

        public Statie Update(Statie uStatie)
        {
            throw new NotImplementedException();
        }
    }
}