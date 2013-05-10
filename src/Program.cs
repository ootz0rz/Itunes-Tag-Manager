using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTunesLib;

namespace iTunes_Tag_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            IiTunes app = new iTunesAppClass();

            IITTrack track = app.CurrentTrack;

            Console.WriteLine(string.Format("Current Track: {0} - {1}", track.Name, track.Artist));

        }
    }
}
