using Microsoft.EntityFrameworkCore;

namespace WebAppProject.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base (options)
        {
            
        }
    }
}
