﻿namespace SupermarketTuto
{
    partial class CategoryForm
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
            this.manageCategoriesPanel = new System.Windows.Forms.Panel();
            this.manageCategoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.delete3Button = new System.Windows.Forms.Button();
            this.edit3Button = new System.Windows.Forms.Button();
            this.add3Button = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.name3Label = new System.Windows.Forms.Label();
            this.id3label = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.name3TextBox = new System.Windows.Forms.TextBox();
            this.id3TextBox = new System.Windows.Forms.TextBox();
            this.manageCategoriesLabel = new System.Windows.Forms.Label();
            this.manageCategoriesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageCategoriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // manageCategoriesPanel
            // 
            this.manageCategoriesPanel.BackColor = System.Drawing.Color.Silver;
            this.manageCategoriesPanel.Controls.Add(this.manageCategoriesDataGridView);
            this.manageCategoriesPanel.Controls.Add(this.delete3Button);
            this.manageCategoriesPanel.Controls.Add(this.edit3Button);
            this.manageCategoriesPanel.Controls.Add(this.add3Button);
            this.manageCategoriesPanel.Controls.Add(this.descriptionLabel);
            this.manageCategoriesPanel.Controls.Add(this.name3Label);
            this.manageCategoriesPanel.Controls.Add(this.id3label);
            this.manageCategoriesPanel.Controls.Add(this.descriptionTextBox);
            this.manageCategoriesPanel.Controls.Add(this.name3TextBox);
            this.manageCategoriesPanel.Controls.Add(this.id3TextBox);
            this.manageCategoriesPanel.Controls.Add(this.manageCategoriesLabel);
            this.manageCategoriesPanel.Location = new System.Drawing.Point(48, 49);
            this.manageCategoriesPanel.Name = "manageCategoriesPanel";
            this.manageCategoriesPanel.Size = new System.Drawing.Size(659, 500);
            this.manageCategoriesPanel.TabIndex = 1;
            // 
            // manageCategoriesDataGridView
            // 
            this.manageCategoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manageCategoriesDataGridView.Location = new System.Drawing.Point(343, 92);
            this.manageCategoriesDataGridView.Name = "manageCategoriesDataGridView";
            this.manageCategoriesDataGridView.RowTemplate.Height = 25;
            this.manageCategoriesDataGridView.Size = new System.Drawing.Size(313, 405);
            this.manageCategoriesDataGridView.TabIndex = 15;
            // 
            // delete3Button
            // 
            this.delete3Button.Location = new System.Drawing.Point(244, 296);
            this.delete3Button.Name = "delete3Button";
            this.delete3Button.Size = new System.Drawing.Size(75, 23);
            this.delete3Button.TabIndex = 12;
            this.delete3Button.Text = "Delete";
            this.delete3Button.UseVisualStyleBackColor = true;
            // 
            // edit3Button
            // 
            this.edit3Button.Location = new System.Drawing.Point(141, 296);
            this.edit3Button.Name = "edit3Button";
            this.edit3Button.Size = new System.Drawing.Size(75, 23);
            this.edit3Button.TabIndex = 11;
            this.edit3Button.Text = "Edit";
            this.edit3Button.UseVisualStyleBackColor = true;
            // 
            // add3Button
            // 
            this.add3Button.Location = new System.Drawing.Point(43, 296);
            this.add3Button.Name = "add3Button";
            this.add3Button.Size = new System.Drawing.Size(75, 23);
            this.add3Button.TabIndex = 10;
            this.add3Button.Text = "Add";
            this.add3Button.UseVisualStyleBackColor = true;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(30, 188);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Description";
            // 
            // name3Label
            // 
            this.name3Label.AutoSize = true;
            this.name3Label.Location = new System.Drawing.Point(30, 141);
            this.name3Label.Name = "name3Label";
            this.name3Label.Size = new System.Drawing.Size(39, 15);
            this.name3Label.TabIndex = 7;
            this.name3Label.Text = "Name";
            // 
            // id3label
            // 
            this.id3label.AutoSize = true;
            this.id3label.Location = new System.Drawing.Point(30, 97);
            this.id3label.Name = "id3label";
            this.id3label.Size = new System.Drawing.Size(18, 15);
            this.id3label.TabIndex = 6;
            this.id3label.Text = "ID";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(191, 180);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 23);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // name3TextBox
            // 
            this.name3TextBox.Location = new System.Drawing.Point(191, 141);
            this.name3TextBox.Name = "name3TextBox";
            this.name3TextBox.Size = new System.Drawing.Size(100, 23);
            this.name3TextBox.TabIndex = 3;
            // 
            // id3TextBox
            // 
            this.id3TextBox.Location = new System.Drawing.Point(191, 98);
            this.id3TextBox.Name = "id3TextBox";
            this.id3TextBox.Size = new System.Drawing.Size(100, 23);
            this.id3TextBox.TabIndex = 2;
            // 
            // manageCategoriesLabel
            // 
            this.manageCategoriesLabel.AutoSize = true;
            this.manageCategoriesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageCategoriesLabel.Location = new System.Drawing.Point(244, 9);
            this.manageCategoriesLabel.Name = "manageCategoriesLabel";
            this.manageCategoriesLabel.Size = new System.Drawing.Size(234, 32);
            this.manageCategoriesLabel.TabIndex = 1;
            this.manageCategoriesLabel.Text = "Manage Categories";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 599);
            this.Controls.Add(this.manageCategoriesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.manageCategoriesPanel.ResumeLayout(false);
            this.manageCategoriesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageCategoriesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel manageCategoriesPanel;
        private DataGridView manageCategoriesDataGridView;
        private Button delete3Button;
        private Button edit3Button;
        private Button add3Button;
        private Label descriptionLabel;
        private Label name3Label;
        private Label id3label;
        private TextBox descriptionTextBox;
        private TextBox name3TextBox;
        private TextBox id3TextBox;
        private Label manageCategoriesLabel;
    }
}