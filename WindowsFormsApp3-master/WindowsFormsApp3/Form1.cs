using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginsair_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pass = txtpassword.Text;
            if (username == "mido" && pass == "123456")
            {
               //MessageBox.Show("welcome to our ggsystem");
          this.Hide();
             Form2 form2 = new Form2();  
              form2.Show();

            }
            else
            {
                MessageBox.Show("wronge user name or password");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
