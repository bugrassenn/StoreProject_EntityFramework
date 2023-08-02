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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // DbEntityProductEntities den nesne ürettik
        DbEntityProductEntities db = new DbEntityProductEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            // categories değişkenine üretilen nesnenini içindeki kategorileri çağırdık ve listeleme komutunu yazdık.
            var categories = db.Tbl_Categories.ToList();
            dataGridView1.DataSource = categories;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //tablodan t nesne üret ve yeni ekleme yap
            Tbl_Categories t = new Tbl_Categories();
            t.NAME = textBox2.Text;
            db.Tbl_Categories.Add(t);
            db.SaveChanges();
            MessageBox.Show("Category Add");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // textbox1 den gelen id değerini al ve categori tablosunda onu bul ardından onu sil
            int x = Convert.ToInt32(textBox1.Text);
            var ctgr = db.Tbl_Categories.Find(x);
            db.Tbl_Categories.Remove(ctgr);
            db.SaveChanges();
            MessageBox.Show("Category Deleted");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ctgr = db.Tbl_Categories.Find(x);
            ctgr.NAME = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Category Update");
        }
    }
}
