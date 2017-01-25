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
using Microsoft.Win32;

namespace Screensaver
{
    public partial class ScreenSaverForm : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        private String dayOfWeek;
        private String day;
        private String month;
        private String year;
        private String hour;
        private String minute;
        private String seconds;

        private int tickCounter;

        private bool previewMode = false;

        public ScreenSaverForm(Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            TopMost = true;

            // Initialize Date
            DateTime current = DateTime.Now;
            dayOfWeek = current.DayOfWeek.ToString();
            day = current.Day.ToString();
            month = current.Month.ToString();
            year = current.Year.ToString();
            hour = current.Hour.ToString();
            minute = current.Minute.ToString();
            seconds = current.Second.ToString();

            tickCounter = 0;

            // Locate Labels
            Screen screen = Screen.FromControl(this);
            Rectangle area = screen.WorkingArea;
            lblDate.Location = new Point(100, area.Height - 150);
            lblTime.Location = new Point(100, area.Height - 250);
            lblCustomText.Location = new Point(100, (int)Math.Round(area.Height * 0.4));

            // Initialize Labels
            lblDate.Text = getFormattedDate();
            lblTime.Text = getFormattedTime();

            // Load Custom Text
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\VRScreenSaver");
            if (key == null)
                lblCustomText.Text = "VR Screensaver";
            else
                lblCustomText.Text = (string)key.GetValue("text");

            // Clock Management - Update every Second
            DateTimeTimer.Interval = 1000;
            DateTimeTimer.Tick += new EventHandler(moveTimer_Tick);
            DateTimeTimer.Start();
        }

        // Terminate app when user interacts
        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Currently not wanted
        }

        private void ScreenSaverForm_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        // Update Window
        private void moveTimer_Tick(object sender, System.EventArgs e)
        {
            // Don't check Date every timer-tick
            tickCounter++;
            if(tickCounter == 60)
            {
                lblDate.Text = getFormattedDate();
                tickCounter = 0;
            }

            // Update Time
            lblTime.Text = getFormattedTime();
        }

        // Return Date
        private String getFormattedDate()
        {
            DateTime current = DateTime.Now;
            // day, dd.mm.yyyy
            return string.Format("{0}, {1:D2}.{2:D2}.{3}", current.DayOfWeek, current.Day, current.Month, current.Year);
        }

        // Return Time
        private String getFormattedTime()
        {
            DateTime current = DateTime.Now;
            // hh:mm:ss
            return string.Format("{0:D2}:{1:D2}:{2:D2}",current.Hour, current.Minute, current.Second);
        }
    }
}
