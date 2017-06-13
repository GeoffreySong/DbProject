using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfClientLibrary
{
    public class ProcessingIncomingMessageClient
    {
		public void ProssingIncomingMessage(PIzzaServiceWebReference.MyMessage message)
		{
			using (var service = new PIzzaServiceWebReference.PizzaService())
			{
				service.ProcessIncomingMessage(message);
			}
		}
	}
}
