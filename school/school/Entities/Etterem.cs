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
        //ez igyjó? Properties?
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string PhoneNo { get; set; }
        public string Feedback { get; set; }

        public string getId()
        {
            return Id;
        }

        public Etterem(string id, string name, string address, string type, string phoneno, string feedback)
        {
            Id = id;
            Name = name;
            Address = address;
            Type = type;
            PhoneNo = phoneno;
            Feedback = feedback;
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
