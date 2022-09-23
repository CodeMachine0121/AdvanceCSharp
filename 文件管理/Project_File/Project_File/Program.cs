using System.Text;

class Project_File
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\james\Desktop\Coding\AdvanceC#\文件管理\Project_File\Project_File\英雄配置.txt";

        if (File.Exists(path))
        {
            Console.WriteLine("發現文件");
            
            // 讀取文件
            string readText = File.ReadAllText(path, Encoding.UTF8);
            Console.WriteLine("文件內容: \n"+readText);
            
            // 新增內容到文件
            string writeText = "\r\n1022    AV女優 2        7000   FALSE   2374    1       263";
            
            // File.WriteAllText(writeText); // 會覆蓋
            File.AppendAllText(path,writeText);
        }
        else
        {
            Console.WriteLine("文件不存在");
        }
        
    }
    
}