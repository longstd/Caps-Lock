using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("大写");
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (IsKeyLocked(Keys.CapsLock))//如果键盘是大写，则显示“A”
            {
                label1.Text = "A";
            }
            else                           //小写则为空白，不显示任何东西
                label1.Text  = "";
            if (IsKeyLocked(Keys.NumLock))//如果数字键盘锁住，则显示“123”
            {
                label2.Text = "123";
                    }
            else                         //如果数字键盘没锁住，则为空白，不显示任何东西
                label2.Text = "";
           
        }

        private void Form1_Load(object sender, EventArgs e)//程序启动时关于窗口的一些设置
        {
             this.TransparencyKey = this.BackColor;        //背景显示透明
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 0;//把窗口放在屏幕的最左边
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height -0;//把窗口放在屏幕的最下边
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)//退出程序
        {
            this.Close();
        }
    }
}
