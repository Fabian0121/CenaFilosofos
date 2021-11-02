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

namespace CenaFilosofo
{
    public partial class Form1 : Form
    {
        public Mutex mutex = new Mutex();
        //
        //public void 
        //
        public Form1()
        {
            InitializeComponent();
                      
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
