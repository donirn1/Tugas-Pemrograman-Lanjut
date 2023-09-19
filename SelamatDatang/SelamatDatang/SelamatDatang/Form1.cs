using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelamatDatang
{
    public partial class frmSelamatDatang : Form
    {
        public frmSelamatDatang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblKeterangan.Text = "Begitu mudahnya membuat aplikasi berbasis windows";
        }

        private void btnKeterangan1_Click(object sender, EventArgs e)
        {
            lblKeterangan.Text = "Selamat Datang di pemrograman C#";
        }
    }
}
