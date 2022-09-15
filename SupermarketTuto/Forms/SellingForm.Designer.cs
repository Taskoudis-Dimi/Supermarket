﻿namespace SupermarketTuto
{
    partial class SellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.DateLabel = new System.Windows.Forms.Label();
            this.SellingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SellingQuantityTextBox = new System.Windows.Forms.TextBox();
            this.SellingPriceTextBox = new System.Windows.Forms.TextBox();
            this.SellingProdName = new System.Windows.Forms.TextBox();
            this.BillId = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SearchCb = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SellingDGV = new System.Windows.Forms.DataGridView();
            this.BillsDGV = new System.Windows.Forms.DataGridView();
            this.SellingPanel = new System.Windows.Forms.Panel();
            this.Products = new System.Windows.Forms.Label();
            this.Bills = new System.Windows.Forms.Label();
            this.commentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.refreshOrderButton = new System.Windows.Forms.Button();
            this.refreshBillsButton = new System.Windows.Forms.Button();
            this.Categories = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.total3Label = new System.Windows.Forms.Label();
            this.total2Label = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.OrderDGV = new System.Windows.Forms.DataGridView();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AddProductbutton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.seller_Name_Label = new System.Windows.Forms.Label();
            this.commentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SellingDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            this.SellingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DateLabel.Location = new System.Drawing.Point(333, 72);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(67, 32);
            this.DateLabel.TabIndex = 14;
            this.DateLabel.Text = "Date";
            // 
            // SellingLabel
            // 
            this.SellingLabel.AutoSize = true;
            this.SellingLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.SellingLabel.Location = new System.Drawing.Point(1266, 52);
            this.SellingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SellingLabel.Name = "SellingLabel";
            this.SellingLabel.Size = new System.Drawing.Size(133, 48);
            this.SellingLabel.TabIndex = 15;
            this.SellingLabel.Text = "Selling";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1359, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bill Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1359, 435);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "ProdName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1359, 535);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1359, 634);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantity";
            // 
            // SellingQuantityTextBox
            // 
            this.SellingQuantityTextBox.Location = new System.Drawing.Point(1580, 652);
            this.SellingQuantityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellingQuantityTextBox.Name = "SellingQuantityTextBox";
            this.SellingQuantityTextBox.Size = new System.Drawing.Size(127, 26);
            this.SellingQuantityTextBox.TabIndex = 24;
            // 
            // SellingPriceTextBox
            // 
            this.SellingPriceTextBox.Enabled = false;
            this.SellingPriceTextBox.Location = new System.Drawing.Point(1580, 548);
            this.SellingPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellingPriceTextBox.Name = "SellingPriceTextBox";
            this.SellingPriceTextBox.Size = new System.Drawing.Size(127, 26);
            this.SellingPriceTextBox.TabIndex = 23;
            // 
            // SellingProdName
            // 
            this.SellingProdName.BackColor = System.Drawing.Color.White;
            this.SellingProdName.Enabled = false;
            this.SellingProdName.Location = new System.Drawing.Point(1580, 455);
            this.SellingProdName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellingProdName.Name = "SellingProdName";
            this.SellingProdName.Size = new System.Drawing.Size(127, 26);
            this.SellingProdName.TabIndex = 22;
            // 
            // BillId
            // 
            this.BillId.Location = new System.Drawing.Point(1580, 360);
            this.BillId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BillId.Name = "BillId";
            this.BillId.Size = new System.Drawing.Size(127, 26);
            this.BillId.TabIndex = 21;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1380, 1406);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 35);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(1250, 1406);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(96, 35);
            this.PrintButton.TabIndex = 27;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1120, 1406);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 35);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // SearchCb
            // 
            this.SearchCb.FormattingEnabled = true;
            this.SearchCb.Location = new System.Drawing.Point(576, 300);
            this.SearchCb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchCb.Name = "SearchCb";
            this.SearchCb.Size = new System.Drawing.Size(136, 28);
            this.SearchCb.TabIndex = 29;
            this.SearchCb.Text = "Select Category";
            this.SearchCb.SelectionChangeCommitted += new System.EventHandler(this.SearchCb_SelectionChangeCommitted);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(886, 300);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(96, 31);
            this.refreshButton.TabIndex = 30;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // SellingDGV
            // 
            this.SellingDGV.AllowUserToAddRows = false;
            this.SellingDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.SellingDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellingDGV.Location = new System.Drawing.Point(362, 357);
            this.SellingDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellingDGV.Name = "SellingDGV";
            this.SellingDGV.RowHeadersWidth = 62;
            this.SellingDGV.RowTemplate.Height = 30;
            this.SellingDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellingDGV.Size = new System.Drawing.Size(621, 294);
            this.SellingDGV.TabIndex = 31;
            this.SellingDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellingDGV_CellClick);
            // 
            // BillsDGV
            // 
            this.BillsDGV.AllowUserToAddRows = false;
            this.BillsDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.BillsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsDGV.Location = new System.Drawing.Point(1120, 1086);
            this.BillsDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.RowHeadersWidth = 62;
            this.BillsDGV.RowTemplate.Height = 30;
            this.BillsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillsDGV.Size = new System.Drawing.Size(626, 277);
            this.BillsDGV.TabIndex = 32;
            this.BillsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDGV_CellClick);
            // 
            // SellingPanel
            // 
            this.SellingPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SellingPanel.Controls.Add(this.commentsLabel);
            this.SellingPanel.Controls.Add(this.Products);
            this.SellingPanel.Controls.Add(this.Bills);
            this.SellingPanel.Controls.Add(this.commentsRichTextBox);
            this.SellingPanel.Controls.Add(this.refreshOrderButton);
            this.SellingPanel.Controls.Add(this.refreshBillsButton);
            this.SellingPanel.Controls.Add(this.Categories);
            this.SellingPanel.Controls.Add(this.sumLabel);
            this.SellingPanel.Controls.Add(this.total3Label);
            this.SellingPanel.Controls.Add(this.total2Label);
            this.SellingPanel.Controls.Add(this.totalLabel);
            this.SellingPanel.Controls.Add(this.OrderDGV);
            this.SellingPanel.Controls.Add(this.AmountLabel);
            this.SellingPanel.Controls.Add(this.AddProductbutton);
            this.SellingPanel.Controls.Add(this.SellingLabel);
            this.SellingPanel.Controls.Add(this.DateLabel);
            this.SellingPanel.Controls.Add(this.BillsDGV);
            this.SellingPanel.Controls.Add(this.SellingProdName);
            this.SellingPanel.Controls.Add(this.deleteButton);
            this.SellingPanel.Controls.Add(this.SellingDGV);
            this.SellingPanel.Controls.Add(this.PrintButton);
            this.SellingPanel.Controls.Add(this.addButton);
            this.SellingPanel.Controls.Add(this.label1);
            this.SellingPanel.Controls.Add(this.refreshButton);
            this.SellingPanel.Controls.Add(this.SearchCb);
            this.SellingPanel.Controls.Add(this.label2);
            this.SellingPanel.Controls.Add(this.label3);
            this.SellingPanel.Controls.Add(this.label4);
            this.SellingPanel.Controls.Add(this.BillId);
            this.SellingPanel.Controls.Add(this.SellingPriceTextBox);
            this.SellingPanel.Controls.Add(this.SellingQuantityTextBox);
            this.SellingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SellingPanel.Location = new System.Drawing.Point(0, 0);
            this.SellingPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellingPanel.Name = "SellingPanel";
            this.SellingPanel.Size = new System.Drawing.Size(3054, 1585);
            this.SellingPanel.TabIndex = 33;
            this.SellingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SellingPanel_Paint);
            // 
            // Products
            // 
            this.Products.AutoSize = true;
            this.Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Products.Location = new System.Drawing.Point(2208, 235);
            this.Products.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(108, 29);
            this.Products.TabIndex = 53;
            this.Products.Text = "Products";
            // 
            // Bills
            // 
            this.Bills.AutoSize = true;
            this.Bills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Bills.Location = new System.Drawing.Point(1113, 1009);
            this.Bills.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bills.Name = "Bills";
            this.Bills.Size = new System.Drawing.Size(59, 29);
            this.Bills.TabIndex = 52;
            this.Bills.Text = "Bills";
            // 
            // commentsRichTextBox
            // 
            this.commentsRichTextBox.Location = new System.Drawing.Point(362, 1086);
            this.commentsRichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.commentsRichTextBox.Name = "commentsRichTextBox";
            this.commentsRichTextBox.Size = new System.Drawing.Size(385, 275);
            this.commentsRichTextBox.TabIndex = 51;
            this.commentsRichTextBox.Text = "";
            // 
            // refreshOrderButton
            // 
            this.refreshOrderButton.Location = new System.Drawing.Point(2858, 249);
            this.refreshOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshOrderButton.Name = "refreshOrderButton";
            this.refreshOrderButton.Size = new System.Drawing.Size(96, 31);
            this.refreshOrderButton.TabIndex = 50;
            this.refreshOrderButton.Text = "Refresh";
            this.refreshOrderButton.UseVisualStyleBackColor = true;
            this.refreshOrderButton.Click += new System.EventHandler(this.refreshOrderButton_Click);
            // 
            // refreshBillsButton
            // 
            this.refreshBillsButton.Location = new System.Drawing.Point(1650, 1023);
            this.refreshBillsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshBillsButton.Name = "refreshBillsButton";
            this.refreshBillsButton.Size = new System.Drawing.Size(96, 31);
            this.refreshBillsButton.TabIndex = 49;
            this.refreshBillsButton.Text = "Refresh";
            this.refreshBillsButton.UseVisualStyleBackColor = true;
            this.refreshBillsButton.Click += new System.EventHandler(this.refreshBillsButton_Click);
            // 
            // Categories
            // 
            this.Categories.AutoSize = true;
            this.Categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Categories.Location = new System.Drawing.Point(370, 289);
            this.Categories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(131, 29);
            this.Categories.TabIndex = 48;
            this.Categories.Text = "Categories";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sumLabel.Location = new System.Drawing.Point(2800, 752);
            this.sumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(62, 29);
            this.sumLabel.TabIndex = 47;
            this.sumLabel.Text = "Sum";
            // 
            // total3Label
            // 
            this.total3Label.AutoSize = true;
            this.total3Label.Location = new System.Drawing.Point(1646, 1406);
            this.total3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total3Label.Name = "total3Label";
            this.total3Label.Size = new System.Drawing.Size(48, 20);
            this.total3Label.TabIndex = 46;
            this.total3Label.Text = "Total:";
            // 
            // total2Label
            // 
            this.total2Label.AutoSize = true;
            this.total2Label.Location = new System.Drawing.Point(2214, 768);
            this.total2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total2Label.Name = "total2Label";
            this.total2Label.Size = new System.Drawing.Size(48, 20);
            this.total2Label.TabIndex = 45;
            this.total2Label.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(357, 680);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 44;
            this.totalLabel.Text = "Total:";
            // 
            // OrderDGV
            // 
            this.OrderDGV.AllowUserToAddRows = false;
            this.OrderDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.OrderDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDGV.Location = new System.Drawing.Point(2216, 314);
            this.OrderDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.RowHeadersWidth = 62;
            this.OrderDGV.RowTemplate.Height = 30;
            this.OrderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDGV.Size = new System.Drawing.Size(738, 386);
            this.OrderDGV.TabIndex = 37;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AmountLabel.Location = new System.Drawing.Point(2508, 745);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(170, 32);
            this.AmountLabel.TabIndex = 35;
            this.AmountLabel.Text = "Total Amount";
            // 
            // AddProductbutton
            // 
            this.AddProductbutton.Location = new System.Drawing.Point(1875, 497);
            this.AddProductbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddProductbutton.Name = "AddProductbutton";
            this.AddProductbutton.Size = new System.Drawing.Size(156, 31);
            this.AddProductbutton.TabIndex = 34;
            this.AddProductbutton.Text = "Add Product";
            this.AddProductbutton.UseVisualStyleBackColor = true;
            this.AddProductbutton.Click += new System.EventHandler(this.AddProductbutton_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sidePanel.Controls.Add(this.seller_Name_Label);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(270, 1585);
            this.sidePanel.TabIndex = 34;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidePanel_Paint);
            // 
            // seller_Name_Label
            // 
            this.seller_Name_Label.AutoSize = true;
            this.seller_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.seller_Name_Label.Location = new System.Drawing.Point(4, 142);
            this.seller_Name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seller_Name_Label.Name = "seller_Name_Label";
            this.seller_Name_Label.Size = new System.Drawing.Size(170, 32);
            this.seller_Name_Label.TabIndex = 0;
            this.seller_Name_Label.Text = "Seller Name";
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.commentsLabel.Location = new System.Drawing.Point(357, 1025);
            this.commentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(129, 29);
            this.commentsLabel.TabIndex = 54;
            this.commentsLabel.Text = "Comments";
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(3054, 1585);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.SellingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selling Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SellingForm_FormClosing);
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellingDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            this.SellingPanel.ResumeLayout(false);
            this.SellingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label DateLabel;
        private Label SellingLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox SellingQuantityTextBox;
        private TextBox SellingPriceTextBox;
        private TextBox SellingProdName;
        private TextBox BillId;
        private Button deleteButton;
        private Button PrintButton;
        private Button addButton;
        private ComboBox SearchCb;
        private Button refreshButton;
        private DataGridView SellingDGV;
        private DataGridView BillsDGV;
        private Panel SellingPanel;
        private Button AddProductbutton;
        private Label AmountLabel;
        private DataGridView OrderDGV;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label total3Label;
        private Label total2Label;
        private Label totalLabel;
        private Panel sidePanel;
        private Label seller_Name_Label;
        private Label sumLabel;
        private Label Categories;
        private Button refreshOrderButton;
        private Button refreshBillsButton;
        private RichTextBox commentsRichTextBox;
        private Label Bills;
        private Label Products;
        private Label commentsLabel;
    }
}