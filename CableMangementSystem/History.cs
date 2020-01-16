using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CableMangementSystem
{
    public class History
    {
        public int HistoryId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string HouseNo { get; set; }
        public int Payment { get; set; }
        public string ReceivedBy { get; set; }
        public string Month { get; set; }
        public int Status { get; set; }
    }
}
