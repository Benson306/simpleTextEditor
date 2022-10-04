using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

        //Open file
        string fileName;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                

                fd.Filter = "Text files (*.txt)|*.txt|RTF files (*.rtf)|*.rtf";

                if (fd.ShowDialog() == DialogResult.OK)
                {

                    fileName = fd.FileName;
                    if (Path.GetExtension(fileName) == ".rtf")
                    {
                        richTextBox1.LoadFile(fileName, RichTextBoxStreamType.RichText);
                    }
                    if (Path.GetExtension(fileName) == ".txt")
                    {
                        richTextBox1.LoadFile(fileName, RichTextBoxStreamType.PlainText);
                    }
                }
            }
        }
        
        //Function to Save .rtf file

        public void saveFile()
        {
            //check if file path is null
            if (fileName == null)
            {
                if (richTextBox1.Text == String.Empty) //Check if richTextBox1 is empty
                {
                    MessageBox.Show("Cannot Save an Empty File.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //If its not empty and its a new file , Save AS method is called instead of save
                    MessageBox.Show("Save As");
                }
            }
            else
            {
                string path = "../../login.rtf";
                using (File.Create(path)) ;
                richTextBox1.SaveFile(path, RichTextBoxStreamType.RichText);

                MessageBox.Show("File Has Been saved as" + "login.rtf", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        // New Button
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text != string.Empty)
            {
                    DialogResult result = MessageBox.Show("Would You Like to Save the document before proceeding?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        saveFile(); //Call the save method.
                    }
                    else
                    {
                        richTextBox1.Text = string.Empty; //clear richTextBox
                    }
            }
            
        }
    }
}
