using System;

namespace PrototypePattern.Conceptual
{
    public class Person
    {
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public PersonId Id { get; set; }

        public Person ShallowCopy() => (Person)MemberwiseClone();

        public Person DeepCopy()
        {
            var clone = (Person)MemberwiseClone();
            clone.Id = new PersonId { IdNumber = Id.IdNumber };
            clone.Name = Name;
            
            return clone;
        }
    }
}