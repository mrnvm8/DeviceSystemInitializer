namespace DeviceSystemInitializer.Model
{
    public class Office
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public string Location { get; init; } = string.Empty;
        public virtual ICollection<Department> Departments { get; set; }
        public Office()
        {
            Departments = new HashSet<Department>();
        }

        public Office Intialise()
        {
            var office = new Office
            {
                Id = Guid.Parse("6b6f34aa-9226-4f0f-b369-0114364d7f21"),
                Name = "ZITHULELE ZLE",
                Location = "ZITHULELE VILLAGE"
            };
            return office;
        }
    }
}
