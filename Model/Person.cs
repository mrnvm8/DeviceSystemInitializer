namespace DeviceSystemInitializer.Model
{
    public class Person
    {
        public Guid Id { get; init; }
        public string FirstName { get; init; } = string.Empty;
        public string LastName { get; init; } = string.Empty;
        public Gender Gender { get; init; }
        public virtual ICollection<Employee> Employees { get; set; }
        public Person()
        {
            Employees = new HashSet<Employee>();
        }

        public Person Intialise()
        {
            var person = new Person
            {
                Id = Guid.Parse("241d9b7c-e4ce-4858-b2b9-77fcd31a1d44"),
                FirstName = "LINDOKUHLE",
                LastName = "MAGAGULA",
                Gender = 0
            };

            return person;
        }
    }
}
