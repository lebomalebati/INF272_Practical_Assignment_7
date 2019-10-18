using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164_Prac_ClassTest1
{
    public partial class frmCount : Form
    {
        public frmCount()
        {
            InitializeComponent();
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            frmPractise myForm1 = new frmPractise();
            myForm1.ShowDialog();
        }
    }
}
