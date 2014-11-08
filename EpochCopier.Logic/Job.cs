using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;

namespace EpochCopier.Logic
{
    [Serializable]
    public class Job
    {
        public  List<String> BasePaths { get; set; }

        public DateTime? StartEpoch { get; set; }

        public DateTime? EndEpoch { get; set; }

        public string Destination { get; set; }
    }
}
