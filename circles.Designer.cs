namespace KursovaNEW
{
    partial class circles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.raduis_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.draw = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.faceResBox = new System.Windows.Forms.TextBox();
            this.cirResBox = new System.Windows.Forms.TextBox();
            this.circBttn = new System.Windows.Forms.Button();
            this.faceBttn = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(473, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 342);
            this.panel1.TabIndex = 4;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // raduis_box
            // 
            this.raduis_box.Location = new System.Drawing.Point(12, 25);
            this.raduis_box.Name = "raduis_box";
            this.raduis_box.Size = new System.Drawing.Size(100, 22);
            this.raduis_box.TabIndex = 5;
            this.raduis_box.Click += new System.EventHandler(this.raduis_box_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Радиус r";
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(473, 400);
            this.draw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(88, 23);
            this.draw.TabIndex = 17;
            this.draw.Text = "Начертай";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(574, 400);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(88, 23);
            this.clear.TabIndex = 56;
            this.clear.Text = "Изчисти";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Черен",
            "Червен",
            "Син",
            "Зелен"});
            this.comboBox1.Location = new System.Drawing.Point(667, 400);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 57;
            this.comboBox1.Text = "Черен";
            // 
            // faceResBox
            // 
            this.faceResBox.Location = new System.Drawing.Point(174, 342);
            this.faceResBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.faceResBox.Name = "faceResBox";
            this.faceResBox.Size = new System.Drawing.Size(100, 22);
            this.faceResBox.TabIndex = 62;
            // 
            // cirResBox
            // 
            this.cirResBox.Location = new System.Drawing.Point(174, 372);
            this.cirResBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cirResBox.Name = "cirResBox";
            this.cirResBox.Size = new System.Drawing.Size(100, 22);
            this.cirResBox.TabIndex = 61;
            // 
            // circBttn
            // 
            this.circBttn.Location = new System.Drawing.Point(12, 371);
            this.circBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circBttn.Name = "circBttn";
            this.circBttn.Size = new System.Drawing.Size(151, 23);
            this.circBttn.TabIndex = 60;
            this.circBttn.Text = "Изчисли обиколка";
            this.circBttn.UseVisualStyleBackColor = true;
            this.circBttn.Click += new System.EventHandler(this.circBttn_Click);
            // 
            // faceBttn
            // 
            this.faceBttn.Location = new System.Drawing.Point(12, 342);
            this.faceBttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.faceBttn.Name = "faceBttn";
            this.faceBttn.Size = new System.Drawing.Size(151, 23);
            this.faceBttn.TabIndex = 59;
            this.faceBttn.Text = "Изчисли лице";
            this.faceBttn.UseVisualStyleBackColor = true;
            this.faceBttn.Click += new System.EventHandler(this.faceBttn_Click);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(9, 419);
            this.home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 58;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click_1);
            // 
            // circles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.faceResBox);
            this.Controls.Add(this.cirResBox);
            this.Controls.Add(this.circBttn);
            this.Controls.Add(this.faceBttn);
            this.Controls.Add(this.home);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.raduis_box);
            this.Controls.Add(this.panel1);
            this.Name = "circles";
            this.Text = "Form5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox raduis_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox faceResBox;
        private System.Windows.Forms.TextBox cirResBox;
        private System.Windows.Forms.Button circBttn;
        private System.Windows.Forms.Button faceBttn;
        private System.Windows.Forms.Button home;
    }
}