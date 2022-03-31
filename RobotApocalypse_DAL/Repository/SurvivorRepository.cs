using Microsoft.EntityFrameworkCore;
using ROBOT_apocalypse_DAL.Model;
using RobotApocalypse_DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotApocalypse_DAL.Repository
{
    public class SurvivorRepository : GenericRepository<Survivors>, ISurvivorRepository
    {
        private readonly DbSet<Survivors> _survivors;

        public SurvivorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _survivors = dbContext.Set<Survivors>();

        }

       


    }
}
