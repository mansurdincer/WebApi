namespace WebApi.Data;

public class DbInitializer
{
    private readonly ModelBuilder modelBuilder;

    public DbInitializer(ModelBuilder modelBuilder)
    {
        this.modelBuilder = modelBuilder;
    }

    public void Seed()
    {

        //seniority
        modelBuilder.Entity<Seniority>().HasData(
            new Seniority { Id = 1, Name = "Şef Müdür", Multiplier = 0f },
            new Seniority { Id = 2, Name = "Grup Lideri", Multiplier = 0f },
            new Seniority { Id = 3, Name = "Takım Lideri", Multiplier = 0f },
            new Seniority { Id = 4, Name = "Takım Lider Yardımcısı", Multiplier = 13.5f },
            new Seniority { Id = 5, Name = "Operatör", Multiplier = 18.5f }
          );

        modelBuilder.Entity<Rank>().HasData(
            new Rank { Id = 1, Name = "Kademe Yok", Multiplier = 1f },
            new Rank { Id = 2, Name = "4. Kademe", Multiplier = 1.232f },
            new Rank { Id = 3, Name = "3. Kademe", Multiplier = 1.15f },
            new Rank { Id = 4, Name = "2. Kademe", Multiplier = 1.077f },
            new Rank { Id = 5, Name = "1. Kademe", Multiplier = 1f },
            new Rank { Id = 6, Name = "En 4. Kademe", Multiplier = 1.287f },
            new Rank { Id = 7, Name = "En 3. Kademe", Multiplier = 1.19f },
            new Rank { Id = 8, Name = "En 2. Kademe", Multiplier = 1f },
            new Rank { Id = 9, Name = "En 1. Kademe", Multiplier = 1f },
            new Rank { Id = 10, Name = "Mek 3. Kademe", Multiplier = 1.378f },
            new Rank { Id = 11, Name = "Mek 2. Kademe", Multiplier = 1.159f },
            new Rank { Id = 12, Name = "Mek 1. Kademe", Multiplier = 1f }
            );

        modelBuilder.Entity<User>().HasData(
          new User { Id = 1, Username = "Mansur", Password = "1", Email = "" },
          new User { Id = 2, Username = "Dondu", Password = "1", Email = "" }
          );

        modelBuilder.Entity<Entities.Role>().HasData(
            new Entities.Role { Id = 1, Name = "Admin" },
            new Entities.Role { Id = 2, Name = "User" }
            );

        modelBuilder.Entity<UserRole>().HasData(
            new UserRole { UserId = 1, RoleId = 1 },
            new UserRole { UserId = 2, RoleId = 2 }
            );

        modelBuilder.Entity<JobTitle>().HasData(
            new JobTitle { Id = 1, Name = "CEO" },
            new JobTitle { Id = 2, Name = "Manager" },
            new JobTitle { Id = 3, Name = "Employee" },
            new JobTitle { Id = 4, Name = "Intern" }
            );

        modelBuilder.Entity<Department>().HasData(
            new Department { Id = 1, Name = "IT" },
            new Department { Id = 2, Name = "QA" },
            new Department { Id = 3, Name = "Sales" },
            new Department { Id = 4, Name = "Marketing" },
            new Department { Id = 5, Name = "Accounting" },
            new Department { Id = 6, Name = "Finance" },
            new Department { Id = 7, Name = "HR" }
            );

        modelBuilder.Entity<Employee>().HasData(
            new Employee { Id = 1, RegistrationNo = "10001", Name = "Mansur", Surname = "Dinçer", Email = "mansur.dincer@filidea.com.tr", DepartmentId = 1, JobTitleId = 3, SeniorityId = 1, RankId = 1 },
            new Employee { Id = 2, RegistrationNo = "10002", Name = "Döndü", Surname = "Yılmaz", Email = "dondu.yilmaz@filidea.com.tr", DepartmentId = 2, JobTitleId = 2, SeniorityId = 2, RankId = 2 },
            new Employee { Id = 3, RegistrationNo = "10003", Name = "Muhammer", Surname = "Sayın", Email = "muhammer.sayin@filidea.com.tr", DepartmentId = 1, JobTitleId = 3, SeniorityId = 3, RankId = 3 },
            new Employee { Id = 4, RegistrationNo = "10004", Name = "Abdullah", Surname = "Kasım", Email = "abdullah.kasim@filidea.com.tr", DepartmentId = 1, JobTitleId = 2, SeniorityId = 4, RankId = 4 },
            new Employee { Id = 5, RegistrationNo = "10005", Name = "Fahri", Surname = "Yılmaz", Email = "fahri.yilmaz@filidea.com.tr", DepartmentId = 6, JobTitleId = 3, SeniorityId = 5, RankId = 5 },
            new Employee { Id = 6, RegistrationNo = "10006", Name = "Mustafa", Surname = "Kalaycıoğlu", Email = "mustafa.kalaycioglu@filidea.com.tr", DepartmentId = 4, JobTitleId = 2, SeniorityId = 1, RankId = 6 }
            );

        modelBuilder.Entity<AbsenteeismType>().HasData(
            new AbsenteeismType { Id = 1, Name = "Ameliyat" },
            new AbsenteeismType { Id = 2, Name = "Covid" },
            new AbsenteeismType { Id = 3, Name = "Doğum" },
            new AbsenteeismType { Id = 4, Name = "Mazeretsiz" },
            new AbsenteeismType { Id = 5, Name = "Hastalık" },
            new AbsenteeismType { Id = 6, Name = "İş Kazası" },
            new AbsenteeismType { Id = 7, Name = "Ücretsiz İzin" }
            );

        modelBuilder.Entity<Absenteeism>().HasData(
            new Absenteeism { Id = 1, EmployeeId = 1, AbsenteeismTypeId = 1, StartDate = new DateTime(2021, 01, 01), EndDate = new DateTime(2021, 01, 02) },
            new Absenteeism { Id = 2, EmployeeId = 2, AbsenteeismTypeId = 2, StartDate = new DateTime(2021, 01, 02), EndDate = new DateTime(2021, 01, 03) },
            new Absenteeism { Id = 3, EmployeeId = 3, AbsenteeismTypeId = 3, StartDate = new DateTime(2021, 01, 03), EndDate = new DateTime(2021, 01, 04) },
            new Absenteeism { Id = 4, EmployeeId = 4, AbsenteeismTypeId = 4, StartDate = new DateTime(2021, 01, 04), EndDate = new DateTime(2021, 01, 05) },
            new Absenteeism { Id = 5, EmployeeId = 5, AbsenteeismTypeId = 5, StartDate = new DateTime(2021, 01, 05), EndDate = new DateTime(2021, 01, 06) },
            new Absenteeism { Id = 6, EmployeeId = 6, AbsenteeismTypeId = 6, StartDate = new DateTime(2021, 01, 06), EndDate = new DateTime(2021, 01, 07) }
            );

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Kırtasiye" },
            new Category { Id = 2, Name = "Elektronik" },
            new Category { Id = 3, Name = "Giyim" }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Kitap", CategoryId = 1 },
            new Product { Id = 2, Name = "Defter", CategoryId = 1 },
            new Product { Id = 3, Name = "Bilgisayar", CategoryId = 2 },
            new Product { Id = 4, Name = "Tablet", CategoryId = 2 },
            new Product { Id = 5, Name = "Pantolon", CategoryId = 3 },
            new Product { Id = 6, Name = "Etek", CategoryId = 3 }
        );
    }
}
