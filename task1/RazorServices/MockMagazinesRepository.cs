using RazorModels;
using System;

namespace RazorServices
{
    public class MockMagazinesRepository : IMagazinesRepository
    {
        List<Magazine> __magazines { get; set; }
        public MockMagazinesRepository()
        {
            __magazines = new List<Magazine>()
            {
                new Magazine()
                {
                    MagazineId = 0,
                    Price = 149
                },
                new Magazine()
                {
                    MagazineId = 1,
                    Price = 159
                },
                new Magazine()
                {
                    MagazineId = 2,
                    Price = 169
                }
            };
        }

        public Magazine Add(Magazine magazine)
        {
            magazine.MagazineId = __magazines.Max(x => x.MagazineId) + 1;
            __magazines.Add(magazine);
            return magazine;
        }

        public Magazine Delete(int id)
        {
            var magazine = __magazines.FirstOrDefault(p => p.MagazineId == id);
            if (magazine != null)
            {
                __magazines.Remove(magazine);
            }
            return magazine;
        }

        public IEnumerable<Magazine> GetAllMagazines()
        {
            return __magazines;
        }

        public Magazine? GetMagazine(int id)
        {
            return __magazines.FirstOrDefault(p => p.MagazineId == id);
        }

        public Magazine Update(Magazine uMagazine)
        {
            Magazine magazine = __magazines.FirstOrDefault(t => t.MagazineId == uMagazine.MagazineId);
            if (magazine != null)
            {
                magazine.Price = uMagazine.Price;
            }
            return magazine;
        }
    }
}
