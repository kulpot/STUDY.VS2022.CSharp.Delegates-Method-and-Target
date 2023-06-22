using System;

//ref link:https://www.youtube.com/watch?v=N9XmnG91G5g&list=PLAE7FECFFFCBE1A54&index=4
// Delegate keeps track of two things a method and an instance to invoke that upon

delegate void MeDelegate(int value);

class MainClass
{
    static void Main()
    {
        //MeDelegate del = Main;
        //Foo();
        MeDelegate d = Foo;// static no object
        Console.WriteLine(d.Method); // result Void Foo(Int32)
        Console.WriteLine(d.Target); // result null
        //new MainClass().Goo(); // instance method
        MainClass m = new MainClass(); 
        //m.Goo(5); 
        d = m.Goo;
        Console.WriteLine(d.Method); // result Void Goo(Int32)
        Console.WriteLine(d.Target); // result MainClass
    }
    static void Foo(int u) { }
    void Goo(int waa) { } // none static method/instance method
}