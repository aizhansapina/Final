using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final3
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Yellow;
                cnt++;
            }
            if (button.BackColor == Color.Yellow)
            {
                button.BackColor = Color.Blue;
                cnt++;
            }
            if (button.BackColor == Color.Blue)
            {
                button.BackColor = Color.Red;
                cnt++;
            }
        
            if (cnt == 4)
                cnt = 1;
        }
    }
}
