using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Get_Picture {


    class Program {
        public static void Main() {
            Console.Write("请输入要查询的目录:");
            string searchDir = Console.ReadLine();

            Console.Write("请输入要复制的目录:");
            string copyDir = Console.ReadLine();

            try {
                if (searchDir != null) {
                    ListFiles(new DirectoryInfo(searchDir), copyDir);
                }

            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
        public static void ListFiles(FileSystemInfo info, string copyDir) {
            if (!info.Exists) return;
            DirectoryInfo dir = info as DirectoryInfo;
            //不是目录
            if (dir == null) return;
            FileSystemInfo[] files = dir.GetFileSystemInfos();
            for (int i = 0; i < files.Length; i++) {
                FileInfo file = files[i] as FileInfo;
                //是文件
                if (file != null) {
                    //Console.WriteLine(file.FullName + "\t " + file.Length);
                    //Console.WriteLine(file.Extension);
                    if (file.Extension == ".png") {
                        Console.WriteLine(file.FullName);
                        string desPath = copyDir+"/" + file.Name;
                        file.CopyTo(desPath);
                    }
                }
                //对于子目录，进行递归调用
                else
                    ListFiles(files[i], copyDir);
            }
        }
    }

}
