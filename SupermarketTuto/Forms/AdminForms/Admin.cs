﻿using ClassLibrary1.Models;
using DataClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketTuto.Forms
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnect loaddata = new SqlConnect();
                loaddata.getData("Select [Id],[UserName],cast([Password] as varchar(MAX)) as Password,[Active] From [Admins]");
                usersDataGridView.DataSource = loaddata.table;
                usersDataGridView.RowHeadersVisible = false;
            }
            catch
            {


            }
            
        }

        private void usersDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

       


    }
}
