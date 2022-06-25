

using DBF_TrainMaster;
using DBF_TrainMaster.Models;

namespace DBFtrain
{
    public class program
    {
        static void Main(string[] args)
        {
            Clurdtrain clurdtrain = new Clurdtrain();
            //TimeSpan a = new TimeSpan(6, 0, 0);
            //TimeSpan b = new TimeSpan(15, 0, 0);
            //clurdtrain.insert(new TrainMaster { TrainNo = 13456, TrainName = "Palnadu Super fast Express", FromStation = "Guntur", ToStation = "Hyderabad", JourneyStartTime = a, JourneyEndTime = b });
            //clurdtrain.insert(new TrainMaster { TrainNo = 667722, TrainName = "Tirupathi Super fast Express", FromStation = "Tirupathi", ToStation = "Secendrabad", JourneyStartTime = new TimeSpan(7,0,0), JourneyEndTime =new TimeSpan(19,30,00)});
            //   clurdtrain.updatebytrainNo(22334, new TrainMaster { TrainName = "Sabari Super fast Express", FromStation = "Tirupathi", ToStation = "Secendrabad", JourneyStartTime = new TimeSpan(2, 0, 0), JourneyEndTime = new TimeSpan(21, 30, 00) });
            // clurdtrain.deletebytrainNo(13456);
            // clurdtrain.searchbytrainno(13456);
            //clurdtrain.searchbystation("Tirupathi", "Secendrabad");
            clurdtrain.insertdays("Sun Mon Tue", new TrainMaster { TrainNo = 667722, TrainName = "Tirupathi Super fast Express", FromStation = "Tirupathi", ToStation = "Secendrabad", JourneyStartTime = new TimeSpan(7, 0, 0), JourneyEndTime = new TimeSpan(19, 30, 00) });
        }

    }
}