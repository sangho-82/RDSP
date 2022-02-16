using System.Text;

namespace FacadePattern.Conceptual
{
    public class Facade
    {
        protected SubsystemFoo _subsystemFoo;
        protected SubsystemBar _subsystemBar;

        public Facade(SubsystemFoo foo, SubsystemBar bar)
        {
            _subsystemFoo = foo;
            _subsystemBar = bar;
        }

        public string Operation()
        {
            var sb = new StringBuilder("Facade initializes subsystems:\n");
            sb.Append(_subsystemFoo.Operation0())
                .Append(_subsystemBar.OperationA())
                .Append("Facade orders subsystems to perform the action.\n")
                .Append(_subsystemFoo.Operation1())
                .Append(_subsystemBar.OperationB());
            
            return sb.ToString();
        }
    }
}