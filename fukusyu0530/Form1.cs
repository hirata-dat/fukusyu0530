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
        int vx = -20;
        int vy = -20;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top  += vy;
            //label1.Leftが0より小さいか
            if (label1.Left < 0)
            {
                //vxをvyに－1掛けた値にする
                //vx = vx *-1;
                //vx *= -1;どれでも可
                vx = -vx;
            }
            if (label1.Top < 0)
            {
                vy = -vy;
            }

            if (label1.Right > 500)//lade1.right647より大きいか
            {
                vx = -vx;
            }

            if (label1.Bottom > 500)//lade1.Bottomより大きいか
            {
                vy = -vy;
            }
           
        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top  += vy;




            MessageBox.Show("" + ClientSize.Width + "," + ClientSize.Height);//ClientSize.Width：フォームの幅、ClientSize.Height：フォームの高さ
            MessageBox.Show("" + label1.Width + "," + label1.Handle);//label1.Width：ラベルの幅（横）、label1.Handle：ラベルの高さ（縦）
        
        
        
        
        
        }
    }
}
