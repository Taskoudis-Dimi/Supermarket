﻿namespace SupermarketTuto.Forms
{
    partial class Product
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.ProdDGV = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.catComboBox = new System.Windows.Forms.ComboBox();
            this.importButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.ApiRadioButton = new System.Windows.Forms.RadioButton();
            this.localRadioButton = new System.Windows.Forms.RadioButton();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.putButton = new System.Windows.Forms.Button();
            this.DeleteApiButton = new System.Windows.Forms.Button();
            this.PostButton = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalLabel.Location = new System.Drawing.Point(8, 940);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(74, 29);
            this.totalLabel.TabIndex = 106;
            this.totalLabel.Text = "Total:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchButton.Location = new System.Drawing.Point(296, 98);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(138, 40);
            this.searchButton.TabIndex = 105;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchTextBox.Location = new System.Drawing.Point(14, 98);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(254, 35);
            this.searchTextBox.TabIndex = 104;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // ProdDGV
            // 
            this.ProdDGV.AllowUserToAddRows = false;
            this.ProdDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV.Location = new System.Drawing.Point(14, 157);
            this.ProdDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersWidth = 62;
            this.ProdDGV.RowTemplate.Height = 30;
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(1352, 752);
            this.ProdDGV.TabIndex = 103;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.refreshButton.Location = new System.Drawing.Point(1192, 88);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(172, 57);
            this.refreshButton.TabIndex = 102;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteButton.Location = new System.Drawing.Point(932, 926);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 52);
            this.deleteButton.TabIndex = 97;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editButton.Location = new System.Drawing.Point(830, 925);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(93, 52);
            this.editButton.TabIndex = 96;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addButton.Location = new System.Drawing.Point(728, 923);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 52);
            this.addButton.TabIndex = 95;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // catComboBox
            // 
            this.catComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.catComboBox.FormattingEnabled = true;
            this.catComboBox.Location = new System.Drawing.Point(524, 95);
            this.catComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.catComboBox.Name = "catComboBox";
            this.catComboBox.Size = new System.Drawing.Size(212, 37);
            this.catComboBox.TabIndex = 107;
            this.catComboBox.Text = "Select Category";
            this.catComboBox.SelectionChangeCommitted += new System.EventHandler(this.catComboBox_SelectionChangeCommitted);
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.importButton.Location = new System.Drawing.Point(1150, 923);
            this.importButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(102, 55);
            this.importButton.TabIndex = 109;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.saveButton.Location = new System.Drawing.Point(1262, 926);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 52);
            this.saveButton.TabIndex = 110;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.exportButton.Location = new System.Drawing.Point(1040, 925);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(102, 54);
            this.exportButton.TabIndex = 111;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // ApiRadioButton
            // 
            this.ApiRadioButton.AutoSize = true;
            this.ApiRadioButton.Location = new System.Drawing.Point(1968, 186);
            this.ApiRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ApiRadioButton.Name = "ApiRadioButton";
            this.ApiRadioButton.Size = new System.Drawing.Size(60, 24);
            this.ApiRadioButton.TabIndex = 116;
            this.ApiRadioButton.TabStop = true;
            this.ApiRadioButton.Text = "API";
            this.ApiRadioButton.UseVisualStyleBackColor = true;
            this.ApiRadioButton.Click += new System.EventHandler(this.ApiRadioButton_Click);
            // 
            // localRadioButton
            // 
            this.localRadioButton.AutoSize = true;
            this.localRadioButton.Location = new System.Drawing.Point(1968, 149);
            this.localRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.localRadioButton.Name = "localRadioButton";
            this.localRadioButton.Size = new System.Drawing.Size(72, 24);
            this.localRadioButton.TabIndex = 117;
            this.localRadioButton.TabStop = true;
            this.localRadioButton.Text = "Local";
            this.localRadioButton.UseVisualStyleBackColor = true;
            this.localRadioButton.Click += new System.EventHandler(this.localRadioButton_Click);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(987, 92);
            this.toDateTimePicker.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(175, 35);
            this.toDateTimePicker.TabIndex = 120;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.toDateTimePicker_ValueChanged);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(782, 92);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(188, 35);
            this.fromDateTimePicker.TabIndex = 119;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged);
            // 
            // putButton
            // 
            this.putButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.putButton.Location = new System.Drawing.Point(1720, 512);
            this.putButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.putButton.Name = "putButton";
            this.putButton.Size = new System.Drawing.Size(102, 45);
            this.putButton.TabIndex = 126;
            this.putButton.Text = "Put";
            this.putButton.UseVisualStyleBackColor = true;
            // 
            // DeleteApiButton
            // 
            this.DeleteApiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DeleteApiButton.Location = new System.Drawing.Point(1481, 509);
            this.DeleteApiButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteApiButton.Name = "DeleteApiButton";
            this.DeleteApiButton.Size = new System.Drawing.Size(102, 45);
            this.DeleteApiButton.TabIndex = 125;
            this.DeleteApiButton.Text = "Delete";
            this.DeleteApiButton.UseVisualStyleBackColor = true;
            // 
            // PostButton
            // 
            this.PostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PostButton.Location = new System.Drawing.Point(1245, 511);
            this.PostButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(100, 46);
            this.PostButton.TabIndex = 124;
            this.PostButton.Text = "Post";
            this.PostButton.UseVisualStyleBackColor = true;
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.GetButton.Location = new System.Drawing.Point(1040, 509);
            this.GetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(96, 48);
            this.GetButton.TabIndex = 123;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1066);
            this.ControlBox = false;
            this.Controls.Add(this.putButton);
            this.Controls.Add(this.DeleteApiButton);
            this.Controls.Add(this.PostButton);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.localRadioButton);
            this.Controls.Add(this.ApiRadioButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.catComboBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.ProdDGV);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Name = "Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label totalLabel;
        private Button searchButton;
        private TextBox searchTextBox;
        private DataGridView ProdDGV;
        private Button refreshButton;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private ComboBox catComboBox;
        private Button importButton;
        private Button saveButton;
        private Button exportButton;
        private RadioButton ApiRadioButton;
        private RadioButton localRadioButton;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private Button putButton;
        private Button DeleteApiButton;
        private Button PostButton;
        private Button GetButton;
    }
}