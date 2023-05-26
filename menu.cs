using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaNEW
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void rect_Click(object sender, EventArgs e)
        {
            this.Hide();
            rectangle f1 = new rectangle();
            f1.Show();
        }

        private void sandbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            sandbox f3 = new sandbox();
            f3.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void multiple_Click(object sender, EventArgs e)
        {

        }

        private void triang_Click(object sender, EventArgs e)
        {
            this.Hide();
            triangle f2 = new triangle();
            f2.Show();
        }

        private void circles_Click(object sender, EventArgs e)
        {
            this.Hide();
            circles f4 = new circles();
            f4.Show();
        }
    }
}
