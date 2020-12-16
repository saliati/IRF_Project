using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Restaurant_Ati
{
    class Etterem
    {
        private string Id { get; set; }
        private string Name { get; set; }
        private string Address { get; set; }
        private string Type { get; set; }
        private string PhoneNo { get; set; }
        private string Feedback { get; set; }

        private Nyitvatartas Ny { get; set; }
        //lista menu tipusu elemek lesznek benne
        private List<Menu> Menus { get; set; }

        public Etterem(string id, string name, string address, string type, string phoneno, string feedback, string nyitvatartas) 
        {
            Id = id; 
            Name = name;
            Address = address;
            Type = type;
            PhoneNo = phoneno;
            Feedback = feedback;
            Menus = readMenus();
            Ny = new Nyitvatartas(nyitvatartas);

        }
        public string getId()
        {
            return Id; 
        }
        public string getFeedback()
        {
            return Feedback;
        }
        public string getName()
        {
            return Name;
        }
        public Nyitvatartas getNyitvatartas()
        {
            return Ny;
        }
        public Menu getMenuByName(string name) // vegigmegyek az osszes menun, A vagy B menüt kérem le
        {
            foreach (Menu menu in Menus)
            {
                if (menu.getName() == name)
                {
                    return menu;
                }
            }
            return null; 
        }
        private List<Menu> readMenus() //XmlReader; XML beolvasása
        {

            List<Menu> m = new List<Menu>();
            XmlReader reader = XmlReader.Create(Id + ".xml");
            reader.ReadToFollowing("menu");
            do
            {
                reader.MoveToAttribute("name"); //attribute 
                string name = reader.Value;
                reader.ReadToFollowing("leves"); //tagek
                string leves = reader.ReadElementContentAsString(); 
                reader.ReadToFollowing("foetel");
                string foetel = reader.ReadElementContentAsString();
                reader.ReadToFollowing("desszert");
                string desszert = reader.ReadElementContentAsString();
                reader.ReadToFollowing("ar");
                string ar = reader.ReadElementContentAsString();
                reader.ReadToFollowing("kaloria");
                string kaloria = reader.ReadElementContentAsString();

                m.Add(new Menu(name, leves, foetel, desszert, ar, kaloria)); 
            }
            while (reader.ReadToFollowing("menu"));
            return m;
        }
        public Stars getStar()
        {
            if (double.Parse(Feedback) < 1) return Stars.zero;
            if (double.Parse(Feedback) < 2) return Stars.one;
            if (double.Parse(Feedback) < 3) return Stars.two;
            if (double.Parse(Feedback) < 4) return Stars.three;
            if (double.Parse(Feedback) < 5) return Stars.four;

            return Stars.five;
        }
    }
}
