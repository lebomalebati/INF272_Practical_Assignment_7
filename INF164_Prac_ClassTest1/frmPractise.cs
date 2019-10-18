using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace INF164_Prac_ClassTest1
{
    public partial class frmPractise : Form
    {
        public frmPractise()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you click the Hide button, one Spanish and one Sepedi" + "\n" + "word will be hiddenso that you can test yourself." + "\n" + "\n" + "Click Show to see the words again." + "\n" + "\n" + "When you are ready to take the test, click Exit." + "\n" + "Then click the Test button on the opening form");
        }

        private void frmPractise_Load(object sender, EventArgs e)
        {
            dgvLanguage.Rows.Add(10);
            btnShow.Enabled = false;

            for (int j=0; j<=9; j++)
            {
                dgvLanguage[0, j].Value = english[j];
                dgvLanguage[1, j].Value = spanish[j];
                dgvLanguage[2, j].Value = sepedi[j];
            }          

            
        }

        string[] english = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
        string[] spanish = { "uno", "dos", "tres", "cuarto", "cinco", "seis", "siete", "ocho", "nueve", "diez" };
        string[] sepedi = { "tee", "pedi", "tharo", "nne", "hlano", "tshela", "supa", "seswai", "senyane", "lesome" };

        Random Num = new Random();
        int rowSpanish;
        int rowSepedi;

        private void btnHide_Click(object sender, EventArgs e)
        {
            rowSpanish = Num.Next(0, 10);
            rowSepedi = Num.Next(0, 10);

            dgvLanguage.Rows[rowSpanish].Cells[1].Style.BackColor = Color.Black;
            dgvLanguage.Rows[rowSepedi].Cells[2].Style.BackColor = Color.Black;

            btnShow.Enabled = true;
            btnHide.Enabled = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvLanguage.Rows[rowSpanish].Cells[1].Style.BackColor = Color.White;
            dgvLanguage.Rows[rowSepedi].Cells[2].Style.BackColor = Color.White;

            btnHide.Enabled = true;
            btnShow.Enabled = false;
        }
    }
}
