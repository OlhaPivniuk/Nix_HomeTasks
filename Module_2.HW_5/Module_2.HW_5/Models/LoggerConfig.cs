using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2.HW_5.Models
{
    public class LoggerConfig
    {
        public string TimeFormat { get; init; }
        public string DirectoryPath { get; init; }
        public string FileNameFormat { get; init; }
        public string FileExtension { get; init; }
        public int FilesLimit { get; init; }
    }
}
