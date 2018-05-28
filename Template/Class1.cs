abstract class Class1
{
    public virtual void Connect()
    {
        //some code here
    }
    public abstract void Select();
    public abstract void Process();
    public virtual void Disconnect()
    {
        //some code here
    }

    public void Run()
    {
        Connect();
        Select();
        Process();
        Disconnect();
    }
}
