﻿using ClassLibrary1.Models;
using DataClass;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class ExcelFile
    {

        #region Csv files

        public DataTable import(Type type)
        {
            try
            {
                int ImportedRecord = 0, inValidItem = 0;
                string SourceURl = "";
                OpenFileDialog dialog = new OpenFileDialog()
                {
                    Title = "Browse Text File",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    Filter = "csv files (*.csv)|*.csv",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    ReadOnlyChecked = true,
                    ShowReadOnly = true

                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (dialog.FileName.EndsWith(".csv"))
                    {
                        DataTable table = new DataTable();
                        table = GetData<ProductTbl>(dialog.FileName);
                        SourceURl = dialog.FileName;
                        if (table.Rows != null && table.Rows.Count > 0)
                        {
                            return table;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception" + ex);
                return null;
            }
        }

        private DataTable GetData<T>(string path) where T : class
        {
            PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            DataTable dt = new DataTable();
            try
            {
                if (path.EndsWith(".csv"))
                {
                    string[] lines = System.IO.File.ReadAllLines(path);
                    if (lines.Length > 0)
                    {
                        //first line to create header
                        string firstLine = lines[0];
                        string[] headerLabels = firstLine.Split(',');
                        foreach (string headerWord in headerLabels)
                        {
                            if (headerWord == "ProdId")
                            {
                                dt.Columns.Add(new DataColumn(headerWord));
                                dt.PrimaryKey = new DataColumn[] { dt.Columns["ProdId"] };
                            }
                            else if (headerWord == "CatId")
                            {
                                dt.Columns.Add(new DataColumn(headerWord));
                                dt.PrimaryKey = new DataColumn[] { dt.Columns["CatId"] };
                            }
                            else
                            {
                                dt.Columns.Add(new DataColumn(headerWord));
                            }
                        }
                        //Set the data types of the columns
                        foreach (PropertyInfo p in properties)
                        {
                            Type getType = GetProperties(p, dt.Columns[$"{p.Name}"].DataType);
                            dt.Columns[$"{p.Name}"].DataType = getType;
                        }
                        //For Data
                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] dataWords = lines[i].Split(',');
                            if (dataWords.Length > 0 && string.IsNullOrEmpty(dataWords[dataWords.Length - 1]))
                            {
                                // Remove the last element from the array
                                Array.Resize(ref dataWords, dataWords.Length - 1);
                            }
                            DataRow dr = dt.NewRow();
                            int columnIndex = 0;
                            foreach (string headerWord in headerLabels)
                            {
                                dr[headerWord] = dataWords[columnIndex++];
                            }
                            dt.Rows.Add(dr);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
            return dt;
        }

        public void export(DataGridView table, bool useSelected = false)
        {
            if (table.Rows.Count > 0)
            {
                SaveFileDialog dialog = new SaveFileDialog()
                {
                    Filter = "CSV (*.csv)|*.csv",
                    Title = "Csv Files",
                    RestoreDirectory = true
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(dialog.FileName))
                    {
                        try
                        {
                            File.Delete(dialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            int colCount = table.Columns.Count;
                            string colNames = string.Empty;
                            string[] outputCSV = new string[table.Rows.Count + 1];
                            for (int i = 0; i < colCount; i++)
                            {
                                if (i == colCount - 1)
                                {
                                    if (table.Columns[i].HeaderText.ToString() != "Select")
                                        colNames += table.Columns[i].HeaderText.ToString();
                                }
                                else
                                {
                                    if (table.Columns[i].HeaderText.ToString() != "Select")
                                        colNames += table.Columns[i].HeaderText.ToString() + ",";
                                }
                            }
                            outputCSV[0] += colNames;

                            for (int i = 1; (i - 1) < table.Rows.Count; i++)
                            {
                                if (useSelected)
                                {
                                    for (int j = 1; j < colCount; j++)
                                    {
                                        outputCSV[i] += table.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                }
                                else
                                {
                                    for (int j = 0; j < colCount; j++)
                                    {
                                        outputCSV[i] += table.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                }
                            }
                            File.WriteAllLines(dialog.FileName, outputCSV, Encoding.UTF8);
                            MessageBox.Show("Successfully export", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }

        #endregion


        public void SaveToDB(DataTable table, Type type)
        {
            //SqlConnect loaddata20 = new SqlConnect();

            //foreach (DataRow row in table.Rows)
            //{
            //    if (type.Name == "Products")
            //    {
            //        DateTime DateTime = (DateTime)row["Date"];
            //        string Date = DateTime.ToString("yyyy-MM-dd");
            //        loaddata20.execCom("Insert Into ProductTbl values('" + row["ProdName"] + "','" + row["ProdQty"] + "','" + row["ProdPrice"] + "','" + row["ProdCatID"] + "','" + row["ProdCat"] + "','" + Date + "')");
            //    }
            //    else if (type.Name.Equals("Categories"))
            //    {
            //        DateTime DateTime = (DateTime)row["Date"];
            //        string Date = DateTime.ToString("yyyy-MM-dd");
            //        loaddata20.execCom("Insert Into CategoryTbl values('" + row["CatName"] + "','" + row["CatDesc"] + "','" + Date + "')");
            //    }
            //    else if (type.Name.Equals("Bills"))
            //    {
            //        loaddata20.execCom("Insert Into BillTbl values('" + row["Comments"] + "','" + row["SellerName"] + "','" + row["BillDate"] + "'," + row["TotAmt"] + ")");
            //    }
            //}
        }


        #region Xlsx files

        List<object> data = new List<object>();

        //Import
        public DataTable ImportExcelAsync(DataGridView dataGridView, Type typeOfClass)
        {
            try
            {
                string path = null;
                int rowAdd = 5;
                int col = 1;
                double date;
                DataTable dataTable = new DataTable();
                OpenFileDialog dialog = new OpenFileDialog()
                {
                    Filter = "xlsx (*.xlsx)|*.xlsx",
                    Title = "xlsx Files",
                    RestoreDirectory = true
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;

                    using (var package = new ExcelPackage(new FileInfo(path)))
                    {
                        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                        package.LoadAsync(path);

                        var ws = package.Workbook.Worksheets[0]; // assuming your data is in the first worksheet 

                        if (typeOfClass.Name.Equals("ProductTbl"))
                        {
                            dataTable.Columns.Add("ProdId", typeof(int));
                            dataTable.Columns.Add("ProdName");
                            dataTable.Columns.Add("ProdQty", typeof(int));
                            dataTable.Columns.Add("ProdPrice", typeof(int));
                            dataTable.Columns.Add("ProdCatID", typeof(int));
                            dataTable.Columns.Add("ProdCat");
                            dataTable.Columns.Add("Date", typeof(DateTime));

                            // Loop through the rows in the worksheet and add them to the DataTable
                            while (string.IsNullOrWhiteSpace(ws.Cells[rowAdd, col].Value?.ToString()) == false)
                            {
                                DataRow row = dataTable.Rows.Add();
                                row["ProdId"] = int.Parse(ws.Cells[rowAdd, col].Value.ToString());
                                row["ProdName"] = ws.Cells[rowAdd, col + 1].Value.ToString();
                                row["ProdQty"] = int.Parse(ws.Cells[rowAdd, col + 2].Value.ToString());
                                row["ProdPrice"] = int.Parse(ws.Cells[rowAdd, col + 3].Value.ToString());
                                row["ProdCatID"] = int.Parse(ws.Cells[rowAdd, col + 4].Value.ToString());
                                row["ProdCat"] = ws.Cells[rowAdd, col + 5].Value.ToString();
                                ExcelRange range = ws.Cells[rowAdd, col + 6];
                                date = Convert.ToDouble(range.Value);
                                row["Date"] = DateTime.FromOADate(date);
                                rowAdd += 1;
                            }

                        }
                        else if (typeOfClass.Name.Equals("BillTbl"))
                        {
                            dataTable.Columns.Add("CatId", typeof(int));
                            dataTable.Columns.Add("CatName");
                            dataTable.Columns.Add("CatDesc");
                            dataTable.Columns.Add("Date", typeof(DateTime));

                            // Loop through the rows in the worksheet and add them to the DataTable
                            while (string.IsNullOrWhiteSpace(ws.Cells[rowAdd, col].Value?.ToString()) == false)
                            {
                                DataRow row = dataTable.Rows.Add();
                                row["CatId"] = int.Parse(ws.Cells[rowAdd, col].Value.ToString());
                                row["CatName"] = ws.Cells[rowAdd, col + 1].Value.ToString();
                                row["CatDesc"] = ws.Cells[rowAdd, col + 5].Value.ToString();
                                ExcelRange range = ws.Cells[rowAdd, col + 6];
                                date = Convert.ToDouble(range.Value);
                                row["Date"] = DateTime.FromOADate(date);
                                rowAdd += 1;
                            }
                        }
                        else if (typeOfClass.Name.Equals("Bills"))
                        {
                            dataTable.Columns.Add("BillId", typeof(int));
                            dataTable.Columns.Add("Comments");
                            dataTable.Columns.Add("SellerName");
                            dataTable.Columns.Add("BillDate", typeof(DateTime));
                            dataTable.Columns.Add("TotAmt", typeof(int));

                            // Loop through the rows in the worksheet and add them to the DataTable
                            while (string.IsNullOrWhiteSpace(ws.Cells[rowAdd, col].Value?.ToString()) == false)
                            {
                                DataRow row = dataTable.Rows.Add();
                                row["BillId"] = int.Parse(ws.Cells[rowAdd, col].Value.ToString());
                                row["Comments"] = ws.Cells[rowAdd, col + 1].Value.ToString();
                                row["SellerName"] = ws.Cells[rowAdd, col + 1].Value.ToString();
                                ExcelRange range = ws.Cells[rowAdd, col + 6];
                                date = Convert.ToDouble(range.Value);
                                row["BillDate"] = DateTime.FromOADate(date);
                                row["TotAmt"] = int.Parse(ws.Cells[rowAdd, col].Value.ToString());
                                rowAdd += 1;
                            }
                        }
                        return dataTable;
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        //Save
        public async void Save(DataGridView dataGridView, Type typeOfClass)
        {
            string path = "";
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            try
            {
                SaveFileDialog dialog = new SaveFileDialog()
                {
                    Filter = "xlsx (*.xlsx)|*.xlsx",
                    Title = "xlsx Files",
                    RestoreDirectory = true
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.FileName;
                    var file = new FileInfo(path);
                    if (typeOfClass.Name.Equals("ProductTbl"))
                    {
                        var products = GetSetupDataProd(dataGridView, typeOfClass);
                        await SaveExcelFile(products, file, typeOfClass);
                    }
                    else if (typeOfClass.Name.Equals("CategoryTbl"))
                    {
                        var categories = GetSetupDataProd(dataGridView, typeOfClass);
                        await SaveExcelFile(categories, file, typeOfClass);
                    }
                    else if (typeOfClass.Name.Equals("BillTbl"))
                    {
                        var bills = GetSetupDataProd(dataGridView, typeOfClass);
                        await SaveExcelFile(bills, file, typeOfClass);
                    }
                }
                else
                {
                    return;
                }
            }
            catch
            {
                return;
            }


        }

        private List<object> GetSetupDataProd(DataGridView dataGridView, Type type)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (type.Name.Equals("ProductTbl"))
                    {
                        ProductTbl prod = new ProductTbl();
                        prod.ProdId = Convert.ToInt32(row.Cells["ProdId"].Value);
                        prod.ProdCat = row.Cells["ProdCat"].Value.ToString();
                        prod.ProdName = row.Cells["ProdName"].Value.ToString();
                        prod.ProdPrice = Convert.ToInt32(row.Cells["ProdPrice"].Value);
                        prod.ProdQty = Convert.ToInt32(row.Cells["ProdQty"].Value);
                        prod.ProdCatID = Convert.ToInt32(row.Cells["ProdCatID"].Value);
                        prod.Date = DateTime.Parse(row.Cells["Date"].Value.ToString());
                        data.Add(prod);
                    }
                    else if (type.Name.Equals("CategoryTbl"))
                    {
                        CategoryTbl cat = new CategoryTbl();
                        cat.CatId = Convert.ToInt32(row.Cells["CatId"].Value);
                        cat.CatName = row.Cells["CatName"].Value.ToString();
                        cat.CatDesc = row.Cells["CatDesc"].Value.ToString();
                        cat.Date = DateTime.Parse(row.Cells["Date"].Value.ToString());
                        data.Add(cat);
                    }
                    else if (type.Name.Equals("BillTbl"))
                    {
                        BillTbl bills = new BillTbl();
                        bills.BillId = Convert.ToInt32(row.Cells["BillId"].Value);
                        bills.Comments = row.Cells["Comments"].Value.ToString();
                        bills.SellerName = row.Cells["SellerName"].Value.ToString();
                        bills.Date = DateTime.Parse(row.Cells["BillDate"].Value.ToString());
                        bills.TotAmt = Convert.ToInt32(row.Cells["TotAmt"].Value);
                        data.Add(bills);
                    }
                }
                return data;
            }
            catch
            {
                return null;
            }
        }

        private static async Task SaveExcelFile(List<object> data, FileInfo file, Type type)
        {
            try
            {
                List<ProductTbl> products = new List<ProductTbl>();
                List<CategoryTbl> categories = new List<CategoryTbl>();
                List<BillTbl> bills = new List<BillTbl>();
                if (type.Name.Equals("ProductTbl"))
                {
                    products = data.Cast<ProductTbl>().ToList();
                }
                else if (type.Name.Equals("CategoryTbl"))
                {
                    categories = data.Cast<CategoryTbl>().ToList();
                }
                else if (type.Name.Equals("BillTbl"))
                {
                    bills = data.Cast<BillTbl>().ToList();
                }

                DeleteIfExists(file);
                using (var package = new ExcelPackage(file))
                {
                    var ws = package.Workbook.Worksheets.Add("MainReport");


                    // Formats the header
                    if (type.Name.Equals("ProductTbl"))
                    {
                        var range = ws.Cells["A3"].LoadFromCollection(products, true);
                        range.AutoFitColumns();
                        ws.Cells["A1"].Value = "Report Products";
                    }
                    else if (type.Name.Equals("CategoryTbl"))
                    {
                        var range = ws.Cells["A3"].LoadFromCollection(categories, true);
                        range.AutoFitColumns();
                        ws.Cells["A1"].Value = "Report Categories";
                    }
                    else if (type.Name.Equals("BillTbl"))
                    {
                        var range = ws.Cells["A3"].LoadFromCollection(bills, true);
                        range.AutoFitColumns();
                        ws.Cells["A1"].Value = "Report Bills";
                    }

                    ws.Cells["A1:C1"].Merge = true;
                    ws.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws.Row(1).Style.Font.Size = 24;
                    ws.Row(1).Style.Border.BorderAround(ExcelBorderStyle.Dashed);
                    ws.Row(1).Style.Font.Color.SetColor(Color.Black);
                    ws.Row(1).Style.Font.Bold = true;

                    ws.Row(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    ws.Row(2).Style.Font.Bold = true;
                    ws.Column(3).Width = 20;

                    await package.SaveAsync();
                };

            }
            catch
            {

            }

        }

        private static void DeleteIfExists(FileInfo file)
        {
            if (file.Exists)
            {
                file.Delete();
            }
        }

        #endregion


        #region Helpers

        private Type GetProperties(PropertyInfo prop, Type type)
        {

            if (prop.PropertyType == typeof(int))
            {
                return typeof(System.Int32);
            }
            else if (prop.PropertyType == typeof(string))
            {
                return typeof(System.String);
            }
            else if (prop.PropertyType == typeof(double))
            {
                return typeof(System.Double);
            }
            else if (prop.PropertyType == typeof(decimal))
            {
                return typeof(System.Decimal);
            }
            else if (prop.PropertyType == typeof(bool))
            {
                return typeof(System.Boolean);
            }
            else if (prop.PropertyType == typeof(DateTime))
            {
                return typeof(System.DateTime);
            }
            return null;
        }

        #endregion

    }
}
