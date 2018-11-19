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
using System.IO;


namespace database
{
    public partial class Form1 : Form

    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\abhinav\database\database\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into employee values('" + id.Text + "','" + name.Text + "','" + dept.Text + "')";
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e1)
            {
                MessageBox.Show("check the inputs");
            }
            con.Close();
            MessageBox.Show("saved");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.image' table. You can move, or remove it, as needed.
            this.imageTableAdapter.Fill(this.database1DataSet1.image);
            // TODO: This line of code loads data into the 'database1DataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.database1DataSet.employee);

        }

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " update employee set name='" + name.Text + "', dept='" + dept.Text + "' where id='" + id.Text + "'";
            cmd.ExecuteNonQuery();
            ret();

            con.Close();
            MessageBox.Show("saved");
        }

        private void display_Click(object sender, EventArgs e)
        {
            string str = "select * from employee;";
            SqlDataAdapter myadapter = new SqlDataAdapter(str, con);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            BindingSource bs = new BindingSource();
            bs.DataSource = mytable;
            dataGridView1.DataSource = bs;

        }
        public void  ret()
        {
            string str = "select * from employee;";
            SqlDataAdapter myadapter = new SqlDataAdapter(str, con);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            BindingSource bs = new BindingSource();
            bs.DataSource = mytable;
            dataGridView1.DataSource = bs;
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void selectimage_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = textBox1.Text;
            

        }

        private void saveimage_Click(object sender, EventArgs e)
        {
           /* pictureBox1.ImageLocation = textBox1.Text;*/
            con.Open();
            Byte[] mypic = File.ReadAllBytes(openFileDialog1.FileName);
            SqlCommand cm = new SqlCommand("insert into image values(1,@pic)",con);
            //cm.CommandType = CommandType.Text;
           
            SqlParameter pr = new SqlParameter("@pic", SqlDbType.VarBinary, mypic.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, mypic);
            cm.Parameters.Add(pr);
            cm.ExecuteNonQuery();
            con.Close();
        }

    }
}
