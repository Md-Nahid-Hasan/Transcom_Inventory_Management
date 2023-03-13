//using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

        //void updateProduct()
        //{
        //    con.Open();
        //    int id = Convert.ToInt32(productsGV.SelectedRows[0].Cells[0].Value.ToString());
        //    int newQty = stock - Convert.ToInt32(qty.Text);
        //    string query = "update ProductTbl set ProductQty = '" + newQty + "' where ProductID = '" + id + "'";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    cmd.ExecuteNonQuery();
        //    MessageBox.Show("Update Successfully!");
        //    populateProduct();
        //    con.Close();
        //}

        int num = 0;
        int flag = 0;
        int stock;
        string product;
        int quantity, totalPrice, uPrice;

        private void productsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = productsGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            //quantity = Convert.ToInt32(qty.Text);
            stock = Convert.ToInt32(productsGV.Rows[e.RowIndex].Cells[2].Value.ToString());
            uPrice = Convert.ToInt32(productsGV.Rows[e.RowIndex].Cells[3].Value.ToString());
            totalPrice = quantity * uPrice;
            flag = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(qty.Text == "")
            {
                MessageBox.Show("Quantity Required!");
            }
            else if(flag == 0)
            {
                MessageBox.Show("Product Required!");
            }
            else if(Convert.ToInt32(qty.Text)>stock)
            {
                MessageBox.Show("Sorry,No Enough Stock Available!");
            }
            else
            {
                num = num + 1;
                quantity = Convert.ToInt32(qty.Text);
                totalPrice = quantity * uPrice;

                //table.Rows.Add(num, product, quantity, uPrice, totalPrice);
                //ordersGV.DataSource = table;

                //DataTable dt = new DataTable();
                //SqlDataAdapter adapter = new SqlDataAdapter();
                //adapter.Fill(dt);
                //ordersGV.DataSource = dt;
                flag = 0;
                MessageBox.Show("Added Successfully!");
                //MessageBox.Show(Convert.ToString(totalPrice));
            }
        }
    }
}
