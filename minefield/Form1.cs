using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minefield
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void diffLvl (object sender, EventArgs e)
        {
            int wBtn = 25;
            Form easyForm = new Form();
            easyForm.Width = 363;
            easyForm.Height = 383;
            for (int i = 0; i < 13; i++)
            {
                for (int x = 0; x < 13; x++)
                {
                    Button uknBtn = new Button();
                    uknBtn.Location = new Point(10+i*wBtn,10+x*wBtn);
                    uknBtn.Width = wBtn;
                    uknBtn.Height = wBtn;
                    uknBtn.Text = "*";
                    easyForm.Controls.Add(uknBtn);

                }
            }
            easyForm.Show();
        }
    }
}
