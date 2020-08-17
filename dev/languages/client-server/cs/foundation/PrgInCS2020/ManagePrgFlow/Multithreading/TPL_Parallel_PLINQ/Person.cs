namespace TPL_Parallel_PLINQ
{
    class Person
    {
        public string Name { get; set; }
        public string City { get; set; }

        public static Person[] GetPeople()
        {
            Person[] people = new Person[] {
                new Person {Name = "Vanessa", City = "New York"},
                new Person {Name = "Peter", City = "Orlando"},
                new Person {Name = "June", City = "New York"},
                //new Person {Name = "Exception Test", City = ""},
                new Person {Name = "Jennifer", City = "Seattle"},
                new Person {Name = "Julie", City = "New York"},
                new Person {Name = "Jessica", City = "Cary"},
                new Person {Name = "Ray", City = "New York"},
            };

            return people;
        }
    }
}
