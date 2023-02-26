using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace DZ_4
{
    public partial class Form1 : Form
    {
        List<ResultRow> results = new List<ResultRow>();
        List<MyTimer> timers = new List<MyTimer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control != null && control.GetType() == progressBar1.GetType())
                {
                    ProgressBar bar = (ProgressBar)control;
                    timers.Add(new MyTimer(bar));
                }
            }

            foreach (MyTimer timer in timers)
            {
                timer.startTimer();
            }

            Thread thread = new Thread(
                new ThreadStart(
                        delegate ()
                        {
                            bool notend = true;
                            int counter = 0;
                            while (notend)
                            {
                                foreach (MyTimer timer in timers)
                                {
                                    if (!timer.isRunning)
                                    {
                                        counter++;
                                    }
                                    if (counter == 5)
                                    {
                                        notend = false;
                                    }
                                    else
                                    {
                                        counter = 0;
                                    }
                                }
                                Thread.Sleep(200);
                            }
                            foreach (MyTimer timer in timers)
                            {
                                results.Add(timer.getResultTimers());
                            }
                        }
                    )
                );
            thread.Start();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string res = "";
            foreach (ResultRow result in results)
            {
                res += result.ToString() + "\n";
            }
            MessageBox.Show(res);
        }
    }
    class MyTimer
    {
        public bool isRunning = false;
        System.Threading.Timer timer;
        ProgressBar _progress;
        DateTime time;
        TimeSpan span = TimeSpan.Zero;
        public MyTimer(ProgressBar progress)
        {
            _progress = progress;
        }

        public void startTimer()
        {
            isRunning = true;
            time = DateTime.Now;
            TimerCallback callback = new TimerCallback(this.CallbackDel);
            timer = new System.Threading.Timer(callback, _progress, 0, 500);
        }
        void deleteTimer()
        {
            span = DateTime.Now - time;
            isRunning = false;
            timer.Dispose();
        }
        void CallbackDel(object obj)
        {
            ProgressBar bar = (ProgressBar)obj;
            bar.BeginInvoke(new Action(() => {
                Random random = new Random();
                int step = random.Next(0, 5);
                if (bar.Value + step > bar.Maximum)
                {
                    bar.Value = bar.Maximum;
                    deleteTimer();
                }
                else
                    bar.Value += step;
            }));

        }
        public ResultRow getResultTimers()
        {
            return new ResultRow(_progress.Name, span);
        }

    }

    class ResultRow
    {
        string BarName;
        TimeSpan span;

        public ResultRow(string name, TimeSpan time)
        {
            BarName = name;
            span = time;
        }
        public override string ToString()
        {
            return BarName + " " + span.ToString();
        }
    }
}
