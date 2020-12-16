using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Ati
{
    class Menu
    {
        private string Name { get; set; }
        private string Leves { get; set; }
        private string Foetel { get; set; }
        private string Desszert { get; set; }
        private string Ar { get; set; }
        private string Kaloria { get; set; }

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
