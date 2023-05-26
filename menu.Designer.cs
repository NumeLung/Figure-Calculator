namespace KursovaNEW
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rect = new System.Windows.Forms.Button();
            this.elipse = new System.Windows.Forms.Button();
            this.circles = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.sandbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(600, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Изберете опция:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rect
            // 
            this.rect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rect.Location = new System.Drawing.Point(243, 91);
            this.rect.Margin = new System.Windows.Forms.Padding(2);
            this.rect.Name = "rect";
            this.rect.Size = new System.Drawing.Size(103, 24);
            this.rect.TabIndex = 1;
            this.rect.Text = "Четириъгълници";
            this.rect.UseVisualStyleBackColor = true;
            this.rect.Click += new System.EventHandler(this.rect_Click);
            // 
            // elipse
            // 
            this.elipse.Location = new System.Drawing.Point(243, 119);
            this.elipse.Margin = new System.Windows.Forms.Padding(2);
            this.elipse.Name = "elipse";
            this.elipse.Size = new System.Drawing.Size(103, 24);
            this.elipse.TabIndex = 2;
            this.elipse.Text = "Триъгълници";
            this.elipse.UseVisualStyleBackColor = true;
            this.elipse.Click += new System.EventHandler(this.triang_Click);
            // 
            // circles
            // 
            this.circles.Location = new System.Drawing.Point(243, 147);
            this.circles.Margin = new System.Windows.Forms.Padding(2);
            this.circles.Name = "circles";
            this.circles.Size = new System.Drawing.Size(103, 24);
            this.circles.TabIndex = 3;
            this.circles.Text = "Окръжности";
            this.circles.UseVisualStyleBackColor = true;
            this.circles.Click += new System.EventHandler(this.circles_Click);
            // 
            // multiple
            // 
            this.multiple.Location = new System.Drawing.Point(243, 175);
            this.multiple.Margin = new System.Windows.Forms.Padding(2);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(103, 24);
            this.multiple.TabIndex = 5;
            this.multiple.Text = "Многоъгълници";
            this.multiple.UseVisualStyleBackColor = true;
            this.multiple.Click += new System.EventHandler(this.multiple_Click);
            // 
            // sandbox
            // 
            this.sandbox.Location = new System.Drawing.Point(243, 203);
            this.sandbox.Margin = new System.Windows.Forms.Padding(2);
            this.sandbox.Name = "sandbox";
            this.sandbox.Size = new System.Drawing.Size(103, 24);
            this.sandbox.TabIndex = 6;
            this.sandbox.Text = "Sandbox ";
            this.sandbox.UseVisualStyleBackColor = true;
            this.sandbox.Click += new System.EventHandler(this.sandbox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.sandbox);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.circles);
            this.Controls.Add(this.elipse);
            this.Controls.Add(this.rect);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калкулатор на фигури";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button rect;
        private System.Windows.Forms.Button elipse;
        private System.Windows.Forms.Button circles;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button sandbox;
    }
}

