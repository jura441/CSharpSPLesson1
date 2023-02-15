namespace Klass_Lesson
{
    public partial class Form1 : Form
    {
        Thread[] threads = new Thread[3];

        char[] allchars = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 
         'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
         '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 
         '!', ',', '.', '?', '&', '@', '#', '$', '^', ':',};
        Random random = new Random();
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(listBox1.SelectedIndex >=0)
            {
                foreach(Thread th in threads)
                {
                    if(th.Name == listBox1.Items[listBox1.SelectedIndex].ToString())
                    {
                        th.Priority = (ThreadPriority)comboBox1.SelectedIndex;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart start = new ThreadStart(WriteNumbers);
            threads[0] = new Thread(start);
            threads[0].Name = "Поток чисел";
            listBox1.Items.Add(threads[0].Name.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThreadStart start = new ThreadStart(WriteChars);
            threads[1] = new Thread(start);
            threads[1].Name = "Поток букв";
            listBox1.Items.Add(threads[1].Name.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThreadStart start = new ThreadStart(WriteSymbols);
            threads[2] = new Thread(start);
            threads[2].Name = "Поток символов";
            listBox1.Items.Add(threads[2].Name.ToString());
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                foreach (Thread th in threads)
                {
                    if (th.Name == listBox1.Items[listBox1.SelectedIndex].ToString())
                    {
                        comboBox1.SelectedIndex = (int)th.Priority;
                    }
                }
            }

        }
         void WriteSymbols()
        {
            while(true)
            {
                richTextBox1.Text += allchars[random.Next(36, 45)];
                counter++;
                Thread.Sleep(50);
                if (counter > 1000)
                    break;
            }
        }
        void WriteNumbers()
        {
            while (true)
            {
                richTextBox1.Text += allchars[random.Next(26, 35)];
                counter++;
                Thread.Sleep(50);
                if (counter > 1000)
                    break;
            }
        }
        void WriteChars()
        {
            while (true)
            {
                richTextBox1.Text += allchars[random.Next(0, 25)];
                counter++;
                Thread.Sleep(50);
                if (counter > 1000)
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                foreach (object obj in listBox1.Items)
                {
                    foreach (Thread thread in threads)
                    {
                        if ((string)obj == thread.Name)
                        {
                            thread.Start();
                        }
                    }
                }
            }
        }
    }
}