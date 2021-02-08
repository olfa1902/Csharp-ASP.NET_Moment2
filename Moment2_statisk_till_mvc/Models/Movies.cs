using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moment2_statisk_till_mvc.Models
{
    public class Movies
    {
        public Movies()
        {
        
        }

        public Movies(string title, string category, int playtime)
        {
            this.Titel = title;
            this.Kategori = category;
            this.Speltid = playtime;
        }

        public string Titel { get; set; }

        public string Kategori { get; set; }

        public int Speltid { get; set; }
    }

    public class ViewModel
    {
        public IEnumerable<Movies> FilmDetaljLista { get; set; }
    }
}
