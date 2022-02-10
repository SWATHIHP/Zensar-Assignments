using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace RemoteServers
{
    public class RemotingServer
    {
        public RemotingServer()
        {

        }
    }

    //service class
    public class Service : MarshalByRefObject
    {
        public void WriteMessage(int num1, int num2)
        {
            Console.WriteLine(Math.Max(num1, num2));
        }
    }

    //server class
    class Server
    {
        static void Main(string[] args)
        {
            //create a new channel
            HttpChannel channel = new HttpChannel(8081);
            //register the created channel
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Service), "Service",WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Services started at Port no:8081.........");
            Console.WriteLine("Please press enter to stop the server...");
            Console.Read();

        }
    }
}
