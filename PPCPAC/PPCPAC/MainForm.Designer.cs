namespace PPCPAC
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.homeBtn = new System.Windows.Forms.MenuItem();
            this.menuBtn = new System.Windows.Forms.MenuItem();
            this.scToggle = new System.Windows.Forms.MenuItem();
            this.infoBtn = new System.Windows.Forms.MenuItem();
            this.exitBtn = new System.Windows.Forms.MenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.catalogPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.label10 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.catalogPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Info.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.homeBtn);
            this.mainMenu1.MenuItems.Add(this.menuBtn);
            // 
            // homeBtn
            // 
            this.homeBtn.Text = "Home";
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.MenuItems.Add(this.scToggle);
            this.menuBtn.MenuItems.Add(this.infoBtn);
            this.menuBtn.MenuItems.Add(this.exitBtn);
            this.menuBtn.Text = "App";
            // 
            // scToggle
            // 
            this.scToggle.Checked = true;
            this.scToggle.Text = "Hide Screenshots";
            this.scToggle.Click += new System.EventHandler(this.scToggle_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Text = "Info";
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Text = "Exit";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.catalogPage);
            this.tabControl.Controls.Add(this.searchTab);
            this.tabControl.Controls.Add(this.Info);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.None;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(240, 294);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // catalogPage
            // 
            this.catalogPage.BackColor = System.Drawing.Color.Black;
            this.catalogPage.Controls.Add(this.panel3);
            this.catalogPage.Controls.Add(this.label6);
            this.catalogPage.Location = new System.Drawing.Point(0, 0);
            this.catalogPage.Name = "catalogPage";
            this.catalogPage.Size = new System.Drawing.Size(240, 267);
            this.catalogPage.Text = "Catalog";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(212)))), ((int)(((byte)(78)))));
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 29);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(7, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 25);
            this.label11.Text = "App Catalog";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(73, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 62);
            this.label6.Text = "browser will appear here";
            // 
            // searchTab
            // 
            this.searchTab.BackColor = System.Drawing.Color.Black;
            this.searchTab.Controls.Add(this.searchBtn);
            this.searchTab.Controls.Add(this.label4);
            this.searchTab.Controls.Add(this.categoryBox);
            this.searchTab.Controls.Add(this.searchTxt);
            this.searchTab.Controls.Add(this.label3);
            this.searchTab.Controls.Add(this.panel1);
            this.searchTab.Location = new System.Drawing.Point(0, 0);
            this.searchTab.Name = "searchTab";
            this.searchTab.Size = new System.Drawing.Size(240, 267);
            this.searchTab.Text = "Search";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(212)))), ((int)(((byte)(78)))));
            this.searchBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.searchBtn.Location = new System.Drawing.Point(8, 182);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(70, 22);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Go";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 19);
            this.label4.Text = "Search by category:";
            // 
            // categoryBox
            // 
            this.categoryBox.BackColor = System.Drawing.Color.White;
            this.categoryBox.ForeColor = System.Drawing.Color.Black;
            this.categoryBox.Items.Add("none");
            this.categoryBox.Items.Add("app");
            this.categoryBox.Items.Add("game");
            this.categoryBox.Items.Add("driver");
            this.categoryBox.Location = new System.Drawing.Point(8, 133);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(225, 26);
            this.categoryBox.TabIndex = 3;
            // 
            // searchTxt
            // 
            this.searchTxt.BackColor = System.Drawing.Color.White;
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchTxt.ForeColor = System.Drawing.Color.Black;
            this.searchTxt.Location = new System.Drawing.Point(8, 69);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(225, 25);
            this.searchTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 19);
            this.label3.Text = "Search by text:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(212)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 29);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.Text = "Search";
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.Black;
            this.Info.Controls.Add(this.label9);
            this.Info.Controls.Add(this.label5);
            this.Info.Controls.Add(this.label8);
            this.Info.Controls.Add(this.label7);
            this.Info.Controls.Add(this.pictureBox1);
            this.Info.Controls.Add(this.panel2);
            this.Info.Location = new System.Drawing.Point(0, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(240, 267);
            this.Info.Text = "Info";
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 62);
            this.label9.Text = "Version 0.1.1\r\ngithub.com/pocket-pc-planet\r\nppcplanet.org";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(44, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "label5";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(77, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 37);
            this.label8.Text = "By JohnS, Rosesam, and kittytopx86";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(77, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 27);
            this.label7.Text = "PPCP App Catalog";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(212)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 29);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.Text = "App Info";
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(0, 28);
            this.browser.Name = "browser";
            this.browser.ScriptErrorsSuppressed = true;
            this.browser.Size = new System.Drawing.Size(240, 242);
            this.browser.Visible = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(7, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 20);
            this.label10.Text = "Search";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Green;
            this.closeBtn.Location = new System.Drawing.Point(189, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(47, 20);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Exit";
            this.closeBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.browser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "PPCPAC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            this.catalogPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.searchTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem homeBtn;
        private System.Windows.Forms.MenuItem menuBtn;
        private System.Windows.Forms.MenuItem scToggle;
        private System.Windows.Forms.MenuItem infoBtn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage catalogPage;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.TabPage Info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuItem exitBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button closeBtn;
    }
}

