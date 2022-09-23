class FileInfo使用
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\james\Desktop\Coding\AdvanceC#\FileInfo使用\FileInfo使用\英雄配置.txt";
        FileInfo fileInfo = new FileInfo(path);
        
        if (fileInfo.Exists)
        {
            Console.WriteLine("文件存在");
            //fileInfo.Delete();
            Console.WriteLine("文件全名: "+fileInfo.FullName);
            Console.WriteLine("文件新增日期: "+fileInfo.CreationTime);
            Console.WriteLine("文件最後訪問日期: "+fileInfo.LastAccessTime);
            Console.WriteLine("文件是否為唯讀文件: "+fileInfo.IsReadOnly);
            Console.WriteLine("文件長度: "+fileInfo.Length);
            Console.WriteLine("文件名稱: "+fileInfo.Name);
        }
        else
        {
            Console.WriteLine("文件不存在");
            fileInfo.Create();
        }
        
    }
    
}