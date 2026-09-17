namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> myDelegateIsEven;

            //Assign a lambda that matches Action<int>: receives int and returns void
            myDelegateIsEven = x =>
            {
                return x % 2 == 0;
            };

            // Invoke the delegate
            //it invocate the methods in the invocation list in the order they were added
            Console.WriteLine(myDelegateIsEven(9));
        }

        private static bool MyMethod(int num)
        {
            Console.WriteLine("Second function");
            return num % 2 == 0;
        }
    }
}
