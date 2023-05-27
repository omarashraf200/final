using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using our system");
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelconter4.ForeColor = System.Drawing.Color.Red;
            labelconter2.ForeColor = System.Drawing.Color.Black;
            labelconter3.ForeColor = System.Drawing.Color.Black;
            labelconter1.ForeColor = System.Drawing.Color.Black;


        }

        private void btnaddpt_Click(object sender, EventArgs e)
        {
            labelconter1.ForeColor = System.Drawing.Color.Red;
            labelconter2.ForeColor = System.Drawing.Color.Black;
            labelconter3.ForeColor = System.Drawing.Color.Black;

            labelconter4.ForeColor = System.Drawing.Color.Black;
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void btnAddstaf_Click(object sender, EventArgs e)
        {
            labelconter2.ForeColor = System.Drawing.Color.Red;
            labelconter1.ForeColor = System.Drawing.Color.Black;
            labelconter3.ForeColor = System.Drawing.Color.Black;
            labelconter4.ForeColor = System.Drawing.Color.Black;
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = false;



        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            labelconter3.ForeColor = System.Drawing.Color.Red;
            labelconter2.ForeColor = System.Drawing.Color.Black;
            labelconter1.ForeColor = System.Drawing.Color.Black;
            labelconter4.ForeColor = System.Drawing.Color.Black;
     
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Addpatient inner join patientMore on Addpatient.pid=patientMore.pid", con);
            cmd.Parameters.AddWithValue("pid", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = DS.Tables[0];


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public string conString = "Data Source=DESKTOP-AICMDV2\\SQLEXPRESS;Initial Catalog=healthcare;Integrated Security=True";
        private object panel3;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textName.Text;
                string address = textAddress.Text;
                Int64 contact = Convert.ToInt64(textContactNumber.Text);
                int age = Convert.ToInt32(textAge.Text);
                string gender = comboGender.Text;
                string blood = textBloodGroup.Text;
                string any = textAny.Text;
                int pid = Convert.ToInt32(textPid.Text);
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string q = "insert into test2(name,address,contact,age,gender,blood,pid)values('" + textName.Text + "','" + textAddress.Text + "','" + textContactNumber.Text.ToString() + "','" + textAge.Text.ToString() + "','" + comboGender.Text + "','" + textBloodGroup.Text + "','" + textPid.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    //cmd.CommandText = "INSERT INTO Patients (Name, Full_Address, Contact, Age, Gender, Blood_Group, Major_Disease, pid) " +
                    //"VALUES (@Name, @Full_Address, @Contact, @Age, @Gender, @Blood_Group, @Major_Disease, @pid)";

                }
                MessageBox.Show("Data saved successfully!");
                textName.Clear();
                textAddress.Clear();
                textAge.Clear();
                textContactNumber.Clear();
                textBloodGroup.Clear();
                textAny.Clear();
                textPid.Clear();
                comboGender.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the data: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from test2 where pid=@pid",con);
                cmd.Parameters.AddWithValue("pid", int.Parse(textBox1.Text));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(textBox1.Text);
                string symptom = textBox2.Text;
                string diagnosis = textBox5.Text;
                string medicens = textBox3.Text;
                string ward = comboBox1.Text;
                string type = comboBox2.Text;

                SqlConnection con = new SqlConnection(conString);
                con.Open();
                if (con.State == ConnectionState.Open)
                {

                    string q = "insert into test3 (pid,symptom,diagnosis,medicens,ward,type)values('" + textBox1.Text.ToString() + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();

                }
            }
            catch(Exception)
            {
                MessageBox.Show("any field is empty OR data is wrong format.");   
            }
            MessageBox.Show("succefully added");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    } 
}