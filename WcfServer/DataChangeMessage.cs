using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServer
{
    public class DataChangeMessage
    {
        public int TableId { get; set; }
        public int RowId { get; set; }
    }
}
