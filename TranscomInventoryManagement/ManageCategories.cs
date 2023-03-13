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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MIS14;Initial Catalog=nahid;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void clear()
        {
            catID.Text = "";
            catName.Text = "";
        }
        public void populate()
        {
            con.Open();
            string myQuery = "select *from CategoryTbl";
            SqlCommand cmd = new SqlCommand(myQuery, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            var ds = new DataSet();
            adapter.Fill(ds);
            categoryGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (catID.Text != "" && catName.Text != "")
            {
                con.Open();
                string myQuery = "insert into CategoryTbl values('" + catID.Text + "','" + catName.Text + "')";
                SqlCommand cmd = new SqlCommand(myQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully!");
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
            if (catID.Text != "" && catName.Text != "")
            {
                con.Open();
                string myQuery = "update CategoryTbl set CategoryName = '" + catName.Text + "' where CategoryID = '" + catID.Text + "' ";
                SqlCommand cmd = new SqlCommand(myQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Updated Successfully!");
                con.Close();
                populate();
                clear();
            }
            else
            {
                MessageBox.Show("Field's can't be empty!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (catID.Text != "" && catName.Text != "")
            {
                con.Open();
                string myQuery = "delete from CategoryTbl where CategoryID = '" + catID.Text + "'";
                SqlCommand cmd = new SqlCommand(myQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Deleted Successfully!");
                con.Close();
                populate();
                clear();
            }
            else
            {
                MessageBox.Show("Field's can't be empty!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void categoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            catID.Text = categoryGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            catName.Text = categoryGV.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
