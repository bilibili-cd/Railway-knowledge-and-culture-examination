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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs1 = new FileStream("C:\\车迷考试成绩（勿动）.txt", FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine(0);
            sw.Close();
            fs1.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj + 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj + 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj + 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj - 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            string ch = Convert.ToString(Program.cj);
            MessageBox.Show(ch);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj + 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj + 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj + 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj + 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj + 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj + 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Program.cj = Program.cj + 5;
            string c = Convert.ToString(Program.cj);
        }

        private void button41_Click_1(object sender, EventArgs e)
        {
            string c = Convert.ToString(Program.cj);
            StreamWriter sc = new StreamWriter("D:\\车迷选择题考试成绩（勿动）.txt", false);
            sc.WriteLine(c);
            sc.Close();
            Clipboard.SetDataObject("2121816020");
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\未批改.df7g5252", false);
            sw.WriteLine("1."+this.textBox1.Text+"批改结果和分数：");
            sw.WriteLine("2." + this.textBox3.Text + "批改结果和分数：");
            sw.WriteLine("3." + this.textBox5.Text + "批改结果和分数：");
            sw.WriteLine("4." + this.textBox2.Text + "批改结果和分数：");
            sw.WriteLine("5." + this.textBox8.Text + "批改结果和分数：");
            sw.WriteLine("6." + this.textBox4.Text + "批改结果和分数：");
            sw.WriteLine("7." + this.textBox7.Text + "批改结果和分数：");
            sw.WriteLine("8." + this.textBox6.Text + "批改结果和分数：");
            sw.WriteLine("9." + this.textBox9.Text + "批改结果和分数：");
            sw.WriteLine("10." + this.textBox10.Text + "批改结果和分数：");
            sw.Close();
            MessageBox.Show("您的选择题成绩为 " + c + " ，请您将程序目录下的“未批改.df7g5252”文件,发送到df7g5252的QQ，并以为您复制了她的QQ号。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button42_Click(object sender, EventArgs e)
        {

        }
    }
}

