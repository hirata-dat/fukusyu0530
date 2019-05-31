using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0530
{
    public partial class Form1 : Form
    {
        int vx =-5;
        int vy = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top  += vy;
           
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
