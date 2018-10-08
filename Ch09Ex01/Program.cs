using System;
using static System.Console;

namespace Ch09Ex01
{
    public abstract class MyBase { } // cannot be instantiated
    internal class MyClass : MyBase { } // MyClass derives from class MyBase; MyClass is only accessible from with the current project
    public interface IMyBaseInterface { } // for difference between interfaces and abstract class see figure 9-13
    internal interface IMyBaseInterface2 { } // another interface
    internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2 { } // Interfaces can inherit from multiple interfaces
    internal sealed class MyComplexClass : MyClass, IMyInterface { } // classes do not allow multiple inheritance but can inherit from more than one interface

    class Program
    {
        static void Main(string[] args)
        {
            MyComplexClass myObj = new MyComplexClass();
            WriteLine(myObj.ToString());
            ReadKey();
        }
    }
}
