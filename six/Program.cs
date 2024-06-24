using System;

// Base class for single inheritance
public class ParentClass
{
    public void Method1()
    {
        Console.WriteLine("Method from ParentClass");
    }
}

// Interface for multiple inheritance
public interface IInterface1
{
    void Method2();
}

public interface IInterface2
{
    void Method3();
}

// Derived class for multiple inheritance
public class ChildClass : ParentClass, IInterface1, IInterface2
{
    public void Method2()
    {
        Console.WriteLine("Method from IInterface1");
    }

    public void Method3()
    {
        Console.WriteLine("Method from IInterface2");
    }
}

// Derived class for multilevel inheritance
public class DerivedClass : ParentClass
{
    public void Method4()
    {
        Console.WriteLine("Method from DerivedClass");
    }
}

// Derived class for hybrid inheritance
public class FurtherDerivedClass : DerivedClass, IInterface1
{
    public void Method2() // Implementation of Method2 from IInterface1
    {
        Console.WriteLine("Method from FurtherDerivedClass");
    }
}

// Derived classes for hierarchical inheritance
public class ChildClass1 : ParentClass
{
    public void Method6()
    {
        Console.WriteLine("Method from ChildClass1");
    }
}

public class ChildClass2 : ParentClass
{
    public void Method7()
    {
        Console.WriteLine("Method from ChildClass2");
    }
}

class Program
{
    static void Main()
    {
        // Single inheritance
        ParentClass parent = new ParentClass();
        parent.Method1(); // Output: Method from ParentClass

        // Multiple inheritance
        ChildClass child = new ChildClass();
        child.Method1(); // Output: Method from ParentClass
        child.Method2(); // Output: Method from IInterface1
        child.Method3(); // Output: Method from IInterface2

        // Multilevel inheritance
        DerivedClass derived = new DerivedClass();
        derived.Method1(); // Output: Method from ParentClass
        derived.Method4(); // Output: Method from DerivedClass

        // Hybrid inheritance
        FurtherDerivedClass furtherDerived = new FurtherDerivedClass();
        furtherDerived.Method1(); // Output: Method from ParentClass
        furtherDerived.Method4(); // Output: Method from DerivedClass
        furtherDerived.Method2(); // Output: Method from FurtherDerivedClass

        // Hierarchical inheritance
        ChildClass1 child1 = new ChildClass1();
        child1.Method1(); // Output: Method from ParentClass
        child1.Method6(); // Output: Method from ChildClass1

        ChildClass2 child2 = new ChildClass2();
        child2.Method1(); // Output: Method from ParentClass
        child2.Method7(); // Output: Method from ChildClass2
    }
}
