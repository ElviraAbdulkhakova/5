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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 child = new Form2();
            //call the Form "Input"
            child.ShowDialog();
            //display entered values if input was correct
            if (child.DialogResult == DialogResult.OK)
            {
                panel1.Visible = true;
                a.Text = "Side a: " + triangle.a;
                b.Text = "Side b: " + triangle.b;
                c.Text = "Side c: " + triangle.c;
                if (triangle.is_perimetr) calc_method.Text = "Calculation method: perimetr";
                else calc_method.Text = "Calculation method: area";
            }
            
        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 result = new Form3();
            //call Form "Calc"
            result.ShowDialog();
        }

        private void viewLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 log = new Form4();
            //call Form "Log"
            log.ShowDialog();
        }

        private void cleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //count_lines contain the count of lines in Logfile
                int count_lines = System.IO.File.ReadAllLines(triangle.path_to_log).Length;
                //if Logfile is not empty
                if (count_lines>0)
                {
                    //readText contain the Logfile content
                    string[] readText = System.IO.File.ReadAllLines(triangle.path_to_log);
                    //delete old Logfile
                    System.IO.File.Delete(triangle.path_to_log);
                    //Crete and fill new Logfile without last string in old Logfile
                    using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(triangle.path_to_log, true))
                        for (int i = 0; i < count_lines - 1;i++ )
                        {
                            file.WriteLine(readText[i]);
                        }
                    
                    //show success message
                    MessageBox.Show("The last data has been cleaned");
                }
                else MessageBox.Show("The log is empty");

                
            }
            catch
            {
                MessageBox.Show("Error");
            }
            
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(triangle.path_to_log, true))
                file.WriteLine(DateTime.Now.ToString() + " Application End");
        }









    }
}
