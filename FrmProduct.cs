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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        DbEntityProductEntities db = new DbEntityProductEntities();
        private void BtnList_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.Tbl_Product.ToList();
            //veya
            // x ismindeki değişken değerlerini product tablosundan alsın dedik  ve select ile nereleri almasını istediğimizi yazdık
            dataGridView1.DataSource = (from x in db.Tbl_Product
                                        select new
                                        {
                                            x.PRODUCTID,
                                            x.PRODUCTNAME,
                                            x.BRAND,
                                            x.PRICE,
                                            x.Tbl_Categories.NAME, // kategori adını tabloya yazdırıyoruz.
                                            x.STATUS
                                        }).ToList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Tbl_Product t = new Tbl_Product();

            t.PRODUCTNAME = TxtName.Text;
            t.BRAND = TxtBrand.Text;
            t.STOCK = short.Parse(TxtStock.Text);
            t.CATEGORY = int.Parse(CmbCategory.SelectedValue.ToString());
            t.PRICE = decimal.Parse(TxtPrice.Text);
            t.STATUS = true;
            db.Tbl_Product.Add(t);
            db.SaveChanges();
            MessageBox.Show("The product has been added to the system");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtID.Text);

            var product = db.Tbl_Product.Find(x);
            db.Tbl_Product.Remove(product);
            db.SaveChanges();
            MessageBox.Show("Product deleted");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtID.Text);

            var product = db.Tbl_Product.Find(x);
            product.PRODUCTNAME = TxtName.Text;
            product.STOCK = short.Parse(TxtStock.Text);
            product.PRICE = decimal.Parse(TxtPrice.Text);
            db.SaveChanges();
            MessageBox.Show("Product Updated");

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            // x ismindeki değişken değerlerini kategori tablosundan alsın dedik  ve select ile nereleri almasını istediğimizi yazdık
            var categories = (from x in db.Tbl_Categories
                              select new
                              {
                                  x.ID,
                                  x.NAME
                              }
                              ).ToList();
            // kategorielri comboboxta listeleme
            CmbCategory.ValueMember = "ID";
            CmbCategory.DisplayMember = "NAME";
            CmbCategory.DataSource = categories;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
