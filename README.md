# DeviceSystemInitializer

Requirements for the project

MySql Server 8.0
ASP.NET dotnet 6.0 
  -dotnet ef
VSCode or Any Editor you Prefer

Download this DeviceSystemInitializer project. --The are a few changes you need to make.

1. ApplicationDbContext.cs from Data Folder
    -Change this to match your Database settings
   **server=localhost;user=user1;password=xxxxxx;database=SystemDB**
2. Users.cs from Model folder -change the string password to what you like 
   **CreatePasswordHash("xxxxxxxx", out byte[] passwordHash, out byte[] passwordSalt)**

NOTICE DO NOT DO THE FOLLOWING IF YOU ARE USING THIS PROJECT WITH  THE DeviceSystem Project.
**dotnet run** command will do find for you, it will seed the database of DeviceSystem.

**Using this Project alone**
Run **dotnet ef migrations add DatabseIntialisation** for creating the database tablets.
Now you are good to go => **dotnet run**

This project will seed a database tables
**-- People table
-- Offices table
-- Department table
-- Employees table
-- Users table**

