using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace WcfClientLibrary
{
    public class DataServiceClient
    {
		public void SendDataChangeMessage(DataServiceWebReference.DataChangeMessage message)
		{
			var proxy = new DataServiceWebReference.DataService();
			proxy.ProcessDataChangeAsync(message);
		}

		public async Task SendDataChangeMessageAsync(DataServiceWebReference.DataChangeMessage message)
        {
            await Task.Run(() =>
            {
                var proxy = new DataServiceWebReference.DataService();
                proxy.ProcessDataChangeAsync(message);
            });
        }
    }
}
