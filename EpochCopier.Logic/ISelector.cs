using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpochCopier.Logic
{
    public interface ISelector
    {
        bool IsOK(Job job, FileData data);
    }
}
