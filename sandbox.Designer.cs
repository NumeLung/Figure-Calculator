namespace KursovaNEW
{
    partial class sandbox
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
            this.draw = new System.Windows.Forms.Button();
            this.parC = new System.Windows.Forms.TextBox();
            this.parB = new System.Windows.Forms.TextBox();
            this.parA = new System.Windows.Forms.TextBox();
            this.home = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.draw);
            this.panel1.Controls.Add(this.parC);
            this.panel1.Controls.Add(this.parB);
            this.panel1.Controls.Add(this.parA);
            this.panel1.Controls.Add(this.home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 742);
            this.panel1.TabIndex = 0;
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(112, 705);
            this.draw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(88, 23);
            this.draw.TabIndex = 38;
            this.draw.Text = "Draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // parC
            // 
            this.parC.Location = new System.Drawing.Point(33, 245);
            this.parC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parC.Name = "parC";
            this.parC.Size = new System.Drawing.Size(100, 22);
            this.parC.TabIndex = 37;
            // 
            // parB
            // 
            this.parB.Location = new System.Drawing.Point(33, 197);
            this.parB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parB.Name = "parB";
            this.parB.Size = new System.Drawing.Size(100, 22);
            this.parB.TabIndex = 36;
            // 
            // parA
            // 
            this.parA.Location = new System.Drawing.Point(33, 149);
            this.parA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parA.Name = "parA";
            this.parA.Size = new System.Drawing.Size(100, 22);
            this.parA.TabIndex = 35;
            // 
            // home
            // 
            this.home.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.home.Location = new System.Drawing.Point(15, 705);
            this.home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(75, 23);
            this.home.TabIndex = 1;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // sandbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 742);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "sandbox";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.TextBox parC;
        private System.Windows.Forms.TextBox parB;
        private System.Windows.Forms.TextBox parA;
        private System.Windows.Forms.Button draw;
    }
}