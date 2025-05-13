using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fildan_Simina_Cartite
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label3.Text = Convert.ToString(Class1.proc+ "%");
         
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
