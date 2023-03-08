using AutoItX3Lib;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace QueueHelper
{
    // Token: 0x02000004 RID: 4
    public partial class QueueHelper : Form
    {
        // Token: 0x06000009 RID: 9
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        // Token: 0x0600000A RID: 10
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        // Token: 0x0600000B RID: 11
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool GetWindowRect(IntPtr hwnd, out QueueHelper.RECT lpRect);

        // Token: 0x0600000C RID: 12
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        // Token: 0x0600000D RID: 13 RVA: 0x000020D3 File Offset: 0x000002D3
        public QueueHelper()
        {
            this.InitializeComponent();
        }

        // Token: 0x0600000E RID: 14 RVA: 0x00002100 File Offset: 0x00000300
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.welcomeTextLabel.Text = "Willkommen : " + Environment.MachineName.ToString() + " !";
            new Thread(new ThreadStart(this.autoAccept))
            {
                IsBackground = true
            }.Start();
            this.backgroundWorker1.RunWorkerAsync();
        }

        // Token: 0x0600000F RID: 15 RVA: 0x00002160 File Offset: 0x00000360
        private void autoAccept()
        {
            for (; ; )
            {
                if (this.autoAcceptBox.Checked)
                {
                    ooga = au3.PixelGetColor(rect.left + 584, rect.top + 555);
                    getwindowrectangle();
                    if (this.ooga == 0x1E252A)
                    {
                        Thread.Sleep(20);
                        au3.MouseMove(rect.left + 584, rect.top + 555, 1);
                        au3.MouseClick("LEFT");
                        Thread.Sleep(10);
                        au3.MouseClick("LEFT");
                        au3.MouseMove(+0, +12);
                        Thread.Sleep(2500);
                    }
                }
                Thread.Sleep(20);
            }
        }

        // Token: 0x06000010 RID: 16 RVA: 0x0000224B File Offset: 0x0000044B
        private void button2_Click(object sender, EventArgs e)
        {
            this.getwindowrectangle();
            this.au3.MouseMove(QueueHelper.rect.left + 584, QueueHelper.rect.top + 555, 0);
        }

        // Token: 0x06000011 RID: 17 RVA: 0x00002280 File Offset: 0x00000480
        private void getwindowrectangle()
        {
            QueueHelper.handle = QueueHelper.FindWindow(null, QueueHelper.WINDOW_NAME);
            QueueHelper.GetWindowRect(QueueHelper.handle, out QueueHelper.rect);
        }

        // Token: 0x06000012 RID: 18 RVA: 0x000022A2 File Offset: 0x000004A2
        private bool isGameActive()
        {
            QueueHelper.MWhandle = QueueHelper.FindWindow(null, "League of Legends");
            QueueHelper.CWhandle = QueueHelper.GetForegroundWindow();
            return QueueHelper.MWhandle == QueueHelper.CWhandle;
        }

        // Token: 0x06000013 RID: 19 RVA: 0x000022D2 File Offset: 0x000004D2
        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            for (; ; )
            {
                if (QueueHelper.GetAsyncKeyState(Keys.F1) < 0)
                {
                    this.autoAcceptBox.Checked = true;
                }
                else if (QueueHelper.GetAsyncKeyState(Keys.F2) < 0)
                {
                    this.autoAcceptBox.Checked = false;
                }
                Thread.Sleep(1);
            }
        }

        // Token: 0x04000004 RID: 4
        public static IntPtr MWhandle;

        // Token: 0x04000005 RID: 5
        public static IntPtr CWhandle;

        // Token: 0x04000006 RID: 6
        private AutoItX3 au3 = (AutoItX3)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("1A671297-FA74-4422-80FA-6C5D8CE4DE04")));

        // Token: 0x04000007 RID: 7
        public static string WINDOW_NAME = "League of Legends";

        // Token: 0x04000008 RID: 8
        public static IntPtr handle;

        // Token: 0x04000009 RID: 9
        public static QueueHelper.RECT rect;

        // Token: 0x0400000A RID: 10
        private int ooga;

        // Token: 0x0400000B RID: 11
        public int counter;

        // Token: 0x02000008 RID: 8
        public struct RECT
        {
            // Token: 0x04000012 RID: 18
            public int left;

            // Token: 0x04000013 RID: 19
            public int top;

            // Token: 0x04000014 RID: 20
            public int right;

            // Token: 0x04000015 RID: 21
            public int bottom;
        }
    }
}
