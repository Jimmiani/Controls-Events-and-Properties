using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls__Events__and_Properties
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            imgCharacter.Visible = true;
            lblStatus.Text = "Status: Clicked";
            btnSubmit.Enabled = false;
            btnQuit.Enabled = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imgCharacter_Click(object sender, EventArgs e)
        {
            imgCharacter.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.RoyalBlue;
        }

        private void btnSurprise_MouseHover(object sender, EventArgs e)
        {
            lblSurprise.Visible = true;
            btnSurprise.Enabled = false;
        }
    }
}
