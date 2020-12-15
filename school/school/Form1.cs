using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace school
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Width = pictureBox1.Image.Width;
            List<Etterem> e = getAllEtterem("restaurants.xml");
            List<Menu> m = getMenu("1.xml"); //problémás
            EtteremXML();
        }

        private List<Etterem> getMenu(string id)
        {
            //?
            List<Menu> m = new List<Menu>();
            XmlReader reader = XmlReader.Create(id + ".xml");
            reader.ReadToFollowing("Menu");
            do
            {
                reader.GetAttribute("name");
                string name = reader.Value;
                reader.ReadToFollowing("leves");
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

        private List<Etterem> getAllEtterem(string file) 
        {
            List<Etterem> e = new List<Etterem>();
            XmlReader reader = XmlReader.Create("restaurants.xml");
            reader.ReadToFollowing("restaurant");
            do
            {
                reader.GetAttribute("Id");
                string id = reader.Value;
                reader.GetAttribute("name");
                string name = reader.Value;
                reader.ReadToFollowing("address");
                string address = reader.ReadElementContentAsString();
                reader.ReadToFollowing("cuisine");
                string cuisine = reader.ReadElementContentAsString();
                reader.ReadToFollowing("phoneno");
                string phoneno = reader.ReadElementContentAsString();
                reader.ReadToFollowing("feedback");
                string feedback = reader.ReadElementContentAsString();

                e.Add(new Etterem(id, name, address, cuisine, phoneno, feedback));
            } 
            
            while (reader.ReadToFollowing("restaurant"));
            return e;
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

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;
            XmlDocument xml = new XmlDocument();
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8)) 
            {
                sw.Write();
            }
        }
    }
}

