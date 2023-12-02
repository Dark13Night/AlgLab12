using RazorModels;
using System;


namespace RazorServices
{
    public interface IMagazinesRepository
    {
        public IEnumerable<Magazine> GetAllMagazines();
        public Magazine? GetMagazine(int id);
        public Magazine Add(Magazine magazine);
        public Magazine Update(Magazine uMagazine);
        public Magazine Delete(int id);
    }
}
