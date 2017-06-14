using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServer
{
    [ServiceContract]
    interface IDataService
    {
        [OperationContract]
        void ProcessDataChange(DataChangeMessage message);
    }
}
