using System.IO;
using System.Text;


//File.Create("Mourya.txt");
//if (File.Exists("Mourya.txt"))
//{
//    Console.WriteLine("File Exists");
//}
//else
//{
//    Console.WriteLine("File not found");
//}

// Write file using StreamWriter
using (StreamWriter writer = new StreamWriter(Path.GetFullPath("Mourya.txt")))
{
    writer.WriteLine("Steve Rogers");
    writer.WriteLine("Tony Stark");
    writer.WriteLine("Natasha Romanolf ");
    writer.WriteLine("Bruce Banner");
    writer.WriteLine("Hawkeye");
}
// Read a file
string readText = File.ReadAllText(Path.GetFullPath("Mourya.txt"));
Console.WriteLine(readText);

string fileName = @"Mourya.txt";
FileInfo fi = new FileInfo(fileName);

try
{// Check if file already exists. If yes, delete it.
    if (fi.Exists) { fi.Delete(); }// Create a new file
    using (FileStream fs = fi.Create())
    {
        Byte[] txt = new UTF8Encoding(true).GetBytes("New file."); fs.Write(txt, 0, txt.Length); Byte[] author = new UTF8Encoding(true).GetBytes("Writer God"); fs.Write(author, 0, author.Length);
    }
    // Write file contents on console.
    using (StreamReader sr = File.OpenText(fileName))
    {
        string s = ""; while ((s = sr.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }
    }
}
catch (Exception Ex)
{
    Console.WriteLine(Ex.ToString());
}

