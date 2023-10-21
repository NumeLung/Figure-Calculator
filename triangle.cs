using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Windows.Forms;

namespace KursovaNEW
{
    public partial class triangle : Form
    {
        public triangle()
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

        //click selection parameters
        private void par_Click(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            textBox.SelectAll();
            textBox.Focus();
        }

        //click selection angles
        private void angl_Click(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            textBox.SelectAll();
            textBox.Focus();
        }

        //prawim inactive butonite sus zadadeni stoinosti
        private void parA_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parA.Text))
            {
                findA.Enabled = true;
            }
            else
            {
                findA.Enabled = false;
            }
        }
        private void parB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parB.Text))
            {
                findB.Enabled = true;
            }
            else
            {
                findB.Enabled = false;
            }
        }
        private void parC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parC.Text))
            {
                findC.Enabled = true;
            }
            else
            {
                findC.Enabled = false;
            }
        }
        private void anglA_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(anglA.Text))
            {
                FindAlpha.Enabled = true;
            }
            else
            {
                FindAlpha.Enabled = false;
            }
        }
        private void anglB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(anglB.Text))
            {
                FindBeta.Enabled = true;
            }
            else
            {
                FindBeta.Enabled = false;
            }
        }
        private void anglG_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(anglG.Text))
            {
                FindGamma.Enabled = true;
            }
            else
            {
                FindGamma.Enabled = false;
            }
        }

        //find side buttons
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parB.Text))
            {
                MessageBox.Show("Грешка parB е празен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early to prevent further execution
            }
            double sideB = double.Parse(parB.Text);
            double sideC = double.Parse(parC.Text);
            double angle;
            
            //трябва да добавя клик евент на C ако няма придоставен ъгъл alpha
            if (string.IsNullOrEmpty(anglA.Text))
            {
                MessageBox.Show("Напишете ъгъл Alpha.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                angle = double.Parse(anglA.Text);
            }

            double sideA = Math.Sqrt(Math.Pow(sideB, 2) + Math.Pow(sideC, 2) - 2 * sideB * sideC * Math.Cos(angle * Math.PI / 180));
            string formattedsideA = string.Format("{0:0.00}", sideA);

            parA.Text = formattedsideA;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parA.Text))
            {
                MessageBox.Show("Грепка parА е празен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early to prevent further execution
            }
            double sideA = double.Parse(parA.Text);
            double sideC = double.Parse(parC.Text);
            double angle;
            //клик евент на C ако няма придоставен ъгъл beta
            if (string.IsNullOrEmpty(anglB.Text))
            {
                MessageBox.Show("Напишете ъгъл Бета.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                angle = double.Parse(anglB.Text);
            }
            double sideB = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideC, 2) - 2 * sideA * sideC * Math.Cos(angle * Math.PI / 180));
            string formattedsideB = string.Format("{0:0.00}", sideB);

            parB.Text = formattedsideB;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parA.Text))
            {
                MessageBox.Show("Грепка parA е празен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early to prevent further execution
            }
            double sideA = double.Parse(parA.Text);
            double sideB = double.Parse(parB.Text);
            double angle;
            //клик евент в случай че липсва ъгъл
            if (string.IsNullOrEmpty(anglG.Text))
            {
                MessageBox.Show("Напишете ъгъл Гама.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                angle = double.Parse(anglG.Text);
            }

            double sideC = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - 2 * sideA * sideB * Math.Cos(angle * Math.PI / 180));
            string formattedsideC = string.Format("{0:0.00}", sideC);

            parC.Text = formattedsideC;
        }

        //намираме височини
        private void but_height_A_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parA.Text))
            {
                MessageBox.Show("Липасва параметър", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early to prevent further execution
            }
            double sideA = double.Parse(parA.Text);
            double face;
            if (string.IsNullOrEmpty(faceResBox.Text))
            {
                MessageBox.Show("Моля изчислете лицето", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                face = double.Parse(faceResBox.Text);
            }
            double heightA = (2 * face) / sideA;
            height_A.Text = heightA.ToString("F2");   
        }

        private void but_height_B_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parB.Text))
            {
                MessageBox.Show("Липасва параметър", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early to prevent further execution
            }
            double sideB = double.Parse(parB.Text);
            double face;
            if (string.IsNullOrEmpty(faceResBox.Text))
            {
                MessageBox.Show("Моля изчислете лицето", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                face = double.Parse(faceResBox.Text);
            }
            double heightB = (2 * face) / sideB;
            height_B.Text = heightB.ToString("F2");
        }

        private void but_height_C_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parC.Text))
            {
                MessageBox.Show("Липасва параметър", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early to prevent further execution
            }
            double sideC = double.Parse(parC.Text);
            double face;
            if (string.IsNullOrEmpty(faceResBox.Text))
            {
                MessageBox.Show("Моля изчислете лицето", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                face = double.Parse(faceResBox.Text);
            }
            double heightC = (2 * face) / sideC;
            height_C.Text = heightC.ToString("F2");
        }

        //намиране на ъглите
        private void FindAlpha_Click(object sender, EventArgs e)
        {
            ThreeSided triangle = new ThreeSided();
            if (string.IsNullOrEmpty(parA.Text))
            {
                MessageBox.Show("Липасва параметър", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early to prevent further execution
            }
            double SideA = double.Parse(parA.Text);
            double SideB = double.Parse(parB.Text);
            double SideC = double.Parse(parC.Text);
            double angleA = Math.Acos((SideB * SideB + SideC * SideC - SideA * SideA) / (2 * SideB * SideC)) * 180 / Math.PI;
            anglA.Text = angleA.ToString("F0");
        }

        private void FindBeta_Click(object sender, EventArgs e)
        {
            ThreeSided triangle = new ThreeSided();
            if (string.IsNullOrEmpty(parA.Text))
            {
                MessageBox.Show("Липасва параметър", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early to prevent further execution
            }
            double SideA = double.Parse(parA.Text);
            double SideB = double.Parse(parB.Text);
            double SideC = double.Parse(parC.Text);
            double angleA = Math.Acos((SideA * SideA + SideC * SideC - SideB * SideB) / (2 * SideA * SideC)) * 180 / Math.PI;
            anglB.Text = angleA.ToString("F0");
        }

        private void FindGamma_Click(object sender, EventArgs e)
        {
            ThreeSided triangle = new ThreeSided();
            if (string.IsNullOrEmpty(parA.Text))
            {
                MessageBox.Show("Липасва параметър", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            double SideA = double.Parse(parA.Text);
            double SideB = double.Parse(parB.Text);
            double SideC = double.Parse(parC.Text);
            double angleA = Math.Acos((SideA * SideA + SideC * SideB - SideC * SideC) / (2 * SideA * SideB)) * 180 / Math.PI;
            anglG.Text = angleA.ToString("F0");
        }

        //лице и обиколка
        private void faceBttn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parA.Text))
            {
                MessageBox.Show("Липасва параметър", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            double sideA = double.Parse(parA.Text);
            double sideB = double.Parse(parB.Text);
            double angleC = double.Parse(anglG.Text);

            // Convert the angle from degrees to radians
            double angleCRadians = angleC * Math.PI / 180;

            double area = (sideA * sideB * Math.Sin(angleCRadians)) / 2;

            faceResBox.Text = area.ToString("F2");
        }
        private void circBttn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(parA.Text))
            {
                MessageBox.Show("Липасва параметър", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            ThreeSided triangle = new ThreeSided();
            triangle.SideA = float.Parse(parA.Text);
            triangle.SideB = float.Parse(parB.Text);
            triangle.SideC = float.Parse(parC.Text);
            //изплозваме виртуалния метод
            float result = triangle.CalculatePerimeter();

            cirResBox.Text = result.ToString();
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
                    selectedColor = Color.Black; // По подразбиране изберете черен цвят
                    break;
            }

            Graphics plain;
            plain = panel1.CreateGraphics();
            SolidBrush brush = new SolidBrush(selectedColor);

            // Взимане на стойностите на страните на триъгълника от текстовите кутии и конвертиране в пиксели
            if (string.IsNullOrEmpty(parA.Text))
            {
                MessageBox.Show("Грешка, въведете параметри", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //използваме от класа страните
            ThreeSided triangle = new ThreeSided();
            triangle.SideA = float.Parse(parA.Text);
            triangle.SideB = float.Parse(parB.Text);
            triangle.SideC = float.Parse(parC.Text);

            int pixelsPerCm = 38; // Съотношението между сантиметри и пиксели

            // Конвертиране на стойностите от сантиметри в пиксели
            float side1 = triangle.SideA * pixelsPerCm;
            float side2 = triangle.SideB * pixelsPerCm;
            float side3 = triangle.SideC * pixelsPerCm;

            // Изчисляване на полупериметъра на триъгълника
            float semiperimeter = (side1 + side2 + side3) / 2.0f;

            // Изчисляване на площа на триъгълника по формулата на Херон
            float area = (float)Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));

            // Изчисляване на височината на триъгълника
            float height = (2 * area) / side1;

            float offsetX = (panel1.Width - side1) / 2;
            float offsetY = (panel1.Height - (float)height) / 2;

            float x1 = offsetX;
            float y1 = offsetY;
            float x2 = side1 + offsetX;
            float y2 = offsetY;
            float x3 = (float)((Math.Pow(side2, 2) + Math.Pow(side1, 2) - Math.Pow(side3, 2)) / (2 * side1)) + offsetX;
            float y3 = (float)height + offsetY;


            // Създаване на масив от точките на триъгълника
            PointF[] points = { new PointF(x1, y1), new PointF(x2, y2), new PointF(x3, y3) };

            // Рисуване на пълния триъгълник
            plain.FillPolygon(brush, points);


        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y; 
            label2.Text = $"X: {x}, Y: {y}";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void clear_MouseClick(object sender, MouseEventArgs e)
        {
            parA.Clear();
            parB.Clear();
            parC.Clear();
            anglA.Clear(); 
            anglB.Clear();
            anglG.Clear();
            height_A.Clear();
            height_B.Clear();
            height_C.Clear();
        }

        private void parA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}