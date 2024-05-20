using ClassLibrary1;
using static System.Console;

namespace EventsExample2
{
    internal class Program
    {
        static void Main()
        {
            Pulished pulished = new Pulished();
            Subsribed subsribed = new Subsribed();
            pulished.myEvent += subsribed.Add;
            pulished.myEvent += subsribed.Add;
            pulished.myEvent -= subsribed.Add;
            pulished.myEvent += subsribed.Add;
            pulished.RaiseEvent(10, 20);
            ReadKey();

        }
    }
}
