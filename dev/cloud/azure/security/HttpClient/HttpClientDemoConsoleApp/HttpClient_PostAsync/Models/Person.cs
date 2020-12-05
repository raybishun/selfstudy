namespace HttpClient_PostAsync.Models
{
    class Person
    {
        public string Name { get; set; }
        public string Occupation { get; set; }

        public override string ToString()
        {
            return $"{Name}: {Occupation}";
        }
    }
}
