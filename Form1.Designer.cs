namespace SwuptiStock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabController = new System.Windows.Forms.TabControl();
            this.ShowPruductsPage = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbBoxSearchBrands = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxP1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateSpecs = new System.Windows.Forms.Button();
            this.lblPlacement = new System.Windows.Forms.Label();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.txtBoxStorageLocation = new System.Windows.Forms.TextBox();
            this.txtBoxSellingPrice = new System.Windows.Forms.TextBox();
            this.txtBoxScreen = new System.Windows.Forms.TextBox();
            this.lblScreen = new System.Windows.Forms.Label();
            this.txtBoxRAM = new System.Windows.Forms.TextBox();
            this.lblRAM = new System.Windows.Forms.Label();
            this.txtBoxNumberQuantity = new System.Windows.Forms.TextBox();
            this.txtBoxPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtBoxHdSize = new System.Windows.Forms.TextBox();
            this.txtBocGraphicCard = new System.Windows.Forms.TextBox();
            this.txtBoxOS = new System.Windows.Forms.TextBox();
            this.txtBoxSpeed = new System.Windows.Forms.TextBox();
            this.txtBoxProcessor = new System.Windows.Forms.TextBox();
            this.txtBoxModelName = new System.Windows.Forms.TextBox();
            this.txtBoxBrand = new System.Windows.Forms.TextBox();
            this.txtBoxProductType = new System.Windows.Forms.TextBox();
            this.txtBoxCategory = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblProcessor = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPeformanceSpeed = new System.Windows.Forms.Label();
            this.lblPurchaseValue = new System.Windows.Forms.Label();
            this.lblOsSystem = new System.Windows.Forms.Label();
            this.lblHDDSize = new System.Windows.Forms.Label();
            this.lblGraphicCard = new System.Windows.Forms.Label();
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAllProducts = new System.Windows.Forms.Label();
            this.lblSearchBrand = new System.Windows.Forms.Label();
            this.ShowStockPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblPreviousProductsInStock = new System.Windows.Forms.Label();
            this.groupBoxP2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxProfit = new System.Windows.Forms.TextBox();
            this.txtBoxTotalSellingPrice = new System.Windows.Forms.TextBox();
            this.txtBoxTotalPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtBoxAllProducts = new System.Windows.Forms.TextBox();
            this.profit = new System.Windows.Forms.Label();
            this.totalSellingPrice = new System.Windows.Forms.Label();
            this.TotalPuchaseValue = new System.Windows.Forms.Label();
            this.AmountOfAllProducts = new System.Windows.Forms.Label();
            this.tabController.SuspendLayout();
            this.ShowPruductsPage.SuspendLayout();
            this.groupBoxP1.SuspendLayout();
            this.ShowStockPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxP2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.ShowPruductsPage);
            this.tabController.Controls.Add(this.ShowStockPage);
            this.tabController.Location = new System.Drawing.Point(0, 0);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(680, 429);
            this.tabController.TabIndex = 2;
            this.tabController.SelectedIndexChanged += new System.EventHandler(this.tabController_Enter);
            this.tabController.Enter += new System.EventHandler(this.tabController_Enter);
            // 
            // ShowPruductsPage
            // 
            this.ShowPruductsPage.Controls.Add(this.listBox1);
            this.ShowPruductsPage.Controls.Add(this.cmbBoxSearchBrands);
            this.ShowPruductsPage.Controls.Add(this.btnSearch);
            this.ShowPruductsPage.Controls.Add(this.groupBoxP1);
            this.ShowPruductsPage.Controls.Add(this.lblAllProducts);
            this.ShowPruductsPage.Controls.Add(this.lblSearchBrand);
            this.ShowPruductsPage.Location = new System.Drawing.Point(4, 22);
            this.ShowPruductsPage.Name = "ShowPruductsPage";
            this.ShowPruductsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ShowPruductsPage.Size = new System.Drawing.Size(672, 403);
            this.ShowPruductsPage.TabIndex = 0;
            this.ShowPruductsPage.Text = "Vis produkter";
            this.ShowPruductsPage.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 290);
            this.listBox1.TabIndex = 44;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cmbBoxSearchBrands
            // 
            this.cmbBoxSearchBrands.FormattingEnabled = true;
            this.cmbBoxSearchBrands.Items.AddRange(new object[] {
            "Acer",
            "Mac",
            "Alle"});
            this.cmbBoxSearchBrands.Location = new System.Drawing.Point(78, 354);
            this.cmbBoxSearchBrands.Name = "cmbBoxSearchBrands";
            this.cmbBoxSearchBrands.Size = new System.Drawing.Size(147, 21);
            this.cmbBoxSearchBrands.TabIndex = 43;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(250, 352);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Søg";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBoxP1
            // 
            this.groupBoxP1.Controls.Add(this.btnUpdateSpecs);
            this.groupBoxP1.Controls.Add(this.lblPlacement);
            this.groupBoxP1.Controls.Add(this.lblSellingPrice);
            this.groupBoxP1.Controls.Add(this.txtBoxStorageLocation);
            this.groupBoxP1.Controls.Add(this.txtBoxSellingPrice);
            this.groupBoxP1.Controls.Add(this.txtBoxScreen);
            this.groupBoxP1.Controls.Add(this.lblScreen);
            this.groupBoxP1.Controls.Add(this.txtBoxRAM);
            this.groupBoxP1.Controls.Add(this.lblRAM);
            this.groupBoxP1.Controls.Add(this.txtBoxNumberQuantity);
            this.groupBoxP1.Controls.Add(this.txtBoxPurchasePrice);
            this.groupBoxP1.Controls.Add(this.txtBoxHdSize);
            this.groupBoxP1.Controls.Add(this.txtBocGraphicCard);
            this.groupBoxP1.Controls.Add(this.txtBoxOS);
            this.groupBoxP1.Controls.Add(this.txtBoxSpeed);
            this.groupBoxP1.Controls.Add(this.txtBoxProcessor);
            this.groupBoxP1.Controls.Add(this.txtBoxModelName);
            this.groupBoxP1.Controls.Add(this.txtBoxBrand);
            this.groupBoxP1.Controls.Add(this.txtBoxProductType);
            this.groupBoxP1.Controls.Add(this.txtBoxCategory);
            this.groupBoxP1.Controls.Add(this.lblBrand);
            this.groupBoxP1.Controls.Add(this.lblProcessor);
            this.groupBoxP1.Controls.Add(this.lblQuantity);
            this.groupBoxP1.Controls.Add(this.lblPeformanceSpeed);
            this.groupBoxP1.Controls.Add(this.lblPurchaseValue);
            this.groupBoxP1.Controls.Add(this.lblOsSystem);
            this.groupBoxP1.Controls.Add(this.lblHDDSize);
            this.groupBoxP1.Controls.Add(this.lblGraphicCard);
            this.groupBoxP1.Controls.Add(this.lblModelName);
            this.groupBoxP1.Controls.Add(this.lblProductType);
            this.groupBoxP1.Controls.Add(this.lblCategory);
            this.groupBoxP1.Location = new System.Drawing.Point(331, 27);
            this.groupBoxP1.Name = "groupBoxP1";
            this.groupBoxP1.Size = new System.Drawing.Size(333, 321);
            this.groupBoxP1.TabIndex = 41;
            this.groupBoxP1.TabStop = false;
            this.groupBoxP1.Text = "Specifikationer";
            // 
            // btnUpdateSpecs
            // 
            this.btnUpdateSpecs.Location = new System.Drawing.Point(252, 284);
            this.btnUpdateSpecs.Name = "btnUpdateSpecs";
            this.btnUpdateSpecs.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSpecs.TabIndex = 35;
            this.btnUpdateSpecs.Text = "Opdater";
            this.btnUpdateSpecs.UseVisualStyleBackColor = true;
            this.btnUpdateSpecs.Click += new System.EventHandler(this.btnUpdateSpecs_Click);
            // 
            // lblPlacement
            // 
            this.lblPlacement.AutoSize = true;
            this.lblPlacement.Location = new System.Drawing.Point(192, 261);
            this.lblPlacement.Name = "lblPlacement";
            this.lblPlacement.Size = new System.Drawing.Size(54, 13);
            this.lblPlacement.TabIndex = 34;
            this.lblPlacement.Text = "Placering:";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Location = new System.Drawing.Point(194, 238);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(52, 13);
            this.lblSellingPrice.TabIndex = 33;
            this.lblSellingPrice.Text = "Salgspris:";
            // 
            // txtBoxStorageLocation
            // 
            this.txtBoxStorageLocation.Location = new System.Drawing.Point(252, 258);
            this.txtBoxStorageLocation.Name = "txtBoxStorageLocation";
            this.txtBoxStorageLocation.Size = new System.Drawing.Size(75, 20);
            this.txtBoxStorageLocation.TabIndex = 32;
            // 
            // txtBoxSellingPrice
            // 
            this.txtBoxSellingPrice.Location = new System.Drawing.Point(252, 235);
            this.txtBoxSellingPrice.Name = "txtBoxSellingPrice";
            this.txtBoxSellingPrice.Size = new System.Drawing.Size(75, 20);
            this.txtBoxSellingPrice.TabIndex = 31;
            // 
            // txtBoxScreen
            // 
            this.txtBoxScreen.Location = new System.Drawing.Point(252, 211);
            this.txtBoxScreen.Name = "txtBoxScreen";
            this.txtBoxScreen.ReadOnly = true;
            this.txtBoxScreen.Size = new System.Drawing.Size(75, 20);
            this.txtBoxScreen.TabIndex = 30;
            // 
            // lblScreen
            // 
            this.lblScreen.AutoSize = true;
            this.lblScreen.Location = new System.Drawing.Point(202, 218);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(44, 13);
            this.lblScreen.TabIndex = 29;
            this.lblScreen.Text = "Skærm:";
            // 
            // txtBoxRAM
            // 
            this.txtBoxRAM.Location = new System.Drawing.Point(230, 140);
            this.txtBoxRAM.Name = "txtBoxRAM";
            this.txtBoxRAM.ReadOnly = true;
            this.txtBoxRAM.Size = new System.Drawing.Size(97, 20);
            this.txtBoxRAM.TabIndex = 28;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(190, 143);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(34, 13);
            this.lblRAM.TabIndex = 27;
            this.lblRAM.Text = "RAM:";
            // 
            // txtBoxNumberQuantity
            // 
            this.txtBoxNumberQuantity.Location = new System.Drawing.Point(78, 258);
            this.txtBoxNumberQuantity.Name = "txtBoxNumberQuantity";
            this.txtBoxNumberQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNumberQuantity.TabIndex = 26;
            // 
            // txtBoxPurchasePrice
            // 
            this.txtBoxPurchasePrice.Location = new System.Drawing.Point(78, 235);
            this.txtBoxPurchasePrice.Name = "txtBoxPurchasePrice";
            this.txtBoxPurchasePrice.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPurchasePrice.TabIndex = 25;
            // 
            // txtBoxHdSize
            // 
            this.txtBoxHdSize.Location = new System.Drawing.Point(78, 211);
            this.txtBoxHdSize.Name = "txtBoxHdSize";
            this.txtBoxHdSize.ReadOnly = true;
            this.txtBoxHdSize.Size = new System.Drawing.Size(100, 20);
            this.txtBoxHdSize.TabIndex = 24;
            // 
            // txtBocGraphicCard
            // 
            this.txtBocGraphicCard.Location = new System.Drawing.Point(78, 188);
            this.txtBocGraphicCard.Name = "txtBocGraphicCard";
            this.txtBocGraphicCard.ReadOnly = true;
            this.txtBocGraphicCard.Size = new System.Drawing.Size(249, 20);
            this.txtBocGraphicCard.TabIndex = 23;
            // 
            // txtBoxOS
            // 
            this.txtBoxOS.Location = new System.Drawing.Point(78, 163);
            this.txtBoxOS.Name = "txtBoxOS";
            this.txtBoxOS.ReadOnly = true;
            this.txtBoxOS.Size = new System.Drawing.Size(249, 20);
            this.txtBoxOS.TabIndex = 22;
            // 
            // txtBoxSpeed
            // 
            this.txtBoxSpeed.Location = new System.Drawing.Point(78, 140);
            this.txtBoxSpeed.Name = "txtBoxSpeed";
            this.txtBoxSpeed.ReadOnly = true;
            this.txtBoxSpeed.Size = new System.Drawing.Size(87, 20);
            this.txtBoxSpeed.TabIndex = 21;
            // 
            // txtBoxProcessor
            // 
            this.txtBoxProcessor.Location = new System.Drawing.Point(78, 117);
            this.txtBoxProcessor.Name = "txtBoxProcessor";
            this.txtBoxProcessor.ReadOnly = true;
            this.txtBoxProcessor.Size = new System.Drawing.Size(249, 20);
            this.txtBoxProcessor.TabIndex = 20;
            // 
            // txtBoxModelName
            // 
            this.txtBoxModelName.Location = new System.Drawing.Point(78, 94);
            this.txtBoxModelName.Name = "txtBoxModelName";
            this.txtBoxModelName.ReadOnly = true;
            this.txtBoxModelName.Size = new System.Drawing.Size(249, 20);
            this.txtBoxModelName.TabIndex = 19;
            // 
            // txtBoxBrand
            // 
            this.txtBoxBrand.Location = new System.Drawing.Point(78, 71);
            this.txtBoxBrand.Name = "txtBoxBrand";
            this.txtBoxBrand.ReadOnly = true;
            this.txtBoxBrand.Size = new System.Drawing.Size(249, 20);
            this.txtBoxBrand.TabIndex = 18;
            // 
            // txtBoxProductType
            // 
            this.txtBoxProductType.Location = new System.Drawing.Point(78, 48);
            this.txtBoxProductType.Name = "txtBoxProductType";
            this.txtBoxProductType.ReadOnly = true;
            this.txtBoxProductType.Size = new System.Drawing.Size(249, 20);
            this.txtBoxProductType.TabIndex = 17;
            // 
            // txtBoxCategory
            // 
            this.txtBoxCategory.Location = new System.Drawing.Point(78, 26);
            this.txtBoxCategory.Name = "txtBoxCategory";
            this.txtBoxCategory.ReadOnly = true;
            this.txtBoxCategory.Size = new System.Drawing.Size(249, 20);
            this.txtBoxCategory.TabIndex = 16;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(6, 74);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(44, 13);
            this.lblBrand.TabIndex = 15;
            this.lblBrand.Text = "Mærke:";
            // 
            // lblProcessor
            // 
            this.lblProcessor.AutoSize = true;
            this.lblProcessor.Location = new System.Drawing.Point(6, 120);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(57, 13);
            this.lblProcessor.TabIndex = 14;
            this.lblProcessor.Text = "Processor:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(6, 261);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(31, 13);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "Antal";
            // 
            // lblPeformanceSpeed
            // 
            this.lblPeformanceSpeed.AutoSize = true;
            this.lblPeformanceSpeed.Location = new System.Drawing.Point(6, 143);
            this.lblPeformanceSpeed.Name = "lblPeformanceSpeed";
            this.lblPeformanceSpeed.Size = new System.Drawing.Size(58, 13);
            this.lblPeformanceSpeed.TabIndex = 12;
            this.lblPeformanceSpeed.Text = "Hastighed:";
            // 
            // lblPurchaseValue
            // 
            this.lblPurchaseValue.AutoSize = true;
            this.lblPurchaseValue.Location = new System.Drawing.Point(6, 238);
            this.lblPurchaseValue.Name = "lblPurchaseValue";
            this.lblPurchaseValue.Size = new System.Drawing.Size(64, 13);
            this.lblPurchaseValue.TabIndex = 11;
            this.lblPurchaseValue.Text = "Indkøbspris:";
            // 
            // lblOsSystem
            // 
            this.lblOsSystem.AutoSize = true;
            this.lblOsSystem.Location = new System.Drawing.Point(6, 166);
            this.lblOsSystem.Name = "lblOsSystem";
            this.lblOsSystem.Size = new System.Drawing.Size(69, 13);
            this.lblOsSystem.TabIndex = 10;
            this.lblOsSystem.Text = "Styre system:";
            // 
            // lblHDDSize
            // 
            this.lblHDDSize.AutoSize = true;
            this.lblHDDSize.Location = new System.Drawing.Point(6, 214);
            this.lblHDDSize.Name = "lblHDDSize";
            this.lblHDDSize.Size = new System.Drawing.Size(76, 13);
            this.lblHDDSize.TabIndex = 9;
            this.lblHDDSize.Text = "HDD størrelse:";
            // 
            // lblGraphicCard
            // 
            this.lblGraphicCard.AutoSize = true;
            this.lblGraphicCard.Location = new System.Drawing.Point(6, 191);
            this.lblGraphicCard.Name = "lblGraphicCard";
            this.lblGraphicCard.Size = new System.Drawing.Size(59, 13);
            this.lblGraphicCard.TabIndex = 8;
            this.lblGraphicCard.Text = "Grafik kort:";
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(6, 97);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(66, 13);
            this.lblModelName.TabIndex = 7;
            this.lblModelName.Text = "Model navn:";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(6, 51);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(74, 13);
            this.lblProductType.TabIndex = 6;
            this.lblProductType.Text = "Produkt Type:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 29);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Kategori:";
            // 
            // lblAllProducts
            // 
            this.lblAllProducts.AutoSize = true;
            this.lblAllProducts.Location = new System.Drawing.Point(10, 27);
            this.lblAllProducts.Name = "lblAllProducts";
            this.lblAllProducts.Size = new System.Drawing.Size(53, 13);
            this.lblAllProducts.TabIndex = 40;
            this.lblAllProducts.Text = "Produkter";
            // 
            // lblSearchBrand
            // 
            this.lblSearchBrand.AutoSize = true;
            this.lblSearchBrand.Location = new System.Drawing.Point(10, 357);
            this.lblSearchBrand.Name = "lblSearchBrand";
            this.lblSearchBrand.Size = new System.Drawing.Size(62, 13);
            this.lblSearchBrand.TabIndex = 39;
            this.lblSearchBrand.Text = "Søg mærke";
            // 
            // ShowStockPage
            // 
            this.ShowStockPage.Controls.Add(this.dataGridView1);
            this.ShowStockPage.Controls.Add(this.lblPreviousProductsInStock);
            this.ShowStockPage.Controls.Add(this.groupBoxP2);
            this.ShowStockPage.Location = new System.Drawing.Point(4, 22);
            this.ShowStockPage.Name = "ShowStockPage";
            this.ShowStockPage.Padding = new System.Windows.Forms.Padding(3);
            this.ShowStockPage.Size = new System.Drawing.Size(672, 403);
            this.ShowStockPage.TabIndex = 1;
            this.ShowStockPage.Text = "Vis beholdning";
            this.ShowStockPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(307, 211);
            this.dataGridView1.TabIndex = 10;
            
            // 
            // lblPreviousProductsInStock
            // 
            this.lblPreviousProductsInStock.AutoSize = true;
            this.lblPreviousProductsInStock.Location = new System.Drawing.Point(326, 48);
            this.lblPreviousProductsInStock.Name = "lblPreviousProductsInStock";
            this.lblPreviousProductsInStock.Size = new System.Drawing.Size(114, 13);
            this.lblPreviousProductsInStock.TabIndex = 9;
            this.lblPreviousProductsInStock.Text = "Tidligere beholdninger:";
            // 
            // groupBoxP2
            // 
            this.groupBoxP2.Controls.Add(this.btnAdd);
            this.groupBoxP2.Controls.Add(this.txtBoxProfit);
            this.groupBoxP2.Controls.Add(this.txtBoxTotalSellingPrice);
            this.groupBoxP2.Controls.Add(this.txtBoxTotalPurchasePrice);
            this.groupBoxP2.Controls.Add(this.txtBoxAllProducts);
            this.groupBoxP2.Controls.Add(this.profit);
            this.groupBoxP2.Controls.Add(this.totalSellingPrice);
            this.groupBoxP2.Controls.Add(this.TotalPuchaseValue);
            this.groupBoxP2.Controls.Add(this.AmountOfAllProducts);
            this.groupBoxP2.Location = new System.Drawing.Point(26, 48);
            this.groupBoxP2.Name = "groupBoxP2";
            this.groupBoxP2.Size = new System.Drawing.Size(246, 240);
            this.groupBoxP2.TabIndex = 0;
            this.groupBoxP2.TabStop = false;
            this.groupBoxP2.Text = "Nuværende beholdning";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(119, 192);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Tilføj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxProfit
            // 
            this.txtBoxProfit.Location = new System.Drawing.Point(119, 149);
            this.txtBoxProfit.Name = "txtBoxProfit";
            this.txtBoxProfit.ReadOnly = true;
            this.txtBoxProfit.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProfit.TabIndex = 7;
            // 
            // txtBoxTotalSellingPrice
            // 
            this.txtBoxTotalSellingPrice.Location = new System.Drawing.Point(119, 112);
            this.txtBoxTotalSellingPrice.Name = "txtBoxTotalSellingPrice";
            this.txtBoxTotalSellingPrice.ReadOnly = true;
            this.txtBoxTotalSellingPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTotalSellingPrice.TabIndex = 6;
            // 
            // txtBoxTotalPurchasePrice
            // 
            this.txtBoxTotalPurchasePrice.Location = new System.Drawing.Point(119, 76);
            this.txtBoxTotalPurchasePrice.Name = "txtBoxTotalPurchasePrice";
            this.txtBoxTotalPurchasePrice.ReadOnly = true;
            this.txtBoxTotalPurchasePrice.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTotalPurchasePrice.TabIndex = 5;
            // 
            // txtBoxAllProducts
            // 
            this.txtBoxAllProducts.Location = new System.Drawing.Point(119, 39);
            this.txtBoxAllProducts.Name = "txtBoxAllProducts";
            this.txtBoxAllProducts.ReadOnly = true;
            this.txtBoxAllProducts.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAllProducts.TabIndex = 4;
            // 
            // profit
            // 
            this.profit.AutoSize = true;
            this.profit.Location = new System.Drawing.Point(23, 152);
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(81, 13);
            this.profit.TabIndex = 3;
            this.profit.Text = "Fortjeneste Kr. :";
            // 
            // totalSellingPrice
            // 
            this.totalSellingPrice.AutoSize = true;
            this.totalSellingPrice.Location = new System.Drawing.Point(23, 115);
            this.totalSellingPrice.Name = "totalSellingPrice";
            this.totalSellingPrice.Size = new System.Drawing.Size(86, 13);
            this.totalSellingPrice.TabIndex = 2;
            this.totalSellingPrice.Text = "Salgspris ialt kr. :";
            // 
            // TotalPuchaseValue
            // 
            this.TotalPuchaseValue.AutoSize = true;
            this.TotalPuchaseValue.Location = new System.Drawing.Point(23, 79);
            this.TotalPuchaseValue.Name = "TotalPuchaseValue";
            this.TotalPuchaseValue.Size = new System.Drawing.Size(78, 13);
            this.TotalPuchaseValue.TabIndex = 1;
            this.TotalPuchaseValue.Text = "købpris ialt kr. :";
            // 
            // AmountOfAllProducts
            // 
            this.AmountOfAllProducts.AutoSize = true;
            this.AmountOfAllProducts.Location = new System.Drawing.Point(23, 42);
            this.AmountOfAllProducts.Name = "AmountOfAllProducts";
            this.AmountOfAllProducts.Size = new System.Drawing.Size(98, 13);
            this.AmountOfAllProducts.TabIndex = 0;
            this.AmountOfAllProducts.Text = "Antal produkter ialt:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 424);
            this.Controls.Add(this.tabController);
            this.Name = "Form1";
            this.Text = "Swupti lagerstyringsprogram";
            this.tabController.ResumeLayout(false);
            this.ShowPruductsPage.ResumeLayout(false);
            this.ShowPruductsPage.PerformLayout();
            this.groupBoxP1.ResumeLayout(false);
            this.groupBoxP1.PerformLayout();
            this.ShowStockPage.ResumeLayout(false);
            this.ShowStockPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxP2.ResumeLayout(false);
            this.groupBoxP2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage ShowPruductsPage;
        private System.Windows.Forms.ComboBox cmbBoxSearchBrands;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBoxP1;
        private System.Windows.Forms.Button btnUpdateSpecs;
        private System.Windows.Forms.Label lblPlacement;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.TextBox txtBoxStorageLocation;
        private System.Windows.Forms.TextBox txtBoxSellingPrice;
        private System.Windows.Forms.TextBox txtBoxScreen;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.TextBox txtBoxRAM;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.TextBox txtBoxNumberQuantity;
        private System.Windows.Forms.TextBox txtBoxPurchasePrice;
        private System.Windows.Forms.TextBox txtBoxHdSize;
        private System.Windows.Forms.TextBox txtBocGraphicCard;
        private System.Windows.Forms.TextBox txtBoxOS;
        private System.Windows.Forms.TextBox txtBoxSpeed;
        private System.Windows.Forms.TextBox txtBoxProcessor;
        private System.Windows.Forms.TextBox txtBoxModelName;
        private System.Windows.Forms.TextBox txtBoxBrand;
        private System.Windows.Forms.TextBox txtBoxProductType;
        private System.Windows.Forms.TextBox txtBoxCategory;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblProcessor;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPeformanceSpeed;
        private System.Windows.Forms.Label lblPurchaseValue;
        private System.Windows.Forms.Label lblOsSystem;
        private System.Windows.Forms.Label lblHDDSize;
        private System.Windows.Forms.Label lblGraphicCard;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAllProducts;
        private System.Windows.Forms.Label lblSearchBrand;
        private System.Windows.Forms.TabPage ShowStockPage;
        private System.Windows.Forms.GroupBox groupBoxP2;
        private System.Windows.Forms.TextBox txtBoxAllProducts;
        private System.Windows.Forms.Label profit;
        private System.Windows.Forms.Label totalSellingPrice;
        private System.Windows.Forms.Label TotalPuchaseValue;
        private System.Windows.Forms.Label AmountOfAllProducts;
        private System.Windows.Forms.Label lblPreviousProductsInStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxProfit;
        private System.Windows.Forms.TextBox txtBoxTotalSellingPrice;
        private System.Windows.Forms.TextBox txtBoxTotalPurchasePrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;


    }
}

