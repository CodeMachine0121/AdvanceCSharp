class File新增刪除
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\james\Desktop\Coding\AdvanceC#\File新增刪除\File新增刪除\英雄配置2.txt";

        
        if (File.Exists(path))
        {
            // 存在就刪除
            File.Delete(path);
            Console.WriteLine("刪除文件");
        }
        else
        {
            // 不存在就新增
            File.Create(path);
            Console.WriteLine("新增文件");
        }
        
    }
}