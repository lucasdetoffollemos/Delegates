namespace Delegates
{
    internal class Program
    {
        // Define a delegate type
        public delegate void MyDelegate(string message);

        static void Main(string[] args)
        {
            //add a reference to the method that matches the delegate signature
            MyDelegate myDelegate = x => Console.WriteLine(x);

            //multicast delegate: add another method to the invocation list
            myDelegate += MyMethod;

            // Invoke the delegate
            //it invocate the methods in the invocation list in the order they were added
            myDelegate("Hello, World!");
        }

        private static void MyMethod(string message)
        {
            Console.WriteLine(message + " (from MyMethod)");
        }
    }
}
