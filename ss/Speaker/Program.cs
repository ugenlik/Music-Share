using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Remoting.Channels;
using System.Collections;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting;
using SpeakerShare;
using System.IO;

namespace Speaker
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteSpeaker speaker = new RemoteSpeaker();

            ChannelServices.RegisterChannel(new TcpChannel(6123), false);
            RemotingServices.Marshal(speaker, "speaker");

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
