using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Threading.Tasks;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static async void cpSendDataChangeInfoAsync(int tableId, int rowId)
	{
		await Task.Run(() =>
		{
			var msg = new WcfClientLibrary.DataServiceWebReference.DataChangeMessage { TableId = tableId, RowId = rowId };
			var client = new WcfClientLibrary.DataServiceClient();
			client.SendDataChangeMessage(msg);
		});
	}
}
