using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Project_INT102
{
    public partial class Form1 : Form
    {
        Thread th;
        private Form2 frm2;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th=new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
    }

        private void opennewform(object obj)
        {
            Application.Run(new Form2());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
