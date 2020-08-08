# Get_PNG
一个工具,获取文件夹目录下的所有.png文件,并复制到另一个文件夹
## 获取指定目录包含的文件和子目录
    1. DirectoryInfo.GetFiles()：获取目录中（不包含子目录）的文件，返回类型为FileInfo[]，支持通配符查找；
    2. DirectoryInfo.GetDirectories()：获取目录（不包含子目录）的子目录，返回类型为DirectoryInfo[]，支持通配符查找；
    3. DirectoryInfo. GetFileSystemInfos()：获取指定目录下（不包含子目录）的文件和子目录，返回类型为FileSystemInfo[]，支持通配符查找；
## 获取指定文件的基本信息；
    FileInfo.Exists：获取指定文件是否存在；
    FileInfo.Name，FileInfo.Extensioin：获取文件的名称和扩展名；
    FileInfo.FullName：获取文件的全限定名称（完整路径）；
    FileInfo.Directory：获取文件所在目录，返回类型为DirectoryInfo；
    FileInfo.DirectoryName：获取文件所在目录的路径（完整路径）；
    FileInfo.Length：获取文件的大小（字节数）；
    FileInfo.IsReadOnly：获取文件是否只读；
    FileInfo.Attributes：获取或设置指定文件的属性，返回类型为FileAttributes枚举，可以是多个值的组合
    FileInfo.CreationTime、FileInfo.LastAccessTime、FileInfo.LastWriteTime：分别用于获取文件的创建时间、访问时间、修改时间；
