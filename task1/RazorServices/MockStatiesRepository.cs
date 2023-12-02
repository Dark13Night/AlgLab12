using RazorModels;
using System;


namespace RazorServices
{
    public class MockStatiesRepository : IStatiesRepository
    {
        List<Statie> __staties;

        public MockStatiesRepository()
        {
            __staties = new List<Statie>()
            {
                new Statie()
                {
                    StatieId = 0,
                    AuthorId = 1,
                    MagazineId = 2
                },
                new Statie()
                {
                    StatieId = 1,
                    AuthorId = 0,
                    MagazineId = 0
                },
                new Statie()
                {
                     StatieId = 2,
                     AuthorId = 2,
                     MagazineId = 1
                }
            };
        }

        public Statie Add(Statie statie)
        {
            statie.StatieId = __staties.Max(x => x.StatieId) + 1;
            __staties.Add(statie);
            return statie;
        }

        public Statie Delete(int id)
        {
            var statie = __staties.FirstOrDefault(p => p.StatieId == id);
            if (statie != null)
            {
                __staties.Remove(statie);
            }
            return statie;
        }

        public IEnumerable<Statie> GetAllStaties()
        {
            return __staties;
        }

        public Statie? GetStatie(int id)
        {
            return __staties.FirstOrDefault(p => p.StatieId == id);
        }

        public Statie Update(Statie uStatie)
        {
            Statie statie = __staties.FirstOrDefault(p => p.StatieId == uStatie.StatieId);
            if (statie != null)
            {
                statie.StatieId = uStatie.StatieId;
            }
            return statie;
        }
    }
}