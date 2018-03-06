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
    public partial class Form2 : Form
     {
       
        public Form3 frm3 { get; set; }

        DataTable score_table = new DataTable();
        

        public Form2()
        {
            FullScreen fs = new FullScreen();
            fs.EnterFullScreenMode(this);
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm3.Show();
            this.Hide();
        }

       

       
       
        private void button9_Click(object sender, EventArgs e)
        {
            frm3.Show();
            this.Hide();
    
        }

       public void create_table(int[] ar, int[] crt)
        {
            try
            {
                score_table.Columns.Add(new DataColumn("Team Name"));
                score_table.Columns.Add(new DataColumn("Score",typeof(Int32)));
                score_table.Columns.Add(new DataColumn("Correct Answers"));

            }
            catch (System.Data.DuplicateNameException) { }
            score_table.Rows.Clear();
            char a = 'A';
            for (int i = 0; i < 14; i++)
            {
                score_table.Rows.Add(a,ar[i],crt[i]);
                a++;

            }

            DataView dv = score_table.DefaultView;
            dv.Sort = "Score DESC";
            DataTable sortedDT = dv.ToTable();
            show(sortedDT);

        }
  

       

        public void show(DataTable dt)
        {
            label5.Text = ("TEAM " + dt.Rows[0][0].ToString()); label6.Text = dt.Rows[0][1].ToString();label8.Text = dt.Rows[0][2].ToString();
            label7.Text = ("TEAM " + dt.Rows[1][0].ToString());label32.Text = dt.Rows[1][1].ToString();label20.Text = dt.Rows[1][2].ToString();
            label9.Text = ("TEAM " + dt.Rows[2][0].ToString()); label33.Text = dt.Rows[2][1].ToString();label21.Text = dt.Rows[2][2].ToString();
            label10.Text = ("TEAM " + dt.Rows[3][0].ToString());label34.Text = dt.Rows[3][1].ToString();label22.Text = dt.Rows[3][2].ToString(); 
            label11.Text = ("TEAM " + dt.Rows[4][0].ToString());label35.Text = dt.Rows[4][1].ToString();label23.Text = dt.Rows[4][2].ToString();
            label12.Text = ("TEAM " + dt.Rows[5][0].ToString());label19.Text = dt.Rows[5][1].ToString();label24.Text = dt.Rows[5][2].ToString();
            label13.Text = ("TEAM " + dt.Rows[6][0].ToString());label37.Text = dt.Rows[6][1].ToString();label25.Text = dt.Rows[6][2].ToString();
            label15.Text = ("TEAM " + dt.Rows[7][0].ToString());label38.Text = dt.Rows[7][1].ToString();label26.Text = dt.Rows[7][2].ToString(); 
            label14.Text = ("TEAM " + dt.Rows[8][0].ToString());label39.Text = dt.Rows[8][1].ToString();label27.Text = dt.Rows[8][2].ToString();
            label16.Text = ("TEAM " + dt.Rows[9][0].ToString());label36.Text = dt.Rows[9][1].ToString();label28.Text = dt.Rows[9][2].ToString();
            label17.Text = ("TEAM " + dt.Rows[10][0].ToString());label41.Text = dt.Rows[10][1].ToString();label30.Text = dt.Rows[10][2].ToString();
            label18.Text = ("TEAM " + dt.Rows[11][0].ToString());label42.Text = dt.Rows[11][1].ToString();label29.Text = dt.Rows[11][2].ToString();
            label40.Text = ("TEAM " + dt.Rows[12][0].ToString());label43.Text = dt.Rows[12][1].ToString();label31.Text = dt.Rows[12][2].ToString();
            label46.Text = ("TEAM " + dt.Rows[13][0].ToString());label45.Text = dt.Rows[13][1].ToString();label47.Text = dt.Rows[13][2].ToString();


        }
    }
}
