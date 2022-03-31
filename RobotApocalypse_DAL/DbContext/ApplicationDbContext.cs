
using Microsoft.EntityFrameworkCore;
using ROBOT_apocalypse_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotApocalypse_DAL
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options
            ) : base(options)
        {

        }
        //public DbSet<Product> Products { get; set; }
        public DbSet<Survivors> Survivors { get; set; }
        public DbSet<Robots> Robots { get; set; }
    }
}
