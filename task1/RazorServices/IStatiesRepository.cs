using System;
using RazorModels;

namespace RazorServices

{
    public interface IStatiesRepository
    {
        public IEnumerable<Statie> GetAllStaties();
        public Statie? GetStatie(int id);
        public Statie Add(Statie statie);
        public Statie Update(Statie uStatie);
        public Statie Delete(int id);
    }
}
