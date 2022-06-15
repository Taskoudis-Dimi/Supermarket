﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using SupermarketTuto.DataAccess;

namespace SupermarketTuto
{
    public partial class SellingForm : Form
    {

        SqlConnect loaddata = new SqlConnect();
        SqlConnect loaddata2 = new SqlConnect();
        SqlConnect loaddata3 = new SqlConnect();
        public SellingForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void display()
        {
            //loaddata.retrieveData("Select [ProdName], [ProdQty] From [ProductTbl]");
            loaddata.retrieveData("Select [ProdName], [ProdQty] From [ProductTbl] Where [ProdCat] = '" + Convert.ToString(SearchCb.SelectedValue) + "'");
            SellingDGV.DataSource = loaddata.table;
        }

        private void displayBills()
        {
            loaddata2.retrieveData("Select * From BillTbl;");
            BillsDGV.DataSource = loaddata2.table;

        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            display();
            displayBills();
            fillCombo();
            SellerNameLabel.Text = WelcomeForm.Sellername;
        }

        private void SellingPanel_Paint(object sender, PaintEventArgs e)
        {
            DateLabel.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();

        }

        private void AddProductbutton_Click(object sender, EventArgs e)
        {

            if (SellingProdName.Text == "" || SellingQuantity.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int n = 0, total = Convert.ToInt32(SellingPrice.Text) * Convert.ToInt32(SellingQuantity.Text), GrdTotal = 0;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = SellingProdName.Text;
                newRow.Cells[2].Value = SellingPrice.Text;
                newRow.Cells[3].Value = SellingQuantity.Text;
                newRow.Cells[4].Value = Convert.ToInt32(SellingPrice.Text) * Convert.ToInt32(SellingQuantity.Text);
                OrderDGV.Rows.Add(newRow);
                n++;
                GrdTotal = GrdTotal + total;
                AmtLabel.Text = "" + GrdTotal;
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {

                loaddata.commandExc("Insert Into BillTbl values(" + BillId.Text + ",'" + SellerNameLabel.Text + "','" + DateLabel.Text + "'," + AmtLabel.Text + ")");

                //displayBills();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

      

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FamilySuperMarket", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Bill ID: " + BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
            e.Graphics.DrawString("Seller Name: " + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Date: " + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Total Amount: " + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("Code Space", new Font("Century Gothic", 20, FontStyle.Italic), Brushes.Blue, new Point(230, 230));


        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            //displayBills();
        }

        private void fillCombo()
        {
            loaddata3.retrieveData("Select [CatName] From [CategoryTbl]");
            SearchCb.DataSource = loaddata3.table;
            //loaddata3.table.Columns.Add("CatName", typeof(string));
            SearchCb.ValueMember = "CatName";
            SearchCb.SelectedIndex = 0;


        }

        private void logOutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.Show();
        }

        private void SellingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm to close", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void SellingDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SellingProdName.Text = SellingDGV.SelectedRows[0].Cells[0].Value.ToString();
            SellingPrice.Text = SellingDGV.SelectedRows[0].Cells[1].Value.ToString();
            display();
        }

        int flag = 0;
        private void BillsDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }
    }
}
