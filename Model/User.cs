using System.Security.Cryptography;

namespace DeviceSystemInitializer.Model
{
    public class User
    {
        public Guid Id { get; init; }
        public Guid EmployeeId { get; init; }
        public byte[] PasswordHash { get; init; }
        public byte[] PasswordSalt { get; init; }
        public Roles Role { get; init; }
        public DateTime DateCreated { get; init; }
        public virtual Employee? Employee { get; set; }
       
        public User(){}
        public User Intialise(Employee employee)
        {
            CreatePasswordHash("xxxxxxxx", out byte[] passwordHash, out byte[] passwordSalt);

            var user = new User
            {
                Id = Guid.NewGuid(),
                EmployeeId = employee.Id,
                Role = 0,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                DateCreated = DateTime.Now
            };
            return user;
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            //crytogrphy algorithm
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                //creating password hash
                passwordHash = hmac
                    .ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
