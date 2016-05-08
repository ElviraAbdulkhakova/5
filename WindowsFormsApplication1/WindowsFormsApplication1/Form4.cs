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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            //textBox1 need to show the content of LogFile   
            textBox1.Text = "";
            textBox1.Text = System.IO.File.ReadAllText(triangle.path_to_log);
            textBox1.ReadOnly = true;
        }
    }
}
