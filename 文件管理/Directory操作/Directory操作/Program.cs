class Dirctory操作
{
    
    public static void Main(string[] args)
    {
        string path = @"C:\Users\james\Desktop\Coding\AdvanceC#\Directory操作\Directory操作\TestDir";
        DirectoryInfo directoryInfo = new DirectoryInfo(path);

        if (directoryInfo.Exists)
        {
            Console.WriteLine("資料夾存在");
            
            Console.WriteLine("資料夾路徑"+directoryInfo.FullName);
            Console.WriteLine("資料夾名稱"+directoryInfo.Name);
            Console.WriteLine("創建日期"+directoryInfo.CreationTime);
            Console.WriteLine("上次存取時間"+directoryInfo.LastAccessTime);
            Console.WriteLine("根目錄"+directoryInfo.Root);
            Console.WriteLine("上次寫入時間"+directoryInfo.LastWriteTime);
            
            Console.WriteLine("刪除資料夾");
            directoryInfo.Delete();
        }
        else
        {
            Console.WriteLine("資料夾不存在");
            Console.WriteLine("新增資料夾");
            directoryInfo.Create();

            Console.WriteLine("新增子資料夾");
            directoryInfo.CreateSubdirectory("子資料夾");

        }
    }
    
}