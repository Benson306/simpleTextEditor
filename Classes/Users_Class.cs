using simpleTextEditor.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        //Method to carry out user authentication on Login
        public bool Login()
        {
            string file = @"../../login.txt";

            string[] lines = System.IO.File.ReadAllLines(file); //Read File

            for(int i = 0; i < lines.Length; i++) //Loop through lines in the file
            {
                string[] field = lines[i].Split(','); //split every phrase separated by a comma into single word and store them in an array

                if (field[0] == username && field[1] == password) 
                {
                    this.userType = field[2];
                    this.firstName = field[3];
                    this.lastName = field[4];
                    this.DateOfBirth = field[5];

                    using ( TextEditor frm = new TextEditor())
                    {
                        frm.username = this.username;
                        frm.userType = this.userType;
                        frm.ShowDialog();
                    }

                    return true;

                }
                
            }
            MessageBox.Show("Your Login Credentials Are Not Correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }


    }
}


