using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Data
{
    //   Scaffold-DBContext "Data Source=FNFIDVPRE22648;Initial Catalog=FNFTraining;Integrated Security=True;Encrypt=False;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data -Tables "Students"

    [Table("Students")]
    internal class Students
    {
        [Key]
        public int Id { get; set; }

        [Required]//NOT NULL
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int Standard { get; set; }
    }

    class StudentsContext : DbContext
    {
        //"Data Source =.\SQLEXPRESS; Initial Catalog = FNFTraining; Integrated Security = True; Encrypt = False; Trust Server Certificate=True"
        public DbSet<Students> MyStudents { get; set; }

        private const string DB_SOURCE = "FNFIDVPRE22648"; //Your SQL Server instance name;
        private const string DB_NAME = "FNFTraining";

        IConfigurationRoot? Configuration { get; set; }


        private void ConfigureServices()
        {
            var conf = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false)
                .Build();
            if (conf == null)
            {
                throw new Exception("Configuration is null");
            }
            Configuration = conf;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            ConfigureServices();

            var connectionString = Configuration["connectionString"];
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
//Open the Package Manager Console in Visual Studio and run the following commands to create and apply a migration:
// PM> Add-Migration mig1
// PM> Update-Database