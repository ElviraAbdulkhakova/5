namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.calc_method = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Result);
            this.panel1.Controls.Add(this.calc_method);
            this.panel1.Controls.Add(this.c);
            this.panel1.Controls.Add(this.b);
            this.panel1.Controls.Add(this.a);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 166);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // calc_method
            // 
            this.calc_method.AutoSize = true;
            this.calc_method.Location = new System.Drawing.Point(14, 111);
            this.calc_method.Name = "calc_method";
            this.calc_method.Size = new System.Drawing.Size(100, 13);
            this.calc_method.TabIndex = 4;
            this.calc_method.Text = "Calculation method:";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(17, 91);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(40, 13);
            this.c.TabIndex = 3;
            this.c.Text = "Side c:";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(17, 66);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(40, 13);
            this.b.TabIndex = 2;
            this.b.Text = "Side b:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(17, 41);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(40, 13);
            this.a.TabIndex = 1;
            this.a.Text = "Side a:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "You entered:";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(17, 134);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(40, 13);
            this.Result.TabIndex = 5;
            this.Result.Text = "Result:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Calc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label calc_method;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Result;
    }
}