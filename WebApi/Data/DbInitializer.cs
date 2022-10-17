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
            new Employee { Id = 1, Name = "Mansur", Surname = "Dinçer", Email = "mansur.dincer@filidea.com.tr", DepartmentId = 1, JobTitleId = 3 },
            new Employee { Id = 2, Name = "Döndü", Surname = "Yılmaz", Email = "dondu.yilmaz@filidea.com.tr", DepartmentId = 2, JobTitleId = 2 },
            new Employee { Id = 3, Name = "Muhammer", Surname = "Sayın", Email = "muhammer.sayin@filidea.com.tr", DepartmentId = 1, JobTitleId = 3 },
            new Employee { Id = 4, Name = "Abdullah", Surname = "Kasım", Email = "abdullah.kasim@filidea.com.tr", DepartmentId = 1, JobTitleId = 2 },
            new Employee { Id = 5, Name = "Fahri", Surname = "Yılmaz", Email = "fahri.yilmaz@filidea.com.tr", DepartmentId = 6, JobTitleId = 3 },
            new Employee { Id = 6, Name = "Mustafa", Surname = "Kalaycıoğlu", Email = "mustafa.kalaycioglu@filidea.com.tr", DepartmentId = 4, JobTitleId = 2 }
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
