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
        private List<Etterem> Etterem;

        public Form1()
        {
            InitializeComponent();

            //pictureBox1.Width = pictureBox1.Image.Width;

            Etterem = getAllEtterem("restaurants.xml");

            this.Controls.Remove(this.button3);
            this.Controls.Remove(this.button4);

            string[] ettermek = new string[Etterem.Count()];

            for (int i = 0; i < Etterem.Count(); i++)
            {
                ettermek[i] = Etterem[i].getName();
            }
            this.comboBox1.Items.AddRange(ettermek);
            this.comboBox1.Size = new Size(216,26);

            this.Controls.Add(this.comboBox1);
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
                reader.MoveToAttribute("name");
                string name = reader.Value;
                reader.ReadToFollowing("address");
                string address = reader.ReadElementContentAsString();
                reader.ReadToFollowing("cuisine");
                string cuisine = reader.ReadElementContentAsString();
                reader.ReadToFollowing("phoneno");
                string phoneno = reader.ReadElementContentAsString();
                reader.ReadToFollowing("feedback");
                string feedback = reader.ReadElementContentAsString();
                reader.ReadToFollowing("nyitvatartas");
                string nyitvatartas = reader.ReadElementContentAsString();

                e.Add(new Etterem(id, name, address, cuisine, phoneno, feedback, nyitvatartas));
            } 
            
            while (reader.ReadToFollowing("restaurant"));
            return e;
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
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (Etterem i in Etterem)
                {
                    sw.WriteLine("Étterem neve;" + i.getName());
                    sw.WriteLine("Feedback:" + i.getFeedback());
                    sw.WriteLine(i.getMenuByName("A").ToString());
                    sw.WriteLine(i.getMenuByName("B").ToString());
                    sw.WriteLine(i.getNyitvatartas().ToCSV());
                    sw.WriteLine();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                sw.WriteLine("Étterem neve;" + this.comboBox1.SelectedItem.ToString());
                Etterem et = null;
                foreach (Etterem i in Etterem)
                {
                    if (i.getName() == this.comboBox1.SelectedItem.ToString())
                    {
                        et = i;
                    }
                }
                sw.WriteLine("Feedback:" + et.getFeedback());
                sw.WriteLine(et.getMenuByName("A").ToString());
                sw.WriteLine(et.getMenuByName("B").ToString());
                sw.WriteLine(et.getNyitvatartas().ToCSV());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Etterem et = null;
            foreach (Etterem i in Etterem)
            {
                if (i.getName() == this.comboBox1.SelectedItem.ToString())
                {
                    et = i;
                }
            }

            this.textBox2.Text = et.getMenuByName("A").getLeves();
            this.textBox4.Text = et.getMenuByName("A").getFoetel();
            this.textBox6.Text = et.getMenuByName("A").getDesszert();
            this.label11.Text = et.getMenuByName("A").getKaloria();
            this.label12.Text = et.getMenuByName("A").getAr();

            this.textBox3.Text = et.getMenuByName("B").getLeves();
            this.textBox5.Text = et.getMenuByName("B").getFoetel();
            this.textBox7.Text = et.getMenuByName("B").getDesszert();
            this.label13.Text = et.getMenuByName("B").getKaloria();
            this.label14.Text = et.getMenuByName("B").getAr();

            this.label15.Text = "Értékelés: " + et.getFeedback() + "/5";
            this.textBox1.Text = et.getNyitvatartas().ToString();
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Etterem.RemoveAll(p => p.getName() == this.comboBox1.SelectedItem.ToString());
            string[] ettermek = new string[Etterem.Count()];

            for (int i = 0; i < Etterem.Count; i++)
            {
                ettermek[i] = Etterem[i].getName();
            }
            this.textBox2.Text = "";
            this.textBox4.Text = "";
            this.textBox6.Text = "";
            this.label11.Text = "";
            this.label12.Text = "";

            this.textBox3.Text = "";
            this.textBox5.Text = "";
            this.textBox7.Text = "";
            this.label13.Text = "";
            this.label14.Text = "";

            this.label15.Text = "";
            this.textBox1.Text = "";
            this.comboBox1.Text = "";
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.AddRange(ettermek);
            this.Controls.Add(this.comboBox1);
            this.Controls.Remove(this.button2);
            this.Controls.Remove(this.button3);
        }
    }
}

