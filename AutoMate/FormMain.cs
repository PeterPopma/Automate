using Hotkeys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMate
{
    public partial class FormMain : Form
    {
        private static System.Windows.Forms.Timer playbackTimer;
        static int counterMouseTime;
        static int xMouse, yMouse, xOffset, yOffset;
        static double xPos, yPos, angle;
        const int CIRCLE_RADIUS = 100;
        const int MOUSE_STEPS = 50;
        private Hotkeys.GlobalHotkey globalHotKeys;

        // Specify what you want to happen when the Elapsed event is raised.
        private static void OnTimedEventUpdatePlayback(object sender, EventArgs eArgs)
        {
            if (counterMouseTime > 0)
            {
                counterMouseTime--;
                angle = ((MOUSE_STEPS - counterMouseTime) / Convert.ToDouble(MOUSE_STEPS)) * 2 * Math.PI;
                xPos = Math.Cos(angle) * CIRCLE_RADIUS;
                yPos = Math.Sin(angle) * CIRCLE_RADIUS;
            }
            int xMouseNew = Convert.ToInt32(xPos);
            int yMouseNew = Convert.ToInt32(yPos);
            if (!xMouseNew.Equals(xMouse) || !yMouseNew.Equals(yMouse))
            {
                xMouse = xMouseNew;
                yMouse = yMouseNew;
                Cursor.Position = new Point(xMouse + xOffset, yMouse + yOffset);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!globalHotKeys.Unregiser())
                MessageBox.Show("Hotkeys failed to unregister!");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!globalHotKeys.Register())
                MessageBox.Show("Hotkeys failed to register!");
        }

        public FormMain()
        {
            InitializeComponent();
            globalHotKeys = new Hotkeys.GlobalHotkey(Constants.NOMOD, Keys.O, this);
            SetupTimers();
        }

        private void HandleHotkey()
        {
            xOffset = Cursor.Position.X - CIRCLE_RADIUS;
            yOffset = Cursor.Position.Y;
            counterMouseTime = MOUSE_STEPS;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Hotkeys.Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }

        private void SetupTimers()
        {
            // Create a timer for screen updates.
            playbackTimer = new System.Windows.Forms.Timer();
            playbackTimer.Interval = 1;
            playbackTimer.Tick += new EventHandler(OnTimedEventUpdatePlayback);
            playbackTimer.Start();
        }

        private void buttonMoveMouse_Click(object sender, EventArgs e)
        {
            xOffset = Cursor.Position.X - CIRCLE_RADIUS;
            yOffset = Cursor.Position.Y;
            counterMouseTime = MOUSE_STEPS;
        }
    }
}
