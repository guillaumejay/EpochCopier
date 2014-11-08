using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpochCopier.Logic
{
    [Serializable]
    public class Jobs
    {
        public List<Job> AvailableJobs { get; set; }
    }
}
