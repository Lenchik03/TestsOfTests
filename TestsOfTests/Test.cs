using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsOfTests
{
    public class Test
    {
        public int Id { get; set; }
        public int RobotId { get; set; }
        public int TesterId { get; set; }
        public DateTime Date { get; set; }
        public int TypeId { get; set; }
        public string ReportPath { get; set; }
        public int StatusId { get; set; }
    }
}
