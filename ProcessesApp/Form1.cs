using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcessesApp
{
    public partial class Form1 : Form
    {
        Process[] processes = Process.GetProcesses();
        public Form1()
        {
            InitializeComponent();
        }

        Process killProcess = new Process();
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateProcessList();
        }
        public void UpdateProcessList()
        {
            Process[] processes = Process.GetProcesses();
            listBox1.Items.Clear();
            foreach (Process process in processes)
            {
                listBox1.Items.Add(process.ProcessName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateProcessList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Int32.Parse(textBox1.Text) * 1000;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    int orderNumber = 0;
                    int counter = 0;
                    foreach (object obj in listBox1.Items )
                    {
                        if ((string)obj == listBox1.Items[listBox1.SelectedIndex].ToString())
                        {

                            if (counter != listBox1.SelectedIndex)
                            {
                                break;
                            }
                                orderNumber++;
                        }
                        counter++;
                    }

                        Process[] processesByName = Process.GetProcessesByName(listBox1.Items[listBox1.SelectedIndex].ToString());
                    if (processesByName.Length > 0)
                    {
                        killProcess = processesByName[0];
                        L_id.Text = processesByName[0].Id.ToString();
                        label_startTime.Text = processesByName[0].StartTime.ToString("H:m:s:fff ");
                        Proc_Time.Text = processesByName[0].TotalProcessorTime.ToString();
                        Thread_count.Text = processesByName[0].Threads.Count.ToString();
                        Proc_Copy.Text = processesByName.Count().ToString();
                    }
                    //foreach (Process process in processesByName)
                    //{
                    //    MessageBox.Show(process.GetHashCode().ToString());
                    //}
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_process_Click(object sender, EventArgs e)
        {
            killProcess.Kill();
        }
        private void newProcessStart_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(newProcessName.Text);
            process.Start();
        }

        private void newProcessName_TextChanged(object sender, EventArgs e)
        {
            if(newProcessName.Text.Length > 0)
            {
                newProcessStart.Enabled = true;
            }
            else
            {
                newProcessStart.Enabled=false;
            }

        }

    }
}
