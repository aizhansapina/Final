using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace final1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Айжан\Desktop\Final\final1\final1\bin\Debug\Task1");
            FileSystemInfo[] file = directory.GetFileSystemInfos();
            foreach (FileSystemInfo f in file)
            {
                Console.WriteLine(f.Name + ":");
            }

            Console.ReadKey();

            StreamReader sw = new StreamReader(@"C:\Users\Айжан\Desktop\Final\final1\final1\bin\Debug\Task1\file1.txt");
            StreamReader sw2 = new StreamReader(@"C:\Users\Айжан\Desktop\Final\final1\final1\bin\Debug\Task1\file2.txt");
            

            string[] s = sw.ReadToEnd().Split();
            
            for (int i = 1; i <= s.Length; i++)
            {
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);

                int cnt = 0;
                for (int j = 1; j <= a; j++)
                {
                    if (a % j == 0 && b % j == 0)
                        cnt++;
                }
               
                if (cnt == 1)
                {
                    Console.WriteLine("yes");
                }
                else if (cnt > 1)
                {
                    Console.WriteLine("no");
                }
                Console.ReadKey();
                
            }
        }
    }
}
