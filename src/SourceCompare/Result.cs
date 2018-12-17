using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCompare
{
    class Result
    {
        public enum ResultAction { DeleteSame1, DeleteSame2 }

        public enum Results { Same, Different, Only1, Only2 }

        public string Folder1 { get; set; }
        public string Folder2 { get; set; }
        public string Path { get; set; }
        public DateTime? Modified1 { get; set; }
        public DateTime? Modified2 { get; set; }
        public Results ComparisonResult { get; set; }

    }
}
