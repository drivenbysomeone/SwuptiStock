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
            this.ShowStockPage = new System.Windows.Forms.TabPage();
            this.cmbBoxSearchBrands = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdateSpecs = new System.Windows.Forms.Button();
            this.lblPlacement = new System.Windows.Forms.Label();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.lblScreen = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.lblRAM = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBoxP1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblAllProducts = new System.Windows.Forms.Label();
            this.lblSearchBrand = new System.Windows.Forms.Label();
            this.groupBoxP2 = new System.Windows.Forms.GroupBox();
            this.AmountOfAllProducts = new System.Windows.Forms.Label();
            this.TotalPuchaseValue = new System.Windows.Forms.Label();
            this.totalSellingPrice = new System.Windows.Forms.Label();
            this.profit = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabController.SuspendLayout();
            this.ShowPruductsPage.SuspendLayout();
            this.ShowStockPage.SuspendLayout();
            this.groupBoxP1.SuspendLayout();
            this.groupBoxP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabController.TabIndex = 0;
            // 
            // ShowPruductsPage
            // 
            this.ShowPruductsPage.Controls.Add(this.cmbBoxSearchBrands);
            this.ShowPruductsPage.Controls.Add(this.btnSearch);
            this.ShowPruductsPage.Controls.Add(this.groupBoxP1);
            this.ShowPruductsPage.Controls.Add(this.listView1);
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
            // ShowStockPage
            // 
            this.ShowStockPage.Controls.Add(this.dataGridView1);
            this.ShowStockPage.Controls.Add(this.label5);
            this.ShowStockPage.Controls.Add(this.groupBoxP2);
            this.ShowStockPage.Location = new System.Drawing.Point(4, 22);
            this.ShowStockPage.Name = "ShowStockPage";
            this.ShowStockPage.Padding = new System.Windows.Forms.Padding(3);
            this.ShowStockPage.Size = new System.Drawing.Size(672, 403);
            this.ShowStockPage.TabIndex = 1;
            this.ShowStockPage.Text = "Vis beholdning";
            this.ShowStockPage.UseVisualStyleBackColor = true;
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
            // 
            // btnUpdateSpecs
            // 
            this.btnUpdateSpecs.Location = new System.Drawing.Point(252, 284);
            this.btnUpdateSpecs.Name = "btnUpdateSpecs";
            this.btnUpdateSpecs.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSpecs.TabIndex = 35;
            this.btnUpdateSpecs.Text = "Opdater";
            this.btnUpdateSpecs.UseVisualStyleBackColor = true;
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
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(252, 258);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(75, 20);
            this.textBox15.TabIndex = 32;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(252, 235);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(75, 20);
            this.textBox14.TabIndex = 31;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(252, 211);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(75, 20);
            this.textBox13.TabIndex = 30;
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
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(230, 140);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(97, 20);
            this.textBox12.TabIndex = 28;
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
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(78, 258);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 26;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(78, 235);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 25;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(78, 211);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 24;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(78, 188);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(249, 20);
            this.textBox8.TabIndex = 23;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(78, 163);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(249, 20);
            this.textBox7.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(78, 140);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(87, 20);
            this.textBox6.TabIndex = 21;
            // 
            // groupBoxP1
            // 
            this.groupBoxP1.Controls.Add(this.btnUpdateSpecs);
            this.groupBoxP1.Controls.Add(this.lblPlacement);
            this.groupBoxP1.Controls.Add(this.lblSellingPrice);
            this.groupBoxP1.Controls.Add(this.textBox15);
            this.groupBoxP1.Controls.Add(this.textBox14);
            this.groupBoxP1.Controls.Add(this.textBox13);
            this.groupBoxP1.Controls.Add(this.lblScreen);
            this.groupBoxP1.Controls.Add(this.textBox12);
            this.groupBoxP1.Controls.Add(this.lblRAM);
            this.groupBoxP1.Controls.Add(this.textBox11);
            this.groupBoxP1.Controls.Add(this.textBox10);
            this.groupBoxP1.Controls.Add(this.textBox9);
            this.groupBoxP1.Controls.Add(this.textBox8);
            this.groupBoxP1.Controls.Add(this.textBox7);
            this.groupBoxP1.Controls.Add(this.textBox6);
            this.groupBoxP1.Controls.Add(this.textBox5);
            this.groupBoxP1.Controls.Add(this.textBox4);
            this.groupBoxP1.Controls.Add(this.textBox3);
            this.groupBoxP1.Controls.Add(this.textBox2);
            this.groupBoxP1.Controls.Add(this.textBox1);
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(78, 117);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(249, 20);
            this.textBox5.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(249, 20);
            this.textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(249, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(249, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 16;
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(9, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(316, 291);
            this.listView1.TabIndex = 38;
            this.listView1.UseCompatibleStateImageBehavior = false;
         
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
            // groupBoxP2
            // 
            this.groupBoxP2.Controls.Add(this.btnAdd);
            this.groupBoxP2.Controls.Add(this.textBox19);
            this.groupBoxP2.Controls.Add(this.textBox18);
            this.groupBoxP2.Controls.Add(this.textBox17);
            this.groupBoxP2.Controls.Add(this.textBox16);
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
            // AmountOfAllProducts
            // 
            this.AmountOfAllProducts.AutoSize = true;
            this.AmountOfAllProducts.Location = new System.Drawing.Point(23, 42);
            this.AmountOfAllProducts.Name = "AmountOfAllProducts";
            this.AmountOfAllProducts.Size = new System.Drawing.Size(98, 13);
            this.AmountOfAllProducts.TabIndex = 0;
            this.AmountOfAllProducts.Text = "Antal produkter ialt:";
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
            // totalSellingPrice
            // 
            this.totalSellingPrice.AutoSize = true;
            this.totalSellingPrice.Location = new System.Drawing.Point(23, 115);
            this.totalSellingPrice.Name = "totalSellingPrice";
            this.totalSellingPrice.Size = new System.Drawing.Size(86, 13);
            this.totalSellingPrice.TabIndex = 2;
            this.totalSellingPrice.Text = "Salgspris ialt kr. :";
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
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(119, 39);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 4;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(119, 76);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 5;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(119, 112);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 6;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(119, 149);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(100, 20);
            this.textBox19.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(119, 192);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Tilføj";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 10;
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
            this.ShowStockPage.ResumeLayout(false);
            this.ShowStockPage.PerformLayout();
            this.groupBoxP1.ResumeLayout(false);
            this.groupBoxP1.PerformLayout();
            this.groupBoxP2.ResumeLayout(false);
            this.groupBoxP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblAllProducts;
        private System.Windows.Forms.Label lblSearchBrand;
        private System.Windows.Forms.TabPage ShowStockPage;
        private System.Windows.Forms.GroupBox groupBoxP2;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label profit;
        private System.Windows.Forms.Label totalSellingPrice;
        private System.Windows.Forms.Label TotalPuchaseValue;
        private System.Windows.Forms.Label AmountOfAllProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.DataGridView dataGridView1;


    }
}

