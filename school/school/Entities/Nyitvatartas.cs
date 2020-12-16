using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class Nyitvatartas
    {
        private Dictionary<string, string> NyitvaT;
        public Nyitvatartas(string nyitvatartas) 
        {
            Dictionary<string, string> seged = new Dictionary<string, string>();
            string[] napok = { "Hetfo", "Kedd", "Szerda", "Csutortok", "Pentek", "Szombat", "Vasarnap" };
            string[] s = nyitvatartas.Split(';');

            for (int i = 0; i < s.Length || i < napok.Length; i++)
            {
                seged.Add(napok[i], s[i]);
            }

            NyitvaT = seged;
        }

        public override string ToString()
        {
            string s = "";
            foreach (var i in NyitvaT)
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
