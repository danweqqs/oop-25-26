using System;

namespace Decorator
{
    public interface IChristmasTree
    {
        string Decorate();
    }
    public class ChristmasTree : IChristmasTree
    {
        public string Decorate()
        {
            return "Base Tree";
        }
    }
    public abstract class TreeDecorator : IChristmasTree
    {
        protected IChristmasTree tree;

        public TreeDecorator(IChristmasTree tree)
        {
            this.tree = tree;
        }

        public virtual string Decorate()
        {
            return tree.Decorate();
        }
    }
    public class OrnamentsDecorator : TreeDecorator
    {
        private string ornaments = " + Balls and Tinsel";
        public OrnamentsDecorator(IChristmasTree tree) : base(tree) { }
        public override string Decorate()
        {
            return tree.Decorate() + ornaments;
        }
    }
    public class GarlandsDecorator : TreeDecorator
    {
        public GarlandsDecorator(IChristmasTree tree) : base(tree) { }

        public override string Decorate()
        {
            return tree.Decorate() + LightUp();
        }
        private string LightUp()
        {
            return " + Shining Garlands";
        }
    }
    public class DecoratorExample
    {
        public static void Main(string[] args)
        {
            IChristmasTree simpleTree = new ChristmasTree();
            Console.WriteLine($"Simple Tree: {simpleTree.Decorate()}");

            IChristmasTree ornamentsOnly = new OrnamentsDecorator(new ChristmasTree());
            Console.WriteLine($"Ornaments Only: {ornamentsOnly.Decorate()}");

            IChristmasTree garlandsOnly = new GarlandsDecorator(new ChristmasTree());
            Console.WriteLine($"Garlands Only: {garlandsOnly.Decorate()}");

            IChristmasTree fullyDecoratedTree = new OrnamentsDecorator(
                new GarlandsDecorator(new ChristmasTree())
            );
            Console.WriteLine($"Fully Decorated: {fullyDecoratedTree.Decorate()}");

            Console.ReadKey();
        }
    }
}