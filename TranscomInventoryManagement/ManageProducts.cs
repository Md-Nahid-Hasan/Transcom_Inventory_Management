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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
            populate();
            fillCategory();
            fillSearchCombo();
            //filterByCategory();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MIS14;Initial Catalog=nahid;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public void clear()
        {
            prodID.Text = "";
            prodName.Text = "";
            prodQty.Text = "";
            prodPrice.Text = "";
            prodDescription.Text = "";
        }
        public void populate()
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
        public void fillCategory()
        {
            con.Open();
            string myQuery = "select *from CategoryTbl";
            SqlCommand cmd = new SqlCommand(myQuery,con);
            SqlDataReader dr;
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                CategoryComboBox.ValueMember = "CategoryName";
                CategoryComboBox.DataSource = dt;             
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

        public void filterByCategory()
        {
            con.Open();
            string myQuery = "select *from ProductTbl where ProductCategory = '"+SearchCombo.SelectedValue.ToString()+"'";
            SqlCommand cmd = new SqlCommand(myQuery, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            var ds = new DataTable();
            adapter.Fill(ds);
            productsGV.DataSource = ds;
            con.Close();
           
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            //fillCategory();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (prodID.Text != "" && prodName.Text != "" && prodQty.Text != "" && prodPrice.Text != "" && prodDescription.Text != "" && CategoryComboBox.Text != "")
            {
                con.Open();
                string myQuery = "insert into ProductTbl values('" + prodID.Text + "','" + prodName.Text + "','" + prodQty.Text + "','" + prodPrice.Text + "','" + prodDescription.Text + "','" + CategoryComboBox.Text + "')";
                SqlCommand cmd = new SqlCommand(myQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully!");
                con.Close();
                populate();
                clear();
            }
            else
            {
                MessageBox.Show("Field's can't be empty!");
            }
            populate();
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (prodID.Text != "" && prodName.Text != "" && prodQty.Text != "" && prodPrice.Text != "" && prodDescription.Text != "" && CategoryComboBox.Text != "")
            {
                con.Open();
                string myQuery = "update ProductTbl set ProductName = '" + prodName.Text + "',ProductQty = '" + prodQty.Text + "',ProductPrice = '" + prodPrice.Text + "',ProductDescription = '" + prodDescription.Text + "',ProductCategory = '" + CategoryComboBox.Text + "' where ProductID = '" + prodID.Text + "' ";
                SqlCommand cmd = new SqlCommand(myQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Updated Successfully!");
                con.Close();
                populate();
                clear();
            }
            else
            {
                MessageBox.Show("Field's can't be empty!");
            }
        }

        private void productsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            prodID.Text = productsGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            prodName.Text = productsGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            prodQty.Text = productsGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            prodPrice.Text = productsGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            prodDescription.Text = productsGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            CategoryComboBox.Text = productsGV.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (prodID.Text != "" && prodName.Text != "" && prodQty.Text != "" && prodPrice.Text != "" && prodDescription.Text != "" && CategoryComboBox.Text != "")
            {
                con.Open();
                string myQuery = "delete from ProductTbl where ProductID = '" + prodID.Text + "' ";
                SqlCommand cmd = new SqlCommand(myQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Deleted Successfully!");
                con.Close();
                populate();
                clear();
            }
            else
            {
                MessageBox.Show("Field's can't be empty!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
