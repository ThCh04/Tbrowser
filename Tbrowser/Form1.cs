using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;


namespace Tbrowser
{
    public partial class Form1 : Form
    {

        private String donate = "https://www.paypal.me/Eacc04";

        public Form1()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (chromiumWebBrowser1.CanGoBack)
            {
                chromiumWebBrowser1.Back();
            }
            
          
        }

        private void forwBtn_Click(object sender, EventArgs e)
        {
            if (chromiumWebBrowser1.CanGoForward)
            {
                chromiumWebBrowser1.Forward();
            }
            
           
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Refresh();
            
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Stop();
            
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {

            chromiumWebBrowser1.LoadUrl("google.com.do");
           
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl(urlTx.Text);
            
        }

        
        private void urlTx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                searchBtn_Click(sender, e);
               
            }
               
        }


       

        private void Form1_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl("www.google.com.do");
        }

        private void chromiumWebBrowser1_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            urlTx.Text = e.Address;
        }

        
        private void chromiumWebBrowser1_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Refresh();
            this.Text = e.Title;
        }

        private void urlTx_Click(object sender, EventArgs e)
        {
            urlTx.SelectAll();
            urlTx.Focus();
        }

        private void donateBt_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadUrl(donate);
        }
    }
}
