using simpleTextEditor.Classes;
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
            Application.Exit();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            //Show the Add User Form
            NewUser frm = new NewUser();
            frm.ShowDialog();
        }

        //login button clicked
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim().Length < 1 || txtPassword.Text.Trim().Length <1)
            {
                MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Create an Instance of Users Class
            Users_Class user = new Users_Class(txtUsername.Text, txtPassword.Text, "", "","","");

            //Call the login method in Users_Class
            if (user.Login())
            {
                this.Hide();
            }
 
        }
    }
}
