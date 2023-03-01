

//Console.WriteLine("Hello, World!");
using System.Text;

string[] badWords = new string[] { "экзамен", "Экзамен" };
string originPath = @"D:\Exam";
DirectoryInfo info = new DirectoryInfo(originPath);
List<FileInfo> list = new List<FileInfo>();
List<DirectoryInfo> list2 = new List<DirectoryInfo>();

list2.AddRange(info.GetDirectories());
list.AddRange(info.GetFiles());
MyGetDirectories(info, ref list2, ref list);


foreach (FileInfo file in list)
{
    Console.WriteLine(file.FullName);
}
foreach (DirectoryInfo directory in list2)
{
    Console.WriteLine(directory.FullName);
}

int countBadWords = 0;

foreach (FileInfo file in list)
{
    bool needCopy = false;
    foreach (string str in badWords)
    {
        byte[] bytes = Encoding.ASCII.GetBytes(str);
        byte[] buffer = new byte[bytes.Length];
        FileStream stream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.Read, bytes.Length, FileOptions.Asynchronous);
        byte[] data = new byte[stream.Length];
        byte readBytes = (byte)stream.EndRead(stream.BeginRead(data, 0, data.Length, null, null));
        int counter = 0;

        foreach (byte b in BitConverter.GetBytes(readBytes))
        {

            if (b == bytes[counter])
            {
                buffer[counter] = b;
                counter++;
            }
            else
            {
                counter = 0;
            }
            if (counter == bytes.Length - 1)
            {
                countBadWords++;
                counter = 0;
                needCopy = true;
            }
        }
        stream.Close();
    }
    if (needCopy) // копировать файл с заменой плохих слов
    {

    }
    needCopy = false;

}
Console.WriteLine(countBadWords);

        

        static void MyGetDirectories(DirectoryInfo directory, ref List<DirectoryInfo> mylist, ref List<FileInfo> files)
{
    foreach (DirectoryInfo dir in directory.GetDirectories())
    {
        mylist.Add(dir);
        files.AddRange(dir.GetFiles());
        MyGetDirectories(dir, ref mylist, ref files);
    }


}
