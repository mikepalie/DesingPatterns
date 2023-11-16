namespace Singleton.Structural
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>

    public sealed class Singleton
    {
        //static Singleton instance;

        // Constructor is 'private'
        public static Singleton instance { get; } = new Singleton();
        private Singleton()
        {
        }

        //public static Singleton Instance()
        //{
        //    // Uses lazy initialization.
        //    // Note: this is not thread safe.
        //    if (instance == null)
        //    {
        //        instance = new Singleton();
        //    }

        //    return instance;
        //}
    }
}

