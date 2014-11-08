﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpochCopier.Logic
{
    public class FileData
    {
        public string Name { get; set; }

        public string PathFromBase { get; set; }

        public string FullPath { get; set; }

        public DateTime Modified { get; set; }

    }
}
