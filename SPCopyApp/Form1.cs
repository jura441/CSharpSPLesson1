using System.Text;
namespace SPCopyApp
{
    public partial class Form1 : Form
    {
        byte[] data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_originPath.Text = @"D:text.txt";
            tb_targetPath.Text = @"D:textcopy.txt";
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            ofd_originPath.FileName = Directory.GetCurrentDirectory();
            if (ofd_originPath.ShowDialog() == DialogResult.OK)
            {
                tb_originPath.Text = ofd_originPath.FileName;
                tb_targetPath.Text = ofd_originPath.FileName;
            }
        }

        private void btn_saveFile_Click(object sender, EventArgs e)
        {

        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            /* Объявления переменных и открытие потоков */
            FileStream fsopen = new FileStream(tb_originPath.Text, FileMode.Open, FileAccess.Read, FileShare.Read, 100, FileOptions.Asynchronous);
            byte[] b;
            long lengthfile = fsopen.Length;

            //  Устанавливаем начальные значения прогресс бара         
            pb_copyProgress.Maximum = 1000;
            pb_copyProgress.Minimum = 0;

            // создаем массив чтения файла из countOperation частей
            int countOperation = 1000;
            long[] partsfilelength = new long[countOperation];
            for (int i = 0; i < countOperation; i++)
            {
                partsfilelength[i] = lengthfile / countOperation;
                if (i == countOperation - 1)
                    partsfilelength[i] += lengthfile % countOperation;
            }
            //  Устанавливаем значения прогресс бара    
            long pbvalue = 1;
            if (lengthfile > 1000)
                pbvalue = lengthfile / 1000;
            for (int i = 0; i < 3; i++)
            {
                data = new byte[partsfilelength[i]];
                fsopen.BeginRead(data, 0, data.Length, MessageBoxPrint, new MyStateObject(data, fsopen));
            }
            //IAsyncResult result;
            // Примеры не эффективной работы обработки ассинхрнных потоков
            //result = fsopen.BeginRead(b, 0, b.Length, null, null);

            /*while (!result.IsCompleted) // проверка выполнения fsopen.BeginRead. 
             // Асинхронная операция не возвращает готовый результат, пока не выполнит все операции.
             // А запрос к результатам мы можем попробовать сделать раньше выполнения и это вызовет ошибку.
            {
                richTextBox1.Text = "Еще не готово";
            }*/

            //fsopen.EndRead(result);

            /*foreach (byte bt in b)
            {
                richTextBox1.Text += bt;
            }*/

            /* foreach (long i in partsfilelength)
             {
                 b = new byte[i];
                 fsopen.BeginRead(b, 0, b.Length, null, null);
                 //fsopen.Read(b, 0, b.Length);
                 //fswrite.Write(b, 0, b.Length);                
                 //pb_copyProgress.Value = (int)(lengthfile / pbvalue); 
             }      */
            fsopen.Close();
            fswrite.Close();

        }

       void MessageBoxPrint(IAsyncResult asyncResult)
       {
            MyStateObject mystate = (MyStateObject)asyncResult.AsyncState;
            mystate.EndRead(asyncResult);
            mystate.Write();
       }
    }

    class MyStateObject
    {
        byte[] _bytes;
        FileStream _fs;
        FileStream fswrite;

        public MyStateObject(byte[] bytes, FileStream fs)
        {
            _bytes = bytes;
            _fs = fs;
            fswrite = new FileStream(path.Text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write, 100, FileOptions.Asynchronous);
        }
        public void EndRead (IAsyncResult asyncResult)
        {
            _fs.EndRead(asyncResult);
        }
        public void Write()
        {
            MessageBox.Show(Encoding.UTF8.GetString(_bytes));
        }
    }
}