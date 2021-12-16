using System;
using System.IO;

namespace Get_Picture {
    class Program {
        public static void Main() {
            //源文件夹
            Console.Write("Please enter the folder you need to find :");
            string searchDir = Console.ReadLine();
            //复制的目标文件夹
            Console.Write("Please enter the destination folder :");
            string tarDir = Console.ReadLine();

            //查找的文件类型
            Console.Write("Please enter the file suffix :");
            string fileType = Console.ReadLine();
            try {
                if (searchDir != null) {
                    ListFiles(new DirectoryInfo(searchDir), tarDir, fileType);
                }
            } catch (IOException e) {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Task finished");
            Console.ReadLine();
        }
        public static void ListFiles(FileSystemInfo info, string tarDir,string fileType) {
            if (!info.Exists) return;
            DirectoryInfo dir = info as DirectoryInfo;
            //不是目录
            if (dir == null) return;
            FileSystemInfo[] files = dir.GetFileSystemInfos();
            for (int i = 0; i < files.Length; i++) {
                FileInfo file = files[i] as FileInfo;
                if (file != null) {
                    //Console.WriteLine(file.Extension);
                    //if (file.Extension == "."+ fileType) {
                    if (file.Extension == "." + fileType) {
                        Console.WriteLine(file.FullName);
                        string desPath = tarDir + "/" + file.Name;
                        file.CopyTo(desPath, true);//允许覆盖文件
                    }
                } else { //子目录递归查找
                    ListFiles(files[i], tarDir, fileType);
                }
            }
        }
    }

}
