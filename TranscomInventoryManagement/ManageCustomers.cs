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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
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
            custID.Text = "";
            custName.Text = "";
            custMobile.Text = "";
        }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(custID.Text != "" && custName.Text !="" && custMobile.Text != "")
            {
                con.Open();
                string myQuery = "insert into CustomerTbl values('"+custID.Text+"','"+custName.Text+"','"+custMobile.Text+"')";
                SqlCommand cmd = new SqlCommand(myQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added Successfully!");
                con.Close();
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
            if(custID.Text != "" && custName.Text != "" && custMobile.Text != "")
            {
                con.Open();
                string myQuery = "update CustomerTbl set CustomerName = '"+custName.Text+"',CustomerMobile = '"+custMobile.Text+"' where CustomerID = '"+custID.Text+"' ";
                SqlCommand cmd = new SqlCommand(myQuery,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Updated Successfully!");
                con.Close() ;
                populate();
                clear();
            }
            else
            {
                MessageBox.Show("Field's can't be empty!");
            }
        }

        private void customersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            custID.Text = customersGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            custName.Text = customersGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            custMobile.Text = customersGV.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(custID.Text != "" && custName.Text != "" && custMobile.Text != "")
            {
                con.Open() ;
                string myQuery = "delete from CustomerTbl where CustomerID = '"+custID.Text+"'";
                SqlCommand cmd = new SqlCommand(myQuery,con);
                cmd.ExecuteNonQuery ();
                MessageBox.Show("Customer Deleted Successfully!");
                con.Close();
                populate();
                clear ();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
