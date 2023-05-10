﻿using ClassLibrary1;
using ClassLibrary1.Models;
using DataClass;
using SupermarketTuto.Forms.General;
using SupermarketTuto.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketTuto.Forms.SellingForms
{
    public partial class CreateBillForm : Form
    {

        DataTable productDataTable = new DataTable();
        DataTable originalProductDataTable = new DataTable();
        DataTable productTableCombobox = new DataTable();
        Type productType = typeof(Products);
        BindingSource bindingSourceProducts = new BindingSource();

        DataTable categoryTable = new DataTable();
        

        public CreateBillForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            fillCombo();

            displayProducts();

            

        }

        private void displayProducts()
        {
            //All Products
            productDataTable = DataAccess.Instance.GetTable("ProductTbl");
            
            if (productDataTable.Columns["Total"] == null)
            {
                productDataTable.Columns.Add("Total", typeof(int));
            }

            bindingSourceProducts.DataSource = productDataTable;

            ProdDGV.DataSource = bindingSourceProducts;
            ProdDGV.AllowUserToAddRows = false;
            ProdDGV.RowHeadersVisible = false;
            totalLabel.Text = $"Total: {ProdDGV.RowCount}";

           
            //foreach (DataRow row in productDataTable.Rows)
            //{
            //    int qty = Convert.ToInt32(row["ProdQty"]);
            //    int price = Convert.ToInt32(row["ProdPrice"]);
            //    row["Total"] = qty * price;
            //}
            //double totAmount = productDataTable.AsEnumerable().Sum(row => row.Field<int>("Total"));
            //totalAmountTextBox.Text = totAmount.ToString();

        }


        private void fillCombo()
        {
            List<string> catNames = new List<string>();
            categoryTable = DataAccess.Instance.GetTable("CategoryTbl");
            foreach (DataRow row in categoryTable.Rows)
            {
                catNames.Add(row["CatName"].ToString());
            }
            catComboBox.DataSource = catNames;
            catComboBox.SelectedItem = null;
            catComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            catComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void catComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productDataTable.Rows.Count > 0)
            {
                productTableCombobox = productDataTable.Clone();
                foreach (DataRow row in productDataTable.Rows)
                {
                    if (catComboBox.Text == row["ProdCat"].ToString())
                    {
                        productTableCombobox.ImportRow(row);
                    }
                }
                ProdDGV.DataSource = productTableCombobox;
                ProdDGV.RowHeadersVisible = false;
                totalLabel.Text = $"Total: {ProdDGV.RowCount}";
            }
        }

        

        private void SellingDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SearchCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            
        }


        private void addButton_Click(object sender, EventArgs e)
        {
           AddBill bill = new AddBill(totalAmountTextBox.Text);
           
           bill.Show();
           
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<DataRow> rowsToDelete = new List<DataRow>();
                DataRow row = null;
                // loop over the selected rows and add them to the list
                foreach (DataGridViewRow selectedRow in ProdDGV.SelectedRows)
                {
                    //Convert DataGridViewRow -> DataRow
                    row = ((DataRowView)selectedRow.DataBoundItem).Row;
                    rowsToDelete.Add(row);
                }

                DataAccess.Instance.DeleteData(row, productType);
                // loop over the rows to delete and remove them from the DataTable
                foreach (DataRow rowToDelete in rowsToDelete)
                {
                    productDataTable.Rows.Remove(rowToDelete);
                }
                ProdDGV.DataSource = productDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utlis.Log(string.Format("Message : {0}", ex.Message), "ErrorDeleteProduct.txt");
            }
        }

       
        private void addProductButton_Click(object sender, EventArgs e)
        {
            addEditProduct add = new addEditProduct(productDataTable, null, categoryTable, true);
            add.editButton.Visible = false;
            add.ProdId.Visible = false;
            add.idLabel.Visible = false;
            add.Show();
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = ProdDGV.CurrentRow;
            addEditProduct edit = new addEditProduct(productDataTable, currentRow, categoryTable, false);
            edit.addButton.Visible = false;
            edit.ProdId.ReadOnly = true;
            edit.Show();
        }










        #region ChechDatabase
        private void check()
        {
            SqlConnect sql = new SqlConnect();
            var customerType = typeof(PreBillsTbl);
            sql.checkTable(Categories: customerType);
        }


        #endregion

        
    }
}
