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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        DbEntityProductEntities db = new DbEntityProductEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            label2.Text = db.Tbl_Categories.Count().ToString();
            label3.Text = db.Tbl_Product.Count().ToString();
            label5.Text = db.Tbl_Customer.Count(x => x.STATUS == true).ToString();
            label7.Text = db.Tbl_Customer.Count(x => x.STATUS == false).ToString();
            label21.Text = db.Tbl_Sales.Sum(x => x.PRICE).ToString() + " ₺";
            label11.Text = (from x in db.Tbl_Product orderby x.PRICE descending select x.PRODUCTNAME).FirstOrDefault();
            label9.Text = (from x in db.Tbl_Product orderby x.PRICE ascending select x.PRODUCTNAME).FirstOrDefault();
            label15.Text = db.Tbl_Product.Count(x => x.CATEGORY == 1).ToString();
            label17.Text = db.Tbl_Product.Count(x => x.PRODUCTNAME == "BUZDOLABI").ToString();
            label23.Text = (from x in db.Tbl_Customer select x.CITY).Distinct().Count().ToString();
            label19.Text = db.GETBRAND().FirstOrDefault();

        }
    }
}
