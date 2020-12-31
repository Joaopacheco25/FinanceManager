using System.Data.Entity.Migrations;
using Microsoft.EntityFrameworkCore;

namespace WebApplication
{
    public class DbMigrationsConfiguration<TContext> : DbMigrationsConfiguration where TContext: DbContext
    {
        public DbMigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}