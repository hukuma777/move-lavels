using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace move_lavels
{
    public partial class Form1 : Form
    {

        //int a = 10;
        int iTime = 0;         
        int vx = rand.Next(1, 101);
        int vy = rand.Next(1, 101);

        private static Random rand = new Random();


        public Form1()
        {
            InitializeComponent();

            label1.Left += rand.Next(1, ClientSize.Width);
            label1.Top += rand.Next(1, ClientSize.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            iTime++;
            label5.Text = "タイム" + iTime;
            Point cpos;

            cpos = PointToClient(MousePosition);

            label2.Text = "" + cpos.X + "," + cpos.Y;
            label3.Text = "" + MousePosition.X + "," + MousePosition.Y;

            //ラベルついてくる
            label4.Left = cpos.X - label4.Width / 2;
            label4.Top = cpos.Y - label4.Height / 2;
            //label1.Text = "HP" + a;

            /*if (a==0)
            {
                label1.Visible = false;
            }*/
 
            if (cpos.X > label1.Left 
                && cpos.X < label1.Right 
                && cpos.Y > label1.Top 
                && cpos.Y < label1.Bottom)
            {
                label1.Visible = false;

                //a--;
            }




            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }

            if (label1.Top < 0)
            {
                vy = Math.Abs(vx);
            }

            if (label1.Left > ClientSize.Width - label1.Width)
            {
                vx = -Math.Abs(vx);
            }

            if (label1.Top > ClientSize.Height - label1.Height)
            {
                vy = -Math.Abs(vx);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 0以上、intの範囲内の乱数
            Text = "" + rand.Next();
            // さいころの目の例
            Text += "," + ((rand.Next() % 6) + 1);

            // 0以上、指定の値「未満」の乱数
            //以下は、0～5までの乱数
            Text += "/" + rand.Next(6);

            // 指定の値以上、指定の値「未満」の乱数
            // 以下は、１～６までの乱数
            Text += "/" + rand.Next(1, 7);

            // 0～1未満の乱数
            Text += "/" + rand.NextDouble();
            // NextDoubleを使って、１～６の乱数を算出するには？
            Text += "/" + (int)(rand.NextDouble() * 6.0 + 1.0);
            // NextDouble()の最大値=0
            // NextDouble()の最小値=99.999
        }
    }
}
