using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openfrom
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mf= new mainform();    
            mf.ShowDialog();
        
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            mainform mf= new mainform();
            mf.ShowDialog(this);
        }
    }
}
