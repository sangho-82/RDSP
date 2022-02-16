namespace CompositePattern.Conceptual
{
    public class Leaf : Component
    {
        public override string Operation() => "LEAF";

        public override bool IsComposite() => false;
    }
}