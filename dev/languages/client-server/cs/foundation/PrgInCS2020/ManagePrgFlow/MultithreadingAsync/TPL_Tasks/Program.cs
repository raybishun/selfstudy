using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // You can run a task within a method (Main() in this case)
            //Task t = Task.Run(() => Work.SomeWork());
            //t.Wait();

            // TaskFactory
            // - Task.Run() actually uses TaskFactory.StartNew() to create and start tasks
            // - Task.Run() also uses the default task scheduler (the .NET framework thread pool)


            // DoSomeWork();
            // Return_A_Value_From_A_Task();
            // Task_WaitAll();
            // Continuous_Tasks();
            // Child_Tasks_Attached_To_Parent();
            Child_Tasks_Without_Attachment_To_Parent();


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

        static void Task_WaitAll()
        {
            Task[] tasks = new Task[10];

            for (int i = 0; i < 10; i++)
            {
                int taskNum = i;

                tasks[i] = Task.Run( ()=> Work.SomeWork(taskNum));
            }

            // Wait for all tasks to complete before proceeding
            Task.WaitAll(tasks);

            // Waits for any one of a number of concurrent tasks to complete
            // Task.WaitAny(tasks); 
        }

        static void Continuous_Tasks()
        {
            //Task t = Task.Run( () => Work.HelloTask() );
            //t.ContinueWith( (prevTask) => Work.WorldTask() );

            Task t = Task.Run(() => Work.HelloTask());

            // ContinueWith overload, the TaskContinuationOptions parameter
            t.ContinueWith((prevTask) => Work.WorldTask(), TaskContinuationOptions.OnlyOnRanToCompletion);

            // A new task will run ExceptionTask() only if HelloTask() throws an exception 
            t.ContinueWith((prevTask) => Work.ExceptionTask(), TaskContinuationOptions.OnlyOnFaulted);
        }

        static void Child_Tasks_Attached_To_Parent()
        {
            // Child tasks execute independently from their parent,
            // these child tasks are referred to as detached child tasks or detached nested tasks
            // You can specify child tasks are attached to their parent, as such,
            // the parent task will only end after all child tasks have completed their work

            var parent = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Parent task started...");
                for (int i = 0; i < 10; i++)
                {
                    int taskNo = i;

                    Task.Factory.StartNew(
                        (x) => Work.ChildTask(x),
                        taskNo, // state object
                        TaskCreationOptions.AttachedToParent);
                }
            });

            // Wait for all attached child tasks to complete
            parent.Wait();
        }

        static void Child_Tasks_Without_Attachment_To_Parent()
        {
            // Using the TaskCreationOptions.DenyChildAttach option
            // Note: By default Task.Run() uses the TaskCreationOptions.DenyChildAttach option

            var parent = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Parent task started...");
                for (int i = 0; i < 10; i++)
                {
                    int taskNo = i;

                    Task.Factory.StartNew(
                        (x) => Work.ChildTask(x),
                        taskNo, // state object
                        TaskCreationOptions.DenyChildAttach);
                }
            });

            // Wait for all child tasks to complete
            parent.Wait();
        }
    }
}
