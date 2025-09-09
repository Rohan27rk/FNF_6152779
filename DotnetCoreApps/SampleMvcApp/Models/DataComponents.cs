using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleMvcApp.Models
{
    [Table("CstTable")]
    public class Customer
    {
        [Key]
        public int CstId { get; set; }

        [Required (ErrorMessage ="Customer name is mandatory")]
        public string CstName { get; set; }
        [Required (ErrorMessage ="Customer address is mandatory")]
        public string CstAddress { get; set; }
        [Required (ErrorMessage ="Bill amount is mandatory")]
        public double BillAmount { get; set; }
    }

    public class CstDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Data Source=FNFIDVPRE22648;Initial Catalog=FNFTraining;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");

            var connectionString = Program.Configuration["ConnectionStrings:MyCon"];
            optionsBuilder.UseSqlServer(connectionString);


        }

    }
}