using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Conceptual
{
    public class Product
    {
        private List<object> _parts = new();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            var stringBuilder = new StringBuilder("Product Parts: ");
            foreach (var part in _parts)
            {
                stringBuilder.Append($"{part}, ");
            }

            stringBuilder.Remove(stringBuilder.Length - 2, 2);
            return stringBuilder.ToString();
        }
    }
}