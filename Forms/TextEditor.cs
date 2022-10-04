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
        public string username { get; set; }
        public string userType { get; set; }
        public TextEditor()
        {
            InitializeComponent();
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            lblUserName.Text = username;
        }

        //Show About form        
        private void btnAbout_Click_1(object sender, EventArgs e)
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
