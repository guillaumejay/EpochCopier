using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EpochCopier.Logic
{
    public interface IExaminer
    {
        List<FileData> Examine(string source);
    }
}
