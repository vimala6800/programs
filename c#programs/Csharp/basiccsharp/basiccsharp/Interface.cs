using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace basiccsharp
{

    internal interface IUniversalRemote
    {
        public void SwitchOn();
        public void SwitchOff();
        public void changeChannel(string channel);
        public void changeVolume(int volume);
        // public String changeChannel(String channel)
        // public int changeVolume(int volume)
        // TCLTV has to implement IUniversalRemote
    }

    internal class SonyTV : IUniversalRemote
    {
        bool tvStatus = false;
        string currentChannel = "";
        int currentVolume = 0;
        public void changeChannel(string channel)
        {
            currentChannel = channel;
            Console.WriteLine("SonyTV: Channel is changed to "+channel);
            //return currentChannel;

        }
        public void changeVolume(int volume)
        {
             currentVolume =volume;
            Console.WriteLine("SonyTV: volume is changed to "+volume);
           // return currentChannel;
        }


        public void SwitchOff()
        {
            
            if (tvStatus)
            {
                tvStatus = false;
                Console.WriteLine("SonyTV is Switched OFF");
            }
            else
            {
                Console.WriteLine("SonyTV is already Switched OFF");
            }
        }

        public void SwitchOn()
        {
            //throw new NotImplementedException();
            if (!tvStatus)
            {
                tvStatus = true;
                Console.WriteLine("SonyTV is Switched ON" );
            }
            else
            {
                Console.WriteLine("SonyTV is already Switched ON");
            }
        }
        internal class Interface
        {
        }
    }
}

