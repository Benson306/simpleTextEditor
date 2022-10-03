using simpleTextEditor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleTextEditor
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Login and Exit Application
            this.Close();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            //Show the Add User Form
            NewUser frm = new NewUser();
            frm.ShowDialog();
        }
    }
}
