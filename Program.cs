using DeviceSystemInitializer.Data;
using DeviceSystemInitializer.Model;

using (var _context = new ApplicationDbContext()){

    //Initialising Person 
    var person = new Person().Intialise();
    _context.People.Add(person);
    _context.SaveChanges();

    //Initialising Office
    var office = new Office().Intialise();
    _context.Offices.Add(office);
    _context.SaveChanges();

    //Initialising Department 
    var department = new Department().Intialise(office);
    _context.Departments.Add(department);
    _context.SaveChanges();

    //Initialising Employee 
    var employee = new Employee().Intialise(person, department);
    _context.Employees.Add(employee);
    var affected = _context.SaveChanges();


    //If the Employee successed.
    //Initialising Users
    if (affected == 1)
    {
        var user = new User().Intialise(employee);
        _context.Users.Add(user);
        _context.SaveChanges();

        Console.WriteLine("Initial setup was successfuly :)");
    }




}