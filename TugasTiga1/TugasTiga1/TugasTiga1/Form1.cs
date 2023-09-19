using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblKELAS.Text = "Informatika 04";
            lblNAMA.Text = "Muhammad Doni Rijalutama Nugraha";
            lblNIM.Text = "22.11.4806";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ket2_Click(object sender, EventArgs e)
        {
            lblKELAS.Text = "";
            lblNAMA.Text = "";
            lblNIM.Text = "";
        }
    }
}
