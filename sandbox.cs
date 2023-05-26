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
    public partial class sandbox : Form
    {
        public sandbox()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu f1 = new menu();
            f1.Show();
        }
        private void draw_Click(object sender, EventArgs e)
        {
            // Get the side lengths from the textboxes
            if (int.TryParse(parA.Text, out int a) && int.TryParse(parB.Text, out int b) && int.TryParse(parC.Text, out int c))
            {
                // Check if the entered sides can form a triangle
                if (a + b > c && a + c > b && b + c > a)
                {
                    // Clear any previous drawings
                    panel1.Invalidate();

                    // Create a Graphics object from the panel
                    using (Graphics g = panel1.CreateGraphics())
                    {
                        // Define the points for the triangle
                        Point pointA = new Point(10, 10);
                        Point pointB = new Point(10 + a, 10);
                        Point pointC = new Point(10 + (a + b) / 2, 10 + (int)Math.Sqrt((double)(a * a) - ((a + b) / 2) * ((a + b) / 2)));

                        // Draw the triangle
                        g.DrawLine(Pens.Black, pointA, pointB);
                        g.DrawLine(Pens.Black, pointB, pointC);
                        g.DrawLine(Pens.Black, pointC, pointA);
                    }
                }
                else
                {
                    MessageBox.Show("The entered side lengths cannot form a triangle.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid side length(s). Please enter numeric values.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
