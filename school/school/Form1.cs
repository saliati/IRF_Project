using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace school
{
    public partial class Form1 : Form
    {
        BindingList<EtteremekData> Rates = new BindingList<EtteremekData>();

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Width = pictureBox1.Image.Width;

            etteremXML();
        }

        public void etteremXML() 
        {
            var restaurants = new XmlDocument();
            restaurants.Load("restaurants.xml");

            foreach (XmlDocument element in restaurants.DocumentElement)
            {
                var rate = new EtteremekData();
                Rates.Add(rate);
                //Name

            }
        }
    }
}
