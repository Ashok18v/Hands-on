using System;
using System.Collections.Generic;

namespace DBF_TrainMaster.Models
{
    public partial class RunningDay
    {
        public int SNo { get; set; }
        public string? RunningDays { get; set; }
        public int? TrainNo { get; set; }

        public virtual TrainMaster? TrainNoNavigation { get; set; }
    }
}
