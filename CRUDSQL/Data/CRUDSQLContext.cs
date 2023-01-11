using Microsoft.EntityFrameworkCore;

namespace CRUDSQL.Data
{
    public class CRUDSQLContext : DbContext
    {
        public CRUDSQLContext (DbContextOptions<CRUDSQLContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDSQL.Models.Produto> Produto { get; set; }
    }
}
