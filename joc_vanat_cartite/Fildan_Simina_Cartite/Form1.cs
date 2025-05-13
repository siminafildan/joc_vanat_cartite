using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fildan_Simina_Cartite
{
    public partial class Form1 : Form
    {
        PictureBox[] pb;
        int nrc, nrv = -1, n=0;
        double lovite=0, ratate=0;
        //double p, proc;
        public Form1()
        {
            int i;
            InitializeComponent();
            pb = new PictureBox[7];
            pb[1] = pictureBox1;
            pb[2] = pictureBox2;
            pb[3] = pictureBox3;
            pb[4] = pictureBox4;
            pb[5] = pictureBox5;
            pb[6] = pictureBox6;
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            for (i = 1; i <= 6; i++)
                pb[i].Click += new System.EventHandler(clic_imagine);
            
         
        }
        private void clic_imagine(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 6; i++)
                if (sender == pb[i])
                    if (nrc == i)
                        lovite++;
                    else
                        ratate++;
            label1.Text = "Cârtițe vânate: " + lovite;
            label2.Text = "Cârtițe ratate: " + ratate;
            if (lovite == 10)
            {
                timer1.Stop();
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                Class1.p = Convert.ToDouble((lovite*100)/(ratate+lovite));
                Class1.proc =Convert.ToDouble(Class1.p.ToString("0.00"));
                Form2 f = new Form2();
                f.Show();
            }

        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            Class1.p = Convert.ToDouble((lovite * 100) / (ratate + lovite));
            Class1.proc = Convert.ToDouble(Class1.p.ToString("0.00"));
            Form3 g = new Form3();
            g.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nrv = -1;
            lovite = 0;
            ratate = 0;
            label1.Text = "Cârtițe vânate: " + lovite;
            label2.Text = "Cârtițe ratate: " + ratate;
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pb[1].Image = Properties.Resources.musuroi_removebg_preview;
            pb[2].Image = Properties.Resources.musuroi_removebg_preview;
            pb[3].Image = Properties.Resources.musuroi_removebg_preview;
            pb[4].Image = Properties.Resources.musuroi_removebg_preview;
            pb[5].Image = Properties.Resources.musuroi_removebg_preview;
            pb[6].Image = Properties.Resources.musuroi_removebg_preview;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //string[] nume;
            //double[] pu;
            //int n, i, j;
            //StreamReader f = new StreamReader("clasament.txt");
            //nume = new string[10];
            //pu = new double[10];

            //n = 0;
            //while (!f.EndOfStream)
            //{
            //    nume[n] = f.ReadLine();
            //    //pu[n] = Convert.ToInt32(f.ReadLine());
            //    n++;
            //}
            //f.Close(); //inchid fisierul din care am citit

            //nume[n] = textBox1.Text; //adaug jucatorul nou
            ////Class1.p = Convert.ToDouble((lovite * 100) / (ratate + lovite));
            ////Class1.proc = Convert.ToDouble(Class1.p.ToString("0.00"));
            //pu[n] = Convert.ToInt32(Class1.proc);
            //n++;


            ////ordonare descrescator dupa punctaj
            //for (i = 0; i < n; i++)
            //    for (j = i + 1; j < n; j++)
            //        if (pu[i] < pu[j])
            //        {
            //            double aux = pu[i];
            //            pu[i] = pu[j];
            //            pu[j] = aux;

            //            string auxn;
            //            auxn = nume[i];
            //            nume[i] = nume[j];
            //            nume[j] = auxn;
            //        }

            //StreamWriter g = new StreamWriter("clasament.txt"); //pregatesc fisierul pt scriere
            //for (i = 0; i < n && i < 5; i++) //salvez datele in fisier (maxim 5 persoane)
            //{
            //    g.WriteLine(nume[i]);
            //    g.WriteLine(pu[i]);
            //}
            //g.Close();

            //MessageBox.Show("Datele au fost adaugate");
            Form4 f = new Form4();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] nume;
            double[] pu;
            int  i, j;
            StreamReader f = new StreamReader("clasament.txt");
            nume = new string[10];
            pu = new double[10];
            //n = 0;
            //while (n<10)
            //{
             //nume[n] = textBox1.Text; //adaug jucatorul nou
             //pu[n] = Convert.ToDouble(Class1.proc);
             //n++;
            //}
            n = 0;
            while (!f.EndOfStream)
            {
                nume[n] = f.ReadLine();
                pu[n] = Convert.ToDouble(f.ReadLine());
                n++;
            }
            f.Close(); //inchid fisierul din care am citit

            nume[n] = textBox1.Text; //adaug jucatorul nou
            Class1.p = Convert.ToDouble((lovite * 100) / (ratate + lovite));
            Class1.proc = Convert.ToDouble(Class1.p.ToString("0.00"));
            pu[n] = Convert.ToDouble(Class1.proc);
            n++;


            //ordonare descrescator dupa punctaj
            for (i = 0; i < n; i++)
                for (j = i + 1; j < n; j++)
                    if (pu[i] < pu[j])
                    {
                        double aux = pu[i];
                        pu[i] = pu[j];
                        pu[j] = aux;

                        string auxn;
                        auxn = nume[i];
                        nume[i] = nume[j];
                        nume[j] = auxn;
                    }

            StreamWriter g = new StreamWriter("clasament.txt"); //pregatesc fisierul pt scriere
            for (i = 0; i < n && i < 5; i++) //salvez datele in fisier (maxim 5 persoane)
            {
                g.WriteLine(nume[i]);
                g.WriteLine(pu[i]);
            }
            g.Close();

            MessageBox.Show("Datele au fost adaugate");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            nrc = r.Next(1,7); //cartita care apare (curenta)
            switch(nrc)
            {
                case 1:
                    pb[1].Image = Properties.Resources.cartita_removebg_preview;
                    break;
                case 2:
                    pb[2].Image = Properties.Resources.cartita_removebg_preview;
                    break;
                case 3:
                    pb[3].Image = Properties.Resources.cartita_removebg_preview;
                    break;
                case 4:
                    pb[4].Image = Properties.Resources.cartita_removebg_preview;
                    break;
                case 5:
                    pb[5].Image = Properties.Resources.cartita_removebg_preview;
                    break;
                case 6:
                    pb[6].Image = Properties.Resources.cartita_removebg_preview;
                    break;

            }
            switch (nrv)
            {
                case 1:
                    pb[1].Image = Properties.Resources.musuroi_removebg_preview;
                    break;
                case 2:
                    pb[2].Image = Properties.Resources.musuroi_removebg_preview;
                    break;
                case 3:
                    pb[3].Image = Properties.Resources.musuroi_removebg_preview;
                    break;
                case 4:
                    pb[4].Image = Properties.Resources.musuroi_removebg_preview;
                    break;
                case 5:
                    pb[5].Image = Properties.Resources.musuroi_removebg_preview;
                    break;
                case 6:
                    pb[6].Image = Properties.Resources.musuroi_removebg_preview;
                    break;

            }
            nrv = nrc;
        }
    }
}
