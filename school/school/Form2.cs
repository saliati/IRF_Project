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
using System.Windows.Forms.DataVisualization.Charting;

namespace school
{
    public partial class Form2 : Form
    {
        BindingList<Entities.Countries> orszagok = new BindingList<Entities.Countries>();
        
        public Form2()
        {
            InitializeComponent();
            dataGridView1.DataSource = orszagok;
            Cases();
            
            
        }

        public void Cases() 
        {
            var cases = new XmlDocument();
            cases.Load("Covid19_4.xml");
            
            foreach  (XmlElement element in cases.DocumentElement)
            {
                var country = new Entities.Countries();
                orszagok.Add(country);

                //country.Names = node.Attributes[0].InnerText;

                /*foreach (XmlNode childNodes in node.ChildNodes)
                {
                    country.Total = int.Parse(childNodes.InnerText);

                }*/

                var childElement5 = (XmlElement)element.ChildNodes[0];
                country.Names = childElement5.GetAttribute("Name");

                var childElement = (XmlElement)element.ChildNodes[0];
                country.Total = childElement.GetAttribute("total");

                var childElement2 = (XmlElement)element.ChildNodes[1];
                country.NewCases = childElement2.GetAttribute("NewCases");

                var childElement3 = (XmlElement)element.ChildNodes[2];
                country.Deaths = childElement3.GetAttribute("Deaths");

                var childElement4 = (XmlElement)element.ChildNodes[3];
                country.NewDeaths = childElement4.GetAttribute("NewDeaths");

            }
        }
        
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
