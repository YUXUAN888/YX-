using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YX计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";//取值
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";//取值
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";//取值
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";//取值
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";//取值
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";//取值
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";//取值
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";//取值
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";//取值
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";//取值
        }

        private void Form1_Load(object sender, EventArgs e)
        { } 
            public double jisuan1; //定义一个变量值

        public double jisuan2; //定义一个变量值

        public char fuhao; //定义一个变量值

        public double jiegun = 0; //定义一个变量值

        private void button13_Click(object sender, EventArgs e)
        {
            if(textBox1 .Text  == "")//判断
            {
                MessageBox.Show("请输入数字以计算");//提示框
                return;//返回执行
            }
            jisuan1 = Convert.ToDouble(textBox1.Text);

            fuhao = '+';

            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入数字以计算");
                return;
            }
            jisuan1 = Convert.ToDouble(textBox1.Text);

            fuhao = '-';

            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入数字以计算");
                return;
            }
            {
                jisuan1 = Convert.ToDouble(textBox1.Text);

                fuhao = '*';

                textBox1.Text = "";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入数字以计算");
                return;
            }
            {
                jisuan1 = Convert.ToDouble(textBox1.Text);

                fuhao = '/';

                textBox1.Text = "";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入数字以计算");
                return;
            }
            jisuan2 = Convert.ToDouble(textBox1.Text);

            switch (fuhao)

            {

                case '+':

                    jiegun = jisuan1 + jisuan2;

                    break;

                case '-':

                    jiegun = jisuan1 - jisuan2;

                    break;

                case '*':

                    jiegun = jisuan1 * jisuan2;

                    break;

                case '/':

                    jiegun = jisuan1 / jisuan2;

                    break;

                case '%':

                    jiegun = jisuan1 / jisuan2;
                    
                    break;

            }

            textBox1.Text = Convert.ToString(jiegun);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
    }
    

