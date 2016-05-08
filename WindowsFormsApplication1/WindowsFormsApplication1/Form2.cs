using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using triangle = WindowsFormsApplication1.Program.Triangle;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void perimetr_CheckedChanged(object sender, EventArgs e)
        {
            if (perimetr.Checked == true) 
            { 
                area.Enabled = false;
                needcalcmethod.Visible = false;
                triangle.is_perimetr = true;
                triangle.is_area = false;
            }
            else if (area.Enabled == false) area.Enabled = true;
        }

        private void area_CheckedChanged(object sender, EventArgs e)
        {
            if (area.Checked == true) 
            {
                perimetr.Enabled = false;
                needcalcmethod.Visible = false;
                triangle.is_perimetr = false;
                triangle.is_area = true;
            }
                
            else if (perimetr.Enabled == false) perimetr.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //a, b, c - variables to save numeric value of triangle sides 
            int a = 0;
            int b = 0;
            int c = 0;

            //a_str , b_str, c_str, calc_str - string variables to save all entered by user values in Logfile
            string a_str;
            if (textBox1.Text == "") a_str = "not entered";
            else a_str = textBox1.Text;

            string b_str;
            if (textBox2.Text == "") b_str = "not entered";
            else b_str = textBox2.Text;

            string c_str;
            if (textBox3.Text == "") c_str = "not entered";
            else c_str = textBox3.Text;

            string calc_str;
            if (perimetr.Checked) calc_str = "perimetr";
            else if (area.Checked) calc_str = "area";
            else calc_str = "not entered";
            
            //write the entered value or "not entered" in Logfile
            using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(triangle.path_to_log, true))
                file.WriteLine("Entered sides: a = {0}, b = {1}, c = {2}, Calculation method: {3}",a_str,b_str,c_str,calc_str);

            //textBox1 use for "a" side of triangle
            //check for empty value
            if (textBox1.Text == "")
            {
                if (less_zero_a.Visible == true) less_zero_a.Visible = false;
                if (int_a.Visible == true) int_a.Visible = false;
                need_a.Visible = true;
            }
            else
            {
                try
                {
                    //convert string to int
                    a = Int32.Parse(textBox1.Text);
                    if (int_a.Visible == true) int_a.Visible = false;
                    if (need_a.Visible == true) need_a.Visible = false;
                    if (less_zero_a.Visible == true) less_zero_a.Visible = false;
                    //check for negative value
                    if (a < 0) less_zero_a.Visible = true;

                }
                catch
                {
                    int_a.Visible = true;
                    if (need_a.Visible == true) need_a.Visible = false;
                    if (less_zero_a.Visible == true) less_zero_a.Visible = false;
                }
            }

            //textBox2 use for "b" side of triangle
            //check for empty value
            if (textBox2.Text == "") 
            {
                if (less_zero_b.Visible == true) less_zero_b.Visible = false;
                if (int_b.Visible == true) int_b.Visible = false;
                need_b.Visible = true; 
            }
            else
            {
                try
                {
                    //convert string to int
                    b = Int32.Parse(textBox2.Text);
                    if (int_b.Visible == true) int_b.Visible = false;
                    if (need_b.Visible == true) need_b.Visible = false;
                    if (less_zero_b.Visible == true) less_zero_b.Visible = false;
                    //check for negative value
                    if (b < 0) less_zero_b.Visible = true;
                }
                catch
                {
                    int_b.Visible = true;
                    if (need_b.Visible == true) need_b.Visible = false;
                    if (less_zero_b.Visible == true) less_zero_b.Visible = false;
                }
            }

            //textBox3 use for "c" side of triangle
            //check for empty value
            if (textBox3.Text == "") 
            {
                if (less_zero_c.Visible == true) less_zero_c.Visible = false;
                if (int_c.Visible == true) int_c.Visible = false;
                need_c.Visible = true;
            }
            else
            {
                try
                {
                    //convert string to int
                    c = Int32.Parse(textBox3.Text);
                    if (int_c.Visible == true) int_c.Visible = false;
                    if (need_c.Visible == true) need_c.Visible = false;
                    if (less_zero_c.Visible == true) less_zero_c.Visible = false;
                    //check for negative value
                    if (c < 0) less_zero_c.Visible = true;
                }
                catch
                {
                    int_c.Visible = true;
                    if (need_c.Visible == true) need_c.Visible = false;
                    if (less_zero_c.Visible == true) less_zero_c.Visible = false;
                }
            }    

            //check the choise of calculation method
            if (perimetr.Checked == false && area.Checked == false)
                needcalcmethod.Visible = true;

            //all enered sides are numbers and calculation method was chosen 
            if ((a > 0) && (b > 0) && (c > 0) && (needcalcmethod.Visible == false))
            {
                //check for exist of triangle with entered sides
                if (((b + c) > a) && ((a + c) > b) && ((a + b) > c))
                {
                    triangle.a = a;
                    triangle.b = b;
                    triangle.c = c;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Triangle with such sides does not exist");
                }    
                    
                    
                
                
            }
                
                
        }


    }
}
