using System;
using System.IO;

namespace ARIA_Backup_Folder_Cleanup
{
    class Program
    {
        static void Main(string[] args)
        {
            string myDirectory = @"E:\FTP\ARIA\";
            string oneWeekago = DateTime.Now.ToString();
            foreach(FileInfo f in new DirectoryInfo(myDirectory).GetFiles("*.pdf"))
            {
                if (f.CreationTime < DateTime.Now.AddDays(-30) && (f.Name != "ARIA Disaster Contingency Reports.pdf"))
                {
                    Console.WriteLine(f.Name + " Delete this one");
                    f.Delete();
                }
                else
                {
                    Console.WriteLine(f.Name + " Keep this one");
                }
            }
            //Console.ReadLine();
        }
    }
}
