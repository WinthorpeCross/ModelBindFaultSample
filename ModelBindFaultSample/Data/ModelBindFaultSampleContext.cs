using Microsoft.EntityFrameworkCore;


namespace ModelBindFaultSample.Models
{
    public class ModelBindFaultSampleContext : DbContext
    {
        public ModelBindFaultSampleContext (DbContextOptions<ModelBindFaultSampleContext> options)
            : base(options)
        {
        }

        public DbSet<Bird> Bird { get; set; }
    }
}
