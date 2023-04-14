﻿using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Transactions;
using System.Windows.Forms;

namespace DataClass
{
    public class SqlConnect
    {

        public static SqlConnection con = new SqlConnection();
        public DataTable table = new DataTable();
        public DataSet set = new DataSet();

        public SqlConnect()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["smarketdb"].ConnectionString;
        }

        public static void OpenCon()
        {
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                CloseCon();
            }
        }

        private static void CloseCon()
        {
            if (con.State != ConnectionState.Closed)
            {
                try
                {
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public DataTable getData(string cmd)
        {
            OpenCon();
            SqlTransaction transaction = con.BeginTransaction();

            try
            {
                SqlCommand command = new SqlCommand(cmd, con, transaction);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(table);

                transaction.Commit();
                return table;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public DataSet getDataSet(string cmd)
        {
            OpenCon();
            SqlTransaction transaction = con.BeginTransaction();

            try
            {
                SqlCommand command = new SqlCommand(cmd, con, transaction);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(table);

                transaction.Commit();
                return set;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public void execCom(string cmd)
        {
            OpenCon();
            SqlTransaction transaction = con.BeginTransaction();

            try
            {
                // Insert data into table
                SqlCommand command = new SqlCommand(cmd, con, transaction);
                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }
            finally
            {
                CloseCon();
            }
        }

        public void backup(string path)
        {
            try
            {
                OpenCon();
                string query = "BACKUP DATABASE smarketdb TO DISK = '" + path + "\\backupfile.bak' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of Testdb';";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("BackUp seccess!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseCon();
            }
        }

        public void search(string text, string sql)
        {
            try
            {
                OpenCon();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseCon();
            }
        }

        public void pagingData(string command, int startRecord, int maxRecord)
        {
            try
            {
                table.Clear();
                SqlDataAdapter adapter = new SqlDataAdapter(command, con);
                adapter.Fill(startRecord, maxRecord, table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void saveImage(byte[] imageData, string query)
        {
            OpenCon();
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.Add("@ImageData", SqlDbType.VarBinary, -1).Value = imageData;
            command.ExecuteNonQuery();
            CloseCon();
        }

        #region Chech Schema of Database
        public void CheckSchema(List<SchemaTable> Table)
        {
            OpenCon();
            var tables = Table;
            foreach (var schemaTable in tables)
            {
                if (!TableExists(con, schemaTable.TableName))
                {
                    CreateTable(con, schemaTable);
                }
                else
                {
                    var existingColumns = GetTableColumns(con, schemaTable.TableName);
                    foreach (var schemaColumn in schemaTable.Columns)
                    {
                        if (!existingColumns.Contains(schemaColumn.ColumnName))
                        {
                            AddColumn(con, schemaTable.TableName, schemaColumn);
                            MessageBox.Show($"Added the {schemaColumn.ColumnName} column to the {schemaTable.TableName} table", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

        }
        private void CreateTable(SqlConnection connection, SchemaTable schemaTable)
        {
            var columnsSql = string.Join(", ", schemaTable.Columns.ConvertAll(c => $"{c.ColumnName} {GetSqlType(c)}"));
            var createTableSql = $"CREATE TABLE {schemaTable.TableName} ({columnsSql})";
            using (var command = new SqlCommand(createTableSql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        private void AddColumn(SqlConnection connection, string tableName, SchemaColumn schemaColumn)
        {
            var addColumnSql = $"ALTER TABLE {tableName} ADD {schemaColumn.ColumnName} {GetSqlType(schemaColumn)}";
            using (var command = new SqlCommand(addColumnSql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public SqlDbType GetSqlType(Type type)
        {
            if (type == typeof(int))
            {
                return SqlDbType.Int;
            }
            else if (type == typeof(string))
            {
                return SqlDbType.NVarChar;
            }
            else if (type == typeof(DateTime))
            {
                return SqlDbType.DateTime;
            }
            else if (type == typeof(decimal))
            {
                return SqlDbType.Decimal;
            }
            else if(type == typeof(Image))
            {
                return SqlDbType.Image;
            }
            else if(type == typeof(byte))
            {
                return SqlDbType.Binary;
            }
            else if(type == typeof(bool))
            {
                return SqlDbType.Bit;
            }
            else
            {
                // Handle other data types as needed
                throw new NotSupportedException($"Data type {type.Name} is not supported.");
            }
        }

        private bool TableExists(SqlConnection connection, string tableName)
        {
            using (var command = new SqlCommand($"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'", connection))
            {
                var count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private List<string> GetTableColumns(SqlConnection connection, string tableName)
        {
            var columns = new List<string>();
            using (var command = new SqlCommand($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        columns.Add(reader.GetString(0));
                    }
                }
            }
            return columns;
        }

        

        

        private string GetSqlType(SchemaColumn schemaColumn)
        {
            if (schemaColumn.DataType == SqlDbType.NVarChar)
            {
                return $"{schemaColumn.DataType}(max)";
            }
            else if (schemaColumn.DataType == SqlDbType.Decimal)
            {
                return $"{schemaColumn.DataType}(18, 2)";
            }
            else if (schemaColumn.DataType == SqlDbType.Date)
            {
                return $"{schemaColumn.DataType}(max)";
            }
            else if (schemaColumn.DataType == SqlDbType.Binary)
            {
                return $"{schemaColumn.DataType}";
            }
            else if (schemaColumn.DataType == SqlDbType.Image)
            {
                return $"{schemaColumn.DataType}";
            }
            else if (schemaColumn.DataType == SqlDbType.Bit)
            {
                return $"{schemaColumn.DataType}";
            }
            else
            {
                return schemaColumn.DataType.ToString();
            }
        }

        #endregion

        public void checkTable(Type Products = null, Type Categories = null, Type Bills = null, Type Sellers = null, Type Admins = null, Type BillingProducts = null)
        {
            List<SchemaTable> tables = new List<SchemaTable>();
            var customerType = typeof(Type);
            if(Products != null)
            {
                customerType = typeof(Products);
            }
            else if(Categories != null)
            {
                customerType = typeof(Categories);
            }
            else if(Bills != null)
            {
                customerType = typeof(Bills);
            }
            else if(Sellers != null)
            {
                customerType = typeof(Sellers);
            }
            else if(Admins != null)
            {
                customerType = typeof(Admins);
            }
            else if(BillingProducts != null)
            {
                customerType = typeof(BillingProducts);
            }
            var customerProperties = customerType.GetProperties();
            var customerColumns = customerProperties.Select(p => new SchemaColumn(p.Name, GetSqlType(p.PropertyType))).ToList();
            var customerTable = new SchemaTable("CategoryTbl", customerColumns);
            tables.Add(customerTable);
            CheckSchema(tables);
        }


    }

    public class SchemaTable
    {
        public string TableName { get; }
        public List<SchemaColumn> Columns { get; }

        public SchemaTable(string tableName, List<SchemaColumn> columns)
        {
            TableName = tableName;
            Columns = columns;
        }
    }

    public class SchemaColumn
    {
        public string ColumnName { get; }
        public SqlDbType DataType { get; }

        public SchemaColumn(string columnName, SqlDbType dataType)
        {
            ColumnName = columnName;
            DataType = dataType;
        }

        public SchemaColumn(string columnName, SqlDbType dataType, int size)
        {
            ColumnName = columnName;
            DataType = dataType;
            // Only applies to NVarChar columns
            if (dataType == SqlDbType.NVarChar)
            {
                DataType = SqlDbType.NVarChar;
                Size = size;
            }
        }

        public int Size { get; }
    }

}