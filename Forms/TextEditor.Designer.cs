using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace simpleTextEditor.Forms
{
    partial class TextEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.leftToolTip = new System.Windows.Forms.Panel();
            this.btnSidePaste = new System.Windows.Forms.Button();
            this.btnSideCopy = new System.Windows.Forms.Button();
            this.btnSideCut = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblUserName = new System.Windows.Forms.ToolStripLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.leftToolTip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftToolTip
            // 
            this.leftToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.leftToolTip.Controls.Add(this.btnSidePaste);
            this.leftToolTip.Controls.Add(this.btnSideCopy);
            this.leftToolTip.Controls.Add(this.btnSideCut);
            this.leftToolTip.Location = new System.Drawing.Point(-1, 52);
            this.leftToolTip.Name = "leftToolTip";
            this.leftToolTip.Size = new System.Drawing.Size(41, 109);
            this.leftToolTip.TabIndex = 8;
            // 
            // btnSidePaste
            // 
            this.btnSidePaste.FlatAppearance.BorderSize = 0;
            this.btnSidePaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSidePaste.Image = ((System.Drawing.Image)(resources.GetObject("btnSidePaste.Image")));
            this.btnSidePaste.Location = new System.Drawing.Point(1, 70);
            this.btnSidePaste.Name = "btnSidePaste";
            this.btnSidePaste.Size = new System.Drawing.Size(37, 28);
            this.btnSidePaste.TabIndex = 11;
            this.btnSidePaste.UseVisualStyleBackColor = true;
            this.btnSidePaste.Click += new System.EventHandler(this.btnSidePaste_Click);
            // 
            // btnSideCopy
            // 
            this.btnSideCopy.FlatAppearance.BorderSize = 0;
            this.btnSideCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnSideCopy.Image")));
            this.btnSideCopy.Location = new System.Drawing.Point(2, 34);
            this.btnSideCopy.Name = "btnSideCopy";
            this.btnSideCopy.Size = new System.Drawing.Size(37, 28);
            this.btnSideCopy.TabIndex = 10;
            this.btnSideCopy.UseVisualStyleBackColor = true;
            this.btnSideCopy.Click += new System.EventHandler(this.btnSideCopy_Click);
            // 
            // btnSideCut
            // 
            this.btnSideCut.FlatAppearance.BorderSize = 0;
            this.btnSideCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideCut.Image = ((System.Drawing.Image)(resources.GetObject("btnSideCut.Image")));
            this.btnSideCut.Location = new System.Drawing.Point(2, 5);
            this.btnSideCut.Name = "btnSideCut";
            this.btnSideCut.Size = new System.Drawing.Size(37, 28);
            this.btnSideCut.TabIndex = 9;
            this.btnSideCut.UseVisualStyleBackColor = true;
            this.btnSideCut.Click += new System.EventHandler(this.btnSideCut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveASToolStripMenuItem,
            this.btnLogout});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.newToolStripMenuItem.Text = "New           Ctrl + N";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.openToolStripMenuItem.Text = "Open          Ctrl + O";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.saveToolStripMenuItem.Text = "Save           Ctlr + S";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveASToolStripMenuItem
            // 
            this.saveASToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveASToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveASToolStripMenuItem.Image")));
            this.saveASToolStripMenuItem.Name = "saveASToolStripMenuItem";
            this.saveASToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.saveASToolStripMenuItem.Text = "Save As";
            this.saveASToolStripMenuItem.Click += new System.EventHandler(this.saveASToolStripMenuItem_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(206, 26);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbout});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(131, 24);
            this.btnAbout.Text = "About....";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 56);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripOpen,
            this.toolStripSave,
            this.toolStripSaveAs,
            this.toolStripSeparator1,
            this.toolStripBold,
            this.toolStripItalic,
            this.toolStripUnderline,
            this.toolStripComboBox1,
            this.toolStripLabel1,
            this.lblUserName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(907, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNew
            // 
            this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNew.Image")));
            this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripNew.Text = "toolStripButton1";
            this.toolStripNew.ToolTipText = "New";
            this.toolStripNew.Click += new System.EventHandler(this.toolStripNew_Click);
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpen.Image")));
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpen.Text = "toolStripButton2";
            this.toolStripOpen.ToolTipText = "Open";
            this.toolStripOpen.Click += new System.EventHandler(this.toolStripOpen_Click);
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripSave.Text = "toolStripButton3";
            this.toolStripSave.ToolTipText = "Save";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripSaveAs
            // 
            this.toolStripSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveAs.Image")));
            this.toolStripSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveAs.Name = "toolStripSaveAs";
            this.toolStripSaveAs.Size = new System.Drawing.Size(23, 22);
            this.toolStripSaveAs.Text = "toolStripButton4";
            this.toolStripSaveAs.ToolTipText = "Save As";
            this.toolStripSaveAs.Click += new System.EventHandler(this.toolStripSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripBold
            // 
            this.toolStripBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBold.Image")));
            this.toolStripBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBold.Name = "toolStripBold";
            this.toolStripBold.Size = new System.Drawing.Size(23, 22);
            this.toolStripBold.Text = "toolStripButton5";
            this.toolStripBold.ToolTipText = "Bold";
            this.toolStripBold.Click += new System.EventHandler(this.toolStripBold_Click);
            // 
            // toolStripItalic
            // 
            this.toolStripItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItalic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItalic.Image")));
            this.toolStripItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItalic.Name = "toolStripItalic";
            this.toolStripItalic.Size = new System.Drawing.Size(23, 22);
            this.toolStripItalic.Text = "toolStripButton6";
            this.toolStripItalic.ToolTipText = "Italic";
            this.toolStripItalic.Click += new System.EventHandler(this.toolStripItalic_Click);
            // 
            // toolStripUnderline
            // 
            this.toolStripUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUnderline.Image")));
            this.toolStripUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUnderline.Name = "toolStripUnderline";
            this.toolStripUnderline.Size = new System.Drawing.Size(23, 22);
            this.toolStripUnderline.Text = "toolStripButton7";
            this.toolStripUnderline.ToolTipText = "underline";
            this.toolStripUnderline.Click += new System.EventHandler(this.toolStripUnderline_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel1.Text = "User Name:";
            // 
            // lblUserName
            // 
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(65, 22);
            this.lblUserName.Text = "username";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(64, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 455);
            this.panel2.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(21, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(743, 408);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftToolTip);
            this.Name = "TextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Simple Text Editor v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TextEditor_Load);
            this.leftToolTip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel leftToolTip;
        private System.Windows.Forms.Button btnSideCut;
        private System.Windows.Forms.Button btnSideCopy;
        private System.Windows.Forms.Button btnSidePaste;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripNew;
        private System.Windows.Forms.ToolStripButton toolStripOpen;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripButton toolStripSaveAs;
        private System.Windows.Forms.ToolStripButton toolStripBold;
        private System.Windows.Forms.ToolStripButton toolStripItalic;
        private System.Windows.Forms.ToolStripButton toolStripUnderline;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblUserName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}