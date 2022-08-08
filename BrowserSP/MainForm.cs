using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BrowserSP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            topPanel.MouseMove += new MouseEventHandler(mainPanel_MouseMove);

            {
                const int value = 11001;

                using (var reg = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION"))
                {
                    reg.SetValue(AppDomain.CurrentDomain.FriendlyName, value, RegistryValueKind.DWord);
                }
            }

            webCom.Navigate("https://www.google.com/?hl=ja");
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            webCom.GoBack();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            webCom.GoForward();
        }

        private void reloButton_Click(object sender, EventArgs e)
        {
            webCom.Refresh();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            webCom.GoHome();
            webCom.GoSearch();
        }

        private void miniButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maxiButton_Click(object sender, EventArgs e)
        {
            if (WindowState== FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState== FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void closButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void urlBox_TextChanged(object sender, EventArgs e)
        {

        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            /*if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }*/
        }

        private void topPanel_DoubleClick(object sender, EventArgs e)
        {
            maxiButton.PerformClick();
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }

        private void webCom_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            urlBox.Text = e.Url.OriginalString;
            if (webCom.DocumentText.Contains("sex"))
            {
                prevButton.PerformClick();
                MessageBox.Show("×");
            }
        }

        private void urlBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                webCom.Navigate(urlBox.Text);
            }
        }
    }
}
