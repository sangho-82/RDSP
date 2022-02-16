namespace BuilderPattern.Conceptual
{
    public class Director
    {
        public IBuilder Builder { private get; set; }

        public void BuildMinimalSpec()
        {
            Builder.BuildPartFoo();
        }

        public void BuildMaximalSpec()
        {
            Builder.BuildPartFoo();
            Builder.BuildPartBar();
            Builder.BuildPartBaz();
        }
    }
}