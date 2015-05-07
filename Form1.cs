using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwuptiStock
{
    public partial class Form1 : Form
    {

        BL bl = new BL();

        public Form1()
        {
            InitializeComponent();
            allBrandsRevealed();
            allModelNamesRevealed();
            
        }

        private void allBrandsRevealed()
        {
            cmbBoxSearchBrands.ValueMember = "Id";
            cmbBoxSearchBrands.DisplayMember = "BrandName";
            cmbBoxSearchBrands.DataSource = bl.GetDataCmbBox();      
        }

        private void allModelNamesRevealed()
        {
      
            listBox1.ValueMember = "ProductId";
            listBox1.DisplayMember = "ModelName";
            listBox1.DataSource = bl.GetDataLstBox();
        }

        private void allModelNamesRevealedById(int id)
        {

            listBox1.ValueMember = "ProductId";
            listBox1.DisplayMember = "ModelName";
            listBox1.DataSource = bl.GetDataLstBox(id);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
  
            if (cmbBoxSearchBrands != null)
            {
                int matches = Convert.ToInt32(cmbBoxSearchBrands.SelectedValue.ToString());
                allModelNamesRevealedById(matches);
            }                     
      }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedValue = Convert.ToInt32(listBox1.SelectedValue.ToString());          
            var stock = bl.GetSingleStockById(selectedValue);
            

            txtBoxCategory.Text = stock.Category;
            txtBoxProductType.Text = stock.ProductType;
            
            //txtBoxBrand.Text = selectedValue.ToString();
            txtBoxBrand.Text = stock.Brand.BrandName;
            txtBoxModelName.Text = stock.ModelName;
            txtBoxProcessor.Text = stock.Processor;
            txtBoxSpeed.Text = stock.Speed.ToString();
            txtBoxRAM.Text = stock.RAM.ToString();
            txtBoxOS.Text = stock.OperatingSystem;
            txtBocGraphicCard.Text = stock.GraphicCard;
            txtBoxHdSize.Text = stock.HardDrive.ToString();
            txtBoxScreen.Text = stock.Screen;
            txtBoxPurchasePrice.Text = stock.Purchase.ToString();
            txtBoxSellingPrice.Text = stock.SellingPrice.ToString();
            txtBoxNumberQuantity.Text = stock.Number.ToString();
            txtBoxStorageLocation.Text = stock.StorageLocation;
       
        }

        private void btnUpdateSpecs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produkt opdateret");
        }
    }
}
