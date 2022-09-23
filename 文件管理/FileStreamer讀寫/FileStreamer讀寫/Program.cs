using System.Text;

class FileStreamer讀寫
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\james\Desktop\Coding\AdvanceC#\FileStreamer讀寫\FileStreamer讀寫\英雄配置.txt";
        // OpenOrCreate: 如果沒有文件的話就新增
        FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate);

        byte[] data = new byte[fileStream.Length];
        while (true)
        {
            // length: 當前讀取完後還剩多少的還沒讀的
            int length = fileStream.Read(data,0,data.Length);
            if (length == 0)
            {
                Console.WriteLine("讀取完畢");
                break;
            }
        }
        
        Console.WriteLine(Encoding.UTF8.GetString(data));
        fileStream.Close();
        
        // 寫入Filestream
        FileStream writeStream = new FileStream(path, FileMode.Open);
        string text = "\r\n";
        text += "1022	教练	2	 7000	FALSE	2374	0	262";
        byte[] writeData = Encoding.UTF8.GetBytes(text);
        // 寫入檔案中，需要標明寫入的初始位置 (資料要從哪裡開始寫，默認是 0)
        writeStream.Position = writeStream.Length;
        writeStream.Write(writeData, 0, writeData.Length);
        writeStream.Close();
    }
    
}