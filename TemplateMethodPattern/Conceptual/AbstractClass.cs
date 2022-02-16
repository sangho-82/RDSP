using System;

namespace TemplateMethodPattern.Conceptual
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            BaseOpeartion1();
            RequiredOperation1();
            BaseOperation2();
            Hook1();
            RequiredOperation2();
            BaseOperation3();
            Hook2();
        }

        protected void BaseOpeartion1() => Console.WriteLine("ABC: BO1");
        
        protected void BaseOperation2() => Console.WriteLine("ABC: BO2");

        protected void BaseOperation3() => Console.WriteLine("ABC: BO3");

        protected abstract void RequiredOperation1();

        protected abstract void RequiredOperation2();

        protected virtual void Hook1() {}
        
        protected virtual void Hook2() {}
    }
}