using System;

namespace MulticastDelegates
{
    class Program
    {
        delegate void Message(string s);

        static void Hello(string s)
        {
            Console.WriteLine("  Hello, {0}", s);
        }

        static void Goodbye(string s)
        {
            Console.WriteLine("  Goodbye, {0}", s);
        }
                

        static void Main(string[] args)
        {
            Console.WriteLine("Multicast Delegates");
            Console.WriteLine("A great feature of delegates is that you can combine them together. This is called multicasting.");
            Console.WriteLine("You can use the + or += operator to add another method to the invocation list of an existing delegate instance.");
            Console.WriteLine("Similarly, you can also remove a method from an invocation list by using the decrement assignment operator (- or -=).");
            Console.WriteLine();

            Message hello, goodBye, helloGoodbye, justGoodBye;

            // create the delegate object 'hello' that references the method Hello
            hello = Hello;

            // create the delegate object 'goodbye' that references the method Goodbye
            goodBye = Goodbye;

            // the two delegates, 'hello' and 'goodbye', are composed to form helloGoodbye: 
            helloGoodbye = hello + goodBye;

            // remove a from the composed delegate, leaving d, which calls only the method Goodbye:
            justGoodBye = helloGoodbye - hello;

            // invoking delegate hello: 
            // Hello, Stuart
            Console.WriteLine("Invoking delegate hello:");
            hello("Stuart");
            Console.WriteLine();

            // invoking delegate goodBye: 
            // Goodbye, Stuart
            Console.WriteLine("Invoking delegate goodBye:");
            goodBye("Stuart");
            Console.WriteLine();

            // invoking delegate helloGoodbye:
            // Hello, Stuart
            // Goodbye, Stuart
            Console.WriteLine("Invoking delegate helloGoodbye:");
            helloGoodbye("Stuart");
            Console.WriteLine();

            // invoking delegate justGoodBye:
            // Goodbye, Stuart
            Console.WriteLine("Invoking delegate justGoodBye:");
            justGoodBye("Stuart");

            Console.ReadLine();
        }
    }
}