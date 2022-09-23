class StreamReader_Writer
{
    
    
    public static void Main(string[] args)
    {
        string path = @"C:\Users\james\Desktop\Coding\AdvanceC#\StreamReader_Writer\StreamReader_Writer\英雄配置.txt";
        StreamReader streamReader = new StreamReader(path);
        Console.WriteLine("StreamReader: \n"+streamReader.ReadToEnd());
        streamReader.Close();


        string writeText = "1023	大妈	2	 5000	FALSE	2250	0	212";
        
        //StreamWriter streamWriter = new StreamWriter(path); // 會被覆蓋
        // 如果是要追加資料，要填入第二個參數: true為追加，false為覆蓋
        StreamWriter streamWriter = new StreamWriter(path, true);
        streamWriter.WriteLine(writeText); 
        streamWriter.Close();
        Console.WriteLine("寫入完畢");
        
    }
    
}