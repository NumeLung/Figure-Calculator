namespace KursovaNEW
{
    partial class rectangle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.faceResBox = new System.Windows.Forms.TextBox();
            this.cirResBox = new System.Windows.Forms.TextBox();
            this.circBttn = new System.Windows.Forms.Button();
            this.faceBttn = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.parB = new System.Windows.Forms.TextBox();
            this.parA = new System.Windows.Forms.TextBox();
            this.draw = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(9, 337);
            this.home.Margin = new System.Windows.Forms.Padding(2);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(56, 19);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(337, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 278);
            this.panel1.TabIndex = 2;
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox.Location = new System.Drawing.Point(11, 11);
            this.txtBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(204, 13);
            this.txtBox.TabIndex = 11;
            this.txtBox.Text = "Въведете парамтри на правоъгълника";
            // 
            // faceResBox
            // 
            this.faceResBox.Location = new System.Drawing.Point(133, 275);
            this.faceResBox.Margin = new System.Windows.Forms.Padding(2);
            this.faceResBox.Name = "faceResBox";
            this.faceResBox.Size = new System.Drawing.Size(76, 20);
            this.faceResBox.TabIndex = 23;
            // 
            // cirResBox
            // 
            this.cirResBox.Location = new System.Drawing.Point(133, 299);
            this.cirResBox.Margin = new System.Windows.Forms.Padding(2);
            this.cirResBox.Name = "cirResBox";
            this.cirResBox.Size = new System.Drawing.Size(76, 20);
            this.cirResBox.TabIndex = 22;
            // 
            // circBttn
            // 
            this.circBttn.Location = new System.Drawing.Point(11, 298);
            this.circBttn.Margin = new System.Windows.Forms.Padding(2);
            this.circBttn.Name = "circBttn";
            this.circBttn.Size = new System.Drawing.Size(113, 19);
            this.circBttn.TabIndex = 21;
            this.circBttn.Text = "Изчисли обиколка";
            this.circBttn.UseVisualStyleBackColor = true;
            this.circBttn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.circBttn_MouseClick);
            // 
            // faceBttn
            // 
            this.faceBttn.Location = new System.Drawing.Point(11, 275);
            this.faceBttn.Margin = new System.Windows.Forms.Padding(2);
            this.faceBttn.Name = "faceBttn";
            this.faceBttn.Size = new System.Drawing.Size(113, 19);
            this.faceBttn.TabIndex = 20;
            this.faceBttn.Text = "Изчисли лице";
            this.faceBttn.UseVisualStyleBackColor = true;
            this.faceBttn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.faceBttn_MouseClick);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(90, 96);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 13);
            this.textBox5.TabIndex = 19;
            this.textBox5.Text = "B";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(90, 58);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 13);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "A";
            // 
            // parB
            // 
            this.parB.Location = new System.Drawing.Point(11, 94);
            this.parB.Margin = new System.Windows.Forms.Padding(2);
            this.parB.Name = "parB";
            this.parB.Size = new System.Drawing.Size(76, 20);
            this.parB.TabIndex = 17;
            this.parB.Text = "0";
            this.parB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.parB_MouseClick);
            // 
            // parA
            // 
            this.parA.Location = new System.Drawing.Point(11, 55);
            this.parA.Margin = new System.Windows.Forms.Padding(2);
            this.parA.Name = "parA";
            this.parA.Size = new System.Drawing.Size(76, 20);
            this.parA.TabIndex = 16;
            this.parA.Text = "0\r\n";
            this.parA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.parA_MouseClick);
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(420, 327);
            this.draw.Margin = new System.Windows.Forms.Padding(2);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(66, 19);
            this.draw.TabIndex = 15;
            this.draw.Text = "Draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.draw_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(446, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(16, 13);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "A";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(577, 178);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(20, 13);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "B";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.faceResBox);
            this.Controls.Add(this.cirResBox);
            this.Controls.Add(this.circBttn);
            this.Controls.Add(this.faceBttn);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.parB);
            this.Controls.Add(this.parA);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.home);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.TextBox faceResBox;
        private System.Windows.Forms.TextBox cirResBox;
        private System.Windows.Forms.Button circBttn;
        private System.Windows.Forms.Button faceBttn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox parB;
        private System.Windows.Forms.TextBox parA;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}