using DBF_TrainMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBF_TrainMaster
{
    public class Clurdtrain
    {
        private train_MasterContext Train_MasterContext;
        public Clurdtrain()
        {
            Train_MasterContext = new train_MasterContext();
        }
        public void insert(TrainMaster trainMaster)
        {

            Train_MasterContext.TrainMasters.Add(trainMaster);
            Train_MasterContext.SaveChanges();
        }
        public void updatebytrainNo(int trainno, TrainMaster trainMasters)
        {
            var train = Train_MasterContext.TrainMasters.Where(x => x.TrainNo == trainno).FirstOrDefault();
            train.TrainNo = trainno;
            train.TrainName = trainMasters.TrainName;
            train.FromStation = trainMasters.FromStation;
            train.ToStation = trainMasters.ToStation;
            train.JourneyStartTime = trainMasters.JourneyStartTime;
            train.JourneyEndTime = trainMasters.JourneyEndTime;
            Train_MasterContext.TrainMasters.Update(train);
            Train_MasterContext.SaveChanges();

        }
        public void deletebytrainNo(int trainNo)
        {
            var train_details = Train_MasterContext.TrainMasters.Where(x => x.TrainNo == trainNo).FirstOrDefault();
            Train_MasterContext.TrainMasters.Remove(train_details);
            Train_MasterContext.SaveChanges();
        }
        public void searchbytrainno(int trainNO)
        {
            var train_details = Train_MasterContext.TrainMasters.Where(x => x.TrainNo == trainNO).FirstOrDefault();
            Console.WriteLine($"Train Name:{train_details.TrainName} starts from {train_details.FromStation} at {train_details.JourneyStartTime} and reaches {train_details.ToStation} at {train_details.JourneyEndTime}");
        }
        public void searchbystation(string from, string to)
        {
            var train_details = Train_MasterContext.TrainMasters.Where(x => x.FromStation == from).Where(y => y.ToStation == to).ToList();
            foreach (var train in train_details)
            {
                Console.WriteLine("Train No:" + train.TrainNo);
                Console.WriteLine("Train Name:" + train.TrainName);
                Console.WriteLine("From:" + train.FromStation);
                Console.WriteLine("To:" + train.ToStation);
                Console.WriteLine("Starts at:" + train.JourneyStartTime);
                Console.WriteLine("Reachs at:" + train.JourneyEndTime);
                Console.WriteLine("");
            }

        }
        public void insertdays( string days, TrainMaster train) { 
            var traindetails = new RunningDay();

            traindetails.RunningDays = days;
            traindetails.TrainNoNavigation = train;
            Train_MasterContext.RunningDays.Add(traindetails);
            Train_MasterContext.SaveChanges();
        }


    }
}
