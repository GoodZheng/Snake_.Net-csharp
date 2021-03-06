/* ==============================================================================
 * 功能描述：    贪吃蛇小游戏
 * 创 建 者：    泰勒Peano
 * 交流邮箱：    goodzheng@88.com
 * 交流QQ：      656029714
 * 创建日期：    2020.08.12
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 贪吃蛇
{
    public partial class ControlFrm : Form
    {
        public ControlFrm()
        {
            InitializeComponent();
        }
        
        //“关于”按钮
        private void button3_Click(object sender, EventArgs e)
        {
            AboutMe hf = new AboutMe();
            hf.ShowDialog();
        }

        //玩法介绍
        private void button2_Click(object sender, EventArgs e)
        {
            HowToPlay htp = new HowToPlay();
            htp.ShowDialog();
        }

        //开始游戏
        private void button1_Click(object sender, EventArgs e)
        {
            GameFrm gf = new GameFrm();
            gf.ShowDialog();
        }
    }
}
