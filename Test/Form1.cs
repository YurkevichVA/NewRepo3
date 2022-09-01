using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Button skovoroda = (Button)sender;

            Random random = new Random();
            skovoroda.Location = new Point(random.Next(0, Size.Width - skovoroda.Width), random.Next(0, Size.Height - skovoroda.Height));
        }
    }
}
