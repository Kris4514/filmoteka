using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmoteka
{
    public partial class MarksForm : Form
    {
        string mark;
        int x;
        public MarksForm()
        {
            InitializeComponent();
           
        }

        

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            valuelabel.Text = trackBar1.Value.ToString();
            mark = trackBar1.Value.ToString();
            x = Convert.ToInt32(mark);
           /* if (x==2)
            {
                pictureBox2.Visible = false;
            }
            if (x == 3)
            {
                pictureBox3.Visible = false;

            }
            if (x == 4)
            {
                pictureBox4.Visible = false;
                

            }
            if (x == 5)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

            } */
        }
    }
}
