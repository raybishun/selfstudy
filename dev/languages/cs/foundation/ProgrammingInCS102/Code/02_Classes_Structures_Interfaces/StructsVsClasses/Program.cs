using System;

namespace StructsVsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            CoordinatePointClass coordinatePointClass =
                new CoordinatePointClass(.82F, .34F);

            CoordinatePointStruct coordinatePointStruct =
                new CoordinatePointStruct(.82F, .34F);

            Console.WriteLine($"CLASS: {coordinatePointClass.X} \t {coordinatePointClass.Y}");

            Console.WriteLine($"STRUCT: {coordinatePointStruct.X} \t {coordinatePointStruct.Y}");

            Console.WriteLine();

            ChangeValueClass(coordinatePointClass);

            ChangeValueStruct(coordinatePointStruct);

            Console.WriteLine($"CLASS: {coordinatePointClass.X} \t {coordinatePointClass.Y}");

            Console.WriteLine($"STRUCT: {coordinatePointStruct.X} \t {coordinatePointStruct.Y}");
        }

        static void ChangeValueClass(CoordinatePointClass obj)
        {
            obj.X = .5F;
            obj.Y = .5F;
        }

        static void ChangeValueStruct(CoordinatePointStruct obj)
        {
            obj.X = .5F;
            obj.Y = .5F;
        }
    }
}
