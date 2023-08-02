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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbEntityProductEntities db = new DbEntityProductEntities();

            var procedure = from x in db.Tbl_Admin where x.USERNAME == textBox1.Text && x.PASSWORD == textBox2.Text select x;

            if ( procedure.Any() )
            {
                FrmMainForm fr = new FrmMainForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("USERNAME OR PASSWORD INCORRECT"); 
            }
        }
    }
}
