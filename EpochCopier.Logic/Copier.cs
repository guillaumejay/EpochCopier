using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpochCopier.Logic
{
    public class Copier
    {
        private readonly IExaminer _examiner;
        private readonly ISelector _selector;
        public Copier( IExaminer examiner, ISelector selector)
        {
            _examiner = examiner;
            _selector = selector;
        }

        public void CreateArchive(Job job)
        {
            List<FileData> list = new List<FileData>();
            foreach (string source in job.BasePaths)
            {
                list.AddRange(_examiner.Examine(source));
            }
            List<FileData> valid = list.Where(data => _selector.IsOk(job, data)).ToList();
        }
    }
}
