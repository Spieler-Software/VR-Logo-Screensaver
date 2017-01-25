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

namespace Screensaver
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        // Load Registry-Key
        private void SettingsForm_Load(object sender, EventArgs e)
        {           
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\VRScreenSaver");
            if (key == null)
                txtDisplayText.Text = "VR Screensaver";
            else
                txtDisplayText.Text = (string)key.GetValue("text");
        }

        // Set Bordercolor of TextBox
        private void SettingsForm_Paint(object sender, PaintEventArgs e)
        {
            ColorConverter c = new ColorConverter();
            Color blue = (Color)c.ConvertFromString("#37527c");
            Pen p = new Pen(blue);
            Graphics g = e.Graphics;
            const int variance = 3;
            g.DrawRectangle(p, new Rectangle(txtDisplayText.Location.X - variance, txtDisplayText.Location.Y - variance, txtDisplayText.Width + variance, txtDisplayText.Height + variance));
        }

        // Create and set Registry-Key
        private void saveKey()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("SOFTWARE\\VRScreenSaver");
            key.SetValue("text", txtDisplayText.Text);
        }

        // Button Cancel
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Button Save
        private void cmdSave_Click(object sender, EventArgs e)
        {
            saveKey();
            Close();
        }
    }
}
