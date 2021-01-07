public seald class Singleton
{
    private static Singleton instance = null;
    private static readonly object padlock = new object();

    Singleton()
    {
    }

    public static Singleton instance
    {
        get
        {
            lock(padlock)
            {
                if(instance == null){
                    instance = new Singleton();
                }
                
                return instance;
            }
        }
    }
}