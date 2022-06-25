using System;
using System.Collections.Generic;

namespace DBF_TrainMaster.Models
{
    public partial class TrainMaster
    {
        public TrainMaster()
        {
            RunningDays = new HashSet<RunningDay>();
        }

        public int TrainNo { get; set; }
        public string? TrainName { get; set; }
        public string FromStation { get; set; } = null!;
        public string ToStation { get; set; } = null!;
        public TimeSpan JourneyStartTime { get; set; }
        public TimeSpan JourneyEndTime { get; set; }

        public virtual ICollection<RunningDay> RunningDays { get; set; }
    }
}
