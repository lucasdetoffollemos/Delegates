namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> myDelegate;

            //Assign a lambda that matches Action<int>: receives int and returns void
            myDelegate = x =>
            {
                return x * 2;
            };

            // Invoke the delegate
            //it invocate the methods in the invocation list in the order they were added
            Console.WriteLine(myDelegate(10));
        }

        private static int MyMethod(int num)
        {
            Console.WriteLine("Second function");
            return num = num * 5;
        }
    }
}
