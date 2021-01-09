using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace PPCPAC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //set up a few things
            categoryBox.SelectedIndex = 0;
            browser.Show();
            browser.BringToFront();

            //remember screenshots setting
            string value = new RegStoreClass().sValue;

            if (value != "^$")
            {
                scToggle.Checked = false;
            }

            //load posts.php page
            browser.Navigate(new Uri("http://appmanager.ppcplanet.org/posts.php?q=^^^" + value));
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            //go home
            tabControl.SelectedIndex = 0;
            homeBtn.Text = "Home";

            //remember screenshots setting
            string value = new RegStoreClass().sValue;

            browser.Navigate(new Uri("http://appmanager.ppcplanet.org/posts.php?q=^^^" + value));
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            //when search button is pressed
            if (searchTxt.Text.Trim() != "" || categoryBox.SelectedIndex != 0)
            {
                tabControl.SelectedIndex = 0;
                homeBtn.Text = "End Search";

                string query = "";
                string category = "";

                //get screenshot string
                string screenshots = new RegStoreClass().sValue;

                //get screenshot preference

                //get query
                if (searchTxt.Text.Trim() != "")
                {
                    query = searchTxt.Text;
                }

                //get selected category
                switch (categoryBox.SelectedIndex)
                {
                    case 1:
                        {
                            category = "app";
                        }
                        break;

                    case 2:
                        {
                            category = "game";
                        }
                        break;

                    case 3:
                        {
                            category = "driver";
                        }
                        break;
                }

                //search
                browser.Navigate(new Uri("http://appmanager.ppcplanet.org/posts.php?q=" + query + "^^" + category + screenshots));
            }
            else
            {
                MessageBox.Show("Invalid search query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //show/hide browser control depending on selected tab. if browser control's parent is the tab control, links don't work.
            if (tabControl.SelectedIndex == 0)
            {
                browser.Show();
                browser.BringToFront();
            }
            else
            {
                browser.Hide();
                browser.SendToBack();
            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            //show info page
            tabControl.SelectedIndex = 2;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //close app
            Application.Exit();
        }

        private void scToggle_Click(object sender, EventArgs e)
        {
            //toggle screenshot setting
            if (scToggle.Checked)
            {
                scToggle.Checked = false;
                new RegStoreClass().sValue = "";
            }
            else
            {
                scToggle.Checked = true;
                new RegStoreClass().sValue = "^$";
            }
        }

        private void searchMenuBtn_Click(object sender, EventArgs e)
        {
            //search
            tabControl.SelectedIndex = 1;
        }
    }
}