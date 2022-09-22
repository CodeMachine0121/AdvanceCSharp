// See https://aka.ms/new-console-template for more information

public class Program
{
    // Action委託 不支持有回傳值的方法，這個時候就可以用 function委託
    private static Action action1;
    private static Action<int, int> action2;
    public static void Main(string[] args)
    {
        // 綁定方法
        action1 = func1;
        // 綁定第二個方法
        action1 += func2;
        // 使用
        action1();
        // 刪除已綁定的方法
        action1 -= func1;
        action1();
        
        // 綁定帶有參數的方法   
        action2 = func3;
        action2(3,5);
    }

    public static void func1()
    {
        Console.WriteLine("調用Function 1");
    }

    public static void func2()
    {
        Console.WriteLine("調用Function 2");
        
    }

    public static void func3(int a, int b)
    {
        Console.WriteLine("調用Function 3: "+ (a+b));
    }
    
}