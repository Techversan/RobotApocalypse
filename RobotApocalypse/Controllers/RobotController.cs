using Microsoft.AspNetCore.Mvc;
using RobotApocalypse_BAL;
using RobotApocalypse_DAL;
using RobotApocalypse_DAL.Interface;

namespace RobotApocalypse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RobotController : ControllerBase
    {
       
        private readonly ApplicationDbContext _dbContext;
        private readonly IRobotRepository _robotRepository;

        public RobotController( ApplicationDbContext dbContext,
            IRobotRepository robotRepository
        )
        {

            _dbContext = dbContext;
           
            _robotRepository = robotRepository;

        }
        [HttpPost("CreateRobots")]
        public string CreateRobots(RobotList Command)
        {
            if (Command != null)
            {

                foreach (var robot in Command.robot)
                {
                    Robots rob = new Robots();
                    rob.category = robot.category;
                    rob.manufacturedDate = robot.manufacturedDate;
                    rob.modal = robot.model;
                    rob.serialNumber = robot.serialNumber;
                    _dbContext.Robots.Add(rob);
                    _dbContext.SaveChanges();

                }
            }
            Robots robots = new Robots();


            return "Succesfully created";
        }
        [HttpGet("GetRobots")]
        public async Task<List<Robots>> GetRobots()
        {
            var Robots = await _robotRepository.GetAllAsync();
            //  var Robots=_dbContext.Robots.ToList();
            List<Robots> robots = new List<Robots>();
            foreach (var robot in Robots)
            {

                robots.Add(robot);
            }
            return robots;
        }
    }
}
