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

            //Check if user is View or edit and make rich text box enabled or disabled
            if(userType == "View")
            {
                richTextBox1.Enabled = false;
            }
            else
            {
                richTextBox1.Enabled = true;
            }
        }

        string fileName;

        //Open file method
        public void openFIle()
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {


                fd.Filter = "RTF files (*.rtf)|*.rtf|Text files (*.txt)|*.txt";

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
        
        //Method to Save .rtf file
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
                    saveAs();
                }
            }
            else
            {
                String newPath = fileName.Substring(0, (fileName.Length - 4)); // remove.txt or .rtf from filename

                string path = newPath+".rtf"; //Add .rtf to fileName

                using (File.Create(path));
                richTextBox1.SaveFile(path, RichTextBoxStreamType.RichText);

                MessageBox.Show("File Has Been saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Method to Save AS .rtf
        public void saveAs()
        {
            if(richTextBox1.Text == String.Empty)
            {
                MessageBox.Show("You cannot Save an empty Document","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "RTF files (*.rtf)|*.rtf";
                saveFileDialog1.Title = "Save the Document";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    MessageBox.Show("File Has Been Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        //New Button Method
        public void NewFile()
        {
            if (richTextBox1.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("Would You Like to Save the document before proceeding?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saveFile(); //Call the save method.
                    richTextBox1.Text = string.Empty;
                }
                else
                {
                    richTextBox1.Text = string.Empty; //clear richTextBox
                }
            }
        }

        //Cut text Method
        public void cutText()
        {
            try
            {
                //First copy to clipboard
                Clipboard.SetText(richTextBox1.SelectedText, TextDataFormat.UnicodeText);

                //Then Delete
                richTextBox1.SelectedText = "";
            }
            catch (Exception)
            {

            }
        }

        //Copy Text Method
        public void copyText()
        {
            try
            {
                Clipboard.SetText(richTextBox1.SelectedText, TextDataFormat.UnicodeText);
                //Clipboard.SetText(richTextBox1.SelectedRtf, TextDataFormat.Rtf);
            }
            catch (Exception)
            {

            }
        }

        //Paste TExt Method
        public void pasteText()
        {
            try
            {
                if (Clipboard.ContainsText(TextDataFormat.UnicodeText))
                {
                    int i = richTextBox1.SelectionStart;
                    richTextBox1.Text += Clipboard.GetText(TextDataFormat.UnicodeText);
                    richTextBox1.SelectionStart = i;
                }
            }
            catch (Exception)
            {

            }
        }

        //Open File Button
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFIle();
        }

        //Save File Button
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        // New File Button
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        //Save AS BUtton
        private void saveASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAs();
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

        private void toolStripNew_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            openFIle();
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void toolStripSaveAs_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        //Copy Selected Text
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyText();
        }
        //Paste Text from clipboard
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteText();
        }
       
        //Button Cut Selected Text
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutText();
        }

        //Side bar cut button
        private void btnSideCut_Click_1(object sender, EventArgs e)
        {
            cutText();
        }
 

        //Side bar copy button  
        private void btnSideCopy_Click_1(object sender, EventArgs e)
        {
            copyText();
        }

        //Side bar paste text button
        private void btnSidePaste_Click_1(object sender, EventArgs e)
        {
            pasteText();
        }
        
        //Make Selected Text Bold
        private void toolStripBold_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = richTextBox1.SelectionFont;
            if (SelectedText_Font != null)
            {
                richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Bold);
            }
        }

        //Italize selected Text
        private void toolStripItalic_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = richTextBox1.SelectionFont;
            if (SelectedText_Font != null)
            {
                richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Italic);
            }
        }
        
        //Underline Selected text
        private void toolStripUnderline_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = richTextBox1.SelectionFont;
            if (SelectedText_Font != null)
            {
                richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Underline);
            }
        }

        //Change Font Size
        public void SetNewFont()
        {
            Font oldFont;
            Font newFont;
            string FName;
            float FontSize = 8;
            FontStyle style = 0;
            byte charset = 0;

            FName = "Times New Roman";
            if (string.IsNullOrEmpty(toolStripComboBox1.Text))
            {
                FontSize = 8;
            }
            else
            {
                FontSize = float.Parse(toolStripComboBox1.Text);
            }
            oldFont = richTextBox1.SelectionFont;

            //Check previos style of font and make sure it return same style after changing font size
            if(oldFont == null)
            {
                style = FontStyle.Regular;
            }
            else
            {
                style = oldFont.Style;
                charset = oldFont.GdiCharSet;
            }

            newFont = new Font(FName, FontSize, style, GraphicsUnit.Point, charset);
            richTextBox1.SelectionFont = newFont;
        }

        //Click font change
        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            SetNewFont();
        }

        private void TextEditor_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.N)       // Ctrl + N New
            {
                NewFile();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }

            if (e.Control && e.KeyCode == Keys.S)       // Ctrl + S Save
            {
                saveFile();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }

            if (e.Control && e.KeyCode == Keys.O)       // Ctrl + O Open
            {
                openFIle();
                e.SuppressKeyPress = true;  // Stops other controls on the form receiving event.
            }
        }

    }
}
