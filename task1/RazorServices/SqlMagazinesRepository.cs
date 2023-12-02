using RazorModels;
using System;

namespace RazorServices
{
    public class SqlMagazinesRepository : IMagazinesRepository
    {
        private AppDbContext __db;

        public SqlMagazinesRepository(AppDbContext db)
        {
            __db = db;
        }

        public Magazine Add(Magazine magazine)
        {
            throw new NotImplementedException();
        }

        public Magazine Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Magazine> GetAllMagazines()
        {
            throw new NotImplementedException();
        }

        public Magazine? GetMagazine(int id)
        {
            throw new NotImplementedException();
        }

        public Magazine Update(Magazine uMagazine)
        {
            throw new NotImplementedException();
        }
    }
}
