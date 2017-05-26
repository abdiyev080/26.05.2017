using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        Panel[] pan = new Panel[5];
        Label[] lb = new Label[5];
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            int col = 10;
            int row = 10;
            for (int t = 1; t < row; t++)
            {

                for (int i = 1; i < col; i++)
                {

                    Button Btn = new Button();
                    Btn.Text = (row * t+i+1).ToString();
                    Btn.Width = 64;
                    Btn.Height = 23;
                    Btn.Location = new Point(t*Btn.Width,i*Btn.Height);
                    this.Controls.Add(Btn);

                }
            }
        }
    }
}


       


