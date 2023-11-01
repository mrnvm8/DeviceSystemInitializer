using System;

namespace DeviceSystemInitializer.Model
{
    public class Employee
    {
        public Guid Id { get; init; }
        public Guid PersonId { get; init; }
        public Guid DepartmentId { get; init; }
        public string WorkEmail { get; init; } = string.Empty;
        public DateTime Enrollment { get; init; }
        public bool IsEmployeeActive { get; init; } = true;
        public virtual Person? Person { get; set; }
        public virtual Department? Department { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public Employee()
        {
            Users = new HashSet<User>();
        }

        public Employee Intialise(Person person, Department department)
        {
            var employee = new Employee
            {
                Id = Guid.Parse("550e0faf-d9a5-42e8-88eb-881e5246262e"),
                PersonId = person.Id,
                DepartmentId = department.Id,
                WorkEmail = "lindokuhle@axiumeducation.org",
                Enrollment = DateTime.Now,
                IsEmployeeActive = true
            };
            return employee;
        }
    }
}
