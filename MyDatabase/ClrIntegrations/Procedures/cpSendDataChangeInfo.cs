using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void cpSendDataChangeInfo (int tableId, int rowId)
    {
		var anOrder = new WcfClientLibrary.PIzzaServiceWebReference.Order { OrderId = tableId, ShipToAddress = "234 Abc avenue", ShipToCity = "DNC", ShipToCountry = "A country", ShipToZipCode = "12345", SubmittedOn = DateTime.UtcNow };
		try
		{
			var client = new WcfClientLibrary.ProcessingIncomingMessageClient();
			client.ProssingIncomingMessage(new WcfClientLibrary.PIzzaServiceWebReference.MyMessage { Data = anOrder });
		}
		catch (Exception e)
		{
			SqlContext.Pipe.Send(e.Message);
		}

	}
}
