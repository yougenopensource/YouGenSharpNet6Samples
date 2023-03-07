/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
namespace XE_HR_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
public class SignalRWebsocketClientBase
{
    public Boolean Initiated { get; private set; }
    protected readonly HubConnection _hubConnection;
    protected readonly CancellationTokenSource _cts;
    public SignalRWebsocketClientBase(String hubUrl)
    {
        Initiated = false;
        _cts = new CancellationTokenSource();
        var contractResolver = new DefaultContractResolver
        {
            NamingStrategy = new DefaultNamingStrategy()
        };
        _hubConnection = new HubConnectionBuilder()    
        .WithUrl(hubUrl, options => {        
            options.SkipNegotiation = true;
            options.Transports = HttpTransportType.WebSockets;
        })
        .WithAutomaticReconnect()
        .AddNewtonsoftJsonProtocol(options => options.PayloadSerializerSettings.ContractResolver = contractResolver)
        .Build();
        // Configure default handlers
        _hubConnection.Closed += e =>
        {
            Console.WriteLine("Connection to " + hubUrl + " closed with error: {0}", e);
            _cts.Cancel();
            return Task.CompletedTask;
        };
        _hubConnection.Reconnecting += e =>
        {
            Console.WriteLine("Reconnecting to " + hubUrl + " due to error : {0}", e);
            _cts.Cancel();
            return Task.CompletedTask;
        };  
    }
    public async Task EstablishConnection()
    {
        if (!Initiated)
        {
            await _hubConnection.StartAsync();
            Initiated = true;        
        }
    }
    public async Task TerminateConnection()
    {
        await _hubConnection.DisposeAsync();
    }
}
