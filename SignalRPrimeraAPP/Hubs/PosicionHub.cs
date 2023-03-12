using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRPrimeraAPP.Hubs
{
    public class PosicionHub : Hub
    {

        public async Task EnviarPosicion(int left , int top)
        {
            await Clients.Others.SendAsync("RecibirPosicion", left, top);
        }
    }
}
