namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int> myDelegate;

            //Assign a lambda that matches Action<int>: receives int and returns void
            myDelegate = x => Console.WriteLine(x * 2);

            //add another method to the invocation list
            myDelegate += MyMethod;

            // Invoke the delegate
            //it invocate the methods in the invocation list in the order they were added
            myDelegate(5);
        }

        private static void MyMethod(int num)
        {
            num = num * 5;
            Console.WriteLine(" (from MyMethod) " + num);
        }
    }
}
