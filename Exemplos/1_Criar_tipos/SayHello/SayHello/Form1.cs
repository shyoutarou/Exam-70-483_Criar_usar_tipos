using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayHello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region MTLCode

        private void button1_Click(object sender, EventArgs e)
        {
            SayHello();
        }


        public void SayHello()
        {
            MessageBox.Show("Hello...");
        }

        #endregion
    }
}
