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
        int vx = -10;
        int vy = -10;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Text = MousePosition.X + "," + MousePosition.Y;//マウスの座標がわかる
            Point p = PointToClient(MousePosition);

            label3.Left = p.X-label3.Width/2;//MousePosition.X;//画面の左上（0,0）
            label3.Top  = p.Y-label3.Height/2;//MousePosition.Y;
            //p.X-label3.Width/2;中心のマウスにラベル３が来る
            //= MousePosition.Y/2;
            

            label1.Left += vx;
            label1.Top  += vy;
            
            //label1.Leftが0より小さいか
            if (label1.Left < 0 )//左
            {
                vx = Math.Abs(vx);
            }
            
            if (label1.Top < 0 )//上
            {
                vy = -vy;
            }

            if (label1.Left > ClientSize.Width - label1.Width)//画面に合わせて跳ね返る
            {
                vx = -Math.Abs(vx);
            }


            if (label1.Right > 500)//右
            {
                vx = -vx;
            }

            if (label1.Bottom > 500)//下
            {
                vy = -vy;
            }
           
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("" + ClientSize.Width + "," + ClientSize.Height);//ClientSize.Width：フォームの幅、ClientSize.Height：フォームの高さ
            MessageBox.Show("" + label1.Width + "," + label1.Handle);//label1.Width：ラベルの幅（横）、label1.Handle：ラベルの高さ（縦）
            //Width =幅(横)
            //Height=高さ(縦)
            //ClientSize(フォーム)
        
        
        
        
        }
    }
}
