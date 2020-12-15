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

            EtteremXML();
        }

        public void EtteremXML()
        {
            var restaurants = new XmlDocument();
            restaurants.Load(@"restaurants.xml");
            //Console.WriteLine(restaurants.DocumentElement.OuterXml);


            /*foreach (XmlDocument element in restaurants.DocumentElement)
            {
                var rate = new EtteremekData();
                Rates.Add(rate);
                //Name
                //XmlElement nameElement = (XmlElement)Rates;
                //rate.Name = element.get
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

