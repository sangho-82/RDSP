namespace BuilderPattern.Conceptual
{
    public class SampleBuilder : IBuilder
    {
        private Product _product = new();

        public SampleBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new Product();
        }
        
        public void BuildPartFoo()
        {
            _product.Add("[Sample]PartFoo");
        }

        public void BuildPartBar()
        {
            _product.Add("[Sample]PartBar");
        }

        public void BuildPartBaz()
        {
            _product.Add("[Sample]PartBaz");
        }

        public Product GetProduct()
        {
            var result = _product;
            Reset();

            return result;
        }
    }
}