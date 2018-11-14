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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\abhinav\dailw wage\dailw wage\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet2.wage' table. You can move, or remove it, as needed.
            this.wageTableAdapter1.Fill(this.database1DataSet2.wage);
            // TODO: This line of code loads data into the 'database1DataSet1.wage' table. You can move, or remove it, as needed.
            this.wageTableAdapter.Fill(this.database1DataSet1.wage);
            // TODO: This line of code loads data into the 'database1DataSet.daily' table. You can move, or remove it, as needed.
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string des;
            if (manager.Checked)
                des = "Manager";
            else if (supervisor.Checked)
                des = "Supervisor";
            else
                des = "Worker";


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText="INSERT into wage values('"+id.Text+"','"+name.Text+"','"+ des + "','"+hours.Text+"','"+wage.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            refresh();
            MessageBox.Show("saved");
        }
        public void refresh()
        {
            string str = "select * from wage;";
            SqlDataAdapter myadapter = new SqlDataAdapter(str, con);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            BindingSource bs = new BindingSource();
            bs.DataSource = mytable;
            dataGridView1.DataSource = bs;

        }

        private void dailywage_Click(object sender, EventArgs e)
        {
            wages f1 = new wages();
            f1.Show();
        }
    }
}
