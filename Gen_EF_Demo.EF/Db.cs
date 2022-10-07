using DbConfigLib;
using Microsoft.EntityFrameworkCore;

namespace Gen_EF_Demo.EF;

public class Db : DbContext
{
    //public DbSet<Person> TablePersons { get; set; }
    public DbSet<Worker> TableWorkers { get; set; }
    public DbSet<Manager> TableManagers { get; set; }

    public Db()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL(DbConfig.ImportFromJson("db.json").ToString());
    }
}