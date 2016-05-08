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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            panel1.Visible = true;
            a.Text = "Side a: " + triangle.a;
            b.Text = "Side b: " + triangle.b;
            c.Text = "Side c: " + triangle.c;
            if (triangle.is_perimetr) calc_method.Text = "Calculation method: perimetr";
            else calc_method.Text = "Calculation method: area";
            //calc perimetr
            triangle.perimetr = triangle.a + triangle.b + triangle.c;            
            if (triangle.is_perimetr)
            {
                Result.Text = "Result: " + triangle.perimetr;
            }
            else
            {
                //calc area
                double half_perimetr = triangle.perimetr / 2;
                triangle.area = Math.Sqrt((half_perimetr * (half_perimetr - triangle.a) * (half_perimetr - triangle.b) * (half_perimetr - triangle.c)));
                Result.Text = "Result: " + triangle.area.ToString("#.###");
            }
            
        }
    }
}
