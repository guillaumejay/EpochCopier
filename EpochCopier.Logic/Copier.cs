using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using Ionic.Zip;
using Ionic.Zlib;

namespace EpochCopier.Logic
{
    public class Copier
    {
        private readonly IExaminer _examiner;
        private readonly ISelector _selector;
        private readonly Job _job;
        public List<FileData> Valids = new List<FileData>();

        public Copier(IExaminer examiner, ISelector selector, Job job)
        {
            _examiner = examiner;
            _selector = selector;
            _job = job;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>True if there are some valid files</returns>
        public bool Examine()
        {
            List<FileData> list = new List<FileData>();
            foreach (string source in _job.BasePaths)
            {
                list.AddRange(_examiner.Examine(source));
            }
            Valids = list.Where(data => _selector.IsOk(_job, data)).ToList();
            return Valids.Any();
        }

        public void CreateArchive()
        {

            using (ZipFile zipFile = new ZipFile())
            {
                zipFile.CompressionLevel = CompressionLevel.BestCompression;
                foreach (FileData data in Valids)
                {
                    zipFile.AddFile(data.FullPath, data.PathFromBase);
                }

                zipFile.Save();
            }

        }
    }
}
