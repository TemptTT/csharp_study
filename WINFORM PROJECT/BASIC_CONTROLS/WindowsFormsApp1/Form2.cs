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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");

        }

        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btnNew = new Button();
            btnNew.Text = "New button";
            btnNew.Width = 50;
            btnNew.Height = 50;

            Random rd = new Random();
            int x = rd.Next(3, 100);
            int y = rd.Next(120, 200);
            btnNew.Location = new Point(x, y);
            this.Controls.Add(btnNew);
           
        }
    }
}
