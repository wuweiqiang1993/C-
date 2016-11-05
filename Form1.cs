using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        static float a=0,  sum;//a为参数，sum为结果
        static int b=0;//b为运算符

        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)//=号
        {
            a = changeText(textBox2.Text);
            sum = compute(sum, a, b);
            textBox3.Text = Convert.ToString(sum) ;
            textBox2.Clear();
            b = 6;
        }

   

        private void button4_Click(object sender, EventArgs e)
        {
            a = changeText(textBox2.Text);
            sum = compute(sum, a, b);
            textBox3.Text = Convert.ToString(sum) + '*';
            textBox2.Clear();
            b = 3;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text += button12.Text;
            
            checkdot();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text += button14.Text;
            
            checkdot();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            textBox2.Text += button15.Text;
            
            checkdot();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += button6.Text;
            
            checkdot();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            textBox2.Text += button16.Text;
            
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text += button13.Text;
            
            checkdot();
        }

        private void button11_Click(object sender, EventArgs e)
        {
                textBox2.Text += button11.Text;
           
            checkdot();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            textBox2.Text += button9.Text;
            
            checkdot();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
                textBox2.Text += button10.Text;
            
            checkdot();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            textBox2.Text += button8.Text;
            
            
            checkdot();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            textBox2.Text += button7.Text;
            
           
            checkdot();
        }

        private void button2_Click(object sender, EventArgs e) //+
        {
            
            a = changeText(textBox2.Text);
            sum = compute(sum, a, b);
            textBox3.Text = Convert.ToString(sum)+'+';
            textBox2.Clear();
            b = 1;
        }

        private  void checkdot() {
            if (textBox3.Text.IndexOf('.') > -1)
            {
                button16.Enabled = false;
            }
            else
            {
                button16.Enabled = true;
            }
        }
        private float changeText(string text)
        {
            float textvalue;
            if (text.Length > 0)
            {
                textvalue = Convert.ToSingle(text);
            }
            else 
            {
                textvalue = 0;
            }
            return textvalue;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = changeText(textBox2.Text);
            sum = compute(sum, a, b);
            textBox3.Text = Convert.ToString(sum) + '%';
            textBox2.Clear();
            b = 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = changeText(textBox2.Text);
            sum = compute(sum, a, b);
            textBox3.Text = Convert.ToString(sum) + '-';
            textBox2.Clear();
            b = 2;
        }

        private float compute(float preNum, float nowNum, int type)
        {
            float result;
            switch (type) { 
                case 0 : //初始为空
                    result = nowNum;
                    break;
                case 1 :
                    result = preNum + nowNum;
                    break;
                case 2:
                    result = preNum - nowNum;
                    break;
                case 3:
                    result = preNum * nowNum;
                    break;
                case 4:
                    result = preNum / nowNum;
                    break;
                case 5: 
                    result = preNum % nowNum;
                    break;
                default : //=
                    result = preNum;
                    break;
            }
            return result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = changeText(textBox2.Text);
            sum = compute(sum, a, b);
            textBox3.Text = Convert.ToString(sum) + '/';
            textBox2.Clear();
            b = 4;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            a = 0;
            b = 0;
            sum = 0;
        }
       
       
    }
}
