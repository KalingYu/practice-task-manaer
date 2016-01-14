using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManage
{
    class Task
    {
        public int pid { get; set; }
        public string name { get; set; }
        public string start { get; set; }
        public int priority { get; set; }
        public long memory { get; set; }
        public string user { get; set; }
    }
}
