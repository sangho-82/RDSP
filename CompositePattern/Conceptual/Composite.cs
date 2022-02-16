using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Conceptual
{
    public class Composite : Component
    {
        protected List<Component> _children = new();

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override string Operation()
        {
            var stringBuilder = new StringBuilder("Branch(");
            foreach (var child in _children)
            {
                stringBuilder.Append(child.Operation()).Append('+');
            }

            stringBuilder.Remove(stringBuilder.Length - 1, 1).Append(')');
            return stringBuilder.ToString();
        }
    }
}