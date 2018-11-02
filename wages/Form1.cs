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

namespace wages
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\wages\wages\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet5.wage' table. You can move, or remove it, as needed.
            this.wageTableAdapter5.Fill(this.database1DataSet5.wage);
            // TODO: This line of code loads data into the 'database1DataSet4.wage' table. You can move, or remove it, as needed.
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into wage values('" + id.Text + "','" + name.Text + "','" + hours.Text + "','" + wage.Text + "','" + desi.Text + "')";
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception)
            {
                MessageBox.Show("invalid input please check");
            }
            con.Close();
            refresh();
            MessageBox.Show("saved");
        }
        public void refresh()
        {
            string str = "select * from wage";
            SqlDataAdapter da = new SqlDataAdapter(str,con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
        }
    }
}
