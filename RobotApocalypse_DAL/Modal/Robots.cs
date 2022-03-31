using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotApocalypse_DAL
{
    public  class Robots
    {
        public int id { get; set; }
        public string modal { get; set; }
        public string serialNumber { get; set; }
        public DateTime manufacturedDate { get; set; }
        public string category { get; set; }

    }
}
