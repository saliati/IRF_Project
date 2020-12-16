using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
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

        public string getName()
        {
            return Name;
        }
        public string getLeves()
        {
            return Leves;
        }
        public string getFoetel()
        {
            return Foetel;
        }
        public string getDesszert()
        {
            return Desszert;
        }
        public string getKaloria()
        {
            return Kaloria;
        }
        public string getAr()
        {
            return Ar;
        }
        public override string ToString()
        {
            return Name + " menu;" + Leves + ";" + Foetel + ";" + Desszert + ";" + Ar + ";" + Kaloria;
        }
    }
}
