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
      

      
    }
}
