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

namespace Calculater
{
   
    public partial class Form1 : Form
    {
        class op
        {
            public string x;
        }
        List<op> opList= new List<op>();
        string textbox;
        string h = "";
        int ct = 0;
        float d;
        int r = 0;

        public Form1()
        {
           
            InitializeComponent();
           
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            textbox += "1";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            textbox += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            textbox += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            textbox += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBox1.Text += "5";
            textbox += "5";
        }
                                                                                     
        private void button6_Click(object sender, EventArgs e)
        {

            textBox1.Text += "6";
            textbox += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            textBox1.Text += "7";
            textbox += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {

            textBox1.Text += "8";
            textbox += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {

            textBox1.Text += "9";
            textbox += "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {

            textBox1.Text += "0";
            textbox += "0";
        }


        private void button11_Click(object sender, EventArgs e)
        {
           

            for (int i = 0; i < textbox.Length; i++)
            {
                if (textbox[i] != '+' && textbox[i] != '-' && textbox[i] != '/' && textbox[i] != '*' && textbox[i] != '%')
                {
                    h += textbox[i];
                    if (i == textbox.Length - 1)
                    {
                        op pnn = new op();
                        pnn.x = h;
                        h = "";
                        opList.Add(pnn);
                    }
                }
                else
                {
                    op pnn = new op();
                    pnn.x = h;
                    h = "";
                    opList.Add(pnn);
                    pnn = new op();
                    pnn.x = "" + textbox[i];
                    opList.Add(pnn);

                }

            }
           

            for (int i = 0; i < opList.Count; i++)
            {
                if (opList[i].x == "/")
                {
                  d= float.Parse(opList[i - 1].x) / float.Parse(opList[i+1].x);

                   
                    opList.Remove(opList[i+1]);
                    opList.Remove(opList[i]);
                    opList[i - 1].x = d+"";
                }
            }


            for (int i = 0; i < opList.Count; i++)
            {
                if (opList[i].x == "*")
                {
                    d = float.Parse(opList[i - 1].x) * float.Parse(opList[i + 1].x);


                    opList.Remove(opList[i + 1]);
                    opList.Remove(opList[i]);
                    opList[i - 1].x = d + "";
                }
            }

            for (int i = 0; i < opList.Count; i++)
            {
                if (opList[i].x == "+")
                {
                    d = float.Parse(opList[i - 1].x) + float.Parse(opList[i + 1].x);


                    opList.Remove(opList[i + 1]);
                    opList.Remove(opList[i]);
                    opList[i - 1].x = d + "";
                }
            }


            for (int i = 0; i < opList.Count; i++)
            {
                if (opList[i].x == "-")
                {
                    d = float.Parse(opList[i - 1].x) - float.Parse(opList[i + 1].x);


                    opList.Remove(opList[i + 1]);
                    opList.Remove(opList[i]);
                    opList[i - 1].x = d + "";
                }
            }

            for (int i = 0; i < opList.Count; i++)
            {
                if (opList[i].x == "%")
                {
                    d = float.Parse(opList[i - 1].x) /float.Parse(opList[i + 1].x);
                    int k= int.Parse(opList[i - 1].x) /int.Parse(opList[i + 1].x);
                    d -= k;
                    d *=float.Parse( opList[i + 1].x);

                    opList.Remove(opList[i + 1]);
                    opList.Remove(opList[i]);
                    opList[i - 1].x = d + "";
                }
            }

            textBox1.Text = d+"";
            textbox = d + "";
            h = "";
            d = 0;

        }
        
        private void button12_Click(object sender, EventArgs e)
        {

            textBox1.Text += "/";
            textbox += "/";

        }

        private void button13_Click(object sender, EventArgs e)
        {

            textBox1.Text += "*";
            textbox += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {

            textBox1.Text += "+";
            textbox += "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {

            textBox1.Text += "-";
            textbox += "-";
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "";
        }

        

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            opList.Clear();
            h = "";
            textbox = "";
            d = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string g;
              g  =  textBox1.Text.Remove(textBox1.TextLength-1 , 1);
            textBox1.Text = g;
            textbox=g;

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            textbox += ".";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "%";
            textbox += "%";
        }
    }
}
