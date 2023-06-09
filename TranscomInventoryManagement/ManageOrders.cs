﻿//using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranscomInventoryManagement
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()

        {
            InitializeComponent();
            populate();
            populateProduct();
            //fillSearchCombo();
            fillCategory();
            //updateProduct();
            //filterByCategory();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MIS14;Initial Catalog=nahid;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public void populate()
        {
            con.Open();
            string myQuery = "select *from CustomerTbl";
            SqlCommand cmd = new SqlCommand(myQuery, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            var ds = new DataSet();
            adapter.Fill(ds);
            customersGV.DataSource = ds.Tables[0];
            con.Close();
        }
        public void populateProduct()
        {
            con.Open();
            string myQuery = "select *from ProductTbl";
            SqlCommand cmd = new SqlCommand(myQuery, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            var ds = new DataSet();
            adapter.Fill(ds);
            productsGV.DataSource = ds.Tables[0];
            con.Close();
        }
        public void filterByCategory()
        {
            con.Open();
            string myQuery = "select *from ProductTbl where ProductCategory = '" + SearchCombo.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(myQuery, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            var ds = new DataTable();
            adapter.Fill(ds);
            productsGV.DataSource = ds;
            con.Close();

        }
        public void fillCategory()
        {
            con.Open();
            string myQuery = "select *from CategoryTbl";
            SqlCommand cmd = new SqlCommand(myQuery, con);
            SqlDataReader dr;
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                /* CategoryComboBox.ValueMember = "CategoryName";
                 CategoryComboBox.DataSource = dt;*/
                SearchCombo.ValueMember = "CategoryName";
                SearchCombo.DataSource = dt;
            }
            catch
            {

            }
            con.Close();
        }
        public void fillSearchCombo()
        {
            con.Open();
            string myQuery = "select *from CategoryTbl";
            SqlCommand cmd = new SqlCommand(myQuery, con);
            SqlDataReader dr;
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                SearchCombo.ValueMember = "CategoryName";
                SearchCombo.DataSource = dt;
            }
            catch
            {

            }
            con.Close();
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            custID.Text = customersGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            custName.Text = customersGV.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void SearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterByCategory();
            //fillSearchCombo();
        }

        int num = 0;
        int flag = 0;
        int stock,id,qt;
        string product;
        int totalPrice, uPrice;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateProduct();
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {
            qt = Convert.ToInt32(qty.Text);
        }

        private void productsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(productsGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            product = productsGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            //quantity = Convert.ToInt32(qty.Text);
            stock = Convert.ToInt32(productsGV.Rows[e.RowIndex].Cells[2].Value.ToString());
            uPrice = Convert.ToInt32(productsGV.Rows[e.RowIndex].Cells[3].Value.ToString());
            //totalPrice = quantity * uPrice;
            flag = 1;
        }
        void updateProduct()
        {
            con.Open();
            //int id = Convert.ToInt32(productsGV.Rows.GetRowCount(DataGridViewElementStates.Selected));
            //int id = Convert.ToInt32(productsGV.SelectedRows[2].Cells[0].Value.ToString());
            //int id = 5;
            int newQty = (stock - qt);
            string query = "update ProductTbl set ProductQty = " +newQty+ " where ProductID = " +id+ ";";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Successfully!");
            con.Close();
            populateProduct();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (qty.Text == "")
            {
                MessageBox.Show("Quantity Required!");
            }
            else if(flag == 0)
            {
                MessageBox.Show("Product Required!");
            }
            else if(Convert.ToInt32(qty.Text)>stock)
            {
                MessageBox.Show("Sorry, Not Enough Stock Available!");
            }
            else
            {
                num = num + 1;
                qt = Convert.ToInt32(qty.Text);
                totalPrice = qt * uPrice;
                DataTable table = new DataTable();
                table.Columns.Add("Number");
                table.Columns.Add("Product");
                table.Columns.Add("Quantity");
                table.Columns.Add("Price");
                table.Columns.Add("Total Price");
                table.Rows.Add(num, product, qt, uPrice, totalPrice);
                ordersGV.DataSource = table;
                flag = 0;
                MessageBox.Show("Added to order!");
                //qty.Text = "";
                /*int id = Convert.ToInt32(productsGV.SelectedRows[0].Cells[0].Value.ToString());
                Console.WriteLine(id);*/
            }
            qty.Text = "";
            sum = sum + totalPrice;
            OrderTotAmount.Text = " BDT. " + sum.ToString();
            updateProduct();
        }
    }
}
