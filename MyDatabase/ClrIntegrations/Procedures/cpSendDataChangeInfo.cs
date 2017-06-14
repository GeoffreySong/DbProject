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
		var msg = new WcfClientLibrary.DataServiceWebReference.DataChangeMessage { TableId = tableId, RowId = rowId };
		var client = new WcfClientLibrary.DataServiceClient();
		client.SendDataChangeMessageAsync(msg);
	}
}
