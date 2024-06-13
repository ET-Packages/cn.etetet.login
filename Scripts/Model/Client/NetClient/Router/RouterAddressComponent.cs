using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace ET.Client
{
    [ComponentOf(typeof(Scene))]
    public class RouterAddressComponent: Entity, IAwake<string>
    {
        public IPAddress RouterManagerIPAddress { get; set; }
        public string Address;
        public HttpGetRouterResponse Info;
        public int RouterIndex;
    }
}