using System;

namespace DeviceSystemInitializer.Model
{
    public class Department
    {
        public Guid Id { get; init; }
        public Guid OfficeId { get; init; }
        public string DepartmentName { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public virtual Office? Offices { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public Department Intialise(Office office)
        {
            var department = new Department
            {
                Id = Guid.Parse("2ff84804-a76a-4fd9-831d-09b55691f299"),
                OfficeId = office.Id,
                DepartmentName = "OPERATIONS",
                Description = "This is the ZLE Operations"
            };

            return department;
        }
    }
}
