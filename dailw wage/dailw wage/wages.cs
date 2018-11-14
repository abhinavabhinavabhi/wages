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
namespace dailw_wage
{
    
    public partial class wages : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\abhinav\dailw wage\dailw wage\Database1.mdf;Integrated Security=True");
        public wages()
        {
            InitializeComponent();
        }

        private void wages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.dailywage' table. You can move, or remove it, as needed.
            this.dailywageTableAdapter.Fill(this.database1DataSet3.dailywage);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into dailywage values((select id from wage),(select name from wage),(select wage from wage))";
            cmd.ExecuteNonQuery();
            con.Close();
            
            MessageBox.Show("saved");
        }
    }
}
