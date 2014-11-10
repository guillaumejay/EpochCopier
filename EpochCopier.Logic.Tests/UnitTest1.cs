using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EpochCopier.Logic.Tests
{
    [TestClass]
    public class ExamineTest
    {
        private string TempFolder;
        public ExamineTest()
        {
            TempFolder = GetTempFolder();
            Directory.CreateDirectory(TempFolder);
        }

        [ClassInitialize]
        public void Init()
        {
            
        }

        private string GetTempFolder()
        {
            string folder = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            while (Directory.Exists(folder) | File.Exists(folder))
            {
                folder = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            }

            return folder;
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
