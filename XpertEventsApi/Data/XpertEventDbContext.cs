using Microsoft.EntityFrameworkCore;

namespace XpertEventsApi.Data
{
    public class XpertEventDbContext:DbContext
    {
        public XpertEventDbContext(DbContextOptions options):base(options)
        {

        }
    }
}
