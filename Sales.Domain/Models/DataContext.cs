using System.Data.Entity;

namespace Sales.Domain.Models
{
    public class DataContext: DbContext
    {
        public DataContext():base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<Sales.Common.Models.Product> Products { get; set; }
    }
}
