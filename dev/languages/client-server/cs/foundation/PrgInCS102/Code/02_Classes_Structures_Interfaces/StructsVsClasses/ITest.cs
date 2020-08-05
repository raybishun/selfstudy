namespace StructsVsClasses
{
    interface ITest
    {
        // Interfaces cannot contains instance fields
        // public int SomeInt;

        // but Interfaces can contain properties
        int SomeInt { get; set; }

        // and of course, the method declarations
        string MustDowork(string[] arrayOfWork);
    }
}
