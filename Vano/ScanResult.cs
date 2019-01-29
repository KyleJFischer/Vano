using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vano
{
    public class ScanResult
    {
        public List<string> files1 = new List<string>();
        public List<string> files2 = new List<string>();
        public string fileLocation1 = "";
        public string fileLocation2 = "";


        static public ScanResult ScanFolder(string folder1, string folder2)
        {
            var result = new ScanResult();
            result.fileLocation1 = folder1;
            result.fileLocation2 = folder2;

            var files1 = Directory.GetFiles(folder1).ToList();
            var files2 = Directory.GetFiles(folder2).ToList();

            var shortenFile1String = new List<string>();
            var shortenFile2String = new List<string>();


            foreach (var item in files1)
            {
                shortenFile1String.Add(item.Remove(0, folder1.Length));
            }
            foreach (var item in files2)
            {
                shortenFile2String.Add(item.Remove(0, folder2.Length));
            }

            result.files1 = shortenFile1String.Where(m => !shortenFile2String.Contains(m)).ToList();
            result.files2 = shortenFile2String.Where(m => !shortenFile1String.Contains(m)).ToList();
            return result;
        }

    }
}
