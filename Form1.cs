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

        int allProducts = 0;
        decimal theTotalPurchase = 0;
        decimal theTotalSellingPrice = 0;
        decimal theProfit = 0;

        public Form1()
        {
            InitializeComponent();       

            allBrandsRevealed();
            allModelNamesRevealed();
            dataInTotalsRevealed();
         
        }

        private void dataInTotalsRevealed()
        {
            dataGridView1.DataSource = bl.GetGridViewData();
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

            var selectedValue = Convert.ToInt32(listBox1.SelectedValue.ToString());
            var stock = bl.GetSingleStockById(selectedValue);

            decimal purchasePrice = 0;
            decimal sellingPrice = 0;
            int quantity = 0;
            string storageLocation = "";
            int theProductId = stock.ProductId;
            
            purchasePrice = Convert.ToDecimal(txtBoxPurchasePrice.Text);
            sellingPrice = Convert.ToDecimal(txtBoxSellingPrice.Text);
            quantity = Convert.ToInt32(txtBoxNumberQuantity.Text);
            storageLocation = txtBoxStorageLocation.Text;

            // overwritten values being updated:
            bl.UpdateTheStock(purchasePrice, sellingPrice, quantity, storageLocation, theProductId);      
     
            MessageBox.Show("Produkt opdateret");
           
        }

        //OBS => in tabControl design view - > events, set: SelectedIndexChanged to tabController_Enter.(So program knows that it is switching between two tabs)
        private void tabController_Enter(object sender, EventArgs e)
        {

            
 
            allProducts = bl.GetTotalNumberOfProducts();
            txtBoxAllProducts.Text = allProducts.ToString();

            theTotalPurchase = bl.GetTotalPurchase();
            txtBoxTotalPurchasePrice.Text = theTotalPurchase.ToString();

            theTotalSellingPrice = bl.GetTotalSellingPrice();
            txtBoxTotalSellingPrice.Text = theTotalSellingPrice.ToString();

            
            theProfit = theTotalSellingPrice - theTotalPurchase;
            txtBoxProfit.Text = theProfit.ToString();




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bl.InsertNewValues(allProducts, theTotalPurchase, theTotalSellingPrice, theProfit);

            
        }

       



    }
}
