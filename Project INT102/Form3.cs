using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_INT102
{
    public partial class Form2 : Form
    {
       
       
        public Form2()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        
       

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            float kilo = 0, totalkilo = 0,total=0;
            bool check;
            if (kilo1.Text.Length  == 0)
            {
                MessageBox.Show("กรุณาป้อนน้ำหนักให้ถูกต้อง");
                return;
            }
            check = float.TryParse(kilo1.Text,out kilo );
            if (check == false)
            {
                MessageBox.Show("กรุณาป้อนน้ำหนักให้ถูกต้อง");
                kilo1.Clear();
                kilo1.Select();
                return;
            }
            if (rd1.Checked)
            {
                total =30;
            }
            else if (rd2.Checked)
            {
                total = 50;
            }
            if (txt1.Text.Length == 0)
            {
                MessageBox.Show("กรุณาป้อนชื่อผู้ส่งให้ถูกต้อง");
                return;
            }
            if (txt2.Text.Length == 0)
            {
                MessageBox.Show("กรุณาป้อนที่อยู่ผู้ส่งให้ถูกต้อง");
                return;
            }
            if (txt3.Text.Length == 0)
            {
                MessageBox.Show("กรุณาป้อนชื่อผู้รับให้ถูกต้อง");
                return;
            }
            if (txt4.Text.Length == 0)
            {
                MessageBox.Show("กรุณาป้อนชื่อผู้รับให้ถูกต้อง");
                return;
            }
            string typesent ="";
            if(!rd1.Checked && !rd2.Checked)
            {
                MessageBox.Show("กรุณาเลือกข้อมูลให้ชัดเจนด้วยค่ะ");
                return;
            }
          


            if (rd1.Checked)
                typesent = rd1.Text;
            if (rd2.Checked)
                typesent = rd2.Text;
            

            totalkilo = kilo * 5+total;
            scrip.Items.Add("            ยินดีต้อนรับ สู่ รับน้า ver 2.0 eiei");
            scrip.Items.Add("ข้อมูลผู้ส่ง");
            scrip.Items.Add("ชื่อ-นามสกุล:\t"     +txt1.Text);
            scrip.Items.Add("ที่อยู่:\t"        +txt2.Text);
            scrip.Items.Add("ข้อมูลผู้รับ");
            scrip.Items.Add("ชื่อ-นามสกุล:\t"     +txt3.Text);
            scrip.Items.Add("ที่อยู่:\t"          +txt4.Text);
            scrip.Items.Add("ราคารวม:     "+totalkilo +"บาท");
            scrip.Items.Add(typesent);
            scrip.Items.Add("------------------------------------------------------------");
           


            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            
            
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            scrip.Items.Clear();
        }

        private void scrip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                    }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           

        }

        private void button4_Click(object sender, EventArgs e)
        {   Boolean check ;
            float kilo= 0, totalkilo=0;
            
            totalkilo = kilo * 5;

            check = float.TryParse(kilo1.Text,out kilo );
            if (check == false)
            {
                MessageBox.Show("กรุณาป้อนน้ำหนักให้ถูกต้อง");
                kilo1.Clear();
                kilo1.Select();
                return;
            }
            totalkilo = kilo * 5;
            MessageBox.Show(totalkilo + "บาท");
        }
    }
}
