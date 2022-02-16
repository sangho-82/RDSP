using System;
using CompositePattern.Conceptual;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaf = new Leaf();
            Console.Write("Client: I get a simple component: ");
            Client.ClientCodeFoo(leaf);

            Component tree = new Composite();
            Composite branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Component branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.Write("Client: Now I have got a composite tree: ");
            Client.ClientCodeFoo(tree);
            
            Console.Write("Client: I do not need to check the components classes: ");
            Client.ClientCodeBar(tree, leaf);
        }
    }
}