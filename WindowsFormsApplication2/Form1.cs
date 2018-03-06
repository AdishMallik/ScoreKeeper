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
        int[] ar = new int[14];
        int incre=10, decre=0;
        int[] crrct = new int[14];

        public Form3 frm2 { get; set; }
        public Form2 frm3 { get; set; }


        private void button6_Click(object sender, EventArgs e)
        {
            ar[5] += incre;
            crrct[5]++;
            label19.Text = ar[5].ToString();
            label24.Text = crrct[5].ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ar[6] += incre;
            crrct[6]++;
            label37.Text = ar[6].ToString();
            label25.Text = crrct[6].ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ar[7] += incre;
            crrct[7]++;
            label38.Text = ar[7].ToString();
            label26.Text = crrct[7].ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ar[8] += incre;
            crrct[8]++;
            label39.Text =ar[8].ToString();
            label27.Text = crrct[8].ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ar[9] += incre;
            crrct[9]++;
            label36.Text = ar[9].ToString();
            label28.Text = crrct[9].ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ar[10] += incre;
            crrct[10]++;
            label41.Text = ar[10].ToString();
            label30.Text = crrct[10].ToString();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            ar[11] += incre;
            crrct[11]++;
            label42.Text = ar[11].ToString();
            label29.Text = crrct[11].ToString();
        }

        private void button5_Click(object sender, EventArgs e1)
        {
            ar[4]+= incre;
            crrct[4]++;
            label35.Text = ar[4].ToString();
            label23.Text = crrct[4].ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ar[3] += incre;
            crrct[3]++;
            label34.Text = ar[3].ToString();
            label22.Text = crrct[3].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ar[2]+= incre;
            crrct[2]++;
            label33.Text = ar[2].ToString();
            label21.Text = crrct[2].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ar[1]+= incre;
            crrct[1]++;
            label32.Text = ar[1].ToString();
            label20.Text = crrct[1].ToString();
        }

        public Form1()
        {
            FullScreen fs = new FullScreen();
            fs.EnterFullScreenMode(this);
            InitializeComponent();
        }
     


        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {
            
        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                incre = int.Parse(textBox1.Text);
                decre = int.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                Error_message er = new Error_message();
                er.show("Input the values of increment and decrement");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ar[0] -= decre;
            label6.Text = ar[0].ToString();

        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            ar[1] -= decre;
            label32.Text = ar[1].ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ar[2] -= decre;
            label33.Text = ar[2].ToString();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            ar[3] -= decre;
            label34.Text = ar[3].ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ar[4] -= decre;
            label35.Text = ar[4].ToString();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            ar[5] -= decre;
            label19.Text = ar[5].ToString();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            ar[6] -= decre;
            label37.Text = ar[6].ToString();
            

        }

        private void button24_Click(object sender, EventArgs e)
        {
            ar[7] -= decre;
            label38.Text = ar[7].ToString();

        }

        private void button25_Click(object sender, EventArgs e)
        {
            ar[8] -= decre;
            label39.Text = ar[8].ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ar[9] -= decre;
            label36.Text = ar[9].ToString();


        }

        private void button27_Click(object sender, EventArgs e)
        {
            ar[10] -= decre;
            label41.Text = ar[10].ToString();

        }

        private void button28_Click(object sender, EventArgs e)
        {
            ar[11] -= decre;
            label42.Text = ar[11].ToString();

        }

        private void button29_Click(object sender, EventArgs e)
        {
            ar[12] -= decre;
            label43.Text = ar[12].ToString();

        }

        private void button30_Click(object sender, EventArgs e)
        {
            ar[13] -= decre;
            label45.Text = ar[13].ToString();
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            ar[13] += incre;
            crrct[13]++;
            label45.Text = ar[13].ToString();
            label47.Text = crrct[13].ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ar[0]+= incre;
            crrct[0]++;
            label6.Text = ar[0].ToString();
            label8.Text = crrct[0].ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            frm3.create_table(ar,crrct);
            frm2.Show();
            this.Hide();

        }

       private void label32_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            ar[12] += incre;
            crrct[12]++;
            label43.Text = ar[12].ToString();
            label31.Text = crrct[12].ToString();
        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

      
        
    }

   public class FullScreen
    {
        public void EnterFullScreenMode(Form targetForm)
        {
            targetForm.WindowState = FormWindowState.Normal;
            //targetForm.FormBorderStyle = FormBorderStyle.None;
            targetForm.WindowState = FormWindowState.Maximized;
        }

        public void LeaveFullScreenMode(Form targetForm)
        {
            targetForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            targetForm.WindowState = FormWindowState.Normal;
        }
    }
    public class SomewhereElse
    {
        public void SomeFunction()
        {
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();

            form1.frm2 = form3;
            form1.frm3 = form2;
            form3.frm1 = form1;
            form3.frm2 = form2;
            form2.frm3 = form3;
            
            Application.Run(form1);
        }
    }

    public class Error_message
    {
        public void show(String s)
        {
            MessageBox.Show(s, "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}


