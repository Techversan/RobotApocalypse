
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotApocalypse_BAL
{
    public partial class CreateSurvivorCommand 
    {
        [AllowNull]

        public string Name { get; set; }
        public int Age { get; set; }
        [AllowNull]
        public string Gender { get; set; }
        [AllowNull]
        public string LastLocation { get; set; }
        [AllowNull]
        public string Resources { get; set; }
    }
    public class CreateRobots
    {
        public string model { get; set; }
        public string serialNumber { get; set; }
        public DateTime manufacturedDate { get; set; }
        public string category { get; set; }
       
    }
    public class RobotList
    {
        public List<CreateRobots> robot { get; set; }
    }
    //public class CreateSurvivorCommandHandler : IRequestHandler<CreateSurvivorCommand, Response<string>>
    //{
    //    private readonly ISurvivorRepository _survivorRepository;




    //    public CreateSurvivorCommandHandler(ISurvivorRepository survivorRepository
    //      )
    //    {


    //        _survivorRepository = survivorRepository;
    //    }

    //    //public async Task<Response<int>> Handle(CreateAdvertisementCommand request, CancellationToken cancellationToken)
        //{

        //}

        //public Response<string> Handle(CreateSurvivorCommand request, CancellationToken cancellationToken)
        //{
        //    return new Response<string>("test");
        //    //throw new NotImplementedException();
        //}
  //  }

}
