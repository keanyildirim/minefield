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
        private void createMine()
        {
            int[,] minefieldLoc =new int[13,13];
            Random rnd = new Random();
            int[,] mineLoc = new int[2, 7];

            for (int i = 0; i < 13; i++)
            {
                for (int x = 0; x < 13; x++)
                {
                    minefieldLoc[i,x] = 0 ;
                    
                }
            }
            
            for (int i = 0; i < 7; i++)
            {
                int height = rnd.Next(13);
                int width = rnd.Next(13);
                if (minefieldLoc[height,width]==9)
                {
                    i--;
                }
                else
                {
                    minefieldLoc[height, width] = 9;
                    mineLoc[0, i] = height;
                    mineLoc[1, i] = width;
                    //Console.WriteLine(mineLoc[0, i].ToString());
                    //Console.WriteLine(mineLoc[1, i].ToString());
                }

                //Console.WriteLine(i.ToString());

            }
            
            
        }
        private void diffLvl (object sender, EventArgs e)
        {
            createMine();
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
