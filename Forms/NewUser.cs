using simpleTextEditor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleTextEditor.Forms
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        //Hide New User Form
        private void btnCancelNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Register a New User
        private void btnRegisterNewUser_Click(object sender, EventArgs e)
        {  
            //check if fields are empty
            if(txtUsername.Text.Trim().Length < 1 || txtPassword.Text.Trim().Length < 1 || txtConfirmPassword.Text.Trim().Length < 1 || txtFirstName.Text.Trim().Length < 1 || txtLastName.Text.Trim().Length < 1 || datePicker.Text.Trim().Length < 1 || cmbUserType.Text.Trim().Length < 1)
            {
                MessageBox.Show("All Fields Must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check if password matches
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password Does Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Set Data to Users Class
            Users_Class users = new Users_Class(txtUsername.Text.Trim(), txtPassword.Text.Trim(), cmbUserType.Text.Trim() , txtFirstName.Text.Trim() , txtLastName.Text.Trim() ,datePicker.Text.Trim());

            //Method from Users_Class to add user to login.txt file
            users.appendLoginInformation();

            //Hide New Users Form after adding new user
            this.Hide();
        }

    }
}
