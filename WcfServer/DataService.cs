using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WcfServer
{
    public class DataService : IDataService
    {
        public void ProcessDataChange(DataChangeMessage message)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Table Id: {0}, Row Id: {1}", message.TableId, message.RowId);
        }
    }
}
