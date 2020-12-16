using school.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
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
