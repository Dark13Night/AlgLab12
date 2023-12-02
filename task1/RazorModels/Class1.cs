using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorModels
{
    public class Statie
    {
        public int StatieId { get; set; }
        public int AuthorId { get; set; }
        public int MagazineId { get; set; }

        public Statie()
        {
        }
    }
}
