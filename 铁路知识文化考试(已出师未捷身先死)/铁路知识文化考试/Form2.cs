using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Text;

namespace 铁路知识文化考试
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("请自觉关闭浏览器或者不使用浏览器，诚信考试，选择题每道题最好只选择一次，否则成绩极有可能会不真实。","提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            Form1 f = new Form1();
            f.ShowDialog();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string str;
            StreamReader sr = new StreamReader("D:\\车迷选择题考试成绩（勿动）.txt", false);
            str = sr.ReadLine().ToString();
            sr.Close();
            MessageBox.Show("最近一次选择题成绩为 " + str + " 分", "选择题成绩查询", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
