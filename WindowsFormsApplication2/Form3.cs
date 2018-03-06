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
    public partial class Form3 : Form
    {
        public Form2 frm2 { get; set; }
        public Form1 frm1 { get; set; }
        private System.Windows.Forms.Timer timer1;
        int flag = 1;
        private int counter;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer("D:\\WindowsFormsApplication2\\WindowsFormsApplication2\\tick-tock.wav");
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer("D:\\WindowsFormsApplication2\\WindowsFormsApplication2\\time-up.wav");

        public Form3()
        {
            FullScreen fs = new FullScreen();
            fs.EnterFullScreenMode(this);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (flag == 1)
            {
                try
                {
                    counter = int.Parse(this.textBox1.Text);
                    timer1 = new System.Windows.Forms.Timer();
                    timer1.Tick += new EventHandler(timer1_Tick);
                    timer1.Interval = 1000; // 1 second
                    timer1.Start();

                    label2.Text = counter.ToString();
                    flag = 0;

                }
                catch (System.FormatException)
                {
                    Error_message er = new Error_message();
                    er.show("Enter time limit for timer");
                };
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            player.Play();
            if (counter == 0)
            {
                flag = 1;
                timer1.Stop();
                player.Stop();
                player2.Play();
            }
            label2.Text = counter.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
            try
            {
                timer1.Stop();
                flag = 1;
                label2.Text = "0";
                player.Stop();
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                flag = 1;
                label2.Text = "0";
                player.Stop();
            }
            catch (Exception)
            {
                Error_message er = new Error_message();
                er.show("Timer is not running");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                flag = 1;
                label2.Text = "0";
                player.Stop();
            }
            catch (Exception) { }
            frm2.Show();
            this.Hide();
        }
    }
}
