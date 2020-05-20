namespace StructsVsClasses
{
    struct CoordinatePointStruct
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
    }
}
