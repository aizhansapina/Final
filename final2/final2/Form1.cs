using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final2
{
    public partial class Form1 : Form
    {
        int cnt = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            int a = cnt++;
            Button button = sender as Button;
            button.Text = a.ToString();
            textBox1.Text = a.ToString();

            if (a % 2 == 0)
            {
                textBox1.Text = a.ToString();
            }
        }
    }
}
