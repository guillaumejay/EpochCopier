using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using Ionic.Zip;

namespace EpochCopier.Logic
{
    [Serializable]
    public class Job
    {
        public string Name { get; set; }
        public  List<String> BasePaths { get; set; }

        public DateTime? StartEpoch { get; set; }

        public DateTime? EndEpoch { get; set; }

        public string Destination { get; set; }


        public string ArchiveName { get { return Path.Combine(Destination, Name + "zip"); } }
    }
}
