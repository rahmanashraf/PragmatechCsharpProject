using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Login_Register.SqlVariables;

namespace Login_Register
{
    public partial class GridView : Form
    {
        public GridView()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DataGetter();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void DataGetter()
        {
            SqlCommand commandList = new SqlCommand("Select * from UserTable", SqlVariable.connection);
            SqlVariable.CheckConnection(SqlVariable.connection);
            SqlDataAdapter da = new SqlDataAdapter(commandList);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void GridView_Load(object sender, EventArgs e)
        {
            DataGetter();
        }
        int selectedID;
        private void DeleteButton_Click(object sender, EventArgs e)
        {
             

            SqlCommand commandDelete = new SqlCommand("Delete from UserTable where UserID=@pID",SqlVariable.connection);
            SqlVariable.CheckConnection(SqlVariable.connection);

            commandDelete.Parameters.AddWithValue("pID", selectedID);

            commandDelete.ExecuteNonQuery();
            DataGetter();   
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UserID"].Value);
            lblselect.Text = selectedID.ToString();     
        }
    }
}
