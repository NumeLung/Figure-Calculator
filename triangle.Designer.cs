namespace KursovaNEW
{
    partial class triangle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(triangle));
            this.faceResBox = new System.Windows.Forms.TextBox();
            this.cirResBox = new System.Windows.Forms.TextBox();
            this.circBttn = new System.Windows.Forms.Button();
            this.faceBttn = new System.Windows.Forms.Button();
            this.parB = new System.Windows.Forms.TextBox();
            this.parA = new System.Windows.Forms.TextBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.home = new System.Windows.Forms.Button();
            this.parC = new System.Windows.Forms.TextBox();
            this.findA = new System.Windows.Forms.Button();
            this.findB = new System.Windows.Forms.Button();
            this.findC = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.anglG = new System.Windows.Forms.TextBox();
            this.anglB = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.anglA = new System.Windows.Forms.TextBox();
            this.FindGamma = new System.Windows.Forms.Button();
            this.FindBeta = new System.Windows.Forms.Button();
            this.FindAlpha = new System.Windows.Forms.Button();
            this.draw = new System.Windows.Forms.Button();
            this.but_height_A = new System.Windows.Forms.Button();
            this.but_height_B = new System.Windows.Forms.Button();
            this.but_height_C = new System.Windows.Forms.Button();
            this.height_C = new System.Windows.Forms.TextBox();
            this.height_B = new System.Windows.Forms.TextBox();
            this.height_A = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // faceResBox
            // 
            this.faceResBox.Location = new System.Drawing.Point(177, 338);
            this.faceResBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.faceResBox.Name = "faceResBox";
            this.faceResBox.Size = new System.Drawing.Size(100, 22);
            this.faceResBox.TabIndex = 33;
            // 
            // cirResBox
            // 
            this.cirResBox.Location = new System.Drawing.Point(177, 368);
            this.cirResBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cirResBox.Name = "cirResBox";
            this.cirResBox.Size = new System.Drawing.Size(100, 22);
            this.cirResBox.TabIndex = 32;
            // 
            // circBttn
            // 
            this.circBttn.Location = new System.Drawing.Point(15, 367);
            this.circBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circBttn.Name = "circBttn";
            this.circBttn.Size = new System.Drawing.Size(151, 23);
            this.circBttn.TabIndex = 31;
            this.circBttn.Text = "Изчисли обиколка";
            this.circBttn.UseVisualStyleBackColor = true;
            this.circBttn.Click += new System.EventHandler(this.circBttn_Click);
            // 
            // faceBttn
            // 
            this.faceBttn.Location = new System.Drawing.Point(15, 338);
            this.faceBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.faceBttn.Name = "faceBttn";
            this.faceBttn.Size = new System.Drawing.Size(151, 23);
            this.faceBttn.TabIndex = 30;
            this.faceBttn.Text = "Изчисли лице";
            this.faceBttn.UseVisualStyleBackColor = true;
            this.faceBttn.Click += new System.EventHandler(this.faceBttn_Click);
            // 
            // parB
            // 
            this.parB.Location = new System.Drawing.Point(15, 89);
            this.parB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parB.Name = "parB";
            this.parB.Size = new System.Drawing.Size(100, 22);
            this.parB.TabIndex = 27;
            this.parB.Click += new System.EventHandler(this.par_Click);
            this.parB.TextChanged += new System.EventHandler(this.parB_TextChanged);
            // 
            // parA
            // 
            this.parA.Location = new System.Drawing.Point(15, 41);
            this.parA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parA.Name = "parA";
            this.parA.Size = new System.Drawing.Size(100, 22);
            this.parA.TabIndex = 26;
            this.parA.Click += new System.EventHandler(this.par_Click);
            this.parA.TextChanged += new System.EventHandler(this.parA_TextChanged);
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.SystemColors.Menu;
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox.Location = new System.Drawing.Point(15, 14);
            this.txtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(272, 15);
            this.txtBox.TabIndex = 25;
            this.txtBox.Text = "Въведете парамтри на триъгълника";
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(12, 415);
            this.home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 24;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click_1);
            // 
            // parC
            // 
            this.parC.Location = new System.Drawing.Point(15, 137);
            this.parC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parC.Name = "parC";
            this.parC.Size = new System.Drawing.Size(100, 22);
            this.parC.TabIndex = 34;
            this.parC.Click += new System.EventHandler(this.par_Click);
            this.parC.TextChanged += new System.EventHandler(this.parC_TextChanged);
            // 
            // findA
            // 
            this.findA.Location = new System.Drawing.Point(123, 41);
            this.findA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findA.Name = "findA";
            this.findA.Size = new System.Drawing.Size(88, 25);
            this.findA.TabIndex = 36;
            this.findA.Text = "Намери А";
            this.findA.UseVisualStyleBackColor = true;
            this.findA.Click += new System.EventHandler(this.button2_Click);
            // 
            // findB
            // 
            this.findB.Location = new System.Drawing.Point(123, 89);
            this.findB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findB.Name = "findB";
            this.findB.Size = new System.Drawing.Size(88, 25);
            this.findB.TabIndex = 37;
            this.findB.Text = "Намери B";
            this.findB.UseVisualStyleBackColor = true;
            this.findB.Click += new System.EventHandler(this.button3_Click);
            // 
            // findC
            // 
            this.findC.Location = new System.Drawing.Point(123, 135);
            this.findC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findC.Name = "findC";
            this.findC.Size = new System.Drawing.Size(88, 25);
            this.findC.TabIndex = 38;
            this.findC.Text = "Намери C";
            this.findC.UseVisualStyleBackColor = true;
            this.findC.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(339, 212);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 15);
            this.textBox1.TabIndex = 44;
            this.textBox1.Text = "γ\t";
            // 
            // anglG
            // 
            this.anglG.Location = new System.Drawing.Point(233, 210);
            this.anglG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anglG.Name = "anglG";
            this.anglG.Size = new System.Drawing.Size(95, 22);
            this.anglG.TabIndex = 43;
            this.anglG.Click += new System.EventHandler(this.angl_Click);
            this.anglG.TextChanged += new System.EventHandler(this.anglG_TextChanged);
            // 
            // anglB
            // 
            this.anglB.Location = new System.Drawing.Point(233, 162);
            this.anglB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anglB.Name = "anglB";
            this.anglB.Size = new System.Drawing.Size(95, 22);
            this.anglB.TabIndex = 40;
            this.anglB.Click += new System.EventHandler(this.angl_Click);
            this.anglB.TextChanged += new System.EventHandler(this.anglB_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(339, 164);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(95, 15);
            this.textBox7.TabIndex = 42;
            this.textBox7.Text = "β";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(339, 117);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(95, 15);
            this.textBox8.TabIndex = 41;
            this.textBox8.Text = "α";
            // 
            // anglA
            // 
            this.anglA.Location = new System.Drawing.Point(233, 114);
            this.anglA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anglA.Name = "anglA";
            this.anglA.Size = new System.Drawing.Size(95, 22);
            this.anglA.TabIndex = 39;
            this.anglA.Click += new System.EventHandler(this.angl_Click);
            this.anglA.TextChanged += new System.EventHandler(this.anglA_TextChanged);
            // 
            // FindGamma
            // 
            this.FindGamma.Location = new System.Drawing.Point(355, 209);
            this.FindGamma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FindGamma.Name = "FindGamma";
            this.FindGamma.Size = new System.Drawing.Size(88, 25);
            this.FindGamma.TabIndex = 47;
            this.FindGamma.Text = "Намери γ";
            this.FindGamma.UseVisualStyleBackColor = true;
            this.FindGamma.Click += new System.EventHandler(this.FindGamma_Click);
            // 
            // FindBeta
            // 
            this.FindBeta.Location = new System.Drawing.Point(355, 161);
            this.FindBeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FindBeta.Name = "FindBeta";
            this.FindBeta.Size = new System.Drawing.Size(88, 25);
            this.FindBeta.TabIndex = 46;
            this.FindBeta.Text = "Намери β\t";
            this.FindBeta.UseVisualStyleBackColor = true;
            this.FindBeta.Click += new System.EventHandler(this.FindBeta_Click);
            // 
            // FindAlpha
            // 
            this.FindAlpha.Location = new System.Drawing.Point(355, 114);
            this.FindAlpha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FindAlpha.Name = "FindAlpha";
            this.FindAlpha.Size = new System.Drawing.Size(88, 25);
            this.FindAlpha.TabIndex = 45;
            this.FindAlpha.Text = "Намери α";
            this.FindAlpha.UseVisualStyleBackColor = true;
            this.FindAlpha.Click += new System.EventHandler(this.FindAlpha_Click);
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(465, 396);
            this.draw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(88, 23);
            this.draw.TabIndex = 16;
            this.draw.Text = "Начертай";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // but_height_A
            // 
            this.but_height_A.Location = new System.Drawing.Point(15, 183);
            this.but_height_A.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_height_A.Name = "but_height_A";
            this.but_height_A.Size = new System.Drawing.Size(88, 25);
            this.but_height_A.TabIndex = 48;
            this.but_height_A.Text = "Вис.->А";
            this.but_height_A.UseVisualStyleBackColor = true;
            this.but_height_A.Click += new System.EventHandler(this.but_height_A_Click);
            // 
            // but_height_B
            // 
            this.but_height_B.Location = new System.Drawing.Point(15, 231);
            this.but_height_B.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_height_B.Name = "but_height_B";
            this.but_height_B.Size = new System.Drawing.Size(88, 25);
            this.but_height_B.TabIndex = 49;
            this.but_height_B.Text = "Вис.->B";
            this.but_height_B.UseVisualStyleBackColor = true;
            this.but_height_B.Click += new System.EventHandler(this.but_height_B_Click);
            // 
            // but_height_C
            // 
            this.but_height_C.Location = new System.Drawing.Point(15, 281);
            this.but_height_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_height_C.Name = "but_height_C";
            this.but_height_C.Size = new System.Drawing.Size(88, 25);
            this.but_height_C.TabIndex = 50;
            this.but_height_C.Text = "Вис.->C";
            this.but_height_C.UseVisualStyleBackColor = true;
            this.but_height_C.Click += new System.EventHandler(this.but_height_C_Click);
            // 
            // height_C
            // 
            this.height_C.Location = new System.Drawing.Point(109, 281);
            this.height_C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.height_C.Name = "height_C";
            this.height_C.Size = new System.Drawing.Size(100, 22);
            this.height_C.TabIndex = 53;
            // 
            // height_B
            // 
            this.height_B.Location = new System.Drawing.Point(109, 233);
            this.height_B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.height_B.Name = "height_B";
            this.height_B.Size = new System.Drawing.Size(100, 22);
            this.height_B.TabIndex = 52;
            // 
            // height_A
            // 
            this.height_A.Location = new System.Drawing.Point(109, 185);
            this.height_A.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.height_A.Name = "height_A";
            this.height_A.Size = new System.Drawing.Size(100, 22);
            this.height_A.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(465, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 342);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Черен",
            "Червен",
            "Син",
            "Зелен"});
            this.comboBox1.Location = new System.Drawing.Point(659, 395);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 54;
            this.comboBox1.Text = "Черен";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(565, 396);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(88, 23);
            this.clear.TabIndex = 55;
            this.clear.Text = "Изчисти";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            this.clear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clear_MouseClick);
            // 
            // triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.findC);
            this.Controls.Add(this.findB);
            this.Controls.Add(this.findA);
            this.Controls.Add(this.parC);
            this.Controls.Add(this.parB);
            this.Controls.Add(this.parA);
            this.Controls.Add(this.height_C);
            this.Controls.Add(this.height_B);
            this.Controls.Add(this.height_A);
            this.Controls.Add(this.but_height_C);
            this.Controls.Add(this.but_height_B);
            this.Controls.Add(this.but_height_A);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.FindGamma);
            this.Controls.Add(this.FindBeta);
            this.Controls.Add(this.FindAlpha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.anglG);
            this.Controls.Add(this.anglB);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.anglA);
            this.Controls.Add(this.faceResBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cirResBox);
            this.Controls.Add(this.circBttn);
            this.Controls.Add(this.faceBttn);
            this.Controls.Add(this.home);
            this.Controls.Add(this.txtBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "triangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Триъгълен калкулатор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox faceResBox;
        private System.Windows.Forms.TextBox cirResBox;
        private System.Windows.Forms.Button circBttn;
        private System.Windows.Forms.Button faceBttn;
        private System.Windows.Forms.TextBox parB;
        private System.Windows.Forms.TextBox parA;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.TextBox parC;
        private System.Windows.Forms.Button findA;
        private System.Windows.Forms.Button findB;
        private System.Windows.Forms.Button findC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox anglG;
        private System.Windows.Forms.TextBox anglB;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox anglA;
        private System.Windows.Forms.Button FindGamma;
        private System.Windows.Forms.Button FindBeta;
        private System.Windows.Forms.Button FindAlpha;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Button but_height_A;
        private System.Windows.Forms.Button but_height_B;
        private System.Windows.Forms.Button but_height_C;
        private System.Windows.Forms.TextBox height_C;
        private System.Windows.Forms.TextBox height_B;
        private System.Windows.Forms.TextBox height_A;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button clear;
    }
}