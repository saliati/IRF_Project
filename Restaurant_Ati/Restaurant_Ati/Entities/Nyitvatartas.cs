using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Ati
{
    class Nyitvatartas
    {
        private Dictionary<string, string> NyitvaT; 
        public Nyitvatartas(string nyitvatartas)
        {
            //seged dictionary
            Dictionary<string, string> seged = new Dictionary<string, string>();
            string[] napok = { "Hetfo", "Kedd", "Szerda", "Csutortok", "Pentek", "Szombat", "Vasarnap" };
            string[] s = nyitvatartas.Split(';'); 

            for (int i = 0; i < s.Length && i < napok.Length; i++) // vegigmegyek a tombokon
            {
                seged.Add(napok[i], s[i]); 
            }

            NyitvaT = seged;
        }

        public override string ToString() //override
        {
            string s = "";
            foreach (var i in NyitvaT) //kiirja az osszeset
            {
                s += i.Key + ": " + i.Value + Environment.NewLine; 
            }
            return s;
        }
        public string ToCSV()
        {
            string s = "";
            foreach (var i in NyitvaT)
            {
                s += i.Key + ";" + i.Value + Environment.NewLine;
            }
            return s;
        }
    }
}
