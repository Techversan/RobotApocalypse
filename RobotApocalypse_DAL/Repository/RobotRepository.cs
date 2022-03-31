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

    public class RobotRepository : GenericRepository<Robots>, IRobotRepository
    {
        private readonly DbSet<Robots> _robots;

        public RobotRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _robots = dbContext.Set<Robots>();

        }




    }
}
