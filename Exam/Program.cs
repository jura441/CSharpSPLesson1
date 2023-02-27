

//Console.WriteLine("Hello, World!");
string[] badWords = new string[] { "экзамен", "Экзамен"};

string orignPath = @"D:\Exam";
DirectoryInfo info = new DirectoryInfo(orignPath);
List<FileInfo> list = new List<FileInfo>();
List<DirectoryInfo> list2 = new List<DirectoryInfo>();


foreach (FileInfo file in list)
{
    Console.WriteLine(file.Name);

}
foreach (DirectoryInfo directory in list2)
{
    Console.WriteLine(directory.FullName)
}
foreach (FileInfo file in list)

