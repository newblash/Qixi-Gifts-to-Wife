using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;

namespace 七夕送老婆礼物
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            this.Text = config.AppSettings.Settings["Title"].Value;
            button1.Text = config.AppSettings.Settings["Btn1"].Value;
            button2.Text = config.AppSettings.Settings["Btn2"].Value;
            button3.Text = config.AppSettings.Settings["Btn3"].Value;
            button4.Text = config.AppSettings.Settings["Btn4"].Value;
            button5.Text = config.AppSettings.Settings["Btn5"].Value;
            button6.Text = config.AppSettings.Settings["Btn6"].Value;
            button7.Text = config.AppSettings.Settings["Btn7"].Value;
            button8.Text = config.AppSettings.Settings["Btn8"].Value;
            button9.Text = config.AppSettings.Settings["Btn9"].Value;
            button10.Text = config.AppSettings.Settings["Btn10"].Value;
            button11.Text = config.AppSettings.Settings["Btn11"].Value;
            button12.Text = config.AppSettings.Settings["Btn12"].Value;
            button13.Text = config.AppSettings.Settings["Btn13"].Value;
            button14.Text = config.AppSettings.Settings["Btn14"].Value;
            button15.Text = config.AppSettings.Settings["Btn15"].Value;
            button16.Text = config.AppSettings.Settings["Btn16"].Value;
            button17.Text = config.AppSettings.Settings["Btn17"].Value;
            button18.Text = config.AppSettings.Settings["Btn18"].Value;
            button19.Text = config.AppSettings.Settings["Btn19"].Value;
            button20.Text = config.AppSettings.Settings["Btn20"].Value;
            button21.Text = config.AppSettings.Settings["Btn21"].Value;
            button22.Text = config.AppSettings.Settings["Btn22"].Value;
            button23.Text = config.AppSettings.Settings["Btn23"].Value;
            button24.Text = config.AppSettings.Settings["Btn24"].Value;
            button25.Text = config.AppSettings.Settings["Btn25"].Value;
            button26.Text = config.AppSettings.Settings["Btn26"].Value;
            button27.Text = config.AppSettings.Settings["Btn27"].Value;
            button28.Text = config.AppSettings.Settings["Btn28"].Value;
            button29.Text = config.AppSettings.Settings["Btn29"].Value;
            button30.Text = config.AppSettings.Settings["Btn30"].Value;
            button31.Text = config.AppSettings.Settings["Btn31"].Value;
            button32.Text = config.AppSettings.Settings["Btn32"].Value;
            button33.Text = config.AppSettings.Settings["Btn33"].Value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //开始按钮变灰不能点
            button1.Enabled = false;
            //开辟一个新进程
            Thread thread1 = new Thread(delegate () {
                //创建一个控制数组,将界面上所有按钮控件加入数组
                Control[] strnames = new Control[Controls.Count];
                for (int i = 0; i < Controls.Count; i++)
                {
                    strnames[i] = this.Controls[i];
                }
                //对控件数组进行倒序排序
                Array.Reverse(strnames);
                //创建一个无限循环
                while (true){
                    //一起33个控件,所以for33次
                    for (int a = 1; a < 33; a++)
                    {
                        //创建一个随机数,范围在0~80
                        Random rand = new Random();
                        var num = rand.Next(0, 80);
                        //让跑起来的控件背景变颜色
                        strnames[a].BackColor = Color.SteelBlue;
                        //匿名代理
                        Invoke(new Action(() =>
                        {
                            //控制控件被选中
                            strnames[a].Focus();
                        }));
                        //延时60毫秒,不让控件起飞了跑
                        Thread.Sleep(60);
                        //跑完让控件恢复本身背景
                        strnames[a].BackColor = Color.Gainsboro;
                        //如果控件的ID=随机的数那么停下来,显示选中的奖品
                        if (a == num)
                        {
                            MessageBox.Show(strnames[num].Text);
                            Invoke(new Action(() =>
                            {
                                //解锁抽奖开始按钮
                                button1.Enabled = true;
                            }));
                            return;
                        }
                    }
                }
                
            });
            //线程开始
            thread1.Start();
        }
    }
}
