namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.perimetr = new System.Windows.Forms.CheckBox();
            this.area = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.needcalcmethod = new System.Windows.Forms.Label();
            this.need_a = new System.Windows.Forms.Label();
            this.need_b = new System.Windows.Forms.Label();
            this.need_c = new System.Windows.Forms.Label();
            this.int_a = new System.Windows.Forms.Label();
            this.int_b = new System.Windows.Forms.Label();
            this.int_c = new System.Windows.Forms.Label();
            this.less_zero_a = new System.Windows.Forms.Label();
            this.less_zero_b = new System.Windows.Forms.Label();
            this.less_zero_c = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the sides of the triangle and choise  calculation method:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "c";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(44, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(44, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // perimetr
            // 
            this.perimetr.AutoSize = true;
            this.perimetr.ForeColor = System.Drawing.Color.Black;
            this.perimetr.Location = new System.Drawing.Point(12, 196);
            this.perimetr.Name = "perimetr";
            this.perimetr.Size = new System.Drawing.Size(70, 17);
            this.perimetr.TabIndex = 7;
            this.perimetr.Text = "Perimeter";
            this.perimetr.UseVisualStyleBackColor = true;
            this.perimetr.CheckedChanged += new System.EventHandler(this.perimetr_CheckedChanged);
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.ForeColor = System.Drawing.Color.Black;
            this.area.Location = new System.Drawing.Point(143, 196);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(48, 17);
            this.area.TabIndex = 8;
            this.area.Text = "Area";
            this.area.UseVisualStyleBackColor = true;
            this.area.CheckedChanged += new System.EventHandler(this.area_CheckedChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(234, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // needcalcmethod
            // 
            this.needcalcmethod.AutoSize = true;
            this.needcalcmethod.ForeColor = System.Drawing.Color.Red;
            this.needcalcmethod.Location = new System.Drawing.Point(12, 171);
            this.needcalcmethod.Name = "needcalcmethod";
            this.needcalcmethod.Size = new System.Drawing.Size(191, 13);
            this.needcalcmethod.TabIndex = 10;
            this.needcalcmethod.Text = "You need to choise calculation method";
            this.needcalcmethod.Visible = false;
            // 
            // need_a
            // 
            this.need_a.AutoSize = true;
            this.need_a.ForeColor = System.Drawing.Color.Red;
            this.need_a.Location = new System.Drawing.Point(41, 37);
            this.need_a.Name = "need_a";
            this.need_a.Size = new System.Drawing.Size(117, 13);
            this.need_a.TabIndex = 11;
            this.need_a.Text = "You need to fill the side";
            this.need_a.Visible = false;
            // 
            // need_b
            // 
            this.need_b.AutoSize = true;
            this.need_b.ForeColor = System.Drawing.Color.Red;
            this.need_b.Location = new System.Drawing.Point(44, 77);
            this.need_b.Name = "need_b";
            this.need_b.Size = new System.Drawing.Size(117, 13);
            this.need_b.TabIndex = 12;
            this.need_b.Text = "You need to fill the side";
            this.need_b.Visible = false;
            // 
            // need_c
            // 
            this.need_c.AutoSize = true;
            this.need_c.ForeColor = System.Drawing.Color.Red;
            this.need_c.Location = new System.Drawing.Point(41, 115);
            this.need_c.Name = "need_c";
            this.need_c.Size = new System.Drawing.Size(117, 13);
            this.need_c.TabIndex = 13;
            this.need_c.Text = "You need to fill the side";
            this.need_c.Visible = false;
            // 
            // int_a
            // 
            this.int_a.AutoSize = true;
            this.int_a.ForeColor = System.Drawing.Color.Red;
            this.int_a.Location = new System.Drawing.Point(44, 37);
            this.int_a.Name = "int_a";
            this.int_a.Size = new System.Drawing.Size(115, 13);
            this.int_a.TabIndex = 14;
            this.int_a.Text = "You need to fill number";
            this.int_a.Visible = false;
            // 
            // int_b
            // 
            this.int_b.AutoSize = true;
            this.int_b.ForeColor = System.Drawing.Color.Red;
            this.int_b.Location = new System.Drawing.Point(44, 77);
            this.int_b.Name = "int_b";
            this.int_b.Size = new System.Drawing.Size(115, 13);
            this.int_b.TabIndex = 15;
            this.int_b.Text = "You need to fill number";
            this.int_b.Visible = false;
            // 
            // int_c
            // 
            this.int_c.AutoSize = true;
            this.int_c.ForeColor = System.Drawing.Color.Red;
            this.int_c.Location = new System.Drawing.Point(44, 115);
            this.int_c.Name = "int_c";
            this.int_c.Size = new System.Drawing.Size(115, 13);
            this.int_c.TabIndex = 16;
            this.int_c.Text = "You need to fill number";
            this.int_c.Visible = false;
            // 
            // less_zero_a
            // 
            this.less_zero_a.AutoSize = true;
            this.less_zero_a.ForeColor = System.Drawing.Color.Red;
            this.less_zero_a.Location = new System.Drawing.Point(47, 37);
            this.less_zero_a.Name = "less_zero_a";
            this.less_zero_a.Size = new System.Drawing.Size(167, 13);
            this.less_zero_a.TabIndex = 17;
            this.less_zero_a.Text = "The side cannot be less than zero";
            this.less_zero_a.Visible = false;
            // 
            // less_zero_b
            // 
            this.less_zero_b.AutoSize = true;
            this.less_zero_b.Location = new System.Drawing.Point(44, 77);
            this.less_zero_b.Name = "less_zero_b";
            this.less_zero_b.Size = new System.Drawing.Size(167, 13);
            this.less_zero_b.TabIndex = 18;
            this.less_zero_b.Text = "The side cannot be less than zero";
            this.less_zero_b.Visible = false;
            // 
            // less_zero_c
            // 
            this.less_zero_c.AutoSize = true;
            this.less_zero_c.Location = new System.Drawing.Point(44, 115);
            this.less_zero_c.Name = "less_zero_c";
            this.less_zero_c.Size = new System.Drawing.Size(167, 13);
            this.less_zero_c.TabIndex = 19;
            this.less_zero_c.Text = "The side cannot be less than zero";
            this.less_zero_c.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 264);
            this.Controls.Add(this.less_zero_c);
            this.Controls.Add(this.less_zero_b);
            this.Controls.Add(this.less_zero_a);
            this.Controls.Add(this.int_c);
            this.Controls.Add(this.int_b);
            this.Controls.Add(this.int_a);
            this.Controls.Add(this.need_c);
            this.Controls.Add(this.need_b);
            this.Controls.Add(this.need_a);
            this.Controls.Add(this.needcalcmethod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.area);
            this.Controls.Add(this.perimetr);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form2";
            this.Text = "Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox perimetr;
        private System.Windows.Forms.CheckBox area;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label needcalcmethod;
        private System.Windows.Forms.Label need_a;
        private System.Windows.Forms.Label need_b;
        private System.Windows.Forms.Label need_c;
        private System.Windows.Forms.Label int_a;
        private System.Windows.Forms.Label int_b;
        private System.Windows.Forms.Label int_c;
        private System.Windows.Forms.Label less_zero_a;
        private System.Windows.Forms.Label less_zero_b;
        private System.Windows.Forms.Label less_zero_c;
    }
}