class Func委託
{
    
    // Func 支援 1~16個參數的方法，且每個方法都要有一個回傳值
    // <回傳型態, 參數型態>
    private static Func<int, int, int> func1;
    public static void Main(String[] args)
    {
        func1 = Test;
        func1 += Test2; // 委託的回傳值 只有最新委託的方法
        int result = func1(100, 500);
        Console.WriteLine("The result is " + result);
        
        // 取消委託
        func1 -= Test;
        
        // 把Func作為方法參數使用
        Test3(Test2, 100,200);

    }

    public static int Test(int a, int b)
    {
        return a * b;
    }

    public static int Test2(int a, int b)
    {
        return a + b;
    }

    // Func比較不方便 所以當方法不需要餐數時候用Action就好。
    public static void Test3(Func<int, int, int> callback, int a, int b)
    {
        Console.WriteLine("使用Test3");
        if (callback != null)
        {
            var result  =callback(a, b);
            Console.WriteLine("Result: "+result);
        }
    }
}