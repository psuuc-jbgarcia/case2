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
    public partial class Form3 : Form
    {
        public Form3(string text)
        {
            InitializeComponent();
            MessageBox.Show(text);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
