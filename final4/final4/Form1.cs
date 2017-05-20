using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final4
{
    public partial class Form1 : Form
    {
        public static int x = 200;
        public static int y = 200;
        //Circle circle = new Circle(x, y);
        //SolidBrush b = new SolidBrush(Color.Gainsboro);
        SolidBrush b2 = new SolidBrush(Color.BlueViolet);
        public Form1()
        {
            InitializeComponent();
        }
       
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillPath(b, circle.path);
            e.Graphics.FillEllipse(b2, x + 30, y + 70, 100, 100);
            //e.Graphics.FillEllipse(b2, x + 120, y + 70, 50, 50);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y += 5;
            //circle = new Circle(x, y);
            Refresh();
        }
    }
}

    
