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
        bool mouseclick = false;
        int cnt = 0;
        public static int x = 100;
        public static int y = 100;
        
        
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
            
            e.Graphics.FillEllipse(b2, x + 30, y + 70, 50, 50);

            if (cnt != 0)
            {
                e.Graphics.FillEllipse(b2, x + 30, y + 70, 50, 50);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y += 3;
            
            Refresh();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            mouseclick = true;
            cnt++;
        }

       
    }
}

    
