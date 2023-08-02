using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjectApp
{
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProduct fr = new FrmProduct();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmStatistics fr = new FrmStatistics();
            fr.Show();
        }
    }
}
