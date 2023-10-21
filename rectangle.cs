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
    public partial class rectangle : Form
    {
        public rectangle()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu f1 = new menu();
            f1.Show();
        }

        private void parA_MouseClick(object sender, MouseEventArgs e)
        {
            var textBox = (TextBox)sender;
            textBox.SelectAll();
            textBox.Focus();
        }

        private void parB_MouseClick(object sender, MouseEventArgs e)
        {
            var textBox = (TextBox)sender;
            textBox.SelectAll();
            textBox.Focus();
        }


        private void circBttn_MouseClick(object sender, MouseEventArgs e)
        {
            FourSided rectangle = new FourSided();
            rectangle.SideA = float.Parse(parA.Text);
            rectangle.SideB = float.Parse(parB.Text);
            rectangle.SideC = float.Parse(parA.Text); 
            rectangle.SideD = float.Parse(parB.Text); //Използван override virtual method

            float result = rectangle.CalculatePerimeter(); // Използваме CalculatePerimeter()

            cirResBox.Text = result.ToString();
        }

        private void faceBttn_MouseClick(object sender, MouseEventArgs e)
        {
            double value1 = double.Parse(parA.Text);
            double value2 = double.Parse(parB.Text);

            double result = value1 * value2;

            faceResBox.Text = result.ToString();
        }

        private void draw_MouseClick(object sender, MouseEventArgs e)
        {
            double value1 = double.Parse(parA.Text) * 37.79;
            double value2 = double.Parse(parB.Text) * 37.79;

            Graphics graphics = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            Rectangle rectangle = new Rectangle(10, 10, (int)value1, (int)value2);
            graphics.DrawRectangle(pen, rectangle);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
