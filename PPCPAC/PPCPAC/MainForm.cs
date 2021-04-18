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
            browser.Navigate(new Uri("http://surfers-side.ppcplanet.org/posts.php?q=^^^" + value));
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            //go home
            switch (homeBtn.Text)
            {
                case "Home":
                    tabControl.SelectedIndex = 0;
                    break;

                case "Refresh":
                    //remember screenshots setting
                    string value = new RegStoreClass().sValue;

                    browser.Navigate(new Uri("http://surfers-side.ppcplanet.org/posts.php?q=^^^" + value));
                    break;

                case "Back":
                    browser.GoBack();
                    break;
            }
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

                //get query
                if (searchTxt.Text.Trim() != "")
                {
                    query = searchTxt.Text;
                }

                //get selected category
                switch (categoryBox.SelectedIndex)
                {
                    case 1:
                        category = "app";
                        break;

                    case 2:
                        category = "game";
                        break;

                    case 3:
                        category = "driver";
                        break;
                }

                //search
                browser.Navigate(new Uri("http://surfers-side.ppcplanet.org/posts.php?q=" + query + "^^" + category + screenshots));
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
                //show browser if user is on catalog tab
                browser.Show();
                browser.BringToFront();

                //update homeBtn text if viewing catalog
                if (homeBtn.Text != "End Search")
                {
                    //if not viewing catalog page, change button text to "Back"
                    if (browser.Url.AbsoluteUri.IndexOf("http://surfers-side.ppcplanet.org/posts.php?q=") == -1)
                    {
                        homeBtn.Text = "Back";
                    }
                    else
                    {
                        homeBtn.Text = "Refresh";
                    }
                }
            }
            else
            {
                //hide browser if user is not on catalog tab
                browser.Hide();
                browser.SendToBack();

                //update homeBtn text if not viewing catalog
                if (homeBtn.Text != "End Search")
                {
                    homeBtn.Text = "Home";
                }
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

        private void browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //depending on URL, show either home or refresh
            if (e.Url.AbsoluteUri.IndexOf("http://surfers-side.ppcplanet.org/posts.php?q=") == -1)
            {
                homeBtn.Text = "Back";
            }
            else
            {
                homeBtn.Text = "Refresh";
            }
        }
    }
}