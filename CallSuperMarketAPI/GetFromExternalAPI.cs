﻿using ClassLibrary1;
using ClassLibrary1.Models;
using Newtonsoft.Json;
using SupermarketTuto.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallSuperMarketAPI
{
    public partial class GetFromExternalAPI : Form
    {
        //https://world.openfoodfacts.org/category/cheeses.json
        static readonly HttpClient client = new HttpClient();
        string url_food = "https://api.edamam.com/api/food-database/v2/parser?app_id=713fa9ba&app_key=045b112511bb6b714c5c10328c5f5aba&nutrition-type=cooking&health=alcohol-free&category=generic-foods";
        List<Products> products = new List<Products>();
        List<Categories> categories = new List<Categories>();
        DataTable productsTable = new DataTable();
        DataTable categoriesTable = new DataTable();


        public GetFromExternalAPI()
        {
            InitializeComponent();
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                statusLabel.Text = "Start getting the data";
                HttpResponseMessage response = await client.GetAsync(url_food);
                var ProductsResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(ProductsResponse);
                    if (myDeserializedClass.hints.Count > 0)
                    {
                        foreach (var pair in myDeserializedClass.hints)
                        {
                            Products product = new Products();
                            Categories category = new Categories();
                            string[] parts = pair.food.knownAs.Split(',');
                            product.ProdName = parts[1];
                            product.ProdCat = parts[0];
                            product.Date = DateTime.Now;
                            category.CatName = parts[0];
                            category.CatDesc = pair.food.category;
                            category.Date = DateTime.Now;
                            categories.Add(category);
                            products.Add(product);
                        }
                    }
                }
                statusLabel.Text = "End of getting";
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request exception: {ex.Message}");

            }

        }



        private void InsertProducts()
        {
            productsTable.Columns.Add("ProdId");
            productsTable.Columns.Add("ProdName");
            productsTable.Columns.Add("ProdQty");
            productsTable.Columns.Add("ProdPrice");
            productsTable.Columns.Add("ProdCatID");
            productsTable.Columns.Add("ProdCat");
            productsTable.Columns.Add("Date");


            foreach (var prod in products)
            {
                DataRow row = productsTable.NewRow();
                row["ProdName"] = prod.ProdName;
                row["ProdCat"] = prod.ProdCat;
                row["Date"] = prod.Date;
                productsTable.Rows.Add(row);
            }
            DataAccess.Instance.GetTable("ProductTbl");
            DataAccess.Instance.InsertData(productsTable);
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            InsertProducts();
            InsertCategories();
        }

        private void InsertCategories()
        {
            categoriesTable.Columns.Add("CatId");
            categoriesTable.Columns.Add("CatName");
            categoriesTable.Columns.Add("CatDesc");
            categoriesTable.Columns.Add("Date");


            foreach (var cat in categories)
            {
                DataRow row = categoriesTable.NewRow();
                row["CatName"] = cat.CatName;
                row["CatDesc"] = cat.CatDesc;
                row["Date"] = cat.Date;
                categoriesTable.Rows.Add(row);
            }
            DataAccess.Instance.GetTable("CategoryTbl");
            DataAccess.Instance.InsertData(categoriesTable);
        }
    }





    public class Food
    {
        public string foodId { get; set; }
        public string label { get; set; }
        public string knownAs { get; set; }
        public Nutrients nutrients { get; set; }
        public string category { get; set; }
        public string categoryLabel { get; set; }
        public string image { get; set; }
    }

    public class Hint
    {
        public Food food { get; set; }
        public List<Measure> measures { get; set; }
    }

    public class Links
    {
        public Next next { get; set; }
    }

    public class Measure
    {
        public string uri { get; set; }
        public string label { get; set; }
        public double weight { get; set; }
        public List<Qualified> qualified { get; set; }
    }

    public class Next
    {
        public string title { get; set; }
        public string href { get; set; }
    }

    public class Nutrients
    {
        public double ENERC_KCAL { get; set; }
        public double PROCNT { get; set; }
        public double FAT { get; set; }
        public double CHOCDF { get; set; }
        public double FIBTG { get; set; }
    }

    public class Qualified
    {
        public List<Qualifier> qualifiers { get; set; }
        public double weight { get; set; }
    }

    public class Qualifier
    {
        public string uri { get; set; }
        public string label { get; set; }
    }

    public class Root
    {
        public string text { get; set; }
        public List<object> parsed { get; set; }
        public List<Hint> hints { get; set; }
        public Links _links { get; set; }
    }



}
