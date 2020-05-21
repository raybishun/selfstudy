namespace StructsVsClasses
{
    interface ITest
    {
        // Interfaces cannot contains instance fields
        // public int SomeInt;

        // but Interfaces can contain properties
        int SomeInt { get; set; }

        // and of course, method signatures
        string MustDowork(string[] arrayOfWork);
    }
}
