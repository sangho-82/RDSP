namespace StatePattern.Conceptual
{
    public abstract class State
    {
        protected Context _context;

        public void SetContext(Context context) => _context = context;

        public abstract void HandleFoo();

        public abstract void HandleBar();
    }
}