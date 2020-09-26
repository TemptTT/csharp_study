using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class f : Form
    {
        public f()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        // vari
        string userName, passWord;

        private void btnLogin_DragOver(object sender, DragEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userName = txtUsername.Text;
            passWord = txtPassword.Text;
      //      MessageBox.Show("Username: " + userName +"\n"+ "Password: " + passWord);
            Button btnLogin_Click = sender as Button;
            btnLogin_Click.BackColor = Color.Green;

        }
    }
}
