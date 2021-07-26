using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prvi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form1.dogadjaj += kreirajDugmice;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void kreirajDugmice(int broj)
        {
            this.Controls.Clear();
            Random rnd = new Random();
            for (int i = 0; i < broj; i++)
            {
                Button b = new Button();
                b.Left = rnd.Next(this.ClientSize.Width - b.Width);
                b.Top = rnd.Next(this.ClientSize.Height - b.Height);
                b.Text = (i + 1).ToString();
                this.Controls.Add(b);
            }

        }
    }
}
