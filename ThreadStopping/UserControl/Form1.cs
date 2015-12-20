using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace UserControl
{
    public partial class Form1 : Form
    {
        /*
        Create a delegate that will allow the thread to
        print output to the textbox.
        */
        private delegate void PrintResult();
        private PrintResult formDelegate;

        string resultString;    // Used to get output from thread into main thread

        readonly object stopLock = new object();
        bool stopping = false;
        bool stopped = false;

        public Form1()
        {
            InitializeComponent();
            formDelegate = new PrintResult(PrintThreadResult);
        }

        private void Btn_StartThread_Click(object sender, EventArgs e)
        {
            Btn_StopThread.BackColor = Color.Gray;
            Btn_StopThread.Text = "Stop";

            // Create and start a single thread
            Thread thread = new Thread(new ThreadStart(ThreadOutput));
            thread.Start();
            Debug.WriteLine("Thread started.");
        }

        private void Btn_StopThread_Click(object sender, EventArgs e)
        {
            Btn_StopThread.BackColor = Color.Yellow;
            Btn_StopThread.Text = "Stopping";

            Stop();

            Btn_StopThread.BackColor = Color.Red;
            Btn_StopThread.Text = "Stopped";
        }

        private void ThreadOutput()
        {
            try
            {
                while (!Stopping)   // Loop until 'stopping' is set to 'true'
                {
                    for (int i = 0; i < 5; i++)
                    {
                        SetResultString(i.ToString() + " Hello\n");
                        Invoke(formDelegate);
                        Thread.Sleep(1000);
                    }

                    if (stopping) { return; }
                }
            }
            finally
            {
                SetStopped();
            }
        }

        public void PrintThreadResult()
        {
            // Append output from worker thread
            Txt_Results.AppendText(GetResultString());
        }

        public void SetResultString(string value) { resultString = value; }

        public string GetResultString() { return resultString; }

        /*
        Code below deals with gracefully stopping the thread
        Referenced from http://www.yoda.arachsys.com/csharp/threads/shutdown.shtml
        */

        
        public bool Stopping
        {
            get
            {
                lock (stopLock)
                {
                    return stopping;
                }
            }
        }

        // Returns whether the worker has stopped
        public bool Stopped
        {
            get
            {
                lock (stopLock)
                {
                    return stopped;
                }
            }
        }

        // Tells the worker to stop after work is complete
        public void Stop()
        {
            lock (stopLock)
            {
                stopping = true;
            }
        }

        // Called by the worker if it has stopped
        void SetStopped()
        {
            lock (stopLock)
            {
                stopped = true;
            }
        }
    }
}
