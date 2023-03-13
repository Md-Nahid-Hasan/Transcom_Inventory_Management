using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace TranscomInventoryManagement
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MIS14;Initial Catalog=nahid;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void populate()
        {
            try
            {
                con.Open();
                //string myQuery = "select *from UserTbl";
                //SqlDataAdapter adapter = new SqlDataAdapter("select *from UserTbl", con);
                //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                SqlCommand cmd = new SqlCommand("select *from UserTbl", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                //DataTable dt = new DataTable();
                adapter.Fill(ds);
                usersGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        public void clear()
        {
            mUserName.Text = "";
            mPassword.Text = "";
            mMobile.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           if(mUserName.Text !="" && mPassword.Text !="" && mMobile.Text !="")
            { 
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('"+mUserName.Text+"','"+mPassword.Text+"','"+mMobile.Text+"')",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully!");
                con.Close();
            }
            else
            {
                MessageBox.Show("Field's can't be empty!");
            }
            populate();
        }

        private void usersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mUserName.Text = usersGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            mPassword.Text = usersGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            mMobile.Text = usersGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            /*//populate();
            mUserName.Text = usersGV.SelectedRows[0].Cells[0].Value.ToString(); 
            mPassword.Text = usersGV.SelectedRows[0].Cells[1].Value.ToString();
            mMobile.Text = usersGV.SelectedRows[0].Cells[2].Value.ToString();*/

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(mMobile.Text == "")
            {
                MessageBox.Show("Mobile field can't be empty!");
            }
            else
            {
                con.Open();
                string myQuery = "delete from UserTbl where Umobile = '"+mMobile.Text+"'";
                SqlCommand cmd = new SqlCommand(myQuery,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Deleted Successfully!");
                con.Close();
                populate();
                clear();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(mUserName.Text != "" && mPassword.Text != "" && mMobile.Text != "")
            {
                con.Open();
                string myQuery = "update UserTbl set Uname = '"+mUserName.Text+"', Upassword ='"+mPassword.Text+"' where Umobile = '"+mMobile.Text+"' ";
                SqlCommand cmd = new SqlCommand(myQuery,con);
                cmd.ExecuteNonQuery ();
                MessageBox.Show("User Updated Successfully!");
                con.Close();
                populate ();
                clear();
            }
            else
            {
                MessageBox.Show("Field's can't be empty!");
            }
        }
    }
}
