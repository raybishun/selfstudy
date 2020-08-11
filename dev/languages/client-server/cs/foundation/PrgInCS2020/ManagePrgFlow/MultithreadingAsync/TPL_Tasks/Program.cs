using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run a task within a method (Main() in this case)
            //Task t = Task.Run(() => Work.SomeWork());
            //t.Wait();

            // DoSomeWork();
            Return_A_Value_From_A_Task();


            Console.WriteLine("Done");
            Console.ReadKey();
        }

        static void DoSomeWork()
        {
            Task t = new Task(() => Work.SomeWork());
            t.Start();
            t.Wait();
        }

        static void Return_A_Value_From_A_Task()
        {
            Task<int> t = Task.Run(() =>
            {
                return Work.CalcResult();
            });

            Console.WriteLine(t.Result);
        }
    }
}
