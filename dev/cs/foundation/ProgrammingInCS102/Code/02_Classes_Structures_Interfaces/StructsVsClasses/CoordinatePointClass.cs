namespace StructsVsClasses
{
    class CoordinatePointClass
    {
        public float X { get; set; }
        public float Y { get; set; }

        public CoordinatePointClass()
        {

        }
        
        public CoordinatePointClass(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
