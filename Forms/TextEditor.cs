using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleTextEditor.Forms
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            panelFile.Height = 0;
            panelFile.Width = 0;

            panelEdit.Width = 0;
            panelEdit.Height = 0;

            panelHelp.Width = 0;
            panelHelp.Height = 0;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if(panelFile.Height == 164)
            {
                panelFile.Height = 0;
                panelFile.Width = 0;
            }
            else
            {
                panelFile.Height = 164;
                panelFile.Width = 172;

                panelEdit.Width = 0;
                panelEdit.Height = 0;

                panelHelp.Width = 0;
                panelHelp.Height = 0;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (panelEdit.Height == 99)
            {
                panelEdit.Height = 0;
                panelEdit.Width = 0;
            }
            else
            {
                panelEdit.Height =99;
                panelEdit.Width = 172;

                panelFile.Height = 0;
                panelFile.Width = 0;

                panelHelp.Width = 0;
                panelHelp.Height = 0;

            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (panelHelp.Height == 30)
            {
                panelHelp.Height = 0;
                panelHelp.Width = 0;
            }
            else
            {
                panelEdit.Height = 0;
                panelEdit.Width = 0;

                panelFile.Height = 0;
                panelFile.Width = 0;

                panelHelp.Width = 112;
                panelHelp.Height = 30;

            }
        }

        //Show About form
        private void btnAbout_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.ShowDialog();
        }

        //logout button clicked
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();

            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
