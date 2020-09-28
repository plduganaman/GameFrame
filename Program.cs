using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace GameFrame
{
    class Program
    {

        static void Main(string[] args)
        {
            string ipAddress = "";
            string command = "";

            //Argument 1	Argument 2	        Description
            //next                              Next animation.
            //brightness    0-7	                Set brightness level.
            //power         on/off              Power up/down the Game Frame. Leave argument 2 blank to toggle.
            //play          8.3 folder name     Play a specific folder by name.
            //alert         8.3 folder name     Play a specific folder by name as alert.
            //color         RGB color code      Fill the display with a specific color (i.e. #FF0000 for red). You may also pass “random” for a random color.
            //clockface     1-5	                Change the clock face graphic.
            //timezone      UTC Offset          Offset from UTC in hours, from -12.0 to 13.0.
            //playback      0-2	                Playback mode (0=Sequential, 1=Shuffle, 2=Pause animations).
            //display	    0-2	                System mode(0=Gallery, 1=Clock, 2=Effects).
            //cycle	        1-8	                Animation duration(1=10s, 2=30s, 3=1m, 4=5m, 5=15m, 6=30m, 7=1h, 8=infinity).
            //reboot                            Reboot Game Frame.

            string argMessage = @"Two arguments are required.They must include the IP address of the Game Frame and the command to send.For example 192.168.1.22 ""power on""";
            if (args == null)
            {
                Console.WriteLine(argMessage);
            }
            else
            {
                if (args.Length != 2)
                {
                    Console.WriteLine(argMessage);
                }
                else
                {
                    ipAddress = args[0];
                    command = args[1];
                    SendCommand(ipAddress, command);
                }
            }
        }

        static void SendCommand(string ipAddress, string command)
        {
            try
            {
                //Game Frame commands use the IP address assigned and port 8888 to send commands.  
                IPAddress ipaddress = IPAddress.Parse(ipAddress);
                IPEndPoint endPoint = new IPEndPoint(ipaddress, 8888);

                Socket s = new Socket(endPoint.Address.AddressFamily, SocketType.Dgram, ProtocolType.Udp);

                byte[] msg = Encoding.ASCII.GetBytes(command);
                s.SendTo(msg, endPoint);
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
