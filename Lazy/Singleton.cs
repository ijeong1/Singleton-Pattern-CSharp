public sealed class Singleton
{
    private Singleton()
    {
    }

    public static Singleton Instance { get { return Nested.Instance; } }

    private class Nested{
        static Nested()
        {
        }

        internal static readonly Singleton Instance = new Singleton();
    }
}