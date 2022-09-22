class Event委託
{
    public static void Main(String[] args)
    {
        Player player = new Player();
        player._delegate += Test1;
        player.Call();
    }

    static void Test1() 
    {
        Console.WriteLine("調用Test1");
    }
}