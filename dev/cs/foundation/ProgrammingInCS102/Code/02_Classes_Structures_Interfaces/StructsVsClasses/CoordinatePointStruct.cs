namespace StructsVsClasses
{
    struct CoordinatePointStruct : ITest
    {
        public float X { get; set; }
        public float Y { get; set; }
        

        //public CoordinatePointStruct()
        //{
        //    // Structs cannot contain explicit parameterless ctors
        //}

        public CoordinatePointStruct(float x, float y)
        {
            X = x;
            Y = y;
        }



        // Yes, a struct can use interfaces...
        public int SomeInt { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string MustDowork(string[] arrayOfWork)
        {
            throw new System.NotImplementedException();
        }
    }
}
