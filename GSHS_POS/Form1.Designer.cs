namespace GSHS_POS
{
    partial class GSHSForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            this.GSHS_Control = new System.Windows.Forms.TabControl();
            this.saleTab = new System.Windows.Forms.TabPage();
            this.addItemTextBox = new System.Windows.Forms.TextBox();
            this.addItem = new System.Windows.Forms.Button();
            this.runningTotal = new System.Windows.Forms.TextBox();
            this.sellButton = new System.Windows.Forms.Button();
            this.salesDataGrid = new System.Windows.Forms.DataGridView();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagridviewContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.newSearch = new System.Windows.Forms.Button();
            this.searchResultGridView = new System.Windows.Forms.DataGridView();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTermsBox = new System.Windows.Forms.GroupBox();
            this.genderAnyRB = new System.Windows.Forms.RadioButton();
            this.productCodeSearch = new System.Windows.Forms.Label();
            this.secondHandCB = new System.Windows.Forms.CheckBox();
            this.categoriesSearchBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.styleSearchBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.genderFemaleRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.genderMaleRadioButton = new System.Windows.Forms.RadioButton();
            this.sizeSearchBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.genderNeutralRB = new System.Windows.Forms.RadioButton();
            this.productCodeSearchBox = new System.Windows.Forms.TextBox();
            this.instockCB = new System.Windows.Forms.CheckBox();
            this.inventoryTab = new System.Windows.Forms.TabPage();
            this.currentSaveFile = new System.Windows.Forms.Label();
            this.loadInvoiceButton = new System.Windows.Forms.Button();
            this.clearInventoryButton = new System.Windows.Forms.Button();
            this.inventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.submitInvoiceButton = new System.Windows.Forms.Button();
            this.changeInvoiceQuantityBtn = new System.Windows.Forms.Button();
            this.addItemInvoiceBtn = new System.Windows.Forms.Button();
            this.changeInvoiceTotalBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.invoiceDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addInvoiceProduct = new System.Windows.Forms.TextBox();
            this.invoiceQuantityTotal = new System.Windows.Forms.TextBox();
            this.inventoryQuantityTotal = new System.Windows.Forms.TextBox();
            this.saveDraftButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inventoryRunningTotal = new System.Windows.Forms.TextBox();
            this.invoiceCostTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newInvoiceButton = new System.Windows.Forms.Button();
            this.inventoryGridView = new System.Windows.Forms.DataGridView();
            this.invoiceProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceProductStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceProductSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceQuantityToAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryProductCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportTab = new System.Windows.Forms.TabPage();
            this.managementTab = new System.Windows.Forms.TabPage();
            this.gshs_posDataSet = new GSHS_POS.gshs_posDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new GSHS_POS.gshs_posDataSetTableAdapters.productsTableAdapter();
            this.reports = new System.Windows.Forms.TreeView();
            this.GSHS_Control.SuspendLayout();
            this.saleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).BeginInit();
            this.datagridviewContext.SuspendLayout();
            this.searchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGridView)).BeginInit();
            this.searchTermsBox.SuspendLayout();
            this.inventoryTab.SuspendLayout();
            this.inventoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).BeginInit();
            this.inventoryContextStrip.SuspendLayout();
            this.reportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gshs_posDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GSHS_Control
            // 
            this.GSHS_Control.Controls.Add(this.saleTab);
            this.GSHS_Control.Controls.Add(this.searchTab);
            this.GSHS_Control.Controls.Add(this.inventoryTab);
            this.GSHS_Control.Controls.Add(this.reportTab);
            this.GSHS_Control.Controls.Add(this.managementTab);
            this.GSHS_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GSHS_Control.HotTrack = true;
            this.GSHS_Control.Location = new System.Drawing.Point(0, 0);
            this.GSHS_Control.Name = "GSHS_Control";
            this.GSHS_Control.SelectedIndex = 0;
            this.GSHS_Control.Size = new System.Drawing.Size(726, 501);
            this.GSHS_Control.TabIndex = 0;
            // 
            // saleTab
            // 
            this.saleTab.Controls.Add(this.addItemTextBox);
            this.saleTab.Controls.Add(this.addItem);
            this.saleTab.Controls.Add(this.runningTotal);
            this.saleTab.Controls.Add(this.sellButton);
            this.saleTab.Controls.Add(this.salesDataGrid);
            this.saleTab.Location = new System.Drawing.Point(4, 22);
            this.saleTab.Name = "saleTab";
            this.saleTab.Padding = new System.Windows.Forms.Padding(3);
            this.saleTab.Size = new System.Drawing.Size(718, 475);
            this.saleTab.TabIndex = 0;
            this.saleTab.Text = "Sales";
            this.saleTab.UseVisualStyleBackColor = true;
            // 
            // addItemTextBox
            // 
            this.addItemTextBox.Location = new System.Drawing.Point(8, 77);
            this.addItemTextBox.Name = "addItemTextBox";
            this.addItemTextBox.Size = new System.Drawing.Size(201, 20);
            this.addItemTextBox.TabIndex = 1;
            this.addItemTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addItemTextBox_KeyDown);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(215, 77);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(75, 23);
            this.addItem.TabIndex = 2;
            this.addItem.Text = "Add";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // runningTotal
            // 
            this.runningTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runningTotal.Location = new System.Drawing.Point(551, 378);
            this.runningTotal.Name = "runningTotal";
            this.runningTotal.ReadOnly = true;
            this.runningTotal.Size = new System.Drawing.Size(159, 20);
            this.runningTotal.TabIndex = 2;
            // 
            // sellButton
            // 
            this.sellButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellButton.Location = new System.Drawing.Point(262, 378);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(126, 43);
            this.sellButton.TabIndex = 1;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // salesDataGrid
            // 
            this.salesDataGrid.AllowUserToAddRows = false;
            this.salesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCode,
            this.productDescription,
            this.productQuantity,
            this.productCost});
            this.salesDataGrid.ContextMenuStrip = this.datagridviewContext;
            this.salesDataGrid.Location = new System.Drawing.Point(8, 106);
            this.salesDataGrid.Name = "salesDataGrid";
            this.salesDataGrid.ReadOnly = true;
            this.salesDataGrid.Size = new System.Drawing.Size(704, 266);
            this.salesDataGrid.TabIndex = 0;
            this.salesDataGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.salesDataGrid_MouseDown);
            // 
            // productCode
            // 
            this.productCode.HeaderText = "Product Code";
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            // 
            // productDescription
            // 
            this.productDescription.HeaderText = "Product Description";
            this.productDescription.Name = "productDescription";
            this.productDescription.ReadOnly = true;
            // 
            // productQuantity
            // 
            this.productQuantity.HeaderText = "Quantity";
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.ReadOnly = true;
            // 
            // productCost
            // 
            this.productCost.HeaderText = "Cost";
            this.productCost.Name = "productCost";
            this.productCost.ReadOnly = true;
            // 
            // datagridviewContext
            // 
            this.datagridviewContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeItemToolStripMenuItem,
            this.removeItemToolStripMenuItem1});
            this.datagridviewContext.Name = "datagridviewContext";
            this.datagridviewContext.Size = new System.Drawing.Size(185, 48);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.removeItemToolStripMenuItem.Text = "Remove All Products";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.removeItemToolStripMenuItem_Click);
            // 
            // removeItemToolStripMenuItem1
            // 
            this.removeItemToolStripMenuItem1.Name = "removeItemToolStripMenuItem1";
            this.removeItemToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.removeItemToolStripMenuItem1.Text = "Remove Item";
            this.removeItemToolStripMenuItem1.Click += new System.EventHandler(this.removeItemToolStripMenuItem1_Click);
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.newSearch);
            this.searchTab.Controls.Add(this.searchResultGridView);
            this.searchTab.Controls.Add(this.searchTermsBox);
            this.searchTab.Location = new System.Drawing.Point(4, 22);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(718, 475);
            this.searchTab.TabIndex = 1;
            this.searchTab.Text = "Search";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // newSearch
            // 
            this.newSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.newSearch.Location = new System.Drawing.Point(143, 345);
            this.newSearch.Name = "newSearch";
            this.newSearch.Size = new System.Drawing.Size(114, 46);
            this.newSearch.TabIndex = 16;
            this.newSearch.Text = "New Search";
            this.newSearch.UseVisualStyleBackColor = true;
            this.newSearch.Visible = false;
            this.newSearch.Click += new System.EventHandler(this.newSearch_Click);
            // 
            // searchResultGridView
            // 
            this.searchResultGridView.AllowUserToAddRows = false;
            this.searchResultGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchResultGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.category,
            this.style,
            this.size,
            this.gender,
            this.inStock,
            this.secondHand});
            this.searchResultGridView.Location = new System.Drawing.Point(8, 24);
            this.searchResultGridView.Name = "searchResultGridView";
            this.searchResultGridView.Size = new System.Drawing.Size(704, 318);
            this.searchResultGridView.TabIndex = 15;
            this.searchResultGridView.Visible = false;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // style
            // 
            this.style.HeaderText = "Style";
            this.style.Name = "style";
            this.style.ReadOnly = true;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // inStock
            // 
            this.inStock.HeaderText = "In Stock";
            this.inStock.Name = "inStock";
            this.inStock.ReadOnly = true;
            // 
            // secondHand
            // 
            this.secondHand.HeaderText = "Second Hand";
            this.secondHand.Name = "secondHand";
            this.secondHand.ReadOnly = true;
            // 
            // searchTermsBox
            // 
            this.searchTermsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTermsBox.Controls.Add(this.genderAnyRB);
            this.searchTermsBox.Controls.Add(this.productCodeSearch);
            this.searchTermsBox.Controls.Add(this.secondHandCB);
            this.searchTermsBox.Controls.Add(this.categoriesSearchBox);
            this.searchTermsBox.Controls.Add(this.label3);
            this.searchTermsBox.Controls.Add(this.styleSearchBox);
            this.searchTermsBox.Controls.Add(this.label2);
            this.searchTermsBox.Controls.Add(this.genderFemaleRB);
            this.searchTermsBox.Controls.Add(this.label1);
            this.searchTermsBox.Controls.Add(this.genderMaleRadioButton);
            this.searchTermsBox.Controls.Add(this.sizeSearchBox);
            this.searchTermsBox.Controls.Add(this.searchButton);
            this.searchTermsBox.Controls.Add(this.genderNeutralRB);
            this.searchTermsBox.Controls.Add(this.productCodeSearchBox);
            this.searchTermsBox.Controls.Add(this.instockCB);
            this.searchTermsBox.Location = new System.Drawing.Point(263, 24);
            this.searchTermsBox.Name = "searchTermsBox";
            this.searchTermsBox.Size = new System.Drawing.Size(150, 374);
            this.searchTermsBox.TabIndex = 15;
            this.searchTermsBox.TabStop = false;
            this.searchTermsBox.Text = "Search Terms";
            // 
            // genderAnyRB
            // 
            this.genderAnyRB.AutoSize = true;
            this.genderAnyRB.Location = new System.Drawing.Point(21, 251);
            this.genderAnyRB.Name = "genderAnyRB";
            this.genderAnyRB.Size = new System.Drawing.Size(43, 17);
            this.genderAnyRB.TabIndex = 17;
            this.genderAnyRB.TabStop = true;
            this.genderAnyRB.Text = "Any";
            this.genderAnyRB.UseVisualStyleBackColor = true;
            // 
            // productCodeSearch
            // 
            this.productCodeSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productCodeSearch.AutoSize = true;
            this.productCodeSearch.Location = new System.Drawing.Point(18, 20);
            this.productCodeSearch.Name = "productCodeSearch";
            this.productCodeSearch.Size = new System.Drawing.Size(72, 13);
            this.productCodeSearch.TabIndex = 10;
            this.productCodeSearch.Text = "Product Code";
            // 
            // secondHandCB
            // 
            this.secondHandCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondHandCB.AutoSize = true;
            this.secondHandCB.Location = new System.Drawing.Point(21, 297);
            this.secondHandCB.Name = "secondHandCB";
            this.secondHandCB.Size = new System.Drawing.Size(92, 17);
            this.secondHandCB.TabIndex = 14;
            this.secondHandCB.Text = "Second Hand";
            this.secondHandCB.UseVisualStyleBackColor = true;
            // 
            // categoriesSearchBox
            // 
            this.categoriesSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriesSearchBox.FormattingEnabled = true;
            this.categoriesSearchBox.Location = new System.Drawing.Point(21, 75);
            this.categoriesSearchBox.Name = "categoriesSearchBox";
            this.categoriesSearchBox.Size = new System.Drawing.Size(121, 21);
            this.categoriesSearchBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Style";
            // 
            // styleSearchBox
            // 
            this.styleSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.styleSearchBox.FormattingEnabled = true;
            this.styleSearchBox.Location = new System.Drawing.Point(21, 115);
            this.styleSearchBox.Name = "styleSearchBox";
            this.styleSearchBox.Size = new System.Drawing.Size(121, 21);
            this.styleSearchBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Size";
            // 
            // genderFemaleRB
            // 
            this.genderFemaleRB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genderFemaleRB.AutoSize = true;
            this.genderFemaleRB.Location = new System.Drawing.Point(21, 205);
            this.genderFemaleRB.Name = "genderFemaleRB";
            this.genderFemaleRB.Size = new System.Drawing.Size(59, 17);
            this.genderFemaleRB.TabIndex = 2;
            this.genderFemaleRB.TabStop = true;
            this.genderFemaleRB.Text = "Female";
            this.genderFemaleRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Categories";
            // 
            // genderMaleRadioButton
            // 
            this.genderMaleRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genderMaleRadioButton.AutoSize = true;
            this.genderMaleRadioButton.Location = new System.Drawing.Point(21, 182);
            this.genderMaleRadioButton.Name = "genderMaleRadioButton";
            this.genderMaleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.genderMaleRadioButton.TabIndex = 3;
            this.genderMaleRadioButton.TabStop = true;
            this.genderMaleRadioButton.Text = "Male";
            this.genderMaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // sizeSearchBox
            // 
            this.sizeSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeSearchBox.FormattingEnabled = true;
            this.sizeSearchBox.Location = new System.Drawing.Point(21, 155);
            this.sizeSearchBox.Name = "sizeSearchBox";
            this.sizeSearchBox.Size = new System.Drawing.Size(121, 21);
            this.sizeSearchBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(18, 320);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(121, 47);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // genderNeutralRB
            // 
            this.genderNeutralRB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genderNeutralRB.AutoSize = true;
            this.genderNeutralRB.Location = new System.Drawing.Point(21, 228);
            this.genderNeutralRB.Name = "genderNeutralRB";
            this.genderNeutralRB.Size = new System.Drawing.Size(59, 17);
            this.genderNeutralRB.TabIndex = 6;
            this.genderNeutralRB.TabStop = true;
            this.genderNeutralRB.Text = "Neutral";
            this.genderNeutralRB.UseVisualStyleBackColor = true;
            // 
            // productCodeSearchBox
            // 
            this.productCodeSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productCodeSearchBox.Location = new System.Drawing.Point(21, 36);
            this.productCodeSearchBox.Name = "productCodeSearchBox";
            this.productCodeSearchBox.Size = new System.Drawing.Size(121, 20);
            this.productCodeSearchBox.TabIndex = 8;
            // 
            // instockCB
            // 
            this.instockCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instockCB.AutoSize = true;
            this.instockCB.Location = new System.Drawing.Point(21, 274);
            this.instockCB.Name = "instockCB";
            this.instockCB.Size = new System.Drawing.Size(66, 17);
            this.instockCB.TabIndex = 7;
            this.instockCB.Text = "In Stock";
            this.instockCB.UseVisualStyleBackColor = true;
            // 
            // inventoryTab
            // 
            this.inventoryTab.Controls.Add(this.currentSaveFile);
            this.inventoryTab.Controls.Add(this.loadInvoiceButton);
            this.inventoryTab.Controls.Add(this.clearInventoryButton);
            this.inventoryTab.Controls.Add(this.inventoryGroupBox);
            this.inventoryTab.Controls.Add(this.newInvoiceButton);
            this.inventoryTab.Controls.Add(this.inventoryGridView);
            this.inventoryTab.Location = new System.Drawing.Point(4, 22);
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Size = new System.Drawing.Size(718, 475);
            this.inventoryTab.TabIndex = 2;
            this.inventoryTab.Text = "Inventory";
            this.inventoryTab.UseVisualStyleBackColor = true;
            // 
            // currentSaveFile
            // 
            this.currentSaveFile.AutoSize = true;
            this.currentSaveFile.Location = new System.Drawing.Point(8, 77);
            this.currentSaveFile.Name = "currentSaveFile";
            this.currentSaveFile.Size = new System.Drawing.Size(0, 13);
            this.currentSaveFile.TabIndex = 19;
            this.currentSaveFile.Visible = false;
            // 
            // loadInvoiceButton
            // 
            this.loadInvoiceButton.Location = new System.Drawing.Point(19, 52);
            this.loadInvoiceButton.Name = "loadInvoiceButton";
            this.loadInvoiceButton.Size = new System.Drawing.Size(86, 23);
            this.loadInvoiceButton.TabIndex = 18;
            this.loadInvoiceButton.Text = "Load Invoice";
            this.loadInvoiceButton.UseVisualStyleBackColor = true;
            this.loadInvoiceButton.Click += new System.EventHandler(this.loadInvoiceButton_Click);
            // 
            // clearInventoryButton
            // 
            this.clearInventoryButton.BackColor = System.Drawing.Color.Red;
            this.clearInventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearInventoryButton.Location = new System.Drawing.Point(8, 96);
            this.clearInventoryButton.Name = "clearInventoryButton";
            this.clearInventoryButton.Size = new System.Drawing.Size(58, 58);
            this.clearInventoryButton.TabIndex = 18;
            this.clearInventoryButton.Text = "Clear";
            this.clearInventoryButton.UseVisualStyleBackColor = false;
            this.clearInventoryButton.Visible = false;
            this.clearInventoryButton.Click += new System.EventHandler(this.clearInventoryButton_Click);
            // 
            // inventoryGroupBox
            // 
            this.inventoryGroupBox.Controls.Add(this.submitInvoiceButton);
            this.inventoryGroupBox.Controls.Add(this.changeInvoiceQuantityBtn);
            this.inventoryGroupBox.Controls.Add(this.addItemInvoiceBtn);
            this.inventoryGroupBox.Controls.Add(this.changeInvoiceTotalBtn);
            this.inventoryGroupBox.Controls.Add(this.label9);
            this.inventoryGroupBox.Controls.Add(this.invoiceDatePicker);
            this.inventoryGroupBox.Controls.Add(this.addInvoiceProduct);
            this.inventoryGroupBox.Controls.Add(this.invoiceQuantityTotal);
            this.inventoryGroupBox.Controls.Add(this.inventoryQuantityTotal);
            this.inventoryGroupBox.Controls.Add(this.saveDraftButton);
            this.inventoryGroupBox.Controls.Add(this.label7);
            this.inventoryGroupBox.Controls.Add(this.label8);
            this.inventoryGroupBox.Controls.Add(this.label4);
            this.inventoryGroupBox.Controls.Add(this.inventoryRunningTotal);
            this.inventoryGroupBox.Controls.Add(this.invoiceCostTotal);
            this.inventoryGroupBox.Controls.Add(this.label5);
            this.inventoryGroupBox.Controls.Add(this.label6);
            this.inventoryGroupBox.Location = new System.Drawing.Point(84, 11);
            this.inventoryGroupBox.Name = "inventoryGroupBox";
            this.inventoryGroupBox.Size = new System.Drawing.Size(626, 149);
            this.inventoryGroupBox.TabIndex = 15;
            this.inventoryGroupBox.TabStop = false;
            this.inventoryGroupBox.Text = "Inventory Fields";
            this.inventoryGroupBox.Visible = false;
            // 
            // submitInvoiceButton
            // 
            this.submitInvoiceButton.Location = new System.Drawing.Point(18, 20);
            this.submitInvoiceButton.Name = "submitInvoiceButton";
            this.submitInvoiceButton.Size = new System.Drawing.Size(75, 23);
            this.submitInvoiceButton.TabIndex = 17;
            this.submitInvoiceButton.Text = "Submit";
            this.submitInvoiceButton.UseVisualStyleBackColor = true;
            this.submitInvoiceButton.Click += new System.EventHandler(this.submitInvoiceButton_Click);
            // 
            // changeInvoiceQuantityBtn
            // 
            this.changeInvoiceQuantityBtn.Location = new System.Drawing.Point(513, 85);
            this.changeInvoiceQuantityBtn.Name = "changeInvoiceQuantityBtn";
            this.changeInvoiceQuantityBtn.Size = new System.Drawing.Size(107, 23);
            this.changeInvoiceQuantityBtn.TabIndex = 16;
            this.changeInvoiceQuantityBtn.Text = "Change Quantity";
            this.changeInvoiceQuantityBtn.UseVisualStyleBackColor = true;
            this.changeInvoiceQuantityBtn.Click += new System.EventHandler(this.changeInvoiceQuantityBtn_Click);
            // 
            // addItemInvoiceBtn
            // 
            this.addItemInvoiceBtn.Location = new System.Drawing.Point(315, 118);
            this.addItemInvoiceBtn.Name = "addItemInvoiceBtn";
            this.addItemInvoiceBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemInvoiceBtn.TabIndex = 14;
            this.addItemInvoiceBtn.Text = "Add";
            this.addItemInvoiceBtn.UseVisualStyleBackColor = true;
            this.addItemInvoiceBtn.Click += new System.EventHandler(this.addItemInvoiceBtn_Click);
            // 
            // changeInvoiceTotalBtn
            // 
            this.changeInvoiceTotalBtn.Location = new System.Drawing.Point(295, 85);
            this.changeInvoiceTotalBtn.Name = "changeInvoiceTotalBtn";
            this.changeInvoiceTotalBtn.Size = new System.Drawing.Size(95, 23);
            this.changeInvoiceTotalBtn.TabIndex = 15;
            this.changeInvoiceTotalBtn.Text = "Change Total";
            this.changeInvoiceTotalBtn.UseVisualStyleBackColor = true;
            this.changeInvoiceTotalBtn.Click += new System.EventHandler(this.changeInvoiceTotalBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Product";
            // 
            // invoiceDatePicker
            // 
            this.invoiceDatePicker.CustomFormat = "dd - MMM - yyyy";
            this.invoiceDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.invoiceDatePicker.Location = new System.Drawing.Point(77, 60);
            this.invoiceDatePicker.Name = "invoiceDatePicker";
            this.invoiceDatePicker.Size = new System.Drawing.Size(124, 20);
            this.invoiceDatePicker.TabIndex = 0;
            this.invoiceDatePicker.Value = new System.DateTime(2017, 2, 4, 10, 43, 13, 591);
            // 
            // addInvoiceProduct
            // 
            this.addInvoiceProduct.Location = new System.Drawing.Point(65, 120);
            this.addInvoiceProduct.Name = "addInvoiceProduct";
            this.addInvoiceProduct.Size = new System.Drawing.Size(224, 20);
            this.addInvoiceProduct.TabIndex = 11;
            this.addInvoiceProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addInvoiceProduct_KeyDown);
            // 
            // invoiceQuantityTotal
            // 
            this.invoiceQuantityTotal.Location = new System.Drawing.Point(513, 60);
            this.invoiceQuantityTotal.Name = "invoiceQuantityTotal";
            this.invoiceQuantityTotal.ReadOnly = true;
            this.invoiceQuantityTotal.Size = new System.Drawing.Size(107, 20);
            this.invoiceQuantityTotal.TabIndex = 2;
            // 
            // inventoryQuantityTotal
            // 
            this.inventoryQuantityTotal.Location = new System.Drawing.Point(513, 18);
            this.inventoryQuantityTotal.Name = "inventoryQuantityTotal";
            this.inventoryQuantityTotal.ReadOnly = true;
            this.inventoryQuantityTotal.Size = new System.Drawing.Size(107, 20);
            this.inventoryQuantityTotal.TabIndex = 1;
            // 
            // saveDraftButton
            // 
            this.saveDraftButton.Location = new System.Drawing.Point(99, 20);
            this.saveDraftButton.Name = "saveDraftButton";
            this.saveDraftButton.Size = new System.Drawing.Size(75, 23);
            this.saveDraftButton.TabIndex = 13;
            this.saveDraftButton.Text = "Save Draft";
            this.saveDraftButton.UseVisualStyleBackColor = true;
            this.saveDraftButton.Click += new System.EventHandler(this.saveDraftButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Current Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Invoice Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Invoice Date";
            // 
            // inventoryRunningTotal
            // 
            this.inventoryRunningTotal.Location = new System.Drawing.Point(295, 18);
            this.inventoryRunningTotal.Name = "inventoryRunningTotal";
            this.inventoryRunningTotal.ReadOnly = true;
            this.inventoryRunningTotal.Size = new System.Drawing.Size(92, 20);
            this.inventoryRunningTotal.TabIndex = 3;
            // 
            // invoiceCostTotal
            // 
            this.invoiceCostTotal.Location = new System.Drawing.Point(295, 59);
            this.invoiceCostTotal.Name = "invoiceCostTotal";
            this.invoiceCostTotal.ReadOnly = true;
            this.invoiceCostTotal.Size = new System.Drawing.Size(92, 20);
            this.invoiceCostTotal.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Current Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Invoice Total";
            // 
            // newInvoiceButton
            // 
            this.newInvoiceButton.Location = new System.Drawing.Point(19, 23);
            this.newInvoiceButton.Name = "newInvoiceButton";
            this.newInvoiceButton.Size = new System.Drawing.Size(86, 23);
            this.newInvoiceButton.TabIndex = 14;
            this.newInvoiceButton.Text = "New Invoice";
            this.newInvoiceButton.UseVisualStyleBackColor = true;
            this.newInvoiceButton.Click += new System.EventHandler(this.newInvoiceButton_Click);
            // 
            // inventoryGridView
            // 
            this.inventoryGridView.AllowUserToAddRows = false;
            this.inventoryGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceProductCode,
            this.invoiceProductCategory,
            this.invoiceProductStyle,
            this.invoiceProductSize,
            this.invoiceQuantityToAdd,
            this.inventoryProductCost});
            this.inventoryGridView.ContextMenuStrip = this.inventoryContextStrip;
            this.inventoryGridView.Location = new System.Drawing.Point(8, 166);
            this.inventoryGridView.Name = "inventoryGridView";
            this.inventoryGridView.Size = new System.Drawing.Size(702, 301);
            this.inventoryGridView.TabIndex = 5;
            // 
            // invoiceProductCode
            // 
            this.invoiceProductCode.HeaderText = "Product Code";
            this.invoiceProductCode.Name = "invoiceProductCode";
            this.invoiceProductCode.ReadOnly = true;
            // 
            // invoiceProductCategory
            // 
            this.invoiceProductCategory.HeaderText = "Category";
            this.invoiceProductCategory.Name = "invoiceProductCategory";
            this.invoiceProductCategory.ReadOnly = true;
            // 
            // invoiceProductStyle
            // 
            this.invoiceProductStyle.HeaderText = "Style";
            this.invoiceProductStyle.Name = "invoiceProductStyle";
            this.invoiceProductStyle.ReadOnly = true;
            // 
            // invoiceProductSize
            // 
            this.invoiceProductSize.HeaderText = "Size";
            this.invoiceProductSize.Name = "invoiceProductSize";
            this.invoiceProductSize.ReadOnly = true;
            // 
            // invoiceQuantityToAdd
            // 
            this.invoiceQuantityToAdd.HeaderText = "Quantity";
            this.invoiceQuantityToAdd.Name = "invoiceQuantityToAdd";
            this.invoiceQuantityToAdd.ReadOnly = true;
            // 
            // inventoryProductCost
            // 
            this.inventoryProductCost.HeaderText = "Cost";
            this.inventoryProductCost.Name = "inventoryProductCost";
            this.inventoryProductCost.ReadOnly = true;
            // 
            // inventoryContextStrip
            // 
            this.inventoryContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeLineToolStripMenuItem,
            this.removeItemToolStripMenuItem2,
            this.addQuantityToolStripMenuItem});
            this.inventoryContextStrip.Name = "inventoryContextStrip";
            this.inventoryContextStrip.Size = new System.Drawing.Size(145, 70);
            // 
            // removeLineToolStripMenuItem
            // 
            this.removeLineToolStripMenuItem.Name = "removeLineToolStripMenuItem";
            this.removeLineToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.removeLineToolStripMenuItem.Text = "Remove Line";
            this.removeLineToolStripMenuItem.Click += new System.EventHandler(this.removeLineToolStripMenuItem_Click);
            // 
            // removeItemToolStripMenuItem2
            // 
            this.removeItemToolStripMenuItem2.Name = "removeItemToolStripMenuItem2";
            this.removeItemToolStripMenuItem2.Size = new System.Drawing.Size(144, 22);
            this.removeItemToolStripMenuItem2.Text = "Remove Item";
            this.removeItemToolStripMenuItem2.Click += new System.EventHandler(this.removeItemToolStripMenuItem2_Click);
            // 
            // addQuantityToolStripMenuItem
            // 
            this.addQuantityToolStripMenuItem.Name = "addQuantityToolStripMenuItem";
            this.addQuantityToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addQuantityToolStripMenuItem.Text = "Add quantity";
            this.addQuantityToolStripMenuItem.Click += new System.EventHandler(this.addQuantityToolStripMenuItem_Click);
            // 
            // reportTab
            // 
            this.reportTab.Controls.Add(this.reports);
            this.reportTab.Location = new System.Drawing.Point(4, 22);
            this.reportTab.Name = "reportTab";
            this.reportTab.Size = new System.Drawing.Size(718, 475);
            this.reportTab.TabIndex = 3;
            this.reportTab.Text = "Reports";
            this.reportTab.UseVisualStyleBackColor = true;
            // 
            // managementTab
            // 
            this.managementTab.Location = new System.Drawing.Point(4, 22);
            this.managementTab.Name = "managementTab";
            this.managementTab.Size = new System.Drawing.Size(718, 475);
            this.managementTab.TabIndex = 4;
            this.managementTab.Text = "Management";
            this.managementTab.UseVisualStyleBackColor = true;
            // 
            // gshs_posDataSet
            // 
            this.gshs_posDataSet.DataSetName = "gshs_posDataSet";
            this.gshs_posDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.gshs_posDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // reports
            // 
            this.reports.Dock = System.Windows.Forms.DockStyle.Left;
            this.reports.Location = new System.Drawing.Point(0, 0);
            this.reports.Name = "reports";
            treeNode13.Name = "Node3";
            treeNode13.Text = "Node3";
            treeNode14.Name = "Node4";
            treeNode14.Text = "Node4";
            treeNode15.Name = "Node5";
            treeNode15.Text = "Node5";
            treeNode16.Name = "Node0";
            treeNode16.Text = "Node0";
            treeNode17.Name = "Node6";
            treeNode17.Text = "Node6";
            treeNode18.Name = "Node7";
            treeNode18.Text = "Node7";
            treeNode19.Name = "Node8";
            treeNode19.Text = "Node8";
            treeNode20.Name = "Node1";
            treeNode20.Text = "Node1";
            treeNode21.Name = "Node9";
            treeNode21.Text = "Node9";
            treeNode22.Name = "Node10";
            treeNode22.Text = "Node10";
            treeNode23.Name = "Node11";
            treeNode23.Text = "Node11";
            treeNode24.Name = "Node2";
            treeNode24.Text = "Node2";
            this.reports.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode20,
            treeNode24});
            this.reports.Size = new System.Drawing.Size(121, 475);
            this.reports.TabIndex = 0;
            // 
            // GSHSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(726, 501);
            this.Controls.Add(this.GSHS_Control);
            this.MinimumSize = new System.Drawing.Size(50, 50);
            this.Name = "GSHSForm";
            this.Text = "GSHS Sale System";
            this.GSHS_Control.ResumeLayout(false);
            this.saleTab.ResumeLayout(false);
            this.saleTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).EndInit();
            this.datagridviewContext.ResumeLayout(false);
            this.searchTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGridView)).EndInit();
            this.searchTermsBox.ResumeLayout(false);
            this.searchTermsBox.PerformLayout();
            this.inventoryTab.ResumeLayout(false);
            this.inventoryTab.PerformLayout();
            this.inventoryGroupBox.ResumeLayout(false);
            this.inventoryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGridView)).EndInit();
            this.inventoryContextStrip.ResumeLayout(false);
            this.reportTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gshs_posDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl GSHS_Control;
        private System.Windows.Forms.TabPage saleTab;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.TabPage inventoryTab;
        private System.Windows.Forms.TabPage reportTab;
        private System.Windows.Forms.TabPage managementTab;
        private System.Windows.Forms.DataGridView salesDataGrid;
        private System.Windows.Forms.RadioButton genderMaleRadioButton;
        private System.Windows.Forms.RadioButton genderFemaleRB;
        private System.Windows.Forms.ComboBox styleSearchBox;
        private System.Windows.Forms.ComboBox categoriesSearchBox;
        private gshs_posDataSet gshs_posDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private gshs_posDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.TextBox runningTotal;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox productCodeSearchBox;
        private System.Windows.Forms.CheckBox instockCB;
        private System.Windows.Forms.RadioButton genderNeutralRB;
        private System.Windows.Forms.ComboBox sizeSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCost;
        private System.Windows.Forms.ContextMenuStrip datagridviewContext;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.TextBox addItemTextBox;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.CheckBox secondHandCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label productCodeSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox searchTermsBox;
        private System.Windows.Forms.DataGridView searchResultGridView;
        private System.Windows.Forms.Button newSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn inStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondHand;
        private System.Windows.Forms.RadioButton genderAnyRB;
        private System.Windows.Forms.DateTimePicker invoiceDatePicker;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem1;
        private System.Windows.Forms.TextBox invoiceCostTotal;
        private System.Windows.Forms.TextBox inventoryRunningTotal;
        private System.Windows.Forms.TextBox invoiceQuantityTotal;
        private System.Windows.Forms.TextBox inventoryQuantityTotal;
        private System.Windows.Forms.DataGridView inventoryGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addInvoiceProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip inventoryContextStrip;
        private System.Windows.Forms.ToolStripMenuItem removeLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addQuantityToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceProductStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceProductSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceQuantityToAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryProductCost;
        private System.Windows.Forms.GroupBox inventoryGroupBox;
        private System.Windows.Forms.Button saveDraftButton;
        private System.Windows.Forms.Button newInvoiceButton;
        private System.Windows.Forms.Button changeInvoiceQuantityBtn;
        private System.Windows.Forms.Button changeInvoiceTotalBtn;
        private System.Windows.Forms.Button addItemInvoiceBtn;
        private System.Windows.Forms.Button submitInvoiceButton;
        private System.Windows.Forms.Button clearInventoryButton;
        private System.Windows.Forms.Button loadInvoiceButton;
        private System.Windows.Forms.Label currentSaveFile;
        private System.Windows.Forms.TreeView reports;
    }
}

