// See https://aka.ms/new-console-template for more information
class Delegate委託
{
    // Delegate 委託 -> 可帶參數也可不帶參數，但寫法相對複雜

    delegate void MyDelegate(); // 建立一個delegate原型
    private static MyDelegate delegate1; // 利用原型實例delegate
    
    // 帶有參數的 delegate
    delegate void MyDelegate2(int a, int b);
    private static MyDelegate2 delegate2; 
    
    public static void Main(string[] args)
    {
        delegate1 += Test1;
        delegate1 += Test2;
        delegate1();
        
        Console.WriteLine("第二次調用: ");
        delegate1 -= Test2;
        delegate1();

        delegate1 += Test2;
        Test(delegate1);
        
        // 帶有參數
        delegate2 += Test3;
        delegate2(20, 40);
    }

    static void Test(MyDelegate _delegate)
    {
        Console.WriteLine("Test!");
        if (_delegate != null)
        {
            _delegate();
        }
    }
    
    static void Test1()
    {
        Console.WriteLine("調用Test1");
    }

    static void Test2()
    {
        Console.WriteLine("調用Test2");
    }

    static void Test3(int a, int b)
    {
        Console.WriteLine("調用Test3, result: "+(a+b));
    }
    
}