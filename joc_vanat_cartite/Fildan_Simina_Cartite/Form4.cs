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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Label[] v;

            string[] nume;
            double[] pu;
            int n, i, j;
            StreamReader f = new StreamReader("clasament.txt");
            nume = new string[10];
            pu = new double[10];
            n = 0;
            while (!f.EndOfStream)
            {
                nume[n] = f.ReadLine();
                pu[n] = Convert.ToDouble(f.ReadLine());
                n++;
            }
            f.Close(); //inchid fisierul din care am citit

            v = new Label[n];
            for (i = 0; i < n; i++)
            {
                v[i] = new Label();
                v[i].Size = new Size(400, 30);
                v[i].Location = new Point(130, 100 + i * 30);
                v[i].Text = nume[i] + " " + pu[i];
                this.Controls.Add(v[i]);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
