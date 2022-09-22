public class Player
{
    public delegate void MyDelegate();

    // Event就是針對委託的限制，讓委託調度只能在自身類別使用
    public event MyDelegate _delegate; // 表示為事件

    public void Call()
    {
        if (_delegate != null)
        {
            _delegate();
        }
    }
}