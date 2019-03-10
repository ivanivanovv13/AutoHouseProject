using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoHouse
{
    public partial class Form1 : Form
    {
       Controller test = new Controller();
        bool f = false;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test.Fill();
            foreach(Users a in test.MyList)
            {
                if (a.Username==textBox1.Text && a.Password==textBox2.Text)
                {
                    f = true;
                }
                else
                {
                    f = false;
                }
            }
            CorrectLogin();
        }

        public void CorrectLogin()
        {
            if(f==true)
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
                DialogResult erorr;
                erorr = MessageBox.Show("Incorrect username or password", "Erorr", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (erorr == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Clear();
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Clear();
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            if (textBox2.Text== "Password" ) textBox2.PasswordChar = '\0';
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Gray;
            label3.BackColor = Color.White;
            if (pictureBox4.Visible==false) pictureBox4.Visible = true;
            lblReg.Visible = false;
            button1.Text = "LogIn";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            
            textBox1.Text = "Username";
            textBox2.Text = "Password";
            label3.BackColor = Color.Gray;
            label1.BackColor = Color.White;
            if (pictureBox4.Visible) pictureBox4.Visible = false;
            lblReg.Visible = true;
            button1.Text = "Create";
        }
    }
}
