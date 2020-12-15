using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.Entities
{
    class Menu
    {
        public string Name { get; set; }
        public string Leves { get; set; }
        public string Foetel { get; set; }
        public string Desszert { get; set; }
        public string Ar { get; set; }
        public string Kaloria { get; set; }

        public Menu(string name, string leves, string foetel, string desszert, string ar, string kaloria)
        {
            Name = name;
            Leves = leves;
            Foetel = foetel;
            Desszert = desszert;
            Ar = ar;
            Kaloria = kaloria;
        }
    }
}
