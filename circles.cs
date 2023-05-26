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
    public partial class circles : Form
    {
        public circles()
        {
            InitializeComponent();
        }

        //home and proper close 
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void home_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            menu f1 = new menu();
            f1.Show();
        }

        private void faceBttn_Click(object   sender, EventArgs e)
        {
            double radius = double.Parse(raduis_box.Text);
            double area;
            
            area = Math.PI * Math.Pow(radius, 2);
            faceResBox.Text = area.ToString("F2");
        }

        private void raduis_box_Click(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            textBox.SelectAll();
            textBox.Focus();
        }

        private void circBttn_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(raduis_box.Text);
            double perimeter;
            perimeter = 2 * Math.PI * radius;
            cirResBox.Text = perimeter.ToString("F2");
        }

        private void draw_Click(object sender, EventArgs e)
        {
            //избираме цвят
            Color selectedColor;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Черен":
                    selectedColor = Color.Black;
                    break;
                case "Червен":
                    selectedColor = Color.Red;
                    break;
                case "Син":
                    selectedColor = Color.Blue;
                    break;
                case "Зелен":
                    selectedColor = Color.Green;
                    break;
                default:
                    selectedColor = Color.Black;
                    break;
            }

            // взимаме радиуса
            double radius = double.Parse(raduis_box.Text); 
            // изчисли диаметъра и центъра на кординатитеее
            int diameter = (int)(2 * (radius*38));
            int centerX = (panel1.Width - diameter) / 2;
            int centerY = (panel1.Height - diameter) / 2;
            // създаваме граафичния обект
            Graphics graphics = panel1.CreateGraphics();
            SolidBrush brush = new SolidBrush(selectedColor);
            // начертаваме
            graphics.FillEllipse(brush, centerX, centerY, diameter, diameter);

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //кординатна система
            int x = e.X; 
            int y = e.Y;
            label2.Text = $"X: {x}, Y: {y}";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //чистим всичко
            panel1.Invalidate();
            raduis_box.Clear();
            faceResBox.Clear();
            cirResBox.Clear();
        }
    }
}
