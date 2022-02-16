namespace SingletonThreadSafePattern.Conceptual
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;
        private static readonly object _lock = new();
        public string Value { get; set; }

        private ThreadSafeSingleton()
        {
        }

        public static ThreadSafeSingleton GetInstance(string value)
        {
            lock (_lock)
            {
                if (_instance != null) return _instance;
                
                _instance = new ThreadSafeSingleton { Value = value };
            }

            return _instance;
        }
    }
}