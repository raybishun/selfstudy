namespace HttpClient_DeserializeObject2.Models
{
    class Contributor
    {
        public string Login { get; set; }
        public short Contributions { get; set; }

        public override string ToString()
        {
            return $"{Login,20}: {Contributions} contributions.";
        }
    }
}
