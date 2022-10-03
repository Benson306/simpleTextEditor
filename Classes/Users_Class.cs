using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleTextEditor.Classes
{
    internal class Users_Class
    {
        public string username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string DateOfBirth { get; set; }
        public string userType { get; set; }
        
        public Users_Class(string username, string password, string userType, string firstName, string lastName, string DateOfBirth)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.DateOfBirth = DateOfBirth;
            this.userType = userType;
        }

        

        public void appendLoginInformation()
        {
            // initialize file 'login.txt' to save user credentials
            string myfile = @"../../login.txt";

            //append credentials to file
            using (StreamWriter sw = File.AppendText(myfile))
            {
                sw.WriteLine(username + "," + password + "," + userType + "," + firstName + "," + lastName + "," + DateOfBirth);
            }

            MessageBox.Show("User Has Been Added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
