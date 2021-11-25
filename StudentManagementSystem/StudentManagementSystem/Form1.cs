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

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        //Coding by Tolga BAYRAK
        //Basic StudentSystem

        void GridDoldur()
        {
            
            con = new SqlConnection("Data Source=.;Initial Catalog=school;Integrated Security=True");
            da = new SqlDataAdapter("Select * from student", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "student");
            dataGridView1.DataSource = ds.Tables["student"];
            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into student(student_no,student_name,student_surname)'";
            cmd.ExecuteNonQuery();
            con.Close();
            GridDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection=con;
            cmd.CommandText ="update student set student_ad='" + textBox1.Text + "'student_name='" + textBox2.Text + "'student_surname='"+ textBox3.Text + "'student_no='" ;
            cmd.ExecuteNonQuery();
            con.Close();
            GridDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
