using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mypos.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyposContext>
    {
        public MyposContext CreateDbContext(string[] args)
        {
            //todo: usar configuração
            var connectionString = "Server=localhost;Database=MyposDb;Uid=root;Pwd=teste;";
            var optionsBuilder = new DbContextOptionsBuilder<MyposContext>();
            optionsBuilder.UseMySQL(connectionString);
            return new MyposContext(optionsBuilder.Options);
        }
    }
}
