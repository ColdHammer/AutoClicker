using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")] public static extern int GetAsyncKeyState(Int32 i);
        public const int NEUTRAL_STATE = 0;
        public const int KEYDOWN_STATE_1 = 32760;
        public const int KEYDOWN_STATE_2 = 32770;
        Thread logThread;
        Thread clickThread;
        Logging logging;
        ClickerClass clicker;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clickThread = null;
            logging = new Logging(this);
            logThread = new Thread(new ThreadStart(logging.StartLogging))
            {
                Priority = ThreadPriority.Highest
            };
            logThread.Start();

            lblHold.StopCondition = (x, y, z, j) => !(x > z && x < j);

            lblStart.KeyDownAction = () => { StartThread(lblStop); };
            lblStop.KeyDownAction = () => { return; };
            lblHold.KeyDownAction = () => { StartThread(lblHold); };

            lblStart.KeyValue = Properties.Settings.Default.StartValue;
            lblStop.KeyValue = Properties.Settings.Default.StopValue;
            lblHold.KeyValue = Properties.Settings.Default.HoldValue;
            txtInterval.Value = Properties.Settings.Default.ClickInterval;
        }

        public class Logging
        {
            Form1 Context;
            public Logging(Form1 context)
            {
                Context = context;
            }
            public void StartLogging()
            {

                while (true)
                {
                    //sleeping for while, this will reduce load on cpu
                    //Console.WriteLine("repeat");
                    Thread.Sleep(100);

                    for (Int32 i = 3; i < 255; i++)
                    {
                        int keyState = GetAsyncKeyState(i);
                        if (keyState != 0)
                        {
                            Context.Invoking(() => { Context.ChangeKey(i); });
                            break;
                        }
                    
                    }
                }
            }
        }
        public class ClickerClass
        {
            readonly int Interval;
            readonly EditableLabel StopLabel;
            readonly int ClickLength;
            Form1 Context;
            private uint i;
            private uint j;

            public ClickerClass(int interval, int clickLength, EditableLabel stopLabel, Form1 context)
            {
                Interval = interval;
                Context = context;
                StopLabel = stopLabel;
                ClickLength = clickLength;
                i = 0;
                j = 0;
            }

            public void DoWork()
            {
                while (true)
                {
                    Thread.Sleep(Interval);
                    int keyState = GetAsyncKeyState(StopLabel.KeyValue);
                    //if(keyState != 0)
                    //    Context.Invoking(() => { Context.lbl_txtStart.Text = $"{i}"; });
                    if(StopLabel.StopCondition(keyState, NEUTRAL_STATE, KEYDOWN_STATE_1, KEYDOWN_STATE_2))
                    {
                        break;
                    }
                    i = (uint)Cursor.Position.X;
                    j = (uint)Cursor.Position.Y;
                    GSystem.GCursor.DoMouseDown(i ,j);
                    Thread.Sleep(ClickLength);
                    GSystem.GCursor.DoMouseUp(i, j);

                }
                Context.Invoking(() => { Context.StopThread(); });
            }
        }
        
        
        public void ChangeKey(int i)
        {
            if (EditableLabel.ItemToEdit != null)
            {
                if (EditableLabel.IsKeyUsed(i) != null) return;
                EditableLabel.ItemToEdit.KeyValue = i;
                EditableLabel.ItemToEdit.SetEditMode();
                return;
            }

            EditableLabel label;
            if ((label = EditableLabel.GetLabelIfItExists(i)) != null)
            {
                label.KeyDownAction();
                return;
            }

        }

        public void Invoking(Action action)
        {
            if (InvokeRequired)
            {
                try
                {
                    Invoke(action);
                }
                catch (ObjectDisposedException) { }

            }
            else
            {
                action();
            }
        }

        bool stopped = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (stopped)
            {
                StartThread(null);
            }
            else
            {
                StopThread();
            }
        }

        private void StartThread(EditableLabel LabelToStopTheThread)
        {
            if (EditableLabel.ItemToEdit != null || clickThread != null) return;
            stopped = false;
            clicker = new ClickerClass((int)txtInterval.Value, (int)intClickSize.Value, LabelToStopTheThread ?? lblStop, this);
            clickThread = new Thread(new ThreadStart(clicker.DoWork))
            {
                Priority = ThreadPriority.Lowest
            };
            clickThread.Start();
            btnStart.Text = "Stop";
        }
        private void StopThread()
        {
            btnStart.Text = "Start";
            if (clickThread.IsAlive) clickThread.Abort();
            clickThread = null;
            stopped = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (logThread.IsAlive) logThread.Abort();
            if (clickThread != null) if (clickThread.IsAlive) clickThread.Abort();
            Properties.Settings.Default.StartValue = lblStart.KeyValue;
            Properties.Settings.Default.StopValue = lblStop.KeyValue;
            Properties.Settings.Default.ClickInterval = txtInterval.Value;
            Properties.Settings.Default.HoldValue = lblHold.KeyValue;
            Properties.Settings.Default.Save();
        }
        #region LabelX
        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DimGray;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.LightGray;

        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.Black;
            this.Close();

        }
        #endregion
        

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
