using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculadoraeliannis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '1';
        }

        private void estadisticaAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            panel1.Visible = true;
            Size = new Size(panel1.Width + 30, panel1.Height + 60);

        }

        private void basicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            Size = new Size(panel1.Width + 30, panel1.Height + 60);

            panel2.Visible = false;
            panel3.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel10.Visible = false;
        }

        private void basicaToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            panel2.Visible = true;
            Size = new Size(panel2.Width + 20, panel2.Height + 54);
            panel1.Visible = false;
            panel3.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel10.Visible = false;
        }

        private void basicaToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            panel3.Visible = true;
            Size = new Size(panel3.Width + 30, panel3.Height + 60);
            panel1.Visible = false;
            panel2.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel10.Visible = false;
        }
        private void conversionDeUnidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            Size = new Size(panel8.Width + 30, panel8.Height + 60);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel7.Visible = false;
            panel10.Visible = false;
        }

        private void conversionDeUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
            Size = new Size(panel10.Width + 30, panel10.Height + 60);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            button209.Enabled = true;
            button210.Enabled = true;
            button211.Enabled = true;
            button212.Enabled = true;
            button213.Enabled = true;
            button214.Enabled = true;
            button215.Enabled = true;
            button216.Enabled = true;
            button217.Enabled = true;
            button218.Enabled = true;
            button219.Enabled = true;
            button220.Enabled = true;
            button221.Enabled = false;
            button222.Enabled = false;
            button223.Enabled = false;
            button224.Enabled = false;
            button225.Enabled = false;
            button226.Enabled = false;
            button227.Enabled = true;
            button228.Enabled = false;
            button229.Enabled = true;
            button230.Enabled = false;
            button231.Enabled = true;
            button230.Enabled = false;
            button232.Enabled = true;
            button233.Enabled = false;
            button234.Enabled = true;
            button235.Enabled = false;
            button236.Enabled = true;
            button237.Enabled = false;
            button238.Enabled = false;
            button239.Enabled = false;
            button240.Enabled = false;
            button241.Enabled = true;
            button242.Enabled = false;
            button243.Enabled = false;
            button244.Enabled = false;
            button245.Enabled = true;
            button246.Enabled = true;
            button247.Enabled = false;
            button248.Enabled = true;
            button249.Enabled = true;
            button250.Enabled = true;
            button251.Enabled = true;
            button252.Enabled = true;
            button253.Enabled = true;
            button254.Enabled = true;

        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            button209.Enabled = true;
            button210.Enabled = true;
            button211.Enabled = true;
            button212.Enabled = true;
            button213.Enabled = true;
            button214.Enabled = true;
            button215.Enabled = true;
            button216.Enabled = true;
            button217.Enabled = true;
            button218.Enabled = true;
            button219.Enabled = true;
            button220.Enabled = true;
            button221.Enabled = false;
            button222.Enabled = false;
            button223.Enabled = false;
            button224.Enabled = false;
            button225.Enabled = false;
            button226.Enabled = false;
            button227.Enabled = true;
            button228.Enabled = false;
            button229.Enabled = true;
            button230.Enabled = false;
            button231.Enabled = true;
            button230.Enabled = true;
            button232.Enabled = true;
            button233.Enabled = true;
            button234.Enabled = true;
            button235.Enabled = true;
            button236.Enabled = true;
            button237.Enabled = false;
            button238.Enabled = true;
            button239.Enabled = true;
            button240.Enabled = false;
            button241.Enabled = true;
            button242.Enabled = false;
            button243.Enabled = false;
            button244.Enabled = true;
            button245.Enabled = true;
            button246.Enabled = true;
            button247.Enabled = false;
            button248.Enabled = true;
            button249.Enabled = true;
            button250.Enabled = true;
            button251.Enabled = true;
            button252.Enabled = true;
            button253.Enabled = true;
            button254.Enabled = true;
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            button209.Enabled = true;
            button210.Enabled = true;
            button211.Enabled = true;
            button212.Enabled = true;
            button213.Enabled = true;
            button214.Enabled = true;
            button215.Enabled = true;
            button216.Enabled = true;
            button217.Enabled = true;
            button218.Enabled = true;
            button219.Enabled = true;
            button220.Enabled = true;
            button221.Enabled = false;
            button222.Enabled = false;
            button223.Enabled = false;
            button224.Enabled = false;
            button225.Enabled = false;
            button226.Enabled = false;
            button227.Enabled = true;
            button228.Enabled = false;
            button229.Enabled = true;
            button230.Enabled = false;
            button231.Enabled = true;
            button230.Enabled = true;
            button232.Enabled = true;
            button233.Enabled = true;
            button234.Enabled = true;
            button235.Enabled = true;
            button236.Enabled = true;
            button237.Enabled = false;
            button238.Enabled = true;
            button239.Enabled = true;
            button240.Enabled = true;
            button241.Enabled = true;
            button242.Enabled = false;
            button243.Enabled = true;
            button244.Enabled = true;
            button245.Enabled = true;
            button246.Enabled = true;
            button247.Enabled = false;
            button248.Enabled = true;
            button249.Enabled = true;
            button250.Enabled = true;
            button251.Enabled = true;
            button252.Enabled = true;
            button253.Enabled = true;
            button254.Enabled = true;
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            button209.Enabled = true;
            button210.Enabled = true;
            button211.Enabled = true;
            button212.Enabled = true;
            button213.Enabled = true;
            button214.Enabled = true;
            button215.Enabled = true;
            button216.Enabled = true;
            button217.Enabled = true;
            button218.Enabled = true;
            button219.Enabled = true;
            button220.Enabled = true;
            button221.Enabled = true;
            button222.Enabled = true;
            button223.Enabled = true;
            button224.Enabled = true;
            button225.Enabled = true;
            button226.Enabled = true;
            button227.Enabled = true;
            button228.Enabled = false;
            button229.Enabled = true;
            button230.Enabled = false;
            button231.Enabled = true;
            button230.Enabled = true;
            button232.Enabled = true;
            button233.Enabled = true;
            button234.Enabled = true;
            button235.Enabled = true;
            button236.Enabled = true;
            button237.Enabled = false;
            button238.Enabled = true;
            button239.Enabled = true;
            button240.Enabled = true;
            button241.Enabled = true;
            button242.Enabled = false;
            button243.Enabled = true;
            button244.Enabled = true;
            button245.Enabled = true;
            button246.Enabled = true;
            button247.Enabled = false;
            button248.Enabled = true;
            button249.Enabled = true;
            button250.Enabled = true;
            button251.Enabled = true;
            button252.Enabled = true;
            button253.Enabled = true;
            button254.Enabled = true;
        }

        private void Radiobutton4_CheckedChanged(object sender, EventArgs e)
        {
            button81.Enabled = true;
            button82.Enabled = true;
            button83.Enabled = true;
            button84.Enabled = true;
            button85.Enabled = true;
            button86.Enabled = false;
            button88.Enabled = false;
            button90.Enabled = true;
            button91.Enabled = false;
            button92.Enabled = true;
            button93.Enabled = false;
            button94.Enabled = true;
            button95.Enabled = false;
            button96.Enabled = false;
            button97.Enabled = false;
            button98.Enabled = false;
            button99.Enabled = true;
            button100.Enabled = false;
            button101.Enabled = false;
            button102.Enabled = false;
            button103.Enabled = true;
            button104.Enabled = true;
            button105.Enabled = false;
            button106.Enabled = true;
            button107.Enabled = true;
            button108.Enabled = true;
            button109.Enabled = true;
            button110.Enabled = true;
            button111.Enabled = true;
            button112.Enabled = true;
            button113.Enabled = false;
            button114.Enabled = false;
            button115.Enabled = false;
            button116.Enabled = false;
            button117.Enabled = false;
            button118.Enabled = false;
            button119.Enabled = true;
            button120.Enabled = true;
            button121.Enabled = true;
            button122.Enabled = true;
            button123.Enabled = true;
            button124.Enabled = true;
            button125.Enabled = true;
            button126.Enabled = true;
            button127.Enabled = true;
            button128.Enabled = true;
            button129.Enabled = true;
            button130.Enabled = true;


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button81.Enabled = true;
            button82.Enabled = true;
            button83.Enabled = true;
            button84.Enabled = true;
            button85.Enabled = true;
            button86.Enabled = false;
            button88.Enabled = true;
            button90.Enabled = true;
            button91.Enabled = true;
            button92.Enabled = true;
            button93.Enabled = true;
            button94.Enabled = true;
            button95.Enabled = false;
            button96.Enabled = true;
            button97.Enabled = true;
            button98.Enabled = false;
            button99.Enabled = true;
            button100.Enabled = false;
            button101.Enabled = false;
            button102.Enabled = true;
            button103.Enabled = true;
            button104.Enabled = true;
            button105.Enabled = false;
            button106.Enabled = true;
            button107.Enabled = true;
            button108.Enabled = true;
            button109.Enabled = true;
            button110.Enabled = true;
            button111.Enabled = true;
            button112.Enabled = true;
            button113.Enabled = false;
            button114.Enabled = false;
            button115.Enabled = false;
            button116.Enabled = false;
            button117.Enabled = false;
            button118.Enabled = false;
            button119.Enabled = true;
            button120.Enabled = true;
            button121.Enabled = true;
            button122.Enabled = true;
            button123.Enabled = true;
            button124.Enabled = true;
            button125.Enabled = true;
            button126.Enabled = true;
            button127.Enabled = true;
            button128.Enabled = true;
            button129.Enabled = true;
            button130.Enabled = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button81.Enabled = true;
            button82.Enabled = true;
            button83.Enabled = true;
            button84.Enabled = true;
            button85.Enabled = true;
            button86.Enabled = false;
            button88.Enabled = true;
            button90.Enabled = true;
            button91.Enabled = true;
            button92.Enabled = true;
            button93.Enabled = true;
            button94.Enabled = true;
            button95.Enabled = false;
            button96.Enabled = true;
            button97.Enabled = true;
            button98.Enabled = true;
            button99.Enabled = true;
            button100.Enabled = false;
            button101.Enabled = true;
            button102.Enabled = true;
            button103.Enabled = true;
            button104.Enabled = true;
            button105.Enabled = false;
            button106.Enabled = true;
            button107.Enabled = true;
            button108.Enabled = true;
            button109.Enabled = true;
            button110.Enabled = true;
            button111.Enabled = true;
            button112.Enabled = true;
            button113.Enabled = false;
            button114.Enabled = false;
            button115.Enabled = false;
            button116.Enabled = false;
            button117.Enabled = false;
            button118.Enabled = false;
            button119.Enabled = true;
            button120.Enabled = true;
            button121.Enabled = true;
            button122.Enabled = true;
            button123.Enabled = true;
            button124.Enabled = true;
            button125.Enabled = true;
            button126.Enabled = true;
            button127.Enabled = true;
            button128.Enabled = true;
            button129.Enabled = true;
            button130.Enabled = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button81.Enabled = true;
            button82.Enabled = true;
            button83.Enabled = true;
            button84.Enabled = true;
            button85.Enabled = true;
            button86.Enabled = false;
            button88.Enabled = true;
            button90.Enabled = true;
            button91.Enabled = true;
            button92.Enabled = true;
            button93.Enabled = true;
            button94.Enabled = true;
            button95.Enabled = false;
            button96.Enabled = true;
            button97.Enabled = true;
            button98.Enabled = true;
            button99.Enabled = true;
            button100.Enabled = false;
            button101.Enabled = true;
            button102.Enabled = true;
            button103.Enabled = true;
            button104.Enabled = true;
            button105.Enabled = false;
            button106.Enabled = true;
            button107.Enabled = true;
            button108.Enabled = true;
            button109.Enabled = true;
            button110.Enabled = true;
            button111.Enabled = true;
            button112.Enabled = true;
            button113.Enabled = true;
            button114.Enabled = true;
            button115.Enabled = true;
            button116.Enabled = true;
            button117.Enabled = true;
            button118.Enabled = true;
            button119.Enabled = true;
            button120.Enabled = true;
            button121.Enabled = true;
            button122.Enabled = true;
            button123.Enabled = true;
            button124.Enabled = true;
            button125.Enabled = true;
            button126.Enabled = true;
            button127.Enabled = true;
            button128.Enabled = true;
            button129.Enabled = true;
            button130.Enabled = true;

        }      

        private void button234_Click(object sender, EventArgs e)
        {
            textBox10.Text = textBox10.Text + '1';

        }

        private void button233_Click(object sender, EventArgs e)
        {
            textBox10.Text = textBox10.Text + '2';
        }

        private void button230_Click(object sender, EventArgs e)
        {
            textBox10.Text = textBox10.Text + '3';
        }

        private void button239_Click(object sender, EventArgs e)
        {
            textBox10.Text = textBox10.Text + '4';
        }

        private void button238_Click(object sender, EventArgs e)
        {
            textBox10.Text = textBox10.Text + '5';
        }

        private void button235_Click(object sender, EventArgs e)
        {
            textBox10.Text = textBox10.Text + '6';
        }

        private void button244_Click(object sender, EventArgs e)
        {
            textBox10.Text = textBox10.Text + '7';
        }

        private void button243_Click(object sender, EventArgs e)
        {
            textBox10.Text = textBox10.Text + '8';
        }

        private void button240_Click(object sender, EventArgs e)
        {
            textBox10.Text = textBox10.Text + '9';
        }

        private void button229_Click(object sender, EventArgs e)
        {
            textBox10.Text = textBox10.Text + '0';
        }

        private void button228_Click(object sender, EventArgs e)
        {
            textBox10.Text = textBox10.Text + '.';
        }

        private void button249_Click(object sender, EventArgs e)
        {
            if (textBox10.Text.Length > 0)
            {
                textBox10.Text = textBox10.Text.Substring(0, textBox10.Text.Length - 1);
            }

        }

        private void button248_Click(object sender, EventArgs e)
        {
            textBox10.Text = "0";
            num1 = 0; num2 = 0;
        }

        private void button245_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
        }
        //Para la +,-,* 
        private double num1, num2, resultado;
        private int op;
    
        private void button236_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox10.Text);
            textBox10.Text= "";
            op = 3;
        }

        private void button231_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox10.Text);
            textBox10.Text = "";
            op = 2;
        }

        private void button246_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox10.Text);
            textBox10.Text = "";
            op = 4;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '0';
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '2';
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '3';
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '4';
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '5';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '6';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '7';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '8';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '9';
        }
        
        private void button7_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button26_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 1;
        }
       

        private void button22_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 2;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 3;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + '0';
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + '1';
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + '2';
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + '3';
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + '4';
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + '5';
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + '6';
        }

        private void button46_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + '7';
        }

        private void button45_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + '8';
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + '9';
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + '.';
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '.';
        }

        private void button29_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
            op = 1;
        }

        private void button33_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
            op = 2;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
            op = 3;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox2.Text);
            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = Math.Pow(num1, num2);
                    break;
                case 5:
                    resultado = Math.Sqrt(num1);
                    break;


            }
            textBox2.Text = resultado.ToString();
        }

        

        private void button23_Click(object sender, EventArgs e)
        {

            num2 = Convert.ToDouble(textBox1.Text);
            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = Math.Pow(num1, num2);
                    break;
                case 5:
                    resultado = Math.Sqrt(num1);
                    break;

            }
            textBox1.Text = resultado.ToString();
        }

        private void button87_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + '0';
        }

        private void button92_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + '1';
        }

        private void button91_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + '2';
        }

        private void button88_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + '3';
        }

        private void button97_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + '4';
        }

        private void button96_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + '5';
        }

        private void button93_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + '6';
        }

        private void button102_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + '7';
        }

        private void button101_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + '8';
        }

        private void button98_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + '9';
        }

        private void button86_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text + '.';
        }

        private void button107_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
            {
                textBox3.Text = textBox3.Text.Substring(0, textBox3.Text.Length - 1);
            }
        }

        private void button106_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";

        }

        private void button103_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void button85_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox3.Text);
            textBox3.Text = "";
            op = 1;
        }

        private void button89_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox3.Text);
            textBox3.Text = "";
            op = 2;
        }

        private void button94_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox3.Text);
            textBox3.Text = "";
            op = 3;
        }

        private void button90_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox3.Text);
            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = Math.Pow(num1, num2);
                    break;
                case 5:
                    resultado = Math.Sqrt(num1);
                    break;

            }
            textBox3.Text = resultado.ToString();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + '0';
        }

        private void button135_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + '1';
        }

        private void button134_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + '2';
        }

        private void button131_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + '3';
        }

        private void button140_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + '4';
        }

        private void button139_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + '5';
        }

        private void button136_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + '6';
        }

        private void button145_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + '7';
        }

        private void button144_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + '8';
        }

        private void button141_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + '9';
        }

        private void button58_Click(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text + '.';
        }

        private void button149_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button146_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button150_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0)
            {
                textBox4.Text = textBox4.Text.Substring(0, textBox4.Text.Length - 1);
            }
        }

        private void button133_Click_1(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox4.Text);
            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = Math.Pow(num1, num2);
                    break;
                case 5:
                    resultado = Math.Sqrt(num1);
                    break;

            }
            textBox4.Text = resultado.ToString();
        }

        private void button57_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(textBox4.Text);
            textBox4.Text = "";
            op = 1;
        }

        private void button132_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            textBox4.Text = "";
            op = 2;
        }

        private void button137_Click_1(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            textBox4.Text = "";
            op = 3;
        }

        private void button158_Click(object sender, EventArgs e)
        {
            textBox9.Text = textBox9.Text + '0';
        }

        private void button163_Click(object sender, EventArgs e)
        {
            textBox9.Text = textBox9.Text + '1';
        }

        private void button162_Click(object sender, EventArgs e)
        {
            textBox9.Text = textBox9.Text + '2';
        }

        private void button159_Click(object sender, EventArgs e)
        {
            textBox9.Text = textBox9.Text + '3';
        }

        private void button168_Click(object sender, EventArgs e)
        {
            textBox9.Text = textBox9.Text + '4';
        }

        private void button167_Click(object sender, EventArgs e)
        {
            textBox9.Text = textBox9.Text + '5';
        }

        private void button164_Click(object sender, EventArgs e)
        {
            textBox9.Text = textBox9.Text + '6';
        }

        private void button173_Click(object sender, EventArgs e)
        {
            textBox9.Text = textBox9.Text + '7';
        }

        private void button172_Click(object sender, EventArgs e)
        {
            textBox9.Text = textBox9.Text + '8';
        }

        private void button169_Click(object sender, EventArgs e)
        {
            textBox9.Text = textBox9.Text + '9';
        }

        private void button157_Click(object sender, EventArgs e)
        {
            textBox9.Text = textBox9.Text + '.';
        }

        private void button156_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox9.Text);
            textBox9.Text = "";
            op = 1;
        }

        private void button160_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox9.Text);
            textBox9.Text = "";
            op = 2;
        }

        private void button165_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox9.Text);
            textBox9.Text = "";
            op = 3;
        }

        private void button161_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox9.Text);
            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = Math.Pow(num1, num2);
                    break;
                case 5:
                    resultado = Math.Sqrt(num1);
                    break;

            }
            textBox9.Text = resultado.ToString();
        }

        private void button174_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
        }

        private void button177_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
        }

        private void button178_Click(object sender, EventArgs e)
        {
            if (textBox9.Text.Length > 0)
            {
                textBox9.Text = textBox9.Text.Substring(0, textBox9.Text.Length - 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = 4;
        }

        private void button48_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
            op = 4;
        }

        private void button104_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(textBox3.Text);
            textBox3.Text = "";
            op = 4;
        }

        private void button147_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(textBox4.Text);
            textBox4.Text = "";
            op = 4;
        }

        private void button175_Click(object sender, EventArgs e)
        {

            num1 = Convert.ToDouble(textBox9.Text);
            textBox9.Text = "";
            op = 4;
        }

        private void button247_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox10.Text);
            textBox9.Text = "";
            op = 5;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            textBox10.Text = "";
            op = 5;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox2.Text);
            textBox10.Text = "";
            op = 5;
        }

        private void button105_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox3.Text);
            textBox10.Text = "";
            op = 5;
        }

        private void button148_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox4.Text);
            textBox10.Text = "";
            op = 5;
        }

        private void button176_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox9.Text);
            textBox10.Text = "";
            op = 5;
        }

        private void conversorDeUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            Size = new Size(panel7.Width + 20, panel7.Height + 60);
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel10.Visible = false;
            panel8.Visible = false;
        }

        private void button232_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textBox10.Text);
            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = Math.Pow( num1,num2);
                    break;
                case 5:
                    resultado = Math.Sqrt(num1);
                    break;
            }
            textBox10.Text = resultado.ToString();
        }
    
        private void button227_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox10.Text);
            textBox10.Text = "";
            op = 1;

        }
    }
}
